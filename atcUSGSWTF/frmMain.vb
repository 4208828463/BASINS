﻿Imports atcData
Imports atcUtility
Imports atcGraph
Imports ZedGraph
Imports MapWinUtility
Imports atcUSGSRecess
Imports System.Windows.Forms

Public Class frmMain
    Public FallObj As clsFall
    Public RiseObj As clsFall
    Private pBasicAttributes As Generic.List(Of String)
    Private pDataGroup As atcTimeseriesGroup
    Private pWTFAttributes As atcDataAttributes

    Private pGraphTsHPeak As atcTimeseries
    Private pGraphTsGroupH2 As atcTimeseriesGroup
    Private pGraphTsGroupRecharge As atcTimeseriesGroup

    Private pWTF As clsWTF

    Friend WithEvents FfrmParam As frmParams

    Public Sub Initialize(Optional ByVal aTimeseriesGroup As atcData.atcTimeseriesGroup = Nothing, _
                          Optional ByVal aBasicAttributes As Generic.List(Of String) = Nothing, _
                      Optional ByVal aShowForm As Boolean = True)
        If aBasicAttributes Is Nothing Then
            pBasicAttributes = atcDataManager.DisplayAttributes
        Else
            pBasicAttributes = aBasicAttributes
        End If

        pDataGroup = aTimeseriesGroup

        'Dim lProvisionalTs As atcTimeseries = Nothing
        'Dim lNonProvisionalTs As atcTimeseries = Nothing
        'SplitProvisional(pDataGroup(0), lProvisionalTs, lNonProvisionalTs)
        'If lNonProvisionalTs IsNot Nothing Then
        '    pDataGroup.Clear()
        '    pDataGroup.Add(lNonProvisionalTs)
        'Else
        '    Throw New ApplicationException("No valid non-provisional data avaiable for analysis.")
        '    Me.Close()
        'End If

        Dim lTimeseries As atcTimeseries = pDataGroup(0)
        Dim lHasProvisional As Boolean = False
        Dim lProvisionalAttribute As String = lTimeseries.Attributes.GetValue("ProvisionalValueAttribute", "P")
        Dim lIndexFirstProvisional As Integer = 0
        For lIndex As Integer = 1 To lTimeseries.numValues
            If lTimeseries.ValueAttributesGetValue(lIndex, lProvisionalAttribute, False) Then
                lHasProvisional = True
                lIndexFirstProvisional = lIndex
                Exit For
            End If
        Next
        If lHasProvisional Then
            Dim lDataFileHistory As String = lTimeseries.Attributes.GetValue("History 1")
            Dim lDataSourceMatch As atcDataSource = Nothing
            For Each lDataSource As atcDataSource In atcDataManager.DataSources
                Dim lDataSourceSpec As String = lDataSource.Specification.ToLower()
                If lDataFileHistory.ToLower().Contains(lDataSourceSpec) Then
                    lDataSourceMatch = lDataSource
                    Exit For
                End If
            Next
            Dim lEndDate As Double = lTimeseries.Dates.Value(lIndexFirstProvisional - 2)
            lTimeseries = SubsetByDate(lTimeseries, lTimeseries.Dates.Value(0), lEndDate, lDataSourceMatch)
            pDataGroup.Clear()
            pDataGroup.Add(lTimeseries)
        End If

        pWTFAttributes = New atcDataAttributes()

        If FallObj Is Nothing Then
            FallObj = New clsFall()
        End If
        If RiseObj Is Nothing Then
            RiseObj = New clsFall()
        End If

        SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Show()
    End Sub

    Private Sub btnAntMethodSpecifyParm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAntMethodSpecifyParm.Click
        'Check data
        If pDataGroup.Count = 0 Then
            Logger.Msg("Select groundwater level data first.", MsgBoxStyle.Information, "WTF Analysis")
            Exit Sub
        End If
        Dim lGWLTs As atcTimeseries = pDataGroup(0)
        Dim lParamCd As String = lGWLTs.Attributes.GetValue("Parm_cd", "")
        If String.IsNullOrEmpty(lParamCd) Then
            Logger.Msg("Unknow groundwater level data type.", MsgBoxStyle.Information, "WTF Analysis")
            Exit Sub
        End If
        Select Case lParamCd
            Case "00000" 'no data was measured
                Exit Sub
            Case "72019" 'Depth to water level, feet below land surface
                Dim lDatumElev As Double = lGWLTs.Attributes.GetValue("alt_va", Double.NaN)
                If Double.IsNaN(lDatumElev) Then
                    lDatumElev = lGWLTs.Attributes.GetValue("Elev", Double.NaN)
                    If Double.IsNaN(lDatumElev) Then
                        Logger.Msg("Missing land surface elevation data for depth GWL data.", MsgBoxStyle.Information, "WTF Analysis")
                        Exit Sub
                    End If
                End If
                'Convert to GW Level as elevation, this is done later
                'For I As Integer = 1 To lGWLTs.numValues
                '    lGWLTs.Value(I) = lDatumElev - lGWLTs.Value(I)
                'Next
            Case Else

        End Select

        'Dim lResponse As MsgBoxResult = MsgBox("User Specify Parameters?", MsgBoxStyle.YesNoCancel, "Parameters for Estimating Ant. GWL")
        'If rdoAntMethodFall.Checked Then
        If pWTF Is Nothing Then
            pWTF = New clsWTFFall()
        ElseIf Not pWTF.GetType.FullName.ToLower.Contains("fall") Then
            pWTF.Clear()
            pWTF = Nothing
            pWTF = New clsWTFFall()
        End If
        'If lResponse = MsgBoxResult.Yes Then
        '    If FfrmParam Is Nothing OrElse FfrmParam.IsDisposed Then
        '        FfrmParam = New frmParams()
        '    End If
        '    pWTFAttributes.SetValue("FallD", CType(pWTF, clsWTFFall).GWLAsymptote)
        '    pWTFAttributes.SetValue("FallKgw", CType(pWTF, clsWTFFall).KGWL)
        '    FfrmParam.Initialize(AntecedentGWLMethod.FALL, pWTFAttributes)
        'ElseIf lResponse = MsgBoxResult.No Then
        '    Dim lfrmFall As New frmRecess()
        '    lfrmFall.Initialize(pDataGroup, pBasicAttributes, , , FallObj)
        'End If
        Dim lfrmFall As New frmRecess()
        'lfrmFall.SetFindingRises(False)
        FallObj = New clsFall()
        FallObj.Phase = WTFAnalysis.FindRecession
        lfrmFall.Initialize(pDataGroup, pBasicAttributes, , , FallObj)
        Dim lFallD As Double = pDataGroup(0).Attributes.GetValue("FallD", Double.NaN)
        Dim lKgw As Double = pDataGroup(0).Attributes.GetValue("FallKgw", Double.NaN)
        If Double.IsNaN(lFallD) Then
            If pWTF IsNot Nothing Then
                CType(pWTF, clsWTFFall).GWLAsymptote = lFallD
                CType(pWTF, clsWTFFall).KGWL = -1 * (1 / lKgw)
            End If
        End If
        'ElseIf rdoAntMethodLinear.Checked Then
        '    If pWTF Is Nothing Then
        '        pWTF = New clsWTFLinear()
        '    ElseIf Not pWTF.GetType.FullName.ToLower.Contains("linear") Then
        '        pWTF.Clear()
        '        pWTF = Nothing
        '        pWTF = New clsWTFLinear()
        '    End If
        '    If lResponse = MsgBoxResult.Yes Then
        '        If FfrmParam Is Nothing OrElse FfrmParam.IsDisposed Then
        '            FfrmParam = New frmParams()
        '        End If
        '        pWTFAttributes.SetValue("LinearA", CType(pWTF, clsWTFLinear).LinearSlope)
        '        pWTFAttributes.SetValue("LinearB", CType(pWTF, clsWTFLinear).LinearIntercept)
        '        FfrmParam.Initialize(AntecedentGWLMethod.Linear, pWTFAttributes)
        '    ElseIf lResponse = MsgBoxResult.No Then
        '        Dim lfrmFall As New frmRecess()
        '        lfrmFall.Initialize(pDataGroup, pBasicAttributes, , , FallObj, True)
        '        pWTF.EstimateParameters(FallObj)
        '    End If
        'ElseIf rdoAntMethodPower.Checked Then
        '    If pWTF Is Nothing Then
        '        pWTF = New clsWTFPower()
        '    ElseIf Not pWTF.GetType.FullName.ToLower.Contains("power") Then
        '        pWTF.Clear()
        '        pWTF = Nothing
        '        pWTF = New clsWTFPower()
        '    End If
        '    If lResponse = MsgBoxResult.Yes Then
        '        If FfrmParam Is Nothing OrElse FfrmParam.IsDisposed Then
        '            FfrmParam = New frmParams()
        '        End If
        '        pWTFAttributes.SetValue("PowerCIntercept", CType(pWTF, clsWTFPower).ParamCIntercept)
        '        pWTFAttributes.SetValue("PowerDMultiplier", CType(pWTF, clsWTFPower).ParamDMultiplier)
        '        pWTFAttributes.SetValue("PowerEDatum", CType(pWTF, clsWTFPower).ParamEDatum)
        '        pWTFAttributes.SetValue("PowerFExp", CType(pWTF, clsWTFPower).ParamFExp)

        '        FfrmParam.Initialize(AntecedentGWLMethod.Power, pWTFAttributes)

        '    ElseIf lResponse = MsgBoxResult.No Then
        '        'Dim lfrmFall As New frmRecess()
        '        'lfrmFall.Initialize(pDataGroup, pBasicAttributes, , , FallObj, True)
        '        'pWTF.EstimateParameters(FallObj)
        '    End If
        'End If
    End Sub

    Private Sub btnCalcRecharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindRechargeEvents.Click
        Dim lfrmFall As New frmRecess()
        With lfrmFall
            .Text = "Find Recharge Events (all rising limbs); Close form when done."
            '.SetFindingRises(True)
            RiseObj = New clsFall()
            RiseObj.Phase = WTFAnalysis.FindRecharge
            .Initialize(pDataGroup, pBasicAttributes, True, Nothing, RiseObj, True)
        End With

        'Dim lNowSeeifFallObjIsStillThere As String = ""
    End Sub

    Private Sub btnEstRecharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstRecharge.Click
        Dim lfrmEstRecharge As New frmEstRecharge()
        With lfrmEstRecharge
            .Initialize(pDataGroup, RiseObj)
        End With
    End Sub
End Class