Imports atcUtility
Imports atcData
Imports MapWinUtility

Public Class atcDataSourceTimeseriesDbf
    Inherits atcDataSource
    '##MODULE_REMARKS Copyright 2007 AQUA TERRA Consultants - Royalty-free use permitted under open source license

    Private Shared pFileFilter As String = "DBF Files (*.dbf)|*.dbf"
    Private pErrorDescription As String
    Private pColDefs As Hashtable

    Public Overrides ReadOnly Property Description() As String
        Get
            Return "Timseries DBF"
        End Get
    End Property

    Public Overrides ReadOnly Property Name() As String
        Get
            Return "Timeseries::DBF"
        End Get
    End Property

    Public Overrides ReadOnly Property Category() As String
        Get
            Return "File"
        End Get
    End Property

    Public Overrides ReadOnly Property CanOpen() As Boolean
        Get
            Return True 'yes, this class can open files
        End Get
    End Property

    Public Overrides ReadOnly Property CanSave() As Boolean
        Get
            Return False 'no saving yet, but could implement if needed 
        End Get
    End Property

    Public Overrides Function Open(ByVal aFileName As String, Optional ByVal aAttributes As atcData.atcDataAttributes = Nothing) As Boolean
        Dim lData As atcTimeseries

        If aFileName Is Nothing OrElse aFileName.Length = 0 OrElse Not FileExists(aFileName) Then
            aFileName = FindFile("Select " & Name & " file to open", , , pFileFilter, True, , 1)
        End If

        If Not FileExists(aFileName) Then
            pErrorDescription = "File '" & aFileName & "' not found"
        Else
            Me.Specification = aFileName

            Logger.Dbg("Process:" & aFileName)
            Dim lDateCol As Integer = -1
            Dim lTimeCol As Integer = -1
            Dim lLocnCol As Integer = -1
            Dim lValueCol As Integer
            Dim lConstituents As New atcCollection
            Dim lTSKey As String
            Dim lTSIndex As Integer
            Dim lLocation As String = ""
            Dim lConstituentName, lConstituentUnits, lValue As String
            Dim lStr As String
            Dim lDBF As IatcTable
            lDBF = New atcTableDBF
            lDBF.OpenFile(aFileName)
            Logger.Dbg("NumFields:" & lDBF.NumFields)
            Logger.Dbg("NumRecords:" & lDBF.NumRecords)

            Try
                For lColumn As Integer = 1 To lDBF.NumFields
                    lStr = UCase(lDBF.FieldName(lColumn))
                    Select Case lStr
                        Case "DATE"
                            lDateCol = lColumn
                            Logger.Dbg("DateColumn:" & lColumn)
                        Case "TIME"
                            lTimeCol = lColumn
                            Logger.Dbg("TimeColumn:" & lColumn)
                        Case "ID", "STREAM" 'location
                            If lLocnCol = -1 Then 'only use first one
                                'should be sure that field is in use here
                                lLocnCol = lColumn
                                Logger.Dbg("IdColumn:" & lColumn)
                            End If
                        Case "SAMPLE"
                            'SKIP
                        Case Else
                            lConstituents.Add(lColumn, lStr)
                            Logger.Dbg("ConstituentColumn:" & lColumn & " Name:" & lStr)
                    End Select
                Next

                If lDateCol > 0 AndAlso lTimeCol > 0 AndAlso lLocnCol > 0 Then
                    While Not lDBF.atEOF
                        lLocation = lDBF.Value(lLocnCol)
                        For lConstituentIndex As Integer = 0 To lConstituents.Count - 1
                            lValueCol = lConstituents.Keys(lConstituentIndex)
                            lStr = lDBF.Value(lValueCol)
                            If lStr.Length > 0 Then
                                lConstituentUnits = lConstituents.Item(lConstituentIndex)
                                lConstituentUnits = lConstituentUnits.Replace(")", "")
                                lConstituentName = StrSplit(lConstituentUnits, "_(", "'")
                                lTSKey = lLocation & ":" & lConstituentName
                                lData = DataSets.ItemByKey(lTSKey)
                                If lData Is Nothing Then 'create new timseries dataset
                                    lData = New atcTimeseries(Me)
                                    lData.Dates = New atcTimeseries(Me)
                                    lData.numValues = lDBF.NumRecords - lDBF.CurrentRecord + 1
                                    lData.Value(0) = Double.NaN
                                    lData.Dates.Value(0) = Double.NaN
                                    lData.Attributes.SetValue("Count", 0)
                                    lData.Attributes.SetValue("Scenario", "OBSERVED")
                                    lData.Attributes.SetValue("Location", lLocation)
                                    lData.Attributes.SetValue("Constituent", lConstituentName)
                                    lData.Attributes.SetValue("Units", lConstituentUnits)
                                    lData.Attributes.SetValue("Point", True)
                                    DataSets.Add(lTSKey, lData)
                                End If
                                lTSIndex = lData.Attributes.GetValue("Count") + 1
                                lValue = lDBF.Value(lValueCol)
                                If IsNumeric(lValue) Then
                                    lData.Value(lTSIndex) = lValue
                                    lData.Dates.Value(lTSIndex) = parseDate(lDBF.Value(lDateCol), lDBF.Value(lTimeCol))
                                    lData.Attributes.SetValue("Count", lTSIndex)
                                Else

                                End If
                            End If
                        Next
                        lDBF.MoveNext()
                    End While
                    For Each lData In DataSets
                        lData.numValues = lData.Attributes.GetValue("Count")
                    Next
                    Open = True
                ElseIf lDateCol < 0 Then
                    Open = False
                    Logger.Msg("Unable to identify Date column in DBF file " & aFileName, "DBF Open")
                ElseIf lTimeCol < 0 Then
                    Open = False
                    Logger.Msg("Unable to identify Time column in DBF file " & aFileName, "DBF Open")
                ElseIf lLocnCol < 0 Then
                    Open = False
                    Logger.Msg("Unable to identify ID column in DBF file " & aFileName, "DBF Open")
                End If
            Catch endEx As Exception
                Open = False
            End Try
        End If
    End Function

    Private Function parseDate(ByVal aDate As String, ByVal aTime As String) As Double
        Dim lDate As Date
        Dim lHour As Integer, lMinute As Integer
        Dim lTime As String

        lTime = aTime
        If lTime.Length = 0 Then
            lTime = "0:0"
        ElseIf lTime.IndexOf(":") = -1 Then
            lTime = lTime.PadLeft(4, "0")
            lTime = lTime.Insert(2, ":")
        End If
        lHour = StrSplit(lTime, ":", "'")
        lMinute = lTime
        lDate = Date.Parse(aDate)
        lDate = lDate.AddHours(lHour)
        lDate = lDate.AddMinutes(lMinute)
        Return lDate.ToOADate
    End Function
End Class
