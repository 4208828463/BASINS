'Copyright 2006 AQUA TERRA Consultants - Royalty-free use permitted under open source license

Option Strict Off
Option Explicit On

Imports System.Collections.ObjectModel
Imports System.Text

Public Class HspfMonthData
    Private pMonthDataTables As Collection(Of HspfMonthDataTable)
    Private pUci As HspfUci
    Private pComment As String

    ReadOnly Property Caption() As String
        Get
            Caption = "Month Data"
        End Get
    End Property


    Public Property Comment() As String
        Get
            Comment = pComment
        End Get
        Set(ByVal Value As String)
            pComment = Value
        End Set
    End Property

    Property Uci() As HspfUci
        Get
            Uci = pUci
        End Get
        Set(ByVal Value As HspfUci)
            pUci = Value
        End Set
    End Property

    Public ReadOnly Property MonthDataTables() As Collection(Of HspfMonthDataTable)
        Get
            MonthDataTables = pMonthDataTables
        End Get
    End Property

    Public ReadOnly Property EditControlName() As String
        Get
            EditControlName = "ATCoHspf.ctlMonthDataEdit"
        End Get
    End Property

    Public Sub Edit()
        editInit(Me, Me.Uci.icon, True)
    End Sub

    Public Sub New()
        MyBase.New()
        pMonthDataTables = New Collection(Of HspfMonthDataTable)
    End Sub

    Public Sub ReadUciFile()
        Dim done As Boolean
        Dim init, OmCode As Integer
        Dim retkey, retcod As Integer
        Dim cbuff As String = Nothing
        Dim i, rectyp As Integer
        Dim myMonthDataTable As HspfMonthDataTable

        If pUci.FastFlag Then
            GetCommentBeforeBlock("MONTH-DATA", pComment)
        End If

        OmCode = HspfOmCode("MONTH-DATA")
        init = 1
        done = False
        retkey = -1
        Do Until done
            If pUci.FastFlag Then
                GetNextRecordFromBlock("MONTH-DATA", retkey, cbuff, rectyp, retcod)
            Else
                Call REM_XBLOCK((Me.Uci), OmCode, init, retkey, cbuff, retcod)
            End If
            init = 0
            If InStr(cbuff, "END") Then 'skip this
            ElseIf InStr(cbuff, "MONTH-DATA") > 0 Then  'another one
                myMonthDataTable = New HspfMonthDataTable
                myMonthDataTable.Id = CInt(Right(cbuff, 3))
                myMonthDataTable.Block = Me
                If pUci.FastFlag Then
                    GetNextRecordFromBlock("MONTH-DATA", retkey, cbuff, rectyp, retcod)
                Else
                    Call REM_XBLOCK((Me.Uci), OmCode, init, retkey, cbuff, retcod)
                End If
                If rectyp = -1 Then
                    'this is a comment
                Else
                    'this is a regular record
                    For i = 1 To 12
                        myMonthDataTable.MonthValue(i) = CSng(Mid(cbuff, 1 + (i - 1) * 6, 6))
                    Next i
                    pMonthDataTables.Add(myMonthDataTable)
                End If
            End If
            If retcod <> 2 Then
                done = True
            End If
        Loop
    End Sub

    Public Overrides Function ToString() As String
        Dim j As Integer
        Dim s, t As String
        Dim lSB As New StringBuilder

        If pMonthDataTables.Count() > 0 Then 'something to write
            If pComment.Length > 0 Then
                lSB.AppendLine(pComment)
            End If
            lSB.AppendLine("MONTH-DATA")
            lSB.AppendLine(" ")
            For Each lMonthDataTable As HspfMonthDataTable In pMonthDataTables
                lSB.AppendLine("  MONTH-DATA     " & myFormatI((lMonthDataTable.Id), 3))
                s = ""
                For j = 1 To 12
                    'TODO:update this to PadRight
                    t = Space(6)
                    t = RSet(CStr(lMonthDataTable.MonthValue(j)), Len(t))
                    s &= t
                Next j
                lSB.AppendLine(s)
                lSB.AppendLine("  END MONTH-DATA " & myFormatI((lMonthDataTable.Id), 3))
                lSB.AppendLine(" ")
            Next lMonthDataTable
            lSB.AppendLine("END MONTH-DATA")
        End If
        Return lSB.ToString
    End Function
End Class