Imports atcData
Imports atcUtility
Imports DFLOWAnalysis
Imports MapWinUtility
Imports atcBatchProcessing
Imports System.Windows.Forms

Public Class frmSWSTATDFlowBatch
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        InitializeComponent() 'required by Windows Form Designer
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuAnalysis As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSelectData As System.Windows.Forms.MenuItem
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabSelectDates As System.Windows.Forms.TabPage
    Friend WithEvents tabNDay As System.Windows.Forms.TabPage
    Friend WithEvents grpDates As System.Windows.Forms.GroupBox
    Friend WithEvents cboStartMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblYearStart As System.Windows.Forms.Label
    Friend WithEvents txtEndDay As System.Windows.Forms.TextBox
    Friend WithEvents txtStartDay As System.Windows.Forms.TextBox
    Friend WithEvents cboEndMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblYearEnd As System.Windows.Forms.Label
    Friend WithEvents grpYears As System.Windows.Forms.GroupBox
    Friend WithEvents lblDataStart As System.Windows.Forms.Label
    Friend WithEvents lblDataEnd As System.Windows.Forms.Label
    Friend WithEvents lblOmitBefore As System.Windows.Forms.Label
    Friend WithEvents lblOmitAfter As System.Windows.Forms.Label
    Friend WithEvents txtOmitAfterYear As System.Windows.Forms.TextBox
    Friend WithEvents txtOmitBeforeYear As System.Windows.Forms.TextBox
    Friend WithEvents cboYears As System.Windows.Forms.ComboBox
    Friend WithEvents btnNDay As System.Windows.Forms.Button
    Friend WithEvents btnDisplayTrend As System.Windows.Forms.Button
    Friend WithEvents btnDisplayBasic As System.Windows.Forms.Button
    Friend WithEvents btnDoFrequencyGrid As System.Windows.Forms.Button
    Friend WithEvents panelTop As System.Windows.Forms.Panel
    Friend WithEvents grpRecurrence As System.Windows.Forms.GroupBox
    Friend WithEvents btnRecurrenceDefault As System.Windows.Forms.Button
    Friend WithEvents btnRecurrenceRemove As System.Windows.Forms.Button
    Friend WithEvents lstRecurrence As System.Windows.Forms.ListBox
    Friend WithEvents btnRecurrenceAdd As System.Windows.Forms.Button
    Friend WithEvents txtRecurrenceAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnRecurrenceNone As System.Windows.Forms.Button
    Friend WithEvents btnRecurrenceAll As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents grpNday As System.Windows.Forms.GroupBox
    Friend WithEvents btnNdayDefault As System.Windows.Forms.Button
    Friend WithEvents btnNdayRemove As System.Windows.Forms.Button
    Friend WithEvents btnNdayAdd As System.Windows.Forms.Button
    Friend WithEvents txtNdayAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnNdayNone As System.Windows.Forms.Button
    Friend WithEvents btnNdayAll As System.Windows.Forms.Button
    Friend WithEvents lstNday As System.Windows.Forms.ListBox
    Friend WithEvents chkLog As System.Windows.Forms.CheckBox
    Friend WithEvents grpHighLow As System.Windows.Forms.GroupBox
    Friend WithEvents radioHigh As System.Windows.Forms.RadioButton
    Friend WithEvents radioLow As System.Windows.Forms.RadioButton
    Friend WithEvents btnDoFrequencyGraph As System.Windows.Forms.Button
    Friend WithEvents chkMultipleStationPlots As System.Windows.Forms.CheckBox
    Friend WithEvents chkMultipleNDayPlots As System.Windows.Forms.CheckBox
    Friend WithEvents gbTextOutput As System.Windows.Forms.GroupBox
    Friend WithEvents txtOutputDir As System.Windows.Forms.TextBox
    Friend WithEvents lblOutputDir As System.Windows.Forms.Label
    Friend WithEvents txtOutputRootName As System.Windows.Forms.TextBox
    Friend WithEvents lblBaseFilename As System.Windows.Forms.Label
    Friend WithEvents tabDFLOW As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbNonBio3 As System.Windows.Forms.TextBox
    Friend WithEvents tbNonBio4 As System.Windows.Forms.TextBox
    Friend WithEvents tbNonBio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbNonBio1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbNonBio3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbNonBio2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbNonBio1 As System.Windows.Forms.RadioButton
    Friend WithEvents gbBio As System.Windows.Forms.GroupBox
    Friend WithEvents tbBio3 As System.Windows.Forms.TextBox
    Friend WithEvents tbBio4 As System.Windows.Forms.TextBox
    Friend WithEvents tbBio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbBio1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbBio3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbBio2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbBio1 As System.Windows.Forms.RadioButton
    Friend WithEvents ckbBio As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnScreeningTests As System.Windows.Forms.Button
    Friend WithEvents btnFrequencyReport As System.Windows.Forms.Button
    Friend WithEvents groupGraph As System.Windows.Forms.GroupBox
    Friend WithEvents chkHarmonicMean As System.Windows.Forms.CheckBox
    Friend WithEvents chkNonBioCustom2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtNonBioCustomNday2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNonBioCustomReturn2 As System.Windows.Forms.TextBox
    Friend WithEvents chkNonBioCustom1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtNonBioCustomNday1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNonBioCustomReturn1 As System.Windows.Forms.TextBox
    Friend WithEvents chkBio3Ammonia As System.Windows.Forms.CheckBox
    Friend WithEvents chkBio2Chronic As System.Windows.Forms.CheckBox
    Friend WithEvents chkBio1Acute As System.Windows.Forms.CheckBox
    Friend WithEvents tbBio3Amm As System.Windows.Forms.TextBox
    Friend WithEvents tbBio4Amm As System.Windows.Forms.TextBox
    Friend WithEvents tbBio2Amm As System.Windows.Forms.TextBox
    Friend WithEvents tbBio1Amm As System.Windows.Forms.TextBox
    Friend WithEvents tbBio3Chronic As System.Windows.Forms.TextBox
    Friend WithEvents tbBio4Chronic As System.Windows.Forms.TextBox
    Friend WithEvents tbBio2Chronic As System.Windows.Forms.TextBox
    Friend WithEvents tbBio1Chronic As System.Windows.Forms.TextBox
    Friend WithEvents ckbBioAmm As System.Windows.Forms.CheckBox
    Friend WithEvents ckbBioChronic As System.Windows.Forms.CheckBox
    Friend WithEvents tbNonBio2Chronic As System.Windows.Forms.TextBox
    Friend WithEvents tbNonBio1Chronic As System.Windows.Forms.TextBox
    Friend WithEvents chkNonBioChronic As System.Windows.Forms.CheckBox
    Friend WithEvents chkNonBioAcute As System.Windows.Forms.CheckBox
    Friend WithEvents chkNonBio3Pct As System.Windows.Forms.CheckBox
    Friend WithEvents chkNonBio2Explicit As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSWSTATDFlowBatch))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFileSelectData = New System.Windows.Forms.MenuItem
        Me.mnuAnalysis = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.tabMain = New System.Windows.Forms.TabControl
        Me.tabSelectDates = New System.Windows.Forms.TabPage
        Me.gbTextOutput = New System.Windows.Forms.GroupBox
        Me.txtOutputDir = New System.Windows.Forms.TextBox
        Me.lblOutputDir = New System.Windows.Forms.Label
        Me.txtOutputRootName = New System.Windows.Forms.TextBox
        Me.lblBaseFilename = New System.Windows.Forms.Label
        Me.grpHighLow = New System.Windows.Forms.GroupBox
        Me.radioHigh = New System.Windows.Forms.RadioButton
        Me.radioLow = New System.Windows.Forms.RadioButton
        Me.btnDisplayBasic = New System.Windows.Forms.Button
        Me.grpDates = New System.Windows.Forms.GroupBox
        Me.cboStartMonth = New System.Windows.Forms.ComboBox
        Me.lblYearStart = New System.Windows.Forms.Label
        Me.txtEndDay = New System.Windows.Forms.TextBox
        Me.txtStartDay = New System.Windows.Forms.TextBox
        Me.cboEndMonth = New System.Windows.Forms.ComboBox
        Me.lblYearEnd = New System.Windows.Forms.Label
        Me.grpYears = New System.Windows.Forms.GroupBox
        Me.lblDataStart = New System.Windows.Forms.Label
        Me.lblDataEnd = New System.Windows.Forms.Label
        Me.lblOmitBefore = New System.Windows.Forms.Label
        Me.lblOmitAfter = New System.Windows.Forms.Label
        Me.txtOmitAfterYear = New System.Windows.Forms.TextBox
        Me.txtOmitBeforeYear = New System.Windows.Forms.TextBox
        Me.cboYears = New System.Windows.Forms.ComboBox
        Me.tabNDay = New System.Windows.Forms.TabPage
        Me.groupGraph = New System.Windows.Forms.GroupBox
        Me.btnDoFrequencyGrid = New System.Windows.Forms.Button
        Me.btnDoFrequencyGraph = New System.Windows.Forms.Button
        Me.chkMultipleNDayPlots = New System.Windows.Forms.CheckBox
        Me.chkMultipleStationPlots = New System.Windows.Forms.CheckBox
        Me.btnFrequencyReport = New System.Windows.Forms.Button
        Me.btnScreeningTests = New System.Windows.Forms.Button
        Me.chkLog = New System.Windows.Forms.CheckBox
        Me.panelTop = New System.Windows.Forms.Panel
        Me.grpRecurrence = New System.Windows.Forms.GroupBox
        Me.btnRecurrenceDefault = New System.Windows.Forms.Button
        Me.btnRecurrenceRemove = New System.Windows.Forms.Button
        Me.lstRecurrence = New System.Windows.Forms.ListBox
        Me.btnRecurrenceAdd = New System.Windows.Forms.Button
        Me.txtRecurrenceAdd = New System.Windows.Forms.TextBox
        Me.btnRecurrenceNone = New System.Windows.Forms.Button
        Me.btnRecurrenceAll = New System.Windows.Forms.Button
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.grpNday = New System.Windows.Forms.GroupBox
        Me.btnNdayDefault = New System.Windows.Forms.Button
        Me.btnNdayRemove = New System.Windows.Forms.Button
        Me.btnNdayAdd = New System.Windows.Forms.Button
        Me.txtNdayAdd = New System.Windows.Forms.TextBox
        Me.btnNdayNone = New System.Windows.Forms.Button
        Me.btnNdayAll = New System.Windows.Forms.Button
        Me.lstNday = New System.Windows.Forms.ListBox
        Me.btnDisplayTrend = New System.Windows.Forms.Button
        Me.btnNDay = New System.Windows.Forms.Button
        Me.tabDFLOW = New System.Windows.Forms.TabPage
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkNonBio3Pct = New System.Windows.Forms.CheckBox
        Me.chkNonBio2Explicit = New System.Windows.Forms.CheckBox
        Me.tbNonBio2Chronic = New System.Windows.Forms.TextBox
        Me.tbNonBio1Chronic = New System.Windows.Forms.TextBox
        Me.chkNonBioChronic = New System.Windows.Forms.CheckBox
        Me.chkNonBioAcute = New System.Windows.Forms.CheckBox
        Me.chkNonBioCustom2 = New System.Windows.Forms.CheckBox
        Me.txtNonBioCustomNday2 = New System.Windows.Forms.TextBox
        Me.txtNonBioCustomReturn2 = New System.Windows.Forms.TextBox
        Me.chkNonBioCustom1 = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNonBioCustomNday1 = New System.Windows.Forms.TextBox
        Me.txtNonBioCustomReturn1 = New System.Windows.Forms.TextBox
        Me.chkHarmonicMean = New System.Windows.Forms.CheckBox
        Me.tbNonBio3 = New System.Windows.Forms.TextBox
        Me.tbNonBio4 = New System.Windows.Forms.TextBox
        Me.tbNonBio2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbNonBio1 = New System.Windows.Forms.TextBox
        Me.gbBio = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ckbBioAmm = New System.Windows.Forms.CheckBox
        Me.ckbBioChronic = New System.Windows.Forms.CheckBox
        Me.tbBio3Amm = New System.Windows.Forms.TextBox
        Me.tbBio4Amm = New System.Windows.Forms.TextBox
        Me.tbBio2Amm = New System.Windows.Forms.TextBox
        Me.tbBio1Amm = New System.Windows.Forms.TextBox
        Me.tbBio3Chronic = New System.Windows.Forms.TextBox
        Me.tbBio4Chronic = New System.Windows.Forms.TextBox
        Me.tbBio2Chronic = New System.Windows.Forms.TextBox
        Me.tbBio1Chronic = New System.Windows.Forms.TextBox
        Me.chkBio3Ammonia = New System.Windows.Forms.CheckBox
        Me.chkBio2Chronic = New System.Windows.Forms.CheckBox
        Me.chkBio1Acute = New System.Windows.Forms.CheckBox
        Me.tbBio3 = New System.Windows.Forms.TextBox
        Me.tbBio4 = New System.Windows.Forms.TextBox
        Me.tbBio2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbBio1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ckbBio = New System.Windows.Forms.CheckBox
        Me.rbNonBio1 = New System.Windows.Forms.RadioButton
        Me.rbNonBio2 = New System.Windows.Forms.RadioButton
        Me.rbNonBio3 = New System.Windows.Forms.RadioButton
        Me.rbBio3 = New System.Windows.Forms.RadioButton
        Me.rbBio1 = New System.Windows.Forms.RadioButton
        Me.rbBio2 = New System.Windows.Forms.RadioButton
        Me.tabMain.SuspendLayout()
        Me.tabSelectDates.SuspendLayout()
        Me.gbTextOutput.SuspendLayout()
        Me.grpHighLow.SuspendLayout()
        Me.grpDates.SuspendLayout()
        Me.grpYears.SuspendLayout()
        Me.tabNDay.SuspendLayout()
        Me.groupGraph.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.grpRecurrence.SuspendLayout()
        Me.grpNday.SuspendLayout()
        Me.tabDFLOW.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbBio.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuAnalysis, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileSelectData})
        Me.mnuFile.Text = "File"
        '
        'mnuFileSelectData
        '
        Me.mnuFileSelectData.Index = 0
        Me.mnuFileSelectData.Text = "Select &Data"
        '
        'mnuAnalysis
        '
        Me.mnuAnalysis.Index = 1
        Me.mnuAnalysis.Text = "Analysis"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.mnuHelp.Text = "Help"
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Controls.Add(Me.tabSelectDates)
        Me.tabMain.Controls.Add(Me.tabNDay)
        Me.tabMain.Controls.Add(Me.tabDFLOW)
        Me.tabMain.Location = New System.Drawing.Point(0, 2)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(466, 535)
        Me.tabMain.TabIndex = 1
        '
        'tabSelectDates
        '
        Me.tabSelectDates.BackColor = System.Drawing.Color.Transparent
        Me.tabSelectDates.Controls.Add(Me.gbTextOutput)
        Me.tabSelectDates.Controls.Add(Me.grpHighLow)
        Me.tabSelectDates.Controls.Add(Me.btnDisplayBasic)
        Me.tabSelectDates.Controls.Add(Me.grpDates)
        Me.tabSelectDates.Controls.Add(Me.grpYears)
        Me.tabSelectDates.Location = New System.Drawing.Point(4, 22)
        Me.tabSelectDates.Name = "tabSelectDates"
        Me.tabSelectDates.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSelectDates.Size = New System.Drawing.Size(458, 509)
        Me.tabSelectDates.TabIndex = 0
        Me.tabSelectDates.Text = "Select Dates"
        Me.tabSelectDates.UseVisualStyleBackColor = True
        '
        'gbTextOutput
        '
        Me.gbTextOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTextOutput.Controls.Add(Me.txtOutputDir)
        Me.gbTextOutput.Controls.Add(Me.lblOutputDir)
        Me.gbTextOutput.Controls.Add(Me.txtOutputRootName)
        Me.gbTextOutput.Controls.Add(Me.lblBaseFilename)
        Me.gbTextOutput.Location = New System.Drawing.Point(214, 6)
        Me.gbTextOutput.Name = "gbTextOutput"
        Me.gbTextOutput.Size = New System.Drawing.Size(235, 144)
        Me.gbTextOutput.TabIndex = 73
        Me.gbTextOutput.TabStop = False
        Me.gbTextOutput.Text = "Output"
        Me.gbTextOutput.Visible = False
        '
        'txtOutputDir
        '
        Me.txtOutputDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputDir.Location = New System.Drawing.Point(6, 45)
        Me.txtOutputDir.Name = "txtOutputDir"
        Me.txtOutputDir.Size = New System.Drawing.Size(223, 20)
        Me.txtOutputDir.TabIndex = 12
        '
        'lblOutputDir
        '
        Me.lblOutputDir.AutoSize = True
        Me.lblOutputDir.Location = New System.Drawing.Point(6, 29)
        Me.lblOutputDir.Name = "lblOutputDir"
        Me.lblOutputDir.Size = New System.Drawing.Size(29, 13)
        Me.lblOutputDir.TabIndex = 31
        Me.lblOutputDir.Text = "Path"
        '
        'txtOutputRootName
        '
        Me.txtOutputRootName.Location = New System.Drawing.Point(6, 102)
        Me.txtOutputRootName.Name = "txtOutputRootName"
        Me.txtOutputRootName.Size = New System.Drawing.Size(201, 20)
        Me.txtOutputRootName.TabIndex = 13
        '
        'lblBaseFilename
        '
        Me.lblBaseFilename.AutoSize = True
        Me.lblBaseFilename.Location = New System.Drawing.Point(6, 86)
        Me.lblBaseFilename.Name = "lblBaseFilename"
        Me.lblBaseFilename.Size = New System.Drawing.Size(52, 13)
        Me.lblBaseFilename.TabIndex = 30
        Me.lblBaseFilename.Text = "File Prefix"
        '
        'grpHighLow
        '
        Me.grpHighLow.Controls.Add(Me.radioHigh)
        Me.grpHighLow.Controls.Add(Me.radioLow)
        Me.grpHighLow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpHighLow.Location = New System.Drawing.Point(8, 6)
        Me.grpHighLow.Name = "grpHighLow"
        Me.grpHighLow.Size = New System.Drawing.Size(200, 65)
        Me.grpHighLow.TabIndex = 72
        Me.grpHighLow.TabStop = False
        Me.grpHighLow.Text = "Flow Condition"
        '
        'radioHigh
        '
        Me.radioHigh.AutoSize = True
        Me.radioHigh.Checked = True
        Me.radioHigh.Location = New System.Drawing.Point(6, 19)
        Me.radioHigh.Name = "radioHigh"
        Me.radioHigh.Size = New System.Drawing.Size(47, 17)
        Me.radioHigh.TabIndex = 1
        Me.radioHigh.TabStop = True
        Me.radioHigh.Text = "High"
        Me.radioHigh.UseVisualStyleBackColor = True
        '
        'radioLow
        '
        Me.radioLow.AutoSize = True
        Me.radioLow.Location = New System.Drawing.Point(6, 42)
        Me.radioLow.Name = "radioLow"
        Me.radioLow.Size = New System.Drawing.Size(45, 17)
        Me.radioLow.TabIndex = 2
        Me.radioLow.Text = "Low"
        Me.radioLow.UseVisualStyleBackColor = True
        '
        'btnDisplayBasic
        '
        Me.btnDisplayBasic.Location = New System.Drawing.Point(8, 270)
        Me.btnDisplayBasic.Name = "btnDisplayBasic"
        Me.btnDisplayBasic.Size = New System.Drawing.Size(157, 23)
        Me.btnDisplayBasic.TabIndex = 10
        Me.btnDisplayBasic.Text = "Display Basic Statistics"
        Me.btnDisplayBasic.UseVisualStyleBackColor = True
        '
        'grpDates
        '
        Me.grpDates.BackColor = System.Drawing.SystemColors.Control
        Me.grpDates.Controls.Add(Me.cboStartMonth)
        Me.grpDates.Controls.Add(Me.lblYearStart)
        Me.grpDates.Controls.Add(Me.txtEndDay)
        Me.grpDates.Controls.Add(Me.txtStartDay)
        Me.grpDates.Controls.Add(Me.cboEndMonth)
        Me.grpDates.Controls.Add(Me.lblYearEnd)
        Me.grpDates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpDates.Location = New System.Drawing.Point(8, 77)
        Me.grpDates.Name = "grpDates"
        Me.grpDates.Size = New System.Drawing.Size(200, 73)
        Me.grpDates.TabIndex = 67
        Me.grpDates.TabStop = False
        Me.grpDates.Text = "Year / Season Boundaries"
        '
        'cboStartMonth
        '
        Me.cboStartMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboStartMonth.Location = New System.Drawing.Point(41, 19)
        Me.cboStartMonth.MaxDropDownItems = 12
        Me.cboStartMonth.Name = "cboStartMonth"
        Me.cboStartMonth.Size = New System.Drawing.Size(88, 21)
        Me.cboStartMonth.TabIndex = 3
        Me.cboStartMonth.Text = "January"
        '
        'lblYearStart
        '
        Me.lblYearStart.AutoSize = True
        Me.lblYearStart.Location = New System.Drawing.Point(6, 22)
        Me.lblYearStart.Name = "lblYearStart"
        Me.lblYearStart.Size = New System.Drawing.Size(29, 13)
        Me.lblYearStart.TabIndex = 23
        Me.lblYearStart.Text = "Start"
        '
        'txtEndDay
        '
        Me.txtEndDay.Location = New System.Drawing.Point(135, 46)
        Me.txtEndDay.Name = "txtEndDay"
        Me.txtEndDay.Size = New System.Drawing.Size(24, 20)
        Me.txtEndDay.TabIndex = 6
        Me.txtEndDay.Text = "31"
        Me.txtEndDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStartDay
        '
        Me.txtStartDay.Location = New System.Drawing.Point(135, 19)
        Me.txtStartDay.Name = "txtStartDay"
        Me.txtStartDay.Size = New System.Drawing.Size(24, 20)
        Me.txtStartDay.TabIndex = 4
        Me.txtStartDay.Text = "1"
        Me.txtStartDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboEndMonth
        '
        Me.cboEndMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboEndMonth.Location = New System.Drawing.Point(41, 46)
        Me.cboEndMonth.MaxDropDownItems = 12
        Me.cboEndMonth.Name = "cboEndMonth"
        Me.cboEndMonth.Size = New System.Drawing.Size(88, 21)
        Me.cboEndMonth.TabIndex = 5
        Me.cboEndMonth.Text = "December"
        '
        'lblYearEnd
        '
        Me.lblYearEnd.AutoSize = True
        Me.lblYearEnd.Location = New System.Drawing.Point(6, 49)
        Me.lblYearEnd.Name = "lblYearEnd"
        Me.lblYearEnd.Size = New System.Drawing.Size(26, 13)
        Me.lblYearEnd.TabIndex = 61
        Me.lblYearEnd.Text = "End"
        '
        'grpYears
        '
        Me.grpYears.BackColor = System.Drawing.SystemColors.Control
        Me.grpYears.Controls.Add(Me.lblDataStart)
        Me.grpYears.Controls.Add(Me.lblDataEnd)
        Me.grpYears.Controls.Add(Me.lblOmitBefore)
        Me.grpYears.Controls.Add(Me.lblOmitAfter)
        Me.grpYears.Controls.Add(Me.txtOmitAfterYear)
        Me.grpYears.Controls.Add(Me.txtOmitBeforeYear)
        Me.grpYears.Controls.Add(Me.cboYears)
        Me.grpYears.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpYears.Location = New System.Drawing.Point(8, 156)
        Me.grpYears.Name = "grpYears"
        Me.grpYears.Size = New System.Drawing.Size(250, 102)
        Me.grpYears.TabIndex = 66
        Me.grpYears.TabStop = False
        Me.grpYears.Text = "Years to Include in Analysis"
        '
        'lblDataStart
        '
        Me.lblDataStart.AutoSize = True
        Me.lblDataStart.Enabled = False
        Me.lblDataStart.Location = New System.Drawing.Point(123, 49)
        Me.lblDataStart.Name = "lblDataStart"
        Me.lblDataStart.Size = New System.Drawing.Size(119, 13)
        Me.lblDataStart.TabIndex = 45
        Me.lblDataStart.Tag = "Data Starts"
        Me.lblDataStart.Text = "Start Date: 11/22/1934"
        '
        'lblDataEnd
        '
        Me.lblDataEnd.AutoSize = True
        Me.lblDataEnd.Enabled = False
        Me.lblDataEnd.Location = New System.Drawing.Point(123, 75)
        Me.lblDataEnd.Name = "lblDataEnd"
        Me.lblDataEnd.Size = New System.Drawing.Size(116, 13)
        Me.lblDataEnd.TabIndex = 1
        Me.lblDataEnd.Tag = "Data Ends"
        Me.lblDataEnd.Text = "End Date: 11/22/1934"
        '
        'lblOmitBefore
        '
        Me.lblOmitBefore.AutoSize = True
        Me.lblOmitBefore.Enabled = False
        Me.lblOmitBefore.Location = New System.Drawing.Point(6, 49)
        Me.lblOmitBefore.Name = "lblOmitBefore"
        Me.lblOmitBefore.Size = New System.Drawing.Size(54, 13)
        Me.lblOmitBefore.TabIndex = 40
        Me.lblOmitBefore.Text = "Start Year"
        '
        'lblOmitAfter
        '
        Me.lblOmitAfter.AutoSize = True
        Me.lblOmitAfter.Enabled = False
        Me.lblOmitAfter.Location = New System.Drawing.Point(6, 75)
        Me.lblOmitAfter.Name = "lblOmitAfter"
        Me.lblOmitAfter.Size = New System.Drawing.Size(51, 13)
        Me.lblOmitAfter.TabIndex = 43
        Me.lblOmitAfter.Text = "End Year"
        '
        'txtOmitAfterYear
        '
        Me.txtOmitAfterYear.Enabled = False
        Me.txtOmitAfterYear.Location = New System.Drawing.Point(66, 72)
        Me.txtOmitAfterYear.Name = "txtOmitAfterYear"
        Me.txtOmitAfterYear.Size = New System.Drawing.Size(37, 20)
        Me.txtOmitAfterYear.TabIndex = 9
        Me.txtOmitAfterYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOmitBeforeYear
        '
        Me.txtOmitBeforeYear.Enabled = False
        Me.txtOmitBeforeYear.Location = New System.Drawing.Point(66, 46)
        Me.txtOmitBeforeYear.Name = "txtOmitBeforeYear"
        Me.txtOmitBeforeYear.Size = New System.Drawing.Size(37, 20)
        Me.txtOmitBeforeYear.TabIndex = 8
        Me.txtOmitBeforeYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboYears
        '
        Me.cboYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYears.FormattingEnabled = True
        Me.cboYears.Location = New System.Drawing.Point(6, 18)
        Me.cboYears.Name = "cboYears"
        Me.cboYears.Size = New System.Drawing.Size(233, 21)
        Me.cboYears.TabIndex = 7
        '
        'tabNDay
        '
        Me.tabNDay.BackColor = System.Drawing.Color.Transparent
        Me.tabNDay.Controls.Add(Me.groupGraph)
        Me.tabNDay.Controls.Add(Me.btnFrequencyReport)
        Me.tabNDay.Controls.Add(Me.btnScreeningTests)
        Me.tabNDay.Controls.Add(Me.chkLog)
        Me.tabNDay.Controls.Add(Me.panelTop)
        Me.tabNDay.Controls.Add(Me.btnDisplayTrend)
        Me.tabNDay.Controls.Add(Me.btnNDay)
        Me.tabNDay.Location = New System.Drawing.Point(4, 22)
        Me.tabNDay.Name = "tabNDay"
        Me.tabNDay.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNDay.Size = New System.Drawing.Size(458, 509)
        Me.tabNDay.TabIndex = 2
        Me.tabNDay.Text = "N-Day, Trend, Frequency"
        Me.tabNDay.UseVisualStyleBackColor = True
        '
        'groupGraph
        '
        Me.groupGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupGraph.Controls.Add(Me.btnDoFrequencyGrid)
        Me.groupGraph.Controls.Add(Me.btnDoFrequencyGraph)
        Me.groupGraph.Controls.Add(Me.chkMultipleNDayPlots)
        Me.groupGraph.Controls.Add(Me.chkMultipleStationPlots)
        Me.groupGraph.Location = New System.Drawing.Point(138, 375)
        Me.groupGraph.Name = "groupGraph"
        Me.groupGraph.Size = New System.Drawing.Size(200, 128)
        Me.groupGraph.TabIndex = 43
        Me.groupGraph.TabStop = False
        Me.groupGraph.Text = "Graph"
        '
        'btnDoFrequencyGrid
        '
        Me.btnDoFrequencyGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDoFrequencyGrid.Location = New System.Drawing.Point(10, 17)
        Me.btnDoFrequencyGrid.Name = "btnDoFrequencyGrid"
        Me.btnDoFrequencyGrid.Size = New System.Drawing.Size(138, 23)
        Me.btnDoFrequencyGrid.TabIndex = 37
        Me.btnDoFrequencyGrid.Text = "Frequency Grid"
        Me.btnDoFrequencyGrid.UseVisualStyleBackColor = True
        '
        'btnDoFrequencyGraph
        '
        Me.btnDoFrequencyGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDoFrequencyGraph.Location = New System.Drawing.Point(10, 46)
        Me.btnDoFrequencyGraph.Name = "btnDoFrequencyGraph"
        Me.btnDoFrequencyGraph.Size = New System.Drawing.Size(138, 23)
        Me.btnDoFrequencyGraph.TabIndex = 38
        Me.btnDoFrequencyGraph.Text = "Frequency Graph"
        Me.btnDoFrequencyGraph.UseVisualStyleBackColor = True
        '
        'chkMultipleNDayPlots
        '
        Me.chkMultipleNDayPlots.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMultipleNDayPlots.AutoSize = True
        Me.chkMultipleNDayPlots.Location = New System.Drawing.Point(14, 75)
        Me.chkMultipleNDayPlots.Name = "chkMultipleNDayPlots"
        Me.chkMultipleNDayPlots.Size = New System.Drawing.Size(121, 17)
        Me.chkMultipleNDayPlots.TabIndex = 39
        Me.chkMultipleNDayPlots.Text = "Multiple N-Day Plots"
        Me.chkMultipleNDayPlots.UseVisualStyleBackColor = True
        '
        'chkMultipleStationPlots
        '
        Me.chkMultipleStationPlots.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMultipleStationPlots.AutoSize = True
        Me.chkMultipleStationPlots.Location = New System.Drawing.Point(14, 98)
        Me.chkMultipleStationPlots.Name = "chkMultipleStationPlots"
        Me.chkMultipleStationPlots.Size = New System.Drawing.Size(124, 17)
        Me.chkMultipleStationPlots.TabIndex = 40
        Me.chkMultipleStationPlots.Text = "Multiple Station Plots"
        Me.chkMultipleStationPlots.UseVisualStyleBackColor = True
        '
        'btnFrequencyReport
        '
        Me.btnFrequencyReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFrequencyReport.Location = New System.Drawing.Point(31, 479)
        Me.btnFrequencyReport.Name = "btnFrequencyReport"
        Me.btnFrequencyReport.Size = New System.Drawing.Size(124, 23)
        Me.btnFrequencyReport.TabIndex = 42
        Me.btnFrequencyReport.Text = "Frequency Report"
        Me.btnFrequencyReport.UseVisualStyleBackColor = True
        '
        'btnScreeningTests
        '
        Me.btnScreeningTests.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnScreeningTests.Location = New System.Drawing.Point(8, 450)
        Me.btnScreeningTests.Name = "btnScreeningTests"
        Me.btnScreeningTests.Size = New System.Drawing.Size(124, 23)
        Me.btnScreeningTests.TabIndex = 41
        Me.btnScreeningTests.Text = "Screening Tests"
        Me.btnScreeningTests.UseVisualStyleBackColor = True
        '
        'chkLog
        '
        Me.chkLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkLog.AutoSize = True
        Me.chkLog.Checked = True
        Me.chkLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLog.Location = New System.Drawing.Point(31, 371)
        Me.chkLog.Name = "chkLog"
        Me.chkLog.Size = New System.Drawing.Size(80, 17)
        Me.chkLog.TabIndex = 36
        Me.chkLog.Text = "Logarithmic"
        Me.chkLog.UseVisualStyleBackColor = True
        '
        'panelTop
        '
        Me.panelTop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTop.Controls.Add(Me.grpRecurrence)
        Me.panelTop.Controls.Add(Me.Splitter1)
        Me.panelTop.Controls.Add(Me.grpNday)
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(458, 368)
        Me.panelTop.TabIndex = 34
        '
        'grpRecurrence
        '
        Me.grpRecurrence.BackColor = System.Drawing.SystemColors.Control
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceDefault)
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceRemove)
        Me.grpRecurrence.Controls.Add(Me.lstRecurrence)
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceAdd)
        Me.grpRecurrence.Controls.Add(Me.txtRecurrenceAdd)
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceNone)
        Me.grpRecurrence.Controls.Add(Me.btnRecurrenceAll)
        Me.grpRecurrence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpRecurrence.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpRecurrence.Location = New System.Drawing.Point(210, 0)
        Me.grpRecurrence.Name = "grpRecurrence"
        Me.grpRecurrence.Size = New System.Drawing.Size(248, 368)
        Me.grpRecurrence.TabIndex = 7
        Me.grpRecurrence.TabStop = False
        Me.grpRecurrence.Text = "Recurrence Interval"
        '
        'btnRecurrenceDefault
        '
        Me.btnRecurrenceDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceDefault.Location = New System.Drawing.Point(186, 309)
        Me.btnRecurrenceDefault.Name = "btnRecurrenceDefault"
        Me.btnRecurrenceDefault.Size = New System.Drawing.Size(56, 20)
        Me.btnRecurrenceDefault.TabIndex = 31
        Me.btnRecurrenceDefault.Text = "Default"
        '
        'btnRecurrenceRemove
        '
        Me.btnRecurrenceRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceRemove.Location = New System.Drawing.Point(152, 309)
        Me.btnRecurrenceRemove.Name = "btnRecurrenceRemove"
        Me.btnRecurrenceRemove.Size = New System.Drawing.Size(28, 20)
        Me.btnRecurrenceRemove.TabIndex = 30
        Me.btnRecurrenceRemove.Text = "-"
        '
        'lstRecurrence
        '
        Me.lstRecurrence.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstRecurrence.IntegralHeight = False
        Me.lstRecurrence.Location = New System.Drawing.Point(6, 19)
        Me.lstRecurrence.Name = "lstRecurrence"
        Me.lstRecurrence.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstRecurrence.Size = New System.Drawing.Size(234, 284)
        Me.lstRecurrence.TabIndex = 27
        Me.lstRecurrence.Tag = "Return Period"
        '
        'btnRecurrenceAdd
        '
        Me.btnRecurrenceAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceAdd.Location = New System.Drawing.Point(120, 309)
        Me.btnRecurrenceAdd.Name = "btnRecurrenceAdd"
        Me.btnRecurrenceAdd.Size = New System.Drawing.Size(27, 20)
        Me.btnRecurrenceAdd.TabIndex = 29
        Me.btnRecurrenceAdd.Text = "+"
        '
        'txtRecurrenceAdd
        '
        Me.txtRecurrenceAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecurrenceAdd.Location = New System.Drawing.Point(6, 309)
        Me.txtRecurrenceAdd.Name = "txtRecurrenceAdd"
        Me.txtRecurrenceAdd.Size = New System.Drawing.Size(108, 20)
        Me.txtRecurrenceAdd.TabIndex = 28
        '
        'btnRecurrenceNone
        '
        Me.btnRecurrenceNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceNone.Location = New System.Drawing.Point(177, 338)
        Me.btnRecurrenceNone.Name = "btnRecurrenceNone"
        Me.btnRecurrenceNone.Size = New System.Drawing.Size(65, 24)
        Me.btnRecurrenceNone.TabIndex = 33
        Me.btnRecurrenceNone.Text = "None"
        '
        'btnRecurrenceAll
        '
        Me.btnRecurrenceAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRecurrenceAll.Location = New System.Drawing.Point(6, 338)
        Me.btnRecurrenceAll.Name = "btnRecurrenceAll"
        Me.btnRecurrenceAll.Size = New System.Drawing.Size(64, 24)
        Me.btnRecurrenceAll.TabIndex = 32
        Me.btnRecurrenceAll.Text = "All"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.Control
        Me.Splitter1.Location = New System.Drawing.Point(200, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(10, 368)
        Me.Splitter1.TabIndex = 13
        Me.Splitter1.TabStop = False
        '
        'grpNday
        '
        Me.grpNday.BackColor = System.Drawing.SystemColors.Control
        Me.grpNday.Controls.Add(Me.btnNdayDefault)
        Me.grpNday.Controls.Add(Me.btnNdayRemove)
        Me.grpNday.Controls.Add(Me.btnNdayAdd)
        Me.grpNday.Controls.Add(Me.txtNdayAdd)
        Me.grpNday.Controls.Add(Me.btnNdayNone)
        Me.grpNday.Controls.Add(Me.btnNdayAll)
        Me.grpNday.Controls.Add(Me.lstNday)
        Me.grpNday.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpNday.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpNday.Location = New System.Drawing.Point(0, 0)
        Me.grpNday.Name = "grpNday"
        Me.grpNday.Size = New System.Drawing.Size(200, 368)
        Me.grpNday.TabIndex = 1
        Me.grpNday.TabStop = False
        Me.grpNday.Text = "Number of Days"
        '
        'btnNdayDefault
        '
        Me.btnNdayDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNdayDefault.Location = New System.Drawing.Point(138, 309)
        Me.btnNdayDefault.Name = "btnNdayDefault"
        Me.btnNdayDefault.Size = New System.Drawing.Size(56, 20)
        Me.btnNdayDefault.TabIndex = 24
        Me.btnNdayDefault.Text = "Default"
        '
        'btnNdayRemove
        '
        Me.btnNdayRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNdayRemove.Location = New System.Drawing.Point(105, 309)
        Me.btnNdayRemove.Name = "btnNdayRemove"
        Me.btnNdayRemove.Size = New System.Drawing.Size(27, 20)
        Me.btnNdayRemove.TabIndex = 23
        Me.btnNdayRemove.Text = "-"
        '
        'btnNdayAdd
        '
        Me.btnNdayAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNdayAdd.Location = New System.Drawing.Point(72, 309)
        Me.btnNdayAdd.Name = "btnNdayAdd"
        Me.btnNdayAdd.Size = New System.Drawing.Size(27, 20)
        Me.btnNdayAdd.TabIndex = 22
        Me.btnNdayAdd.Text = "+"
        '
        'txtNdayAdd
        '
        Me.txtNdayAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNdayAdd.Location = New System.Drawing.Point(6, 309)
        Me.txtNdayAdd.Name = "txtNdayAdd"
        Me.txtNdayAdd.Size = New System.Drawing.Size(54, 20)
        Me.txtNdayAdd.TabIndex = 21
        '
        'btnNdayNone
        '
        Me.btnNdayNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNdayNone.Location = New System.Drawing.Point(130, 338)
        Me.btnNdayNone.Name = "btnNdayNone"
        Me.btnNdayNone.Size = New System.Drawing.Size(64, 23)
        Me.btnNdayNone.TabIndex = 26
        Me.btnNdayNone.Text = "None"
        '
        'btnNdayAll
        '
        Me.btnNdayAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNdayAll.Location = New System.Drawing.Point(6, 338)
        Me.btnNdayAll.Name = "btnNdayAll"
        Me.btnNdayAll.Size = New System.Drawing.Size(64, 24)
        Me.btnNdayAll.TabIndex = 25
        Me.btnNdayAll.Text = "All"
        '
        'lstNday
        '
        Me.lstNday.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstNday.IntegralHeight = False
        Me.lstNday.Location = New System.Drawing.Point(6, 19)
        Me.lstNday.Name = "lstNday"
        Me.lstNday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstNday.Size = New System.Drawing.Size(188, 284)
        Me.lstNday.TabIndex = 20
        Me.lstNday.Tag = "NDay"
        '
        'btnDisplayTrend
        '
        Me.btnDisplayTrend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDisplayTrend.Location = New System.Drawing.Point(8, 421)
        Me.btnDisplayTrend.Name = "btnDisplayTrend"
        Me.btnDisplayTrend.Size = New System.Drawing.Size(124, 23)
        Me.btnDisplayTrend.TabIndex = 35
        Me.btnDisplayTrend.Text = "Trend List"
        Me.btnDisplayTrend.UseVisualStyleBackColor = True
        '
        'btnNDay
        '
        Me.btnNDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNDay.Location = New System.Drawing.Point(8, 392)
        Me.btnNDay.Name = "btnNDay"
        Me.btnNDay.Size = New System.Drawing.Size(124, 23)
        Me.btnNDay.TabIndex = 34
        Me.btnNDay.Text = "N-Day Timeseries List"
        Me.btnNDay.UseVisualStyleBackColor = True
        '
        'tabDFLOW
        '
        Me.tabDFLOW.Controls.Add(Me.btnCalculate)
        Me.tabDFLOW.Controls.Add(Me.GroupBox2)
        Me.tabDFLOW.Controls.Add(Me.gbBio)
        Me.tabDFLOW.Controls.Add(Me.rbNonBio1)
        Me.tabDFLOW.Controls.Add(Me.rbNonBio2)
        Me.tabDFLOW.Controls.Add(Me.rbNonBio3)
        Me.tabDFLOW.Controls.Add(Me.rbBio3)
        Me.tabDFLOW.Controls.Add(Me.rbBio1)
        Me.tabDFLOW.Controls.Add(Me.rbBio2)
        Me.tabDFLOW.Location = New System.Drawing.Point(4, 22)
        Me.tabDFLOW.Name = "tabDFLOW"
        Me.tabDFLOW.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDFLOW.Size = New System.Drawing.Size(458, 509)
        Me.tabDFLOW.TabIndex = 3
        Me.tabDFLOW.Text = "Design Flow"
        Me.tabDFLOW.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(6, 478)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.chkNonBio3Pct)
        Me.GroupBox2.Controls.Add(Me.chkNonBio2Explicit)
        Me.GroupBox2.Controls.Add(Me.tbNonBio2Chronic)
        Me.GroupBox2.Controls.Add(Me.tbNonBio1Chronic)
        Me.GroupBox2.Controls.Add(Me.chkNonBioChronic)
        Me.GroupBox2.Controls.Add(Me.chkNonBioAcute)
        Me.GroupBox2.Controls.Add(Me.chkNonBioCustom2)
        Me.GroupBox2.Controls.Add(Me.txtNonBioCustomNday2)
        Me.GroupBox2.Controls.Add(Me.txtNonBioCustomReturn2)
        Me.GroupBox2.Controls.Add(Me.chkNonBioCustom1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtNonBioCustomNday1)
        Me.GroupBox2.Controls.Add(Me.txtNonBioCustomReturn1)
        Me.GroupBox2.Controls.Add(Me.chkHarmonicMean)
        Me.GroupBox2.Controls.Add(Me.tbNonBio3)
        Me.GroupBox2.Controls.Add(Me.tbNonBio4)
        Me.GroupBox2.Controls.Add(Me.tbNonBio2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbNonBio1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 230)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Non-Biological Design Flow Parameters"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(279, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Chronic: criterion continuous concentration (default 7Q10)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(262, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Acute: criterion maximum concentration (default 1Q10)"
        '
        'chkNonBio3Pct
        '
        Me.chkNonBio3Pct.AutoSize = True
        Me.chkNonBio3Pct.Location = New System.Drawing.Point(300, 121)
        Me.chkNonBio3Pct.Name = "chkNonBio3Pct"
        Me.chkNonBio3Pct.Size = New System.Drawing.Size(97, 17)
        Me.chkNonBio3Pct.TabIndex = 41
        Me.chkNonBio3Pct.Text = "Flow percentile"
        Me.chkNonBio3Pct.UseVisualStyleBackColor = True
        '
        'chkNonBio2Explicit
        '
        Me.chkNonBio2Explicit.AutoSize = True
        Me.chkNonBio2Explicit.Location = New System.Drawing.Point(168, 121)
        Me.chkNonBio2Explicit.Name = "chkNonBio2Explicit"
        Me.chkNonBio2Explicit.Size = New System.Drawing.Size(110, 17)
        Me.chkNonBio2Explicit.TabIndex = 40
        Me.chkNonBio2Explicit.Text = "Explicit flow value"
        Me.chkNonBio2Explicit.UseVisualStyleBackColor = True
        '
        'tbNonBio2Chronic
        '
        Me.tbNonBio2Chronic.Enabled = False
        Me.tbNonBio2Chronic.Location = New System.Drawing.Point(229, 74)
        Me.tbNonBio2Chronic.Name = "tbNonBio2Chronic"
        Me.tbNonBio2Chronic.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio2Chronic.TabIndex = 39
        Me.tbNonBio2Chronic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbNonBio1Chronic
        '
        Me.tbNonBio1Chronic.Enabled = False
        Me.tbNonBio1Chronic.Location = New System.Drawing.Point(229, 42)
        Me.tbNonBio1Chronic.Name = "tbNonBio1Chronic"
        Me.tbNonBio1Chronic.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio1Chronic.TabIndex = 38
        Me.tbNonBio1Chronic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkNonBioChronic
        '
        Me.chkNonBioChronic.AutoSize = True
        Me.chkNonBioChronic.Location = New System.Drawing.Point(229, 19)
        Me.chkNonBioChronic.Name = "chkNonBioChronic"
        Me.chkNonBioChronic.Size = New System.Drawing.Size(62, 17)
        Me.chkNonBioChronic.TabIndex = 37
        Me.chkNonBioChronic.Text = "Chronic"
        Me.chkNonBioChronic.UseVisualStyleBackColor = True
        '
        'chkNonBioAcute
        '
        Me.chkNonBioAcute.AutoSize = True
        Me.chkNonBioAcute.Location = New System.Drawing.Point(168, 19)
        Me.chkNonBioAcute.Name = "chkNonBioAcute"
        Me.chkNonBioAcute.Size = New System.Drawing.Size(54, 17)
        Me.chkNonBioAcute.TabIndex = 36
        Me.chkNonBioAcute.Text = "Acute"
        Me.chkNonBioAcute.UseVisualStyleBackColor = True
        '
        'chkNonBioCustom2
        '
        Me.chkNonBioCustom2.AutoSize = True
        Me.chkNonBioCustom2.Location = New System.Drawing.Point(360, 19)
        Me.chkNonBioCustom2.Name = "chkNonBioCustom2"
        Me.chkNonBioCustom2.Size = New System.Drawing.Size(57, 17)
        Me.chkNonBioCustom2.TabIndex = 35
        Me.chkNonBioCustom2.Text = "Scen2"
        Me.chkNonBioCustom2.UseVisualStyleBackColor = True
        '
        'txtNonBioCustomNday2
        '
        Me.txtNonBioCustomNday2.Enabled = False
        Me.txtNonBioCustomNday2.Location = New System.Drawing.Point(360, 42)
        Me.txtNonBioCustomNday2.Name = "txtNonBioCustomNday2"
        Me.txtNonBioCustomNday2.Size = New System.Drawing.Size(49, 20)
        Me.txtNonBioCustomNday2.TabIndex = 33
        Me.txtNonBioCustomNday2.Text = "30"
        Me.txtNonBioCustomNday2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNonBioCustomReturn2
        '
        Me.txtNonBioCustomReturn2.Enabled = False
        Me.txtNonBioCustomReturn2.Location = New System.Drawing.Point(360, 74)
        Me.txtNonBioCustomReturn2.Name = "txtNonBioCustomReturn2"
        Me.txtNonBioCustomReturn2.Size = New System.Drawing.Size(49, 20)
        Me.txtNonBioCustomReturn2.TabIndex = 34
        Me.txtNonBioCustomReturn2.Text = "5"
        Me.txtNonBioCustomReturn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkNonBioCustom1
        '
        Me.chkNonBioCustom1.AutoSize = True
        Me.chkNonBioCustom1.Location = New System.Drawing.Point(297, 19)
        Me.chkNonBioCustom1.Name = "chkNonBioCustom1"
        Me.chkNonBioCustom1.Size = New System.Drawing.Size(57, 17)
        Me.chkNonBioCustom1.TabIndex = 32
        Me.chkNonBioCustom1.Text = "Scen1"
        Me.chkNonBioCustom1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(6, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Return period on years" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with excursions (years):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(6, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Flow averaging period (N days):"
        '
        'txtNonBioCustomNday1
        '
        Me.txtNonBioCustomNday1.Enabled = False
        Me.txtNonBioCustomNday1.Location = New System.Drawing.Point(297, 42)
        Me.txtNonBioCustomNday1.Name = "txtNonBioCustomNday1"
        Me.txtNonBioCustomNday1.Size = New System.Drawing.Size(49, 20)
        Me.txtNonBioCustomNday1.TabIndex = 28
        Me.txtNonBioCustomNday1.Text = "30"
        Me.txtNonBioCustomNday1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNonBioCustomReturn1
        '
        Me.txtNonBioCustomReturn1.Enabled = False
        Me.txtNonBioCustomReturn1.Location = New System.Drawing.Point(297, 74)
        Me.txtNonBioCustomReturn1.Name = "txtNonBioCustomReturn1"
        Me.txtNonBioCustomReturn1.Size = New System.Drawing.Size(49, 20)
        Me.txtNonBioCustomReturn1.TabIndex = 31
        Me.txtNonBioCustomReturn1.Text = "5"
        Me.txtNonBioCustomReturn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkHarmonicMean
        '
        Me.chkHarmonicMean.AutoSize = True
        Me.chkHarmonicMean.Checked = True
        Me.chkHarmonicMean.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHarmonicMean.Location = New System.Drawing.Point(6, 121)
        Me.chkHarmonicMean.Name = "chkHarmonicMean"
        Me.chkHarmonicMean.Size = New System.Drawing.Size(101, 17)
        Me.chkHarmonicMean.TabIndex = 12
        Me.chkHarmonicMean.Text = "Harmonic Mean"
        Me.chkHarmonicMean.UseVisualStyleBackColor = True
        '
        'tbNonBio3
        '
        Me.tbNonBio3.Enabled = False
        Me.tbNonBio3.Location = New System.Drawing.Point(168, 144)
        Me.tbNonBio3.Name = "tbNonBio3"
        Me.tbNonBio3.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio3.TabIndex = 11
        Me.tbNonBio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbNonBio4
        '
        Me.tbNonBio4.Enabled = False
        Me.tbNonBio4.Location = New System.Drawing.Point(300, 144)
        Me.tbNonBio4.Name = "tbNonBio4"
        Me.tbNonBio4.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio4.TabIndex = 10
        Me.tbNonBio4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbNonBio2
        '
        Me.tbNonBio2.Enabled = False
        Me.tbNonBio2.Location = New System.Drawing.Point(168, 74)
        Me.tbNonBio2.Name = "tbNonBio2"
        Me.tbNonBio2.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio2.TabIndex = 9
        Me.tbNonBio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(220, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "cfs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(352, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "%"
        '
        'tbNonBio1
        '
        Me.tbNonBio1.Enabled = False
        Me.tbNonBio1.Location = New System.Drawing.Point(168, 42)
        Me.tbNonBio1.Name = "tbNonBio1"
        Me.tbNonBio1.Size = New System.Drawing.Size(46, 20)
        Me.tbNonBio1.TabIndex = 5
        Me.tbNonBio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbBio
        '
        Me.gbBio.Controls.Add(Me.Label15)
        Me.gbBio.Controls.Add(Me.Label11)
        Me.gbBio.Controls.Add(Me.Label12)
        Me.gbBio.Controls.Add(Me.ckbBioAmm)
        Me.gbBio.Controls.Add(Me.ckbBioChronic)
        Me.gbBio.Controls.Add(Me.tbBio3Amm)
        Me.gbBio.Controls.Add(Me.tbBio4Amm)
        Me.gbBio.Controls.Add(Me.tbBio2Amm)
        Me.gbBio.Controls.Add(Me.tbBio1Amm)
        Me.gbBio.Controls.Add(Me.tbBio3Chronic)
        Me.gbBio.Controls.Add(Me.tbBio4Chronic)
        Me.gbBio.Controls.Add(Me.tbBio2Chronic)
        Me.gbBio.Controls.Add(Me.tbBio1Chronic)
        Me.gbBio.Controls.Add(Me.chkBio3Ammonia)
        Me.gbBio.Controls.Add(Me.chkBio2Chronic)
        Me.gbBio.Controls.Add(Me.chkBio1Acute)
        Me.gbBio.Controls.Add(Me.tbBio3)
        Me.gbBio.Controls.Add(Me.tbBio4)
        Me.gbBio.Controls.Add(Me.tbBio2)
        Me.gbBio.Controls.Add(Me.Label4)
        Me.gbBio.Controls.Add(Me.Label3)
        Me.gbBio.Controls.Add(Me.Label2)
        Me.gbBio.Controls.Add(Me.tbBio1)
        Me.gbBio.Controls.Add(Me.Label1)
        Me.gbBio.Controls.Add(Me.ckbBio)
        Me.gbBio.Location = New System.Drawing.Point(8, 6)
        Me.gbBio.Name = "gbBio"
        Me.gbBio.Size = New System.Drawing.Size(442, 229)
        Me.gbBio.TabIndex = 5
        Me.gbBio.TabStop = False
        Me.gbBio.Text = "Biological Design Flow Parameters"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 13)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Ammonia: default 30B3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(272, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Chronic: criterion continuous concentration (default 4B3)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(255, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Acute: criterion maximum concentration (default 1B3)"
        '
        'ckbBioAmm
        '
        Me.ckbBioAmm.AutoSize = True
        Me.ckbBioAmm.Checked = True
        Me.ckbBioAmm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbBioAmm.Location = New System.Drawing.Point(368, 158)
        Me.ckbBioAmm.Name = "ckbBioAmm"
        Me.ckbBioAmm.Size = New System.Drawing.Size(61, 17)
        Me.ckbBioAmm.TabIndex = 24
        Me.ckbBioAmm.Text = "Custom"
        Me.ckbBioAmm.UseVisualStyleBackColor = True
        '
        'ckbBioChronic
        '
        Me.ckbBioChronic.AutoSize = True
        Me.ckbBioChronic.Checked = True
        Me.ckbBioChronic.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbBioChronic.Location = New System.Drawing.Point(300, 158)
        Me.ckbBioChronic.Name = "ckbBioChronic"
        Me.ckbBioChronic.Size = New System.Drawing.Size(61, 17)
        Me.ckbBioChronic.TabIndex = 23
        Me.ckbBioChronic.Text = "Custom"
        Me.ckbBioChronic.UseVisualStyleBackColor = True
        '
        'tbBio3Amm
        '
        Me.tbBio3Amm.Enabled = False
        Me.tbBio3Amm.Location = New System.Drawing.Point(368, 95)
        Me.tbBio3Amm.Name = "tbBio3Amm"
        Me.tbBio3Amm.Size = New System.Drawing.Size(46, 20)
        Me.tbBio3Amm.TabIndex = 22
        Me.tbBio3Amm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio4Amm
        '
        Me.tbBio4Amm.Enabled = False
        Me.tbBio4Amm.Location = New System.Drawing.Point(368, 121)
        Me.tbBio4Amm.Name = "tbBio4Amm"
        Me.tbBio4Amm.Size = New System.Drawing.Size(46, 20)
        Me.tbBio4Amm.TabIndex = 21
        Me.tbBio4Amm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio2Amm
        '
        Me.tbBio2Amm.Enabled = False
        Me.tbBio2Amm.Location = New System.Drawing.Point(368, 69)
        Me.tbBio2Amm.Name = "tbBio2Amm"
        Me.tbBio2Amm.Size = New System.Drawing.Size(46, 20)
        Me.tbBio2Amm.TabIndex = 20
        Me.tbBio2Amm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio1Amm
        '
        Me.tbBio1Amm.Enabled = False
        Me.tbBio1Amm.Location = New System.Drawing.Point(368, 43)
        Me.tbBio1Amm.Name = "tbBio1Amm"
        Me.tbBio1Amm.Size = New System.Drawing.Size(46, 20)
        Me.tbBio1Amm.TabIndex = 19
        Me.tbBio1Amm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio3Chronic
        '
        Me.tbBio3Chronic.Enabled = False
        Me.tbBio3Chronic.Location = New System.Drawing.Point(300, 95)
        Me.tbBio3Chronic.Name = "tbBio3Chronic"
        Me.tbBio3Chronic.Size = New System.Drawing.Size(46, 20)
        Me.tbBio3Chronic.TabIndex = 18
        Me.tbBio3Chronic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio4Chronic
        '
        Me.tbBio4Chronic.Enabled = False
        Me.tbBio4Chronic.Location = New System.Drawing.Point(300, 121)
        Me.tbBio4Chronic.Name = "tbBio4Chronic"
        Me.tbBio4Chronic.Size = New System.Drawing.Size(46, 20)
        Me.tbBio4Chronic.TabIndex = 17
        Me.tbBio4Chronic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio2Chronic
        '
        Me.tbBio2Chronic.Enabled = False
        Me.tbBio2Chronic.Location = New System.Drawing.Point(300, 69)
        Me.tbBio2Chronic.Name = "tbBio2Chronic"
        Me.tbBio2Chronic.Size = New System.Drawing.Size(46, 20)
        Me.tbBio2Chronic.TabIndex = 16
        Me.tbBio2Chronic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio1Chronic
        '
        Me.tbBio1Chronic.Enabled = False
        Me.tbBio1Chronic.Location = New System.Drawing.Point(300, 43)
        Me.tbBio1Chronic.Name = "tbBio1Chronic"
        Me.tbBio1Chronic.Size = New System.Drawing.Size(46, 20)
        Me.tbBio1Chronic.TabIndex = 15
        Me.tbBio1Chronic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkBio3Ammonia
        '
        Me.chkBio3Ammonia.AutoSize = True
        Me.chkBio3Ammonia.Location = New System.Drawing.Point(368, 20)
        Me.chkBio3Ammonia.Name = "chkBio3Ammonia"
        Me.chkBio3Ammonia.Size = New System.Drawing.Size(69, 17)
        Me.chkBio3Ammonia.TabIndex = 14
        Me.chkBio3Ammonia.Text = "Ammonia"
        Me.chkBio3Ammonia.UseVisualStyleBackColor = True
        '
        'chkBio2Chronic
        '
        Me.chkBio2Chronic.AutoSize = True
        Me.chkBio2Chronic.Location = New System.Drawing.Point(300, 20)
        Me.chkBio2Chronic.Name = "chkBio2Chronic"
        Me.chkBio2Chronic.Size = New System.Drawing.Size(62, 17)
        Me.chkBio2Chronic.TabIndex = 13
        Me.chkBio2Chronic.Text = "Chronic"
        Me.chkBio2Chronic.UseVisualStyleBackColor = True
        '
        'chkBio1Acute
        '
        Me.chkBio1Acute.AutoSize = True
        Me.chkBio1Acute.Location = New System.Drawing.Point(237, 20)
        Me.chkBio1Acute.Name = "chkBio1Acute"
        Me.chkBio1Acute.Size = New System.Drawing.Size(54, 17)
        Me.chkBio1Acute.TabIndex = 12
        Me.chkBio1Acute.Text = "Acute"
        Me.chkBio1Acute.UseVisualStyleBackColor = True
        '
        'tbBio3
        '
        Me.tbBio3.Enabled = False
        Me.tbBio3.Location = New System.Drawing.Point(237, 95)
        Me.tbBio3.Name = "tbBio3"
        Me.tbBio3.Size = New System.Drawing.Size(46, 20)
        Me.tbBio3.TabIndex = 11
        Me.tbBio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio4
        '
        Me.tbBio4.Enabled = False
        Me.tbBio4.Location = New System.Drawing.Point(237, 121)
        Me.tbBio4.Name = "tbBio4"
        Me.tbBio4.Size = New System.Drawing.Size(46, 20)
        Me.tbBio4.TabIndex = 10
        Me.tbBio4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbBio2
        '
        Me.tbBio2.Enabled = False
        Me.tbBio2.Location = New System.Drawing.Point(237, 69)
        Me.tbBio2.Name = "tbBio2"
        Me.tbBio2.Size = New System.Drawing.Size(46, 20)
        Me.tbBio2.TabIndex = 9
        Me.tbBio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Average number of excursions per cluster:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Length of excursion clustering period (days):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Average number of years between excursions:"
        '
        'tbBio1
        '
        Me.tbBio1.Enabled = False
        Me.tbBio1.Location = New System.Drawing.Point(237, 43)
        Me.tbBio1.Name = "tbBio1"
        Me.tbBio1.Size = New System.Drawing.Size(46, 20)
        Me.tbBio1.TabIndex = 5
        Me.tbBio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Flow averaging period (days):"
        '
        'ckbBio
        '
        Me.ckbBio.AutoSize = True
        Me.ckbBio.Checked = True
        Me.ckbBio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbBio.Location = New System.Drawing.Point(237, 158)
        Me.ckbBio.Name = "ckbBio"
        Me.ckbBio.Size = New System.Drawing.Size(61, 17)
        Me.ckbBio.TabIndex = 0
        Me.ckbBio.Text = "Custom"
        Me.ckbBio.UseVisualStyleBackColor = True
        '
        'rbNonBio1
        '
        Me.rbNonBio1.AutoSize = True
        Me.rbNonBio1.Checked = True
        Me.rbNonBio1.Location = New System.Drawing.Point(136, 492)
        Me.rbNonBio1.Name = "rbNonBio1"
        Me.rbNonBio1.Size = New System.Drawing.Size(83, 17)
        Me.rbNonBio1.TabIndex = 1
        Me.rbNonBio1.TabStop = True
        Me.rbNonBio1.Text = "Hydrological"
        Me.rbNonBio1.UseVisualStyleBackColor = True
        '
        'rbNonBio2
        '
        Me.rbNonBio2.AutoSize = True
        Me.rbNonBio2.Location = New System.Drawing.Point(225, 492)
        Me.rbNonBio2.Name = "rbNonBio2"
        Me.rbNonBio2.Size = New System.Drawing.Size(112, 17)
        Me.rbNonBio2.TabIndex = 2
        Me.rbNonBio2.Text = "Explicit flow value:"
        Me.rbNonBio2.UseVisualStyleBackColor = True
        '
        'rbNonBio3
        '
        Me.rbNonBio3.AutoSize = True
        Me.rbNonBio3.Location = New System.Drawing.Point(323, 492)
        Me.rbNonBio3.Name = "rbNonBio3"
        Me.rbNonBio3.Size = New System.Drawing.Size(99, 17)
        Me.rbNonBio3.TabIndex = 3
        Me.rbNonBio3.Text = "Flow percentile:"
        Me.rbNonBio3.UseVisualStyleBackColor = True
        '
        'rbBio3
        '
        Me.rbBio3.AutoSize = True
        Me.rbBio3.Location = New System.Drawing.Point(356, 478)
        Me.rbBio3.Name = "rbBio3"
        Me.rbBio3.Size = New System.Drawing.Size(102, 17)
        Me.rbBio3.TabIndex = 3
        Me.rbBio3.Text = "Ammonia (30B3)"
        Me.rbBio3.UseVisualStyleBackColor = True
        '
        'rbBio1
        '
        Me.rbBio1.AutoSize = True
        Me.rbBio1.Checked = True
        Me.rbBio1.Location = New System.Drawing.Point(87, 478)
        Me.rbBio1.Name = "rbBio1"
        Me.rbBio1.Size = New System.Drawing.Size(238, 17)
        Me.rbBio1.TabIndex = 1
        Me.rbBio1.TabStop = True
        Me.rbBio1.Text = "Criterion maximum concentration (acute, 1B3)"
        Me.rbBio1.UseVisualStyleBackColor = True
        '
        'rbBio2
        '
        Me.rbBio2.AutoSize = True
        Me.rbBio2.Location = New System.Drawing.Point(189, 469)
        Me.rbBio2.Name = "rbBio2"
        Me.rbBio2.Size = New System.Drawing.Size(255, 17)
        Me.rbBio2.TabIndex = 2
        Me.rbBio2.Text = "Criterion continuous concentration (chronic, 4B3)"
        Me.rbBio2.UseVisualStyleBackColor = True
        '
        'frmSWSTATDFlowBatch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 537)
        Me.Controls.Add(Me.tabMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmSWSTATDFlowBatch"
        Me.Text = "Integrated Design Flow"
        Me.tabMain.ResumeLayout(False)
        Me.tabSelectDates.ResumeLayout(False)
        Me.gbTextOutput.ResumeLayout(False)
        Me.gbTextOutput.PerformLayout()
        Me.grpHighLow.ResumeLayout(False)
        Me.grpHighLow.PerformLayout()
        Me.grpDates.ResumeLayout(False)
        Me.grpDates.PerformLayout()
        Me.grpYears.ResumeLayout(False)
        Me.grpYears.PerformLayout()
        Me.tabNDay.ResumeLayout(False)
        Me.tabNDay.PerformLayout()
        Me.groupGraph.ResumeLayout(False)
        Me.groupGraph.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.grpRecurrence.ResumeLayout(False)
        Me.grpRecurrence.PerformLayout()
        Me.grpNday.ResumeLayout(False)
        Me.grpNday.PerformLayout()
        Me.tabDFLOW.ResumeLayout(False)
        Me.tabDFLOW.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbBio.ResumeLayout(False)
        Me.gbBio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'The group of atcTimeseries displayed
    Private WithEvents pDataGroup As atcTimeseriesGroup
    Private WithEvents pNDayGroup As atcTimeseriesGroup

    Private pDateFormat As New atcDateFormat

    'Value formatting options, can be overridden by timeseries attributes
    Private pMaxWidth As Integer = 10
    Private pFormat As String = "#,##0.########"
    Private pExpFormat As String = "#.#e#"
    Private pCantFit As String = "#"
    Private pSignificantDigits As Integer = 5

    'Private pDataAttributes As ArrayList
    Private pBasicAttributes As Generic.List(Of String)
    Private pNDayAttributes As Generic.List(Of String)
    Private pTrendAttributes As Generic.List(Of String)

    Private pYearStartMonth As Integer = 0
    Private pYearStartDay As Integer = 0
    Private pYearEndMonth As Integer = 0
    Private pYearEndDay As Integer = 0
    Private pFirstYear As Integer = 0
    Private pLastYear As Integer = 0

    Private pCommonStart As Double = GetMinValue()
    Private pCommonEnd As Double = GetMaxValue()

    Private Const pNoDatesInCommon As String = ": No dates in common"

    Public Event ParametersSet(ByVal aArgs As atcDataAttributes)
    Private pAttributes As atcDataAttributes
    Private pSetGlobal As Boolean = False
    Private pBatch As Boolean = False

    Private Shared pLastDayOfMonth() As Integer = {99, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

    Private pHelpLocation As String = "BASINS Details\Analysis\USGS Surface Water Statistics.html"
    Private Sub mnuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelp.Click
        ShowHelp(pHelpLocation)
    End Sub

    Private Sub PopulateForm()
        pDateFormat = New atcDateFormat
        With pDateFormat
            .IncludeHours = False
            .IncludeMinutes = False
            .IncludeSeconds = False
        End With

        If GetSetting("atcFrequencyGrid", "Defaults", "HighOrLow", "High") = "High" Then
            radioHigh.Checked = True
        Else
            radioLow.Checked = True
        End If

        chkLog.Checked = (GetSetting("atcFrequencyGrid", "Defaults", "Logarithmic", "True") = "True")

        LoadListSettingsOrDefaults(lstNday)
        LoadListSettingsOrDefaults(lstRecurrence)
        RepopulateForm()
    End Sub

    Private Sub PopulateForm(ByVal attribs As atcDataAttributes)
        pDateFormat = New atcDateFormat
        With pDateFormat
            .IncludeHours = False
            .IncludeMinutes = False
            .IncludeSeconds = False
        End With

        Dim lHighLow As String = attribs.GetValue(InputNames.HighLow, "")
        If lHighLow.ToLower = "high" Then
            radioHigh.Checked = True
        Else
            radioLow.Checked = True
        End If

        chkLog.Checked = attribs.GetValue(InputNames.Logarithmic, True)
        chkMultipleNDayPlots.Checked = attribs.GetValue(InputNames.MultiNDayPlot, False)
        chkMultipleStationPlots.Checked = attribs.GetValue(InputNames.MultiStationPlot, False)
        Dim lOutDir As String = attribs.GetValue(InputNames.OutputDir, "")
        If IO.Directory.Exists(lOutDir) Then
            txtOutputDir.Text = lOutDir
        End If
        Dim lPrefix As String = attribs.GetValue(InputNames.OutputPrefix, "")
        txtOutputRootName.Text = lPrefix

        LoadListSettingsOrDefaults(lstNday, attribs)
        LoadListSettingsOrDefaults(lstRecurrence, attribs)
        RepopulateForm()
    End Sub

    Private Sub RepopulateForm()
        SeasonsYearsToForm()

        Dim lFirstDate As Double = GetMaxValue()
        Dim lLastDate As Double = GetMinValue()

        pCommonStart = GetMinValue()
        pCommonEnd = GetMaxValue()

        Dim lAllText As String = "All"
        Dim lCommonText As String = "Common"

        Dim lHaveAnnual As Boolean = False
        Dim lAnnualIsHigh As Boolean = False
        Dim lAnnualIsLow As Boolean = False
        Dim lAnnualNday As Integer = 0

        For Each lDataset As atcData.atcTimeseries In pDataGroup
            If lDataset.Dates.numValues > 0 Then
                Dim lThisDate As Double = lDataset.Dates.Value(1)
                If lThisDate < lFirstDate Then lFirstDate = lThisDate
                If lThisDate > pCommonStart Then pCommonStart = lThisDate
                lThisDate = lDataset.Dates.Value(lDataset.Dates.numValues)
                If lThisDate > lLastDate Then lLastDate = lThisDate
                If lThisDate < pCommonEnd Then pCommonEnd = lThisDate

                If lDataset.Attributes.GetValue("Tu", atcTimeUnit.TUDay) = atcTimeUnit.TUYear Then
                    lHaveAnnual = True
                    Dim lConstituent As String = lDataset.Attributes.GetValue("Constituent", "")
                    If lConstituent.Length < 4 Then
                        Logger.Msg("Dataset #" & lDataset.Attributes.GetValue("ID", "") & " " & lDataset.ToString, _
                                   "Annual Dataset Missing Constituent")
                    Else
                        Select Case lConstituent.Substring(0, 1).ToUpper
                            Case "L" : lAnnualIsLow = True
                            Case "H" : lAnnualIsHigh = True
                            Case Else
                                Logger.Msg("Dataset #" & lDataset.Attributes.GetValue("ID", "") & " " & lDataset.ToString, _
                                           "Annual Dataset Constituent does not start with L or H")
                        End Select
                        Dim lNday As Integer
                        If Integer.TryParse(lConstituent.Substring(1), lNday) Then
                            If lAnnualNday = 0 Then
                                lAnnualNday = lNday
                            ElseIf lAnnualNday <> lNday Then
                                Logger.Msg("Annual datasets with different N-Day cannot be analyzed at the same time." & vbCrLf _
                                           & "N-Day values of both " & lAnnualNday & " and " & lNday & " were found.", _
                                           "Incompatible Annual Data Selected")
                            End If
                        End If
                    End If
                End If
            End If
        Next

        grpHighLow.Enabled = True
        grpNday.Enabled = True
        If lHaveAnnual Then
            If lAnnualIsLow <> lAnnualIsHigh Then
                radioHigh.Checked = lAnnualIsHigh
                radioLow.Checked = Not lAnnualIsHigh
                grpHighLow.Enabled = False
            Else
                If lAnnualIsLow Then
                    Logger.Msg("Low and high annual datasets cannot be analyzed at the same time", _
                               "Incompatible Annual Data Selected")
                End If
            End If

            If lAnnualNday > 0 Then
                lstNday.ClearSelected()
                SelectNday(lAnnualNday)
                grpNday.Enabled = False
            End If
        End If

        If lFirstDate < GetMaxValue() AndAlso lLastDate > GetMinValue() Then
            lblDataStart.Text = lblDataStart.Tag & " " & pDateFormat.JDateToString(lFirstDate)
            lblDataEnd.Text = lblDataEnd.Tag & " " & pDateFormat.JDateToString(lLastDate)
            lAllText &= ": " & pDateFormat.JDateToString(lFirstDate) & " to " & pDateFormat.JDateToString(lLastDate)
        End If

        If pCommonStart > GetMinValue() AndAlso pCommonEnd < GetMaxValue() AndAlso pCommonStart < pCommonEnd Then
            lCommonText &= ": " & pDateFormat.JDateToString(pCommonStart) & " to " & pDateFormat.JDateToString(pCommonEnd)
        Else
            lCommonText &= pNoDatesInCommon
        End If

        Dim lLastSelectedIndex As Integer = cboYears.SelectedIndex
        If lLastSelectedIndex < 0 Then lLastSelectedIndex = 0
        With cboYears.Items
            .Clear()
            .Add(lAllText)
            .Add(lCommonText)
            .Add("Custom")
        End With
        cboYears.SelectedIndex = lLastSelectedIndex


    End Sub

    Private Sub LoadListSettingsOrDefaults(ByVal lst As Windows.Forms.ListBox)
        Dim lArgName As String = lst.Tag
        Dim lAvailableArray As String(,) = GetAllSettings("atcFrequencyGrid", "List." & lArgName)
        Dim lSelected As New ArrayList
        lst.Items.Clear()

        If Not lAvailableArray Is Nothing AndAlso lAvailableArray.Length > 0 Then
            Try
                For lIndex As Integer = 0 To lAvailableArray.GetUpperBound(0)
                    lst.Items.Add(lAvailableArray(lIndex, 0))
                    If lAvailableArray(lIndex, 1) = "True" Then
                        lst.SetSelected(lst.Items.Count - 1, True)
                    End If
                Next
            Catch e As Exception
                Logger.Dbg("Error retrieving saved settings: " & e.Message)
            End Try
        Else
            LoadListDefaults(lst)
        End If
    End Sub

    Private Sub LoadListSettingsOrDefaults(ByVal lst As Windows.Forms.ListBox, ByVal attribs As atcDataAttributes)
        Dim lArgName As String = lst.Tag & "s"
        Dim listing As atcCollection = attribs.GetValue(lArgName, Nothing)
        If listing Is Nothing Then
            Exit Sub
        End If

        Dim lSelected As New ArrayList
        lst.Items.Clear()

        If listing.Count > 0 Then
            Try
                For lIndex As Integer = 0 To listing.Count - 1
                    lst.Items.Add(listing.Keys(lIndex))
                    If listing.ItemByIndex(lIndex) Then
                        lst.SetSelected(lst.Items.Count - 1, True)
                    End If
                Next
            Catch e As Exception
                Logger.Dbg("Error retrieving " & lArgName & " settings: " & e.Message)
            End Try
        Else
            LoadListDefaults(lst)
        End If
    End Sub

    Private Sub frmSWSTATDFlowBatch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Windows.Forms.Keys.F1 Then
            ShowHelp(pHelpLocation)
        End If
    End Sub

    Public Sub Initialize(Optional ByVal aTimeseriesGroup As atcData.atcTimeseriesGroup = Nothing, _
                          Optional ByVal aBasicAttributes As Generic.List(Of String) = Nothing, _
                          Optional ByVal aNDayAttributes As Generic.List(Of String) = Nothing, _
                          Optional ByVal aTrendAttributes As Generic.List(Of String) = Nothing, _
                          Optional ByVal aShowForm As Boolean = True)

        If aTimeseriesGroup Is Nothing Then
            pDataGroup = New atcTimeseriesGroup
        Else
            pDataGroup = aTimeseriesGroup
        End If

        If aBasicAttributes Is Nothing Then
            pBasicAttributes = atcDataManager.DisplayAttributes
        Else
            pBasicAttributes = aBasicAttributes
        End If

        If aNDayAttributes Is Nothing Then
            pNDayAttributes = atcDataManager.DisplayAttributes
        Else
            pNDayAttributes = aNDayAttributes
        End If

        If aTrendAttributes Is Nothing Then
            pTrendAttributes = atcDataManager.DisplayAttributes
        Else
            pTrendAttributes = aTrendAttributes
        End If

        If aShowForm Then
            Dim DisplayPlugins As ICollection = atcDataManager.GetPlugins(GetType(atcDataDisplay))
            For Each lDisp As atcDataDisplay In DisplayPlugins
                Dim lMenuText As String = lDisp.Name
                If lMenuText <> "Analysis::USGS Surface Water Statistics (SWSTAT)::Integrated Frequency Analysis" Then
                    If lMenuText.StartsWith("Analysis::") Then lMenuText = lMenuText.Substring(10)
                    mnuAnalysis.MenuItems.Add(lMenuText, New EventHandler(AddressOf mnuAnalysis_Click))
                End If
            Next
        End If

        If pDataGroup.Count = 0 Then 'ask user to specify some timeseries
            pDataGroup = atcDataManager.UserSelectData("Select Data for Integrated Frequency Analysis", _
                                                       pDataGroup, Nothing, True, True, Me.Icon)
        End If
        DFLOWCalcs_Initialize()
        If pDataGroup.Count > 0 Then
            PopulateForm()
            PopulateDFLOW(pDataGroup)
            If aShowForm Then Me.Show()
        Else 'user declined to specify timeseries
            Me.Close()
        End If

    End Sub

    Public Sub Initialize(ByVal aTimeseriesGroup As atcData.atcTimeseriesGroup, _
                          ByVal attributes As atcDataAttributes)

        'Optional ByVal aBasicAttributes As Generic.List(Of String) = Nothing, _
        'Optional ByVal aNDayAttributes As Generic.List(Of String) = Nothing, _
        'Optional ByVal aTrendAttributes As Generic.List(Of String) = Nothing, _
        'Optional ByVal aShowForm As Boolean = True
        DFLOWCalcs_Initialize(attributes)
        If aTimeseriesGroup Is Nothing Then
            pDataGroup = New atcTimeseriesGroup
        Else
            pDataGroup = aTimeseriesGroup
        End If

        pAttributes = attributes

        pBatch = True
        Dim loperation As String = attributes.GetValue("Operation", "")
        If loperation.ToLower = "globalsetparm" Then
            pSetGlobal = True
            btnDoFrequencyGrid.Text = "Set Global Parameters"
            Me.Text &= " -Batch Run Global Default Parameter Setup"

        Else
            pSetGlobal = False
            btnDoFrequencyGrid.Text = "Set Group Parameters"
            Dim lGroupname As String = attributes.GetValue("group", "")
            Me.Text &= " -Batch Run Group (" & lGroupname & ") Parameter Setup"
        End If
        btnNDay.Visible = False
        btnDisplayTrend.Visible = False
        btnDisplayBasic.Visible = False
        btnDoFrequencyGraph.Visible = False
        gbTextOutput.Visible = True

        PopulateForm(attributes)
        Me.Show()
    End Sub

    Public Property DateFormat() As atcDateFormat
        Get
            Return pDateFormat
        End Get
        Set(ByVal newValue As atcDateFormat)
            pDateFormat = newValue
        End Set
    End Property

    Private Sub mnuAnalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnalysis.Click
        atcDataManager.ShowDisplay(sender.Text, pDataGroup, Me.Icon)
    End Sub

    Private Sub pDataGroup_Added(ByVal aAdded As atcCollection) Handles pDataGroup.Added
        If Me.Visible Then RepopulateForm()
        'TODO: could efficiently insert newly added item(s)
    End Sub

    Private Sub pDataGroup_Removed(ByVal aRemoved As atcCollection) Handles pDataGroup.Removed
        If Me.Visible Then RepopulateForm()
        'TODO: could efficiently remove by serial number
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        pDataGroup = Nothing
    End Sub

    Private Sub mnuFileSelectData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSelectData.Click
        atcDataManager.UserSelectData("Select Data for Integrated Frequency Analysis", _
                                      pDataGroup, Nothing, False, True, Me.Icon)
    End Sub

    Private Sub SeasonsYearsToForm()
        If cboStartMonth.Items.Count > 0 Then
            cboStartMonth.SelectedIndex = pYearStartMonth - 1
            cboEndMonth.SelectedIndex = pYearEndMonth - 1
            If pYearStartDay > 0 Then txtStartDay.Text = pYearStartDay Else txtStartDay.Text = ""
            If pYearEndDay > 0 Then txtEndDay.Text = pYearEndDay Else txtEndDay.Text = ""
            If pFirstYear > 0 Then txtOmitBeforeYear.Text = pFirstYear Else txtOmitBeforeYear.Text = ""
            If pLastYear > 0 Then txtOmitAfterYear.Text = pLastYear Else txtOmitAfterYear.Text = ""
            If pFirstYear > 0 OrElse pLastYear > 0 Then
                ShowCustomYears(True)
            End If
        End If
    End Sub

    Private Function SeasonsYearsFromFormBatch() As String
        pYearStartMonth = cboStartMonth.SelectedIndex + 1
        pYearEndMonth = cboEndMonth.SelectedIndex + 1
        If IsNumeric(txtStartDay.Text) Then
            pYearStartDay = Math.Min(CInt(txtStartDay.Text), DayMon(1901, pYearStartMonth))
            txtStartDay.Text = pYearStartDay
        Else
            pYearStartDay = 0
        End If
        If IsNumeric(txtEndDay.Text) Then
            pYearEndDay = Math.Min(CInt(txtEndDay.Text), DayMon(1901, pYearEndMonth))
            txtEndDay.Text = pYearEndDay
        Else
            pYearEndDay = 0
        End If
        If IsNumeric(txtOmitBeforeYear.Text) Then
            pFirstYear = CInt(txtOmitBeforeYear.Text)
        Else
            pFirstYear = 0
        End If
        If IsNumeric(txtOmitAfterYear.Text) Then
            pLastYear = CInt(txtOmitAfterYear.Text)
        Else
            pLastYear = 0
        End If
        Dim lMsg As String = SaveSettingsBatch()
        Return lMsg
    End Function

    Private Sub SeasonsYearsFromForm()
        pYearStartMonth = cboStartMonth.SelectedIndex + 1
        pYearEndMonth = cboEndMonth.SelectedIndex + 1
        If IsNumeric(txtStartDay.Text) Then
            pYearStartDay = Math.Min(CInt(txtStartDay.Text), DayMon(1901, pYearStartMonth))
            txtStartDay.Text = pYearStartDay
        Else
            pYearStartDay = 0
        End If
        If IsNumeric(txtEndDay.Text) Then
            pYearEndDay = Math.Min(CInt(txtEndDay.Text), DayMon(1901, pYearEndMonth))
            txtEndDay.Text = pYearEndDay
        Else
            pYearEndDay = 0
        End If
        If IsNumeric(txtOmitBeforeYear.Text) Then
            pFirstYear = CInt(txtOmitBeforeYear.Text)
        Else
            pFirstYear = 0
        End If
        If IsNumeric(txtOmitAfterYear.Text) Then
            pLastYear = CInt(txtOmitAfterYear.Text)
        Else
            pLastYear = 0
        End If
        SaveSettings()
    End Sub

    Private Sub ShowCustomYears(ByVal aShowCustom As Boolean)
        'cboYears.Visible = Not aShowCustom
        txtOmitBeforeYear.Enabled = aShowCustom
        txtOmitAfterYear.Enabled = aShowCustom
        lblDataStart.Enabled = aShowCustom
        lblDataEnd.Enabled = aShowCustom
        lblOmitBefore.Enabled = aShowCustom
        lblOmitAfter.Enabled = aShowCustom
    End Sub

    'Return all selected items, or if none are selected then all items
    Private Function ListToArray(ByVal aList As Windows.Forms.ListBox) As Double()
        Dim lArray() As Double
        Dim lCollection As New ArrayList
        If aList.SelectedItems.Count > 0 Then
            For lIndex As Integer = 0 To aList.SelectedItems.Count - 1
                If IsNumeric(aList.SelectedItems(lIndex)) Then
                    lCollection.Add(CDbl(aList.SelectedItems(lIndex)))
                End If
            Next
        Else
            For lIndex As Integer = 0 To aList.Items.Count - 1
                If IsNumeric(aList.Items(lIndex)) Then
                    lCollection.Add(CDbl(aList.Items(lIndex)))
                End If
            Next
        End If
        ReDim lArray(lCollection.Count - 1)
        For lIndex As Integer = 0 To lCollection.Count - 1
            lArray(lIndex) = lCollection.Item(lIndex)
        Next
        Return lArray
    End Function

    Private Function SelectedData() As atcTimeseriesGroup
        Dim lDataGroupB As New atcTimeseriesGroup
        Dim lTsB As atcTimeseries
        SeasonsYearsFromForm()

        For Each lTs As atcTimeseries In pDataGroup
            If lTs.Attributes.GetValue("Time Unit") = atcTimeUnit.TUYear Then
                lTsB = lTs
            Else
                If pFirstYear > 0 AndAlso pLastYear > 0 Then
                    lTsB = SubsetByDateBoundary(lTs, pYearStartMonth, pYearStartDay, Nothing, pFirstYear, pLastYear, pYearEndMonth, pYearEndDay)
                Else
                    lTsB = lTs
                End If

                Dim lSeasons As New atcSeasonsYearSubset(pYearStartMonth, pYearStartDay, pYearEndMonth, pYearEndDay)
                lSeasons.SeasonSelected(0) = True
                lTsB = lSeasons.SplitBySelected(lTsB, Nothing).ItemByIndex(1)
                lTsB.Attributes.SetValue("ID", lTs.OriginalParentID)
            End If
            lDataGroupB.Add(lTsB)
        Next

        Return lDataGroupB
    End Function

    Private Sub btnDisplayBasic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayBasic.Click
        Dim lList As New atcList.atcListForm

        With lList
            .Text = "Basic Statistics"
            .Initialize(SelectedData(), pBasicAttributes, False, , )
            .Width = 600
            .SwapRowsColumns = True
            .Icon = Me.Icon
        End With

        'Code section is to print out Text format of Basic Statistics, leave to remind how formatting is working to get 
        '     at the precise formatting in a SWSTAT format table
        '
        'Dim lselectedData As atcDataGroup = SelectedData()
        'Dim lfrmReport As New frmTextReport
        'lfrmReport.Title = "Basic Flow Statistics"

        'lfrmReport.ReportBody = "  DATA-                                                     NUMBER      NON-ZERO" & vbCrLf
        'lfrmReport.ReportBody &= "   SET                                        STANDARD   OF DATA VALUES RETURNS" & vbCrLf
        'lfrmReport.ReportBody &= " NUMBER    MINIMUM     MAXIMUM        MEAN   DEVIATION     USED  UNUSED CODE  NO." & vbCrLf
        'lfrmReport.ReportBody &= " ------ ---------- ----------- ----------- -----------  ------- ------- ---- ---" & vbCrLf

        'Dim lTemp As Double = 0.0
        'Dim lTSstats As New ArrayList()
        'If lselectedData.Count > 0 Then
        '    For Each aTS As atcTimeseries In lselectedData

        '        lTSstats = TSStats(aTS)

        '        lfrmReport.ReportBody &= CStr(aTS.Attributes.GetValue("ID")).PadLeft(6)
        '        lfrmReport.ReportBody &= DecimalAlignM(lTSstats(0), , 3, 6, False).PadLeft(13) 'min
        '        lfrmReport.ReportBody &= DecimalAlignM(lTSstats(1), , 3, 6, False).PadLeft(12) 'max
        '        lfrmReport.ReportBody &= DecimalAlignM(lTSstats(2), , 3, 6, False).PadLeft(12) 'mean
        '        lfrmReport.ReportBody &= DecimalAlignM(lTSstats(3), , 3, 6, False).PadLeft(12) 'lstdev
        '        lfrmReport.ReportBody &= CStr(lTSstats(4)).PadLeft(8) 'used
        '        lfrmReport.ReportBody &= CStr(lTSstats(5)).PadLeft(8) 'unused
        '        lfrmReport.ReportBody &= vbCrLf

        '    Next
        'Else
        'Logger.Msg("Select at least one time series")
        'End If

        'lfrmReport.displayReport()

    End Sub

    'Private Function TSStats(ByVal aTS As atcTimeseries) As ArrayList

    '    Dim lmean As Double
    '    Dim lmin As Double
    '    Dim lmax As Double
    '    Dim lstdev As Double
    '    Dim lUsed As Integer
    '    Dim lTotalCount As Integer
    '    Dim lSum As Double
    '    Dim lUnused As Integer
    '    Dim lSS As Double

    '    Dim lusedVals As New ArrayList()
    '    Dim lStats As New ArrayList()

    '    lmin = Double.MaxValue
    '    lmax = Double.MinValue
    '    For Each lVal As Double In aTS.Values
    '        lTotalCount += 1
    '        If lVal > 0 Then
    '            lUsed += 1
    '            lSum += lVal
    '            lusedVals.Add(lVal)
    '            If lVal > lmax Then
    '                lmax = lVal
    '            End If
    '            If lVal < lmin Then
    '                lmin = lVal
    '            End If
    '        End If
    '    Next

    '    lmean = lSum / lUsed
    '    lUnused = lTotalCount - lUsed

    '    For Each lVal As Double In lusedVals
    '        lSS += (lVal - lmean) ^ 2
    '    Next

    '    lstdev = Math.Sqrt(lSS / lUsed)

    '    lStats.Add(lmin)
    '    lStats.Add(lmax)
    '    lStats.Add(lmean)
    '    lStats.Add(lstdev)
    '    lStats.Add(lUsed)
    '    lStats.Add(lUnused)

    '    Return lStats

    'End Function

    Private Sub btnNDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNDay.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim lSelectedData As atcTimeseriesGroup = SelectedData()
        If lSelectedData.Count > 0 Then
            If lstNday.SelectedIndices.Count > 0 Then
                Dim lRankedAnnual As atcTimeseriesGroup = _
                   clsIDFPlugin.ComputeRankedAnnualTimeseries(aTimeseriesGroup:=lSelectedData, _
                                                                 aNDay:=ListToArray(lstNday), aHighFlag:=radioHigh.Checked, _
                                                                 aFirstYear:=pFirstYear, aLastYear:=pLastYear, _
                                                                 aBoundaryMonth:=pYearStartMonth, aBoundaryDay:=pYearStartDay, _
                                                                 aEndMonth:=pYearEndMonth, aEndDay:=pYearEndDay)
                If lRankedAnnual.Count > 0 Then
                    For Each lTS As atcTimeseries In lRankedAnnual
                        lTS.Attributes.SetValue("Units", "Common")
                    Next

                    Dim lList As New atcList.atcListForm
                    With lList
                        With .DateFormat
                            .IncludeDays = False
                            .IncludeHours = False
                            .IncludeMinutes = False
                            .IncludeMonths = False
                        End With
                        .Text = "N-Day " & HighOrLowString() & " Annual Time Series and Ranking"
                        .Initialize(lRankedAnnual.Clone, pNDayAttributes, True, , )
                        .DisplayValueAttributes = True
                        .Icon = Me.Icon
                    End With
                End If
            Else
                Logger.Msg("Select at least one number of days")
            End If
        Else
            Logger.Msg("Select at least one time series")
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnNdayAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayAdd.Click
        AddNday(txtNdayAdd.Text)
    End Sub

    Private Sub AddNday(ByVal aNday As String)
        If IsNumeric(aNday) Then
            Try
                Dim lIndex As Integer = 0
                Dim lNewValue As Double = CDbl(aNday)
                While lIndex < lstNday.Items.Count AndAlso CDbl(lstNday.Items(lIndex)) < lNewValue
                    lIndex += 1
                End While
                lstNday.Items.Insert(lIndex, aNday)
                lstNday.SetSelected(lIndex, True)
            Catch ex As Exception
                Logger.Dbg("Exception adding N-day '" & aNday & "': " & ex.Message)
            End Try
        Else
            Logger.Msg("Non-numeric value '" & aNday & "' could not be added to N-Day list")
        End If
    End Sub

    Private Sub SelectNday(ByVal aNday As String)
        If Not lstNday.Items.Contains(aNday) Then
            AddNday(aNday)
        End If
        For lNdayIndex As Integer = 0 To lstNday.Items.Count - 1
            If CInt(lstNday.Items(lNdayIndex)) = aNday Then
                lstNday.SelectedIndex = lNdayIndex
                Exit For
            End If
        Next
    End Sub

    Private Sub btnNdayRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayRemove.Click
        Dim lRemoveThese As New ArrayList
        Dim lIndex As Integer
        If lstNday.SelectedIndices.Count > 0 Then
            For lIndex = lstNday.SelectedIndices.Count - 1 To 0 Step -1
                lRemoveThese.Add(lstNday.SelectedIndices.Item(lIndex))
            Next
        Else
            For lIndex = lstNday.Items.Count - 1 To 0 Step -1
                If lstNday.Items(lIndex) = txtNdayAdd.Text Then
                    lRemoveThese.Add(lIndex)
                End If
            Next
        End If

        For Each lIndex In lRemoveThese
            lstNday.Items.RemoveAt(lIndex)
        Next
    End Sub

    Private Sub btnNdayDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayDefault.Click
        LoadListDefaults(lstNday)
    End Sub

    Private Sub LoadListDefaults(ByVal aList As Windows.Forms.ListBox)
        Dim lDefault() As Double = clsIDFPlugin.ListDefaultArray(aList.Tag)
        If Not lDefault Is Nothing Then
            aList.Items.Clear()
            For Each lNumber As Double In lDefault
                Dim lLabel As String = Format(lNumber, "0.####")
                aList.Items.Add(lLabel)
            Next
        End If
    End Sub

    ''' <summary>Calculate aOperationName: "n-day " HighOrLowString " value"
    ''' aReturnPeriods() = ListToArray(lstRecurrence))
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CalculateBatch()
        If Not pSetGlobal AndAlso pDataGroup IsNot Nothing Then ClearAttributes()
        Dim lMsg As String = SeasonsYearsFromFormBatch()
        If Not String.IsNullOrEmpty(lMsg) Then
            Logger.Msg("Please address the following issues before proceeding:" & vbCrLf & vbCrLf & lMsg, MsgBoxStyle.Information, "Input Needs Correction")
            Exit Sub
        Else
            If pSetGlobal Then
                Logger.MsgCustomOwned("Parameters are set for Global Defaults.", "USGS Batch Processing", Me, New String() {"OK"})
                Me.Close()
            Else
                Dim lGroup As String = pAttributes.GetValue("Group", "")
                Logger.MsgCustomOwned("Group Parameters are set for " & lGroup, "USGS Batch Processing", Me, New String() {"OK"})
                Me.Close()
            End If
        End If
        RaiseEvent ParametersSet(pAttributes)
    End Sub

    Private Sub Calculate(ByVal aOperationName As String, ByVal aReturnPeriods() As Double)
        ClearAttributes()
        SeasonsYearsFromForm() 'setup all inputs from form
        Dim lCalculator As New atcTimeseriesNdayHighLow.atcTimeseriesNdayHighLow
        For Each lTs As atcTimeseries In pDataGroup
            lTs.Attributes.SetValueIfMissing("CalcEMA", True)
        Next
        Dim lArgs As New atcDataAttributes
        lArgs.SetValue("Timeseries", pDataGroup)
        lArgs.SetValue("NDay", ListToArray(lstNday))
        lArgs.SetValue("Return Period", aReturnPeriods)
        lArgs.SetValue("LogFlg", chkLog.Checked)
        If pYearStartMonth > 0 Then lArgs.SetValue("BoundaryMonth", pYearStartMonth)
        If pYearStartDay > 0 Then lArgs.SetValue("BoundaryDay", pYearStartDay)
        If pYearEndMonth > 0 Then lArgs.SetValue("EndMonth", pYearEndMonth)
        If pYearEndDay > 0 Then lArgs.SetValue("EndDay", pYearEndDay)
        If pFirstYear > 0 Then lArgs.SetValue("FirstYear", pFirstYear)
        If pLastYear > 0 Then lArgs.SetValue("LastYear", pLastYear)

        lCalculator.Open(aOperationName, lArgs)
        lCalculator.DataSets.Clear()
    End Sub

    Private Function SaveSettingsBatch() As String
        Dim lMsg As String = ""
        Dim lName As String = HighOrLowString()
        If pYearStartMonth = 0 OrElse pYearStartDay = 0 OrElse pYearEndMonth = 0 OrElse pYearEndDay = 0 Then
            lMsg &= "- Problem with start and/or end dates." & vbCrLf
        Else
            If pAttributes Is Nothing Then
                pAttributes = New atcDataAttributes()
            End If
            With pAttributes
                .SetValue(InputNames.StartMonth, pYearStartMonth)
                .SetValue(InputNames.StartDay, pYearStartDay)
                .SetValue(InputNames.EndMonth, pYearEndMonth)
                .SetValue(InputNames.EndDay, pYearEndDay)
                'For All years, txtOmitBeforeYear and txtOmitAfterYear are empty
                .SetValue(InputNames.IncludeYears, cboYears.SelectedItem.ToString())
                .SetValue(InputNames.StartYear, txtOmitBeforeYear.Text)
                .SetValue(InputNames.EndYear, txtOmitAfterYear.Text)
                .SetValue(InputNames.HighLow, lName)
                .SetValue(InputNames.Logarithmic, chkLog.Checked)
                .SetValue(InputNames.MultiNDayPlot, chkMultipleNDayPlots.Checked)
                .SetValue(InputNames.MultiStationPlot, chkMultipleStationPlots.Checked)
                If IO.Directory.Exists(txtOutputDir.Text) Then
                    .SetValue(InputNames.OutputDir, txtOutputDir.Text)
                Else
                    lMsg &= "- Need to specify a default output directory."
                End If
                If Not String.IsNullOrEmpty(txtOutputRootName.Text.Trim()) Then
                    .SetValue(InputNames.OutputPrefix, txtOutputRootName.Text.Trim())
                End If
            End With
        End If

        If Not pSetGlobal Then
            Dim lStationsInfo As atcCollection = clsBatchUtil.BuildStationsInfo(pDataGroup)
            pAttributes.SetValue(InputNames.StationsInfo, lStationsInfo)
        End If

        lMsg &= SaveListBatch(lstNday)
        lMsg &= SaveListBatch(lstRecurrence)

        Return lMsg
    End Function

    Private Sub SaveSettings()
        Dim lName As String = HighOrLowString()
        SaveSetting("atcFrequencyGrid", "StartMonth", lName, pYearStartMonth)
        SaveSetting("atcFrequencyGrid", "StartDay", lName, pYearStartDay)
        SaveSetting("atcFrequencyGrid", "EndMonth", lName, pYearEndMonth)
        SaveSetting("atcFrequencyGrid", "EndDay", lName, pYearEndDay)
        SaveSetting("atcFrequencyGrid", "Defaults", "HighOrLow", lName)
        SaveSetting("atcFrequencyGrid", "Defaults", "Logarithmic", chkLog.Checked.ToString)
        SaveList(lstNday)
        SaveList(lstRecurrence)
    End Sub

    Private Sub SaveList(ByVal lst As Windows.Forms.ListBox)
        SaveSetting("atcFrequencyGrid", "List." & lst.Tag, "dummy", "")
        DeleteSetting("atcFrequencyGrid", "List." & lst.Tag)
        For lIndex As Integer = 0 To lst.Items.Count - 1
            SaveSetting("atcFrequencyGrid", "List." & lst.Tag, lst.Items(lIndex), lst.SelectedIndices.Contains(lIndex))
        Next
    End Sub

    Private Function SaveListBatch(ByVal lst As Windows.Forms.ListBox) As String
        Dim lMsg As String = ""

        'Dim listing0() As Double = pAttributes.GetValue(lst.Tag, Nothing)
        'If listing0 IsNot Nothing Then
        '    ReDim listing0(0)
        '    listing0 = Nothing
        'End If
        Dim lCollection0 As atcCollection = pAttributes.GetValue(lst.Tag & "s", Nothing)
        If lCollection0 IsNot Nothing Then
            lCollection0.Clear()
            lCollection0 = Nothing
        End If
        pAttributes.RemoveByKey(lst.Tag)
        pAttributes.RemoveByKey(lst.Tag & "s")
        If lst.SelectedIndices.Count = 0 Then
            lMsg &= "- Need to select at least one " & lst.Tag & vbCrLf
            Return lMsg
        Else
            Dim listing(lst.Items.Count - 1) As Double
            Dim lCollection As New atcCollection()

            Dim lItemValue As Double
            For lIndex As Integer = 0 To lst.Items.Count - 1
                lItemValue = lst.Items(lIndex)
                listing(lIndex) = lItemValue
                lCollection.Add(lItemValue, lst.SelectedIndices.Contains(lIndex))
            Next
            pAttributes.SetValue(lst.Tag, listing)
            pAttributes.SetValue(lst.Tag & "s", lCollection)
        End If

        Return lMsg
    End Function

    Private Sub ClearAttributes()
        Dim lRemoveThese As New atcCollection
        For Each lData As atcDataSet In pDataGroup
            For Each lAttribute As atcDefinedValue In lData.Attributes
                If Not lAttribute.Arguments Is Nothing Then
                    If lAttribute.Arguments.ContainsAttribute("Nday") OrElse _
                       lAttribute.Arguments.ContainsAttribute("Return Period") Then
                        lRemoveThese.Add(lAttribute)
                    End If
                End If
            Next
            For Each lAttribute As atcDefinedValue In lRemoveThese
                lData.Attributes.Remove(lAttribute)
            Next
        Next
    End Sub

    Private Sub btnNdayAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayAll.Click
        For index As Integer = 0 To lstNday.Items.Count - 1
            lstNday.SetSelected(index, True)
        Next
    End Sub

    Private Sub btnNdayNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNdayNone.Click
        For index As Integer = 0 To lstNday.Items.Count - 1
            lstNday.SetSelected(index, False)
        Next
    End Sub

    Private Sub radioHigh_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioHigh.CheckedChanged
        GetDefaultYearStartEnd()
    End Sub

    Private Sub radioLow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioLow.CheckedChanged
        GetDefaultYearStartEnd()
    End Sub

    Private Sub GetDefaultYearStartEnd()
        If radioHigh.Checked Then
            pYearStartMonth = 10
            pYearStartDay = 1
            pYearEndMonth = 9
            pYearEndDay = 30
        Else
            pYearStartMonth = 4
            pYearStartDay = 1
            pYearEndMonth = 3
            pYearEndDay = 31
        End If

        Dim lName As String = HighOrLowString()
        pYearStartMonth = GetSetting("atcFrequencyGrid", "StartMonth", lName, pYearStartMonth)
        pYearStartDay = GetSetting("atcFrequencyGrid", "StartDay", lName, pYearStartDay)
        pYearEndMonth = GetSetting("atcFrequencyGrid", "EndMonth", lName, pYearEndMonth)
        pYearEndDay = GetSetting("atcFrequencyGrid", "EndDay", lName, pYearEndDay)
        SeasonsYearsToForm()
    End Sub

    Private Function HighOrLowString() As String
        If radioHigh.Checked Then
            Return "High"
        Else
            Return "Low"
        End If
    End Function

    Private Function MultipleNDayPlots() As Boolean
        If chkMultipleNDayPlots.Checked Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function MultipleStationPlots() As Boolean
        If chkMultipleStationPlots.Checked Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function RunSpearmanTest(ByVal aAnnualTS As atcTimeseries) As String
        Dim lRunR As String
        Dim lPrompt As Boolean = False
        Do
            lRunR = FindFile("Locate RunR executable", "RunR.exe", aUserVerifyFileName:=lPrompt)
            If lRunR.Length = 0 Then Return "RunR.exe not found"
            lPrompt = True
        Loop While Not lRunR.ToLower.EndsWith("runr.exe") OrElse Not IO.File.Exists(lRunR)

        lPrompt = False
        Dim lRcodeFilename As String
        Do
            lRcodeFilename = FindFile("Locate R script for computing Spearman Rho Test", "fnGetTrend.R", aUserVerifyFileName:=lPrompt)
            If lRcodeFilename.Length = 0 Then Return "R script not found"
            lPrompt = True
        Loop While Not lRcodeFilename.ToUpper.EndsWith(".R") OrElse Not IO.File.Exists(lRcodeFilename)

        If IO.File.Exists(lRcodeFilename) AndAlso aAnnualTS.numValues > 0 Then
            Dim lYearsString As String = ""
            Dim lValuesString As String = ""
            Dim lDateArray(6) As Integer
            For lValueIndex As Integer = 1 To aAnnualTS.numValues
                If Not Double.IsNaN(aAnnualTS.Value(lValueIndex)) Then
                    J2Date(aAnnualTS.Dates.Value(lValueIndex), lDateArray)
                    lYearsString &= lDateArray(0) & ", "
                    lValuesString &= DoubleToString(aAnnualTS.Value(lValueIndex), 15, "0.##########", aSignificantDigits:=8) & ", "
                End If
            Next
            'Trim extra comma and space
            lYearsString = lYearsString.Substring(0, lYearsString.Length - 2)
            lValuesString = lValuesString.Substring(0, lValuesString.Length - 2)

            Dim lArgsFilename As String = GetTemporaryFileName("RunR", ".R")
            Logger.Dbg("Writing trend R function/arguments to " & lArgsFilename)
            TryCopy(lRcodeFilename, lArgsFilename)
            Dim lArgWriter As New System.IO.StreamWriter(lArgsFilename, True)
            lArgWriter.WriteLine()
            lArgWriter.WriteLine("# Arguments for this run")
            lArgWriter.WriteLine("InputYears <- c(" & lYearsString & ")")
            lArgWriter.WriteLine("InputValues <- c(" & lValuesString & ")")
            lArgWriter.WriteLine("fnGetTrend(InputYears, InputValues, dPercentConfidenceInterval = 95, intWhat = 0)")
            lArgWriter.Close()

            Dim lResultsFilename As String = GetTemporaryFileName("Rresults", ".txt")
            Logger.Dbg("Writing trend R results to " & lResultsFilename)
            LaunchProgram(lRunR, IO.Path.GetDirectoryName(lRcodeFilename), lResultsFilename & " " & lArgsFilename)
            Return IO.File.ReadAllText(lResultsFilename).TrimEnd(vbLf).TrimEnd(vbCr)
        End If
        Return "R code not found"
    End Function

    Private Sub btnDisplayTrend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayTrend.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim lSelectedData As atcTimeseriesGroup = SelectedData()
        If lSelectedData.Count > 0 Then
            If lstNday.SelectedIndices.Count > 0 Then
                Dim lRankedAnnual As atcTimeseriesGroup = _
                   clsIDFPlugin.ComputeRankedAnnualTimeseries(aTimeseriesGroup:=lSelectedData, _
                                                                 aNDay:=ListToArray(lstNday), _
                                                                 aHighFlag:=radioHigh.Checked, _
                                                                 aFirstYear:=pFirstYear, _
                                                                 aLastYear:=pLastYear, _
                                                                 aBoundaryMonth:=pYearStartMonth, _
                                                                 aBoundaryDay:=pYearStartDay, _
                                                                 aEndMonth:=pYearEndMonth, _
                                                                 aEndDay:=pYearEndDay)
                If lRankedAnnual.Count > 0 Then
                    For Each lTS As atcTimeseries In lRankedAnnual
                        With lTS.Attributes
                            .SetValue("Original ID", lTS.OriginalParentID)
                            .SetValue("From", pDateFormat.JDateToString(lTS.Dates.Value(1)))
                            .SetValue("To", pDateFormat.JDateToString(lTS.Dates.Value(lTS.numValues)))
                            .SetValue("Not Used", .GetValue("Count Missing"))
                            .SetValueIfMissing("SpearmanTest", RunSpearmanTest(lTS))
                        End With
                    Next
                    Dim lList As New atcList.atcListForm
                    With lList
                        With .DateFormat
                            .IncludeDays = False
                            .IncludeHours = False
                            .IncludeMinutes = False
                            .IncludeMonths = False
                        End With
                        .Text = "Trend of " & HighOrLowString() & " Annual Time Series and Statistics"
                        .Initialize(lRankedAnnual, pTrendAttributes, False)
                        .SwapRowsColumns = True
                        .Icon = Me.Icon
                    End With
                End If
            Else
                Logger.Msg("Select at least one number of days")
            End If
        Else
            Logger.Msg("Select at least one time series")
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnDoFrequencyGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoFrequencyGrid.Click
        If pBatch Then
            CalculateBatch() 'setting params for batch run
        Else
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Calculate("n-day " & HighOrLowString() & " value", ListToArray(lstRecurrence))

            Dim lFreqForm As New frmDisplayFrequencyGrid(aDataGroup:=pDataGroup, _
                                                         aHigh:=radioHigh.Checked, _
                                                         aNday:=ListToArray(lstNday), _
                                                         aReturns:=ListToArray(lstRecurrence))
            lFreqForm.SWSTATDFlowBatchfrm = Me

            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    'Private Sub btnFrequencyReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFrequencyReport.Click
    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

    '    Dim lSaveDialog As New System.Windows.Forms.SaveFileDialog
    '    With lSaveDialog
    '        .Title = "Save Frequency Report As"
    '        .DefaultExt = ".txt"
    '        .FileName = ReplaceString(Me.Text, " ", "_") & "_report.txt"
    '        If FileExists(IO.Path.GetDirectoryName(.FileName), True, False) Then
    '            .InitialDirectory = IO.Path.GetDirectoryName(.FileName)
    '        End If
    '        If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '            Calculate("n-day " & HighOrLowString() & " value", ListToArray(lstRecurrence))

    '            Dim lFreqForm As New frmDisplayFrequencyGrid(aDataGroup:=pDataGroup, _
    '                                                         aHigh:=radioHigh.Checked, _
    '                                                         aNday:=ListToArray(lstNday), _
    '                                                         aReturns:=ListToArray(lstRecurrence))
    '            lFreqForm.Visible = False

    '            SaveFileString(.FileName, lFreqForm.CreateReport)
    '            OpenFile(.FileName)
    '        End If
    '    End With
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    'End Sub

    Private Sub btnDoFrequencyGraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoFrequencyGraph.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        DoFrequencyGraph()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Public Sub DoFrequencyGraph(Optional ByVal aDataGroup As atcData.atcTimeseriesGroup = Nothing)
        Calculate("n-day " & HighOrLowString() & " value", clsIDFPlugin.ListDefaultArray("Return Period"))
        Dim lGraphPlugin As New atcGraph.atcGraphPlugin
        Dim lGraphForm As atcGraph.atcGraphForm
        'Dim lSeparateGraphs As Boolean = False
        'Select Case pDataGroup.Count
        '    Case 0 : Return
        '    Case 1 : lSeparateGraphs = False
        '    Case Else
        '        lSeparateGraphs = (Logger.MsgCustomCheckbox("Create separate graphs or all on one graph?", _
        '                                                    pDataGroup.Count & " datasets selected", _
        '                                                    "Do not ask again", "BASINS", "SWSTAT", "SeparateFreqGraphs", _
        '                                                    "Separate", "One Graph") = "Separate")
        'End Select

        'Get station list
        Dim lStnList As New Generic.List(Of String)
        For Each lDataSet As atcTimeseries In pDataGroup
            If Not lStnList.Contains(STAID(lDataSet)) Then
                lStnList.Add(STAID(lDataSet))
            End If
        Next
        'Get Nday list
        Dim lNDayList As New Generic.List(Of String)
        For Each lDataSet As atcTimeseries In pDataGroup
            For Each lAtt As atcData.atcDefinedValue In lDataSet.Attributes
                If lAtt.Definition.Name.ToLower.Contains("daytimeseries") Then
                    If Not lNDayList.Contains(lAtt.Definition.Name) Then
                        lNDayList.Add(lAtt.Definition.Name)
                    End If
                End If
            Next
        Next
        If MultipleNDayPlots() And MultipleStationPlots() Then
            For Each lStaId As String In lStnList
                For Each lNDayTimeseriesName As String In lNDayList
                    Dim lDataGroup As New atcData.atcTimeseriesGroup
                    For Each lDataset As atcTimeseries In pDataGroup
                        If STAID(lDataset) = lStaId Then
                            Dim lTs As atcTimeseries = lDataset.Attributes.GetValue(lNDayTimeseriesName)
                            If lTs IsNot Nothing Then
                                lDataGroup.Add(lTs)
                            End If
                        End If
                    Next
                    If lDataGroup.Count > 0 Then
                        lGraphForm = lGraphPlugin.Show(lDataGroup, "Frequency")
                        lGraphForm.Icon = Me.Icon
                    End If
                    lDataGroup.Clear()
                    lDataGroup = Nothing
                Next
            Next

            'For Each lDataSet As atcTimeseries In pDataGroup
            '    lGraphForm = lGraphPlugin.Show(New atcTimeseriesGroup(lDataSet), "Frequency")
            '    lGraphForm.Icon = Me.Icon
            'Next
        ElseIf MultipleNDayPlots() Then
            For Each lNDayTimeseriesName As String In lNDayList
                Dim lDataGroup As New atcData.atcTimeseriesGroup
                For Each lDataset As atcTimeseries In pDataGroup
                    Dim lTs As atcTimeseries = lDataset.Attributes.GetValue(lNDayTimeseriesName)
                    If lTs IsNot Nothing Then
                        lDataGroup.Add(lTs)
                    End If
                Next
                If lDataGroup IsNot Nothing AndAlso lDataGroup.Count > 0 Then
                    lGraphForm = lGraphPlugin.Show(lDataGroup, "Frequency")
                    lGraphForm.Icon = Me.Icon
                End If
                lDataGroup.Clear()
                lDataGroup = Nothing
            Next
        ElseIf MultipleStationPlots() Then
            Dim lDataGroup As atcData.atcTimeseriesGroup = Nothing
            For Each lStaId As String In lStnList
                lDataGroup = pDataGroup.FindData("STAID", lStaId)
                If lDataGroup IsNot Nothing AndAlso lDataGroup.Count > 0 Then
                    lGraphForm = lGraphPlugin.Show(lDataGroup, "Frequency")
                    lGraphForm.Icon = Me.Icon
                End If
                lDataGroup.Clear()
                lDataGroup = Nothing
            Next
        Else
            lGraphForm = lGraphPlugin.Show(pDataGroup, "Frequency")
            lGraphForm.Icon = Me.Icon
        End If

        lNDayList.Clear()
        lNDayList = Nothing
        lStnList.Clear()
        lStnList = Nothing
    End Sub

    Private Sub cboYears_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYears.SelectedIndexChanged
        Select Case cboYears.SelectedIndex
            Case 0 'All
                ShowCustomYears(False)
                txtOmitBeforeYear.Text = ""
                txtOmitAfterYear.Text = ""
            Case 1 'Common
                ShowCustomYears(False)
                If cboYears.Text.EndsWith(pNoDatesInCommon) Then
                    cboYears.SelectedIndex = 0
                Else
                    Dim lCurDate(5) As Integer
                    J2Date(pCommonStart, lCurDate)
                    txtOmitBeforeYear.Text = Format(lCurDate(0), "0000")
                    J2Date(pCommonEnd, lCurDate)
                    txtOmitAfterYear.Text = Format(lCurDate(0), "0000")
                End If
            Case 2 'Custom
                ShowCustomYears(True)
        End Select
    End Sub

    Private Sub btnRecurrenceAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceAdd.Click
        If IsNumeric(txtRecurrenceAdd.Text) Then
            Try
                Dim lIndex As Integer = 0
                Dim lNewValue As Double = CDbl(txtRecurrenceAdd.Text)
                While lIndex < lstRecurrence.Items.Count AndAlso CDbl(lstRecurrence.Items(lIndex)) < lNewValue
                    lIndex += 1
                End While
                lstRecurrence.Items.Insert(lIndex, txtRecurrenceAdd.Text)
                lstRecurrence.SetSelected(lIndex, True)
            Catch ex As Exception
                Logger.Dbg("Exception adding Recurrence '" & txtRecurrenceAdd.Text & "': " & ex.Message)
            End Try
        Else
            Logger.Msg("Type a return period to add in the blank, then press the add button again")
        End If
    End Sub

    Private Sub btnRecurrenceRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceRemove.Click
        Dim lRemoveThese As New ArrayList
        Dim lIndex As Integer
        If lstRecurrence.SelectedIndices.Count > 0 Then
            For lIndex = lstRecurrence.SelectedIndices.Count - 1 To 0 Step -1
                lRemoveThese.Add(lstRecurrence.SelectedIndices.Item(lIndex))
            Next
        Else
            For lIndex = lstRecurrence.Items.Count - 1 To 0 Step -1
                If lstRecurrence.Items(lIndex) = txtRecurrenceAdd.Text Then
                    lRemoveThese.Add(lIndex)
                End If
            Next
        End If

        For Each lIndex In lRemoveThese
            lstRecurrence.Items.RemoveAt(lIndex)
        Next

    End Sub

    Private Sub btnRecurrenceDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceDefault.Click
        LoadListDefaults(lstRecurrence)
    End Sub

    Private Sub btnRecurrenceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceAll.Click
        For index As Integer = 0 To lstRecurrence.Items.Count - 1
            lstRecurrence.SetSelected(index, True)
        Next
    End Sub

    Private Sub btnRecurrenceNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecurrenceNone.Click
        For index As Integer = 0 To lstRecurrence.Items.Count - 1
            lstRecurrence.SetSelected(index, False)
        Next
    End Sub

#Region "DFLOW"

    Private Sub ckbBio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbBio.CheckedChanged
        DFLOWCalcs.fBioDefault = Not ckbBio.Checked

        'rbBio1.Enabled = DFLOWCalcs.fBioDefault
        'rbBio2.Enabled = DFLOWCalcs.fBioDefault
        'rbBio3.Enabled = DFLOWCalcs.fBioDefault

        tbBio1.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio2.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio3.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio4.Enabled = Not DFLOWCalcs.fBioDefault
        'Label1.Enabled = Not DFLOWCalcs.fBioDefault
        'Label2.Enabled = Not DFLOWCalcs.fBioDefault
        'Label3.Enabled = Not DFLOWCalcs.fBioDefault
        'Label4.Enabled = Not DFLOWCalcs.fBioDefault

        DFLOWCalcs.fBioType = 0
        If DFLOWCalcs.fBioDefault Then
            tbBio1.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 0)
            tbBio2.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 1)
            tbBio3.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 2)
            tbBio4.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 3)
        Else
            'For i As Integer = 0 To 3
            '    If DFLOWCalcs.fBioFPArray(3, i) < 0 Then
            '        DFLOWCalcs.fBioFPArray(3, i) = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, i)
            '    End If
            'Next
            'tbBio1.Text = DFLOWCalcs.fBioFPArray(3, 0)
            'tbBio2.Text = DFLOWCalcs.fBioFPArray(3, 1)
            'tbBio3.Text = DFLOWCalcs.fBioFPArray(3, 2)
            'tbBio4.Text = DFLOWCalcs.fBioFPArray(3, 3)
        End If

        If pBatch AndAlso pAttributes IsNot Nothing Then
            If DFLOWCalcs.fBioDefault Then
                Dim lParams() As Integer = Nothing
                If rbBio1.Checked Then
                    lParams = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration.ToString, Nothing)
                ElseIf rbBio2.Checked Then
                    lParams = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration.ToString, Nothing)
                ElseIf rbBio3.Checked Then
                    lParams = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia.ToString, Nothing)
                End If
                If lParams IsNot Nothing Then
                    lParams(0) = DFLOWCalcs.fBioPeriod
                    lParams(1) = DFLOWCalcs.fBioYears
                    lParams(2) = DFLOWCalcs.fBioCluster
                    lParams(3) = DFLOWCalcs.fBioExcursions
                End If
            End If
        End If
    End Sub

    Private Sub ckbBioChronic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbBioChronic.CheckedChanged
        DFLOWCalcs.fBioDefault = Not ckbBioChronic.Checked

        tbBio1Chronic.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio2Chronic.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio3Chronic.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio4Chronic.Enabled = Not DFLOWCalcs.fBioDefault
        DFLOWCalcs.fBioType = 1
        If DFLOWCalcs.fBioDefault Then
            tbBio1Chronic.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 0)
            tbBio2Chronic.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 1)
            tbBio3Chronic.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 2)
            tbBio4Chronic.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 3)
        Else
            'For i As Integer = 0 To 3
            '    If DFLOWCalcs.fBioFPArray(3, i) < 0 Then
            '        DFLOWCalcs.fBioFPArray(3, i) = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, i)
            '    End If
            'Next
            'tbBio1Chronic.Text = DFLOWCalcs.fBioFPArray(3, 0)
            'tbBio2Chronic.Text = DFLOWCalcs.fBioFPArray(3, 1)
            'tbBio3Chronic.Text = DFLOWCalcs.fBioFPArray(3, 2)
            'tbBio4Chronic.Text = DFLOWCalcs.fBioFPArray(3, 3)
        End If

        If pBatch AndAlso pAttributes IsNot Nothing Then
            If DFLOWCalcs.fBioDefault Then
                Dim lParams() As Integer = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration.ToString, Nothing)
                If lParams IsNot Nothing Then
                    lParams(0) = DFLOWCalcs.fBioPeriod
                    lParams(1) = DFLOWCalcs.fBioYears
                    lParams(2) = DFLOWCalcs.fBioCluster
                    lParams(3) = DFLOWCalcs.fBioExcursions
                End If
            End If
        End If
    End Sub

    Private Sub ckbBioAmm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbBioAmm.CheckedChanged
        DFLOWCalcs.fBioDefault = Not ckbBioAmm.Checked

        tbBio1Amm.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio2Amm.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio3Amm.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio4Amm.Enabled = Not DFLOWCalcs.fBioDefault
        DFLOWCalcs.fBioType = 2
        If DFLOWCalcs.fBioDefault Then
            tbBio1Amm.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 0)
            tbBio2Amm.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 1)
            tbBio3Amm.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 2)
            tbBio4Amm.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 3)
        Else
            'For i As Integer = 0 To 3
            '    If DFLOWCalcs.fBioFPArray(3, i) < 0 Then
            '        DFLOWCalcs.fBioFPArray(3, i) = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, i)
            '    End If
            'Next
            'tbBio1Amm.Text = DFLOWCalcs.fBioFPArray(3, 0)
            'tbBio2Amm.Text = DFLOWCalcs.fBioFPArray(3, 1)
            'tbBio3Amm.Text = DFLOWCalcs.fBioFPArray(3, 2)
            'tbBio4Amm.Text = DFLOWCalcs.fBioFPArray(3, 3)
        End If

        If pBatch AndAlso pAttributes IsNot Nothing Then
            If DFLOWCalcs.fBioDefault Then
                Dim lParams() As Integer = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia.ToString, Nothing)
                If lParams IsNot Nothing Then
                    lParams(0) = DFLOWCalcs.fBioPeriod
                    lParams(1) = DFLOWCalcs.fBioYears
                    lParams(2) = DFLOWCalcs.fBioCluster
                    lParams(3) = DFLOWCalcs.fBioExcursions
                End If
            End If
        End If
    End Sub

    Private Sub rbBio1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBio1.CheckedChanged, rbBio3.CheckedChanged, rbBio2.CheckedChanged
        If rbBio1.Checked Then
            DFLOWCalcs.fBioType = 0
        ElseIf rbBio2.Checked Then
            DFLOWCalcs.fBioType = 1
        Else
            DFLOWCalcs.fBioType = 2
        End If
        If pBatch AndAlso pAttributes IsNot Nothing Then
            Dim lParams() As Integer = Nothing
            If rbBio1.Checked Then
                lParams = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration.ToString())
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioSelectedMethod, DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration)
            ElseIf rbBio2.Checked Then
                lParams = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration.ToString())
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioSelectedMethod, DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration)
            ElseIf rbBio3.Checked Then
                lParams = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia.ToString())
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioSelectedMethod, DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia)
            End If
            If lParams IsNot Nothing Then
                tbBio1.Text = lParams(0).ToString()
                tbBio2.Text = lParams(1).ToString()
                tbBio3.Text = lParams(2).ToString()
                tbBio4.Text = lParams(3).ToString()
            End If
        Else
            tbBio1.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 0)
            tbBio2.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 1)
            tbBio3.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 2)
            tbBio4.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 3)
        End If
    End Sub
    ' Boolean flag used to determine when a character other than a number is entered.
    Private nonNumberEntered As Boolean = False

    ' Handle the KeyDown event to determine the type of character entered into the control.
    Private Sub textBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
         Handles tbBio1.KeyDown, tbBio2.KeyDown, tbBio3.KeyDown, tbBio4.KeyDown, tbNonBio1.KeyDown, tbNonBio2.KeyDown, tbNonBio4.KeyDown
        ' Initialize the flag to false.
        nonNumberEntered = False

        ' Determine whether the keystroke is a number from the top of the keyboard.
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            ' Determine whether the keystroke is a number from the keypad.
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                ' Determine whether the keystroke is a backspace.
                If e.KeyCode <> Keys.Back Then
                    ' A non-numerical keystroke was pressed. 
                    ' Set the flag to true and evaluate in KeyPress event.
                    nonNumberEntered = True
                End If
            End If
        End If
    End Sub 'textBox1_KeyDown
    Private Sub textBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbNonBio3.KeyDown
        ' Initialize the flag to false.
        nonNumberEntered = False

        ' Determine whether the keystroke is a number from the top of the keyboard.
        If e.KeyCode = Keys.OemPeriod And InStr(sender.text, ".") = 1 Then
            If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
                ' Determine whether the keystroke is a number from the keypad.
                If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                    ' Determine whether the keystroke is a backspace.
                    If e.KeyCode <> Keys.Back Then
                        ' A non-numerical keystroke was pressed. 
                        ' Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = True
                    End If
                End If
            End If
        End If
    End Sub

    ' This event occurs after the KeyDown event and can be used 
    ' to prevent characters from entering the control.
    Private Sub textBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles tbBio1.KeyPress, tbBio2.KeyPress, tbBio3.KeyPress, tbBio4.KeyPress, tbNonBio1.KeyPress, tbNonBio2.KeyPress, tbNonBio4.KeyPress, tbNonBio3.KeyPress

        ' Check for the flag being set in the KeyDown event.
        If nonNumberEntered = True Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
        End If
    End Sub 'textBox1_KeyPress

    Private Sub rbNonBio1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNonBio1.CheckedChanged, rbNonBio3.CheckedChanged, rbNonBio2.CheckedChanged

        If rbNonBio1.Checked Then
            DFLOWCalcs.fNonBioType = 0
        ElseIf rbNonBio2.Checked Then
            DFLOWCalcs.fNonBioType = 1
        Else
            DFLOWCalcs.fNonBioType = 2
        End If
        Label7.Enabled = rbNonBio1.Checked
        Label8.Enabled = rbNonBio1.Checked
        tbNonBio1.Enabled = rbNonBio1.Checked
        tbNonBio2.Enabled = rbNonBio1.Checked

        Label5.Enabled = rbNonBio2.Checked
        tbNonBio3.Enabled = rbNonBio2.Checked

        Label6.Enabled = rbNonBio3.Checked
        tbNonBio4.Enabled = rbNonBio3.Checked

        If pBatch AndAlso pAttributes IsNot Nothing Then
            If rbNonBio1.Checked Then
                pAttributes.SetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Hydrological)
                'Dim lParams() As Integer = pAttributes.GetValue(InputNames.EDFlowType.Hydrological.ToString(), Nothing)
                'If lParams IsNot Nothing AndAlso lParams.Length = 2 Then
                '    tbNonBio1.Text = lParams(0).ToString()
                '    tbNonBio2.Text = lParams(1).ToString()
                'End If
            ElseIf rbNonBio2.Checked Then
                pAttributes.SetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value)
                'Dim lflowval As Double = pAttributes.GetValue(InputNames.EDFlowType.Explicit_Flow_Value.ToString(), 1.0)
                'tbNonBio3.Text = lflowval.ToString()
            ElseIf rbNonBio3.Checked Then
                pAttributes.SetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile)
                'Dim lflowPct As Double = pAttributes.GetValue(InputNames.EDFlowType.Flow_Percentile.ToString(), 0.1)
                'tbNonBio4.Text = lflowPct.ToString()
            End If
        Else
            If rbNonBio1.Checked Then
                If pAttributes IsNot Nothing Then pAttributes.SetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Hydrological)
                Dim lAvgPeriod As Integer
                Dim lReturnPeriod As Integer
                If pAttributes IsNot Nothing AndAlso pAttributes.ContainsAttribute(DFLOWAnalysis.InputNames.EDFlowType.Hydrological.ToString()) Then
                    Dim lParams() As Integer = pAttributes.GetValue(DFLOWAnalysis.InputNames.EDFlowType.Hydrological.ToString(), Nothing)
                    If lParams IsNot Nothing AndAlso lParams.Length = 2 Then
                        lAvgPeriod = lParams(0)
                        lReturnPeriod = lParams(1)
                    Else
                        lAvgPeriod = DFLOWAnalysis.DFLOWCalcs.fAveragingPeriod
                        lReturnPeriod = DFLOWAnalysis.DFLOWCalcs.fReturnPeriod
                    End If
                Else
                    lAvgPeriod = DFLOWAnalysis.DFLOWCalcs.fAveragingPeriod
                    lReturnPeriod = DFLOWAnalysis.DFLOWCalcs.fReturnPeriod
                End If
                tbNonBio1.Text = lAvgPeriod.ToString()
                tbNonBio2.Text = lReturnPeriod.ToString()
            ElseIf rbNonBio2.Checked Then
                If pAttributes IsNot Nothing Then pAttributes.SetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value)
                Dim lflowval As Double
                If pAttributes IsNot Nothing AndAlso pAttributes.ContainsAttribute(DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value.ToString()) Then
                    lflowval = pAttributes.GetValue(DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value.ToString())
                Else
                    lflowval = DFLOWAnalysis.DFLOWCalcs.fExplicitFlow
                End If
                tbNonBio3.Text = lflowval.ToString()
            ElseIf rbNonBio3.Checked Then
                If pAttributes IsNot Nothing Then pAttributes.SetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile)
                Dim lflowPct As Double
                If pAttributes IsNot Nothing AndAlso pAttributes.ContainsAttribute(DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile.ToString()) Then
                    lflowPct = pAttributes.GetValue(DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile.ToString())
                Else
                    lflowPct = DFLOWAnalysis.DFLOWCalcs.fPercentile
                End If
                tbNonBio4.Text = lflowPct.ToString()
            End If
        End If
    End Sub

    Private Sub tbNonBio1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNonBio1.TextChanged
        If IsNumeric(tbNonBio1.Text) AndAlso Integer.TryParse(tbNonBio1.Text, DFLOWCalcs.fAveragingPeriod) Then
            Dim lParams() As Integer = GetSavedParams(False)
            If lParams IsNot Nothing AndAlso lParams.Length = 2 Then
                lParams(0) = DFLOWCalcs.fAveragingPeriod
            End If
        End If
    End Sub
    Private Sub tbNonBio2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNonBio2.TextChanged
        If IsNumeric(tbNonBio2.Text) AndAlso Integer.TryParse(tbNonBio2.Text, DFLOWCalcs.fReturnPeriod) Then
            Dim lParams() As Integer = GetSavedParams(False)
            If lParams IsNot Nothing AndAlso lParams.Length = 2 Then
                lParams(1) = DFLOWCalcs.fReturnPeriod
            End If
        End If
    End Sub
    Private Sub tbNonBio3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNonBio3.TextChanged
        If IsNumeric(tbNonBio3.Text) AndAlso Double.TryParse(tbNonBio3.Text, DFLOWCalcs.fExplicitFlow) AndAlso DFLOWCalcs.fExplicitFlow > 0 Then
            Dim lNewValue As Double = GetSavedParams(False, DFLOWCalcs.fExplicitFlow)
        End If
    End Sub
    Private Sub tbNonBio4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNonBio4.TextChanged
        If IsNumeric(tbNonBio4.Text) AndAlso Double.TryParse(tbNonBio4.Text, DFLOWCalcs.fPercentile) AndAlso DFLOWCalcs.fPercentile > 0 Then
            Dim lNewValue As Double = GetSavedParams(False, DFLOWCalcs.fPercentile)
        End If
    End Sub

    Private Sub tbBio1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBio1.TextChanged
        If IsNumeric(tbBio1.Text) AndAlso Integer.TryParse(tbBio1.Text, DFLOWCalcs.fBioFPArray(3, 0)) Then
            'fBioFPArray(3, 0) = tbBio1.Text
            Dim lParams() As Integer = GetSavedParams()
            If lParams IsNot Nothing AndAlso lParams.Length = 4 Then
                lParams(DFLOWAnalysis.InputNames.EBioDFlowParamIndex.P0FlowAveragingPeriodDays) = Integer.Parse(tbBio1.Text)
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioUseDefault, False)
            End If
        End If
    End Sub
    Private Sub tbBio2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBio2.TextChanged
        If IsNumeric(tbBio2.Text) AndAlso Integer.TryParse(tbBio2.Text, DFLOWCalcs.fBioFPArray(3, 1)) Then
            'fBioFPArray(3, 1) = tbBio2.Text
            Dim lParams() As Integer = GetSavedParams()
            If lParams IsNot Nothing AndAlso lParams.Length = 4 Then
                lParams(DFLOWAnalysis.InputNames.EBioDFlowParamIndex.P1AverageYearsBetweenExcursions) = Integer.Parse(tbBio2.Text)
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioUseDefault, False)
            End If
        End If
    End Sub
    Private Sub tbBio3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBio3.TextChanged
        If IsNumeric(tbBio3.Text) AndAlso Integer.TryParse(tbBio3.Text, DFLOWCalcs.fBioFPArray(3, 2)) Then
            'fBioFPArray(3, 2) = tbBio3.Text
            Dim lParams() As Integer = GetSavedParams()
            If lParams IsNot Nothing AndAlso lParams.Length = 4 Then
                lParams(DFLOWAnalysis.InputNames.EBioDFlowParamIndex.P2ExcursionClusterPeriodDays) = Integer.Parse(tbBio3.Text)
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioUseDefault, False)
            End If
        End If
    End Sub
    Private Sub tbBio4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBio4.TextChanged
        If IsNumeric(tbBio4.Text) AndAlso Integer.TryParse(tbBio4.Text, DFLOWCalcs.fBioFPArray(3, 3)) Then
            'fBioFPArray(3, 3) = tbBio4.Text
            Dim lParams() As Integer = GetSavedParams()
            If lParams IsNot Nothing AndAlso lParams.Length = 4 Then
                lParams(DFLOWAnalysis.InputNames.EBioDFlowParamIndex.P3AverageExcursionsPerCluster) = Integer.Parse(tbBio4.Text)
                pAttributes.SetValue(DFLOWAnalysis.InputNames.BioUseDefault, False)
            End If
        End If
    End Sub

    Private Function GetSavedParams(Optional ByVal aBio As Boolean = True, Optional ByVal aValue As Double = -99) As Object
        If pAttributes IsNot Nothing Then
            If aBio Then
                If rbBio1.Checked Then
                    Return pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration.ToString(), Nothing)
                ElseIf rbBio2.Checked Then
                    Return pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration.ToString(), Nothing)
                ElseIf rbBio3.Checked Then
                    Return pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia.ToString(), Nothing)
                End If
            Else
                If rbNonBio1.Checked Then
                    Return pAttributes.GetValue(DFLOWAnalysis.InputNames.EDFlowType.Hydrological.ToString(), Nothing)
                ElseIf rbNonBio2.Checked Then
                    If aValue > 0 Then
                        pAttributes.SetValue(DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value.ToString(), aValue)
                    End If
                    Return pAttributes.GetValue(DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value.ToString(), Nothing)
                ElseIf rbNonBio3.Checked Then
                    If aValue > 0 Then
                        pAttributes.SetValue(DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile.ToString(), aValue)
                    End If
                    Return pAttributes.GetValue(DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile.ToString(), Nothing)
                End If
            End If
        Else
            Return Nothing
        End If
        Return Nothing
    End Function

    Friend Sub DFLOWCalcs_Initialize(Optional ByVal aChoice As atcDataAttributes = Nothing)
        If aChoice Is Nothing Then
            ' This sets the initial values for DFLOW calculations - CMC, 7Q10
            DFLOWCalcs.fBioDefault = True
            DFLOWCalcs.fBioType = 0
            DFLOWCalcs.fBioPeriod = 1
            DFLOWCalcs.fBioYears = 3
            DFLOWCalcs.fBioCluster = 120
            DFLOWCalcs.fBioExcursions = 5

            DFLOWCalcs.fNonBioType = 0
            DFLOWCalcs.fAveragingPeriod = 7
            DFLOWCalcs.fReturnPeriod = 10
            DFLOWCalcs.fExplicitFlow = 1.0
            DFLOWCalcs.fPercentile = 0.1

            aChoice = New atcDataAttributes()
            With aChoice
                .SetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration.ToString(), DFLOWCalcs.GetBioDefaultParams(DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration))
                .SetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration.ToString(), DFLOWCalcs.GetBioDefaultParams(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration))
                .SetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia.ToString(), DFLOWCalcs.GetBioDefaultParams(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia))
                .SetValue(DFLOWAnalysis.InputNames.EDFlowType.Hydrological.ToString(), New Integer() {7, 10})
                .SetValue(DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value.ToString(), 1.0)
                .SetValue(DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile.ToString(), 0.1)
            End With
        Else
            With aChoice
                DFLOWCalcs.fBioDefault = .GetValue(DFLOWAnalysis.InputNames.BioUseDefault, True)
                DFLOWCalcs.fBioType = .GetValue(DFLOWAnalysis.InputNames.BioSelectedMethod, DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration)
                Dim lBio4Params() As Integer '= DFLOWCalcs.GetBioDefaultParams(DFLOWCalcs.fBioType)
                If DFLOWCalcs.fBioDefault Then
                    lBio4Params = DFLOWCalcs.GetBioDefaultParams(DFLOWCalcs.fBioType)
                Else
                    Select Case DFLOWCalcs.fBioType
                        Case DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration
                            lBio4Params = .GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration.ToString(), DFLOWCalcs.GetBioDefaultParams(DFLOWCalcs.fBioType))
                        Case DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration
                            lBio4Params = .GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration.ToString(), DFLOWCalcs.GetBioDefaultParams(DFLOWCalcs.fBioType))
                        Case DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia
                            lBio4Params = .GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia.ToString(), DFLOWCalcs.GetBioDefaultParams(DFLOWCalcs.fBioType))
                    End Select
                End If
                DFLOWCalcs.fBioPeriod = lBio4Params(0)
                DFLOWCalcs.fBioYears = lBio4Params(1)
                DFLOWCalcs.fBioCluster = lBio4Params(2)
                DFLOWCalcs.fBioExcursions = lBio4Params(3)

                DFLOWCalcs.fNonBioType = .GetValue(DFLOWAnalysis.InputNames.NBioSelectedMethod, DFLOWAnalysis.InputNames.EDFlowType.Hydrological)
                Dim lHydro2Params() As Integer = .GetValue(DFLOWAnalysis.InputNames.EDFlowType.Hydrological.ToString(), New Integer() {7, 10})
                DFLOWCalcs.fAveragingPeriod = lHydro2Params(0)
                DFLOWCalcs.fReturnPeriod = lHydro2Params(1)

                DFLOWCalcs.fExplicitFlow = .GetValue(DFLOWAnalysis.InputNames.EDFlowType.Explicit_Flow_Value.ToString(), 1.0)
                DFLOWCalcs.fPercentile = .GetValue(DFLOWAnalysis.InputNames.EDFlowType.Flow_Percentile.ToString(), 0.1)
            End With
        End If
    End Sub

    Private Sub PopulateDFLOW(ByVal aTimeseriesGroup As atcTimeseriesGroup)
        ' This populates the DFLOW input form according to the DFLOW calculation values
        ckbBio.Checked = DFLOWCalcs.fBioDefault
        rbBio1.Enabled = DFLOWCalcs.fBioDefault
        rbBio2.Enabled = DFLOWCalcs.fBioDefault
        rbBio3.Enabled = DFLOWCalcs.fBioDefault

        Select Case DFLOWCalcs.fBioType
            Case 0
                rbBio1.Checked = True
            Case 1
                rbBio2.Checked = True
            Case 2
                rbBio3.Checked = True
        End Select

        tbBio1.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio2.Enabled = Not DFLOWCalcs.fBioDefault
        tbBio3.Enabled = Not DFLOWCalcs.fBioDefault

        Dim lBioIdx As Integer
        If DFLOWCalcs.fBioDefault Then
            lBioIdx = DFLOWCalcs.fBioType
        Else
            lBioIdx = 3
        End If

        RemoveHandler tbBio1.TextChanged, AddressOf tbBio1_TextChanged
        RemoveHandler tbBio2.TextChanged, AddressOf tbBio2_TextChanged
        RemoveHandler tbBio3.TextChanged, AddressOf tbBio3_TextChanged
        RemoveHandler tbBio4.TextChanged, AddressOf tbBio4_TextChanged

        RemoveHandler tbNonBio1.TextChanged, AddressOf tbNonBio1_TextChanged
        RemoveHandler tbNonBio2.TextChanged, AddressOf tbNonBio2_TextChanged
        RemoveHandler tbNonBio3.TextChanged, AddressOf tbNonBio3_TextChanged
        RemoveHandler tbNonBio4.TextChanged, AddressOf tbNonBio4_TextChanged


        If DFLOWCalcs.fBioFPArray(lBioIdx, 0) < 0 Then
            If pBatch Then
                tbBio1.Text = DFLOWCalcs.fBioPeriod.ToString()
            Else
                tbBio1.Text = ""
            End If
        Else
            If pBatch Then
                tbBio1.Text = DFLOWCalcs.fBioPeriod.ToString()
            Else
                tbBio1.Text = DFLOWCalcs.fBioFPArray(lBioIdx, 0)
            End If
        End If

        If DFLOWCalcs.fBioFPArray(lBioIdx, 1) < 0 Then
            If pBatch Then
                tbBio2.Text = DFLOWCalcs.fBioYears.ToString()
            Else
                tbBio2.Text = ""
            End If
        Else
            If pBatch Then
                tbBio2.Text = DFLOWCalcs.fBioYears.ToString()
            Else
                tbBio2.Text = DFLOWCalcs.fBioFPArray(lBioIdx, 1)
            End If
        End If

        If DFLOWCalcs.fBioFPArray(lBioIdx, 2) < 0 Then
            If pBatch Then
                tbBio3.Text = DFLOWCalcs.fBioExcursions.ToString()
            Else
                tbBio3.Text = ""
            End If
        Else
            If pBatch Then
                tbBio3.Text = DFLOWCalcs.fBioExcursions.ToString()
            Else
                tbBio3.Text = DFLOWCalcs.fBioFPArray(lBioIdx, 2)
            End If
        End If

        If DFLOWCalcs.fBioFPArray(lBioIdx, 3) < 0 Then
            If pBatch Then
                tbBio4.Text = DFLOWCalcs.fBioCluster.ToString()
            Else
                tbBio4.Text = ""
            End If
        Else
            If pBatch Then
                tbBio4.Text = DFLOWCalcs.fBioCluster.ToString()
            Else
                tbBio4.Text = DFLOWCalcs.fBioFPArray(lBioIdx, 3)
            End If
        End If

        Select Case DFLOWCalcs.fNonBioType
            Case 0
                rbNonBio1.Checked = True
            Case 1
                rbNonBio2.Checked = True
            Case 2
                rbNonBio3.Checked = True
        End Select

        tbNonBio1.Text = DFLOWCalcs.fAveragingPeriod
        tbNonBio2.Text = DFLOWCalcs.fReturnPeriod
        tbNonBio3.Text = DFLOWCalcs.fExplicitFlow
        tbNonBio4.Text = DFLOWCalcs.fPercentile

        AddHandler tbBio1.TextChanged, AddressOf tbBio1_TextChanged
        AddHandler tbBio2.TextChanged, AddressOf tbBio2_TextChanged
        AddHandler tbBio3.TextChanged, AddressOf tbBio3_TextChanged
        AddHandler tbBio4.TextChanged, AddressOf tbBio4_TextChanged

        AddHandler tbNonBio1.TextChanged, AddressOf tbNonBio1_TextChanged
        AddHandler tbNonBio2.TextChanged, AddressOf tbNonBio2_TextChanged
        AddHandler tbNonBio3.TextChanged, AddressOf tbNonBio3_TextChanged
        AddHandler tbNonBio4.TextChanged, AddressOf tbNonBio4_TextChanged

        'clbDataSets.Items.Clear()

        Dim lDateFormat As atcDateFormat
        lDateFormat = New atcDateFormat
        With lDateFormat
            .IncludeHours = False
            .IncludeMinutes = False
            .IncludeSeconds = False
        End With

        If aTimeseriesGroup IsNot Nothing AndAlso aTimeseriesGroup.Count > 0 Then
            'Dim lDataSet As atcDataSet
            'For Each lDataSet In aTimeseriesGroup
            '    Dim lString As String
            '    lString = lDataSet.Attributes.GetFormattedValue("Location") & " (" & _
            '              lDateFormat.JDateToString(lDataSet.Attributes.GetValue("start date")) & " - " & _
            '              lDateFormat.JDateToString(lDataSet.Attributes.GetValue("end date")) & ")"

            '    clbDataSets.Items.Add(lString, True)
            'Next
        End If
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        DFLOWCalcs.fBioPeriod = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 0)
        DFLOWCalcs.fBioYears = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 1)
        DFLOWCalcs.fBioCluster = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 2)
        DFLOWCalcs.fBioExcursions = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 3)
        Dim lfrmResult As New DFLOWAnalysis.frmDFLOWResults(pDataGroup, , True)
    End Sub
#End Region '"DFLOW"

    Private Sub chkBio1Acute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBio1Acute.CheckedChanged
        If chkBio1Acute.Checked Then
            DFLOWCalcs.fBioType = 0
        Else
            tbBio1.Text = ""
            tbBio2.Text = ""
            tbBio3.Text = ""
            tbBio4.Text = ""
            Exit Sub
        End If
        If pBatch AndAlso pAttributes IsNot Nothing Then
            Dim lParams() As Integer = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration.ToString())
            pAttributes.SetValue(DFLOWAnalysis.InputNames.BioSelectedMethod, DFLOWAnalysis.InputNames.EBioDFlowType.Acute_maximum_concentration)
            If lParams IsNot Nothing Then
                tbBio1.Text = lParams(0).ToString()
                tbBio2.Text = lParams(1).ToString()
                tbBio3.Text = lParams(2).ToString()
                tbBio4.Text = lParams(3).ToString()
            End If
        Else
            tbBio1.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 0)
            tbBio2.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 1)
            tbBio3.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 2)
            tbBio4.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 3)
        End If
    End Sub

    Private Sub chkBio2Chronic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBio2Chronic.CheckedChanged
        If chkBio2Chronic.Checked Then
            DFLOWCalcs.fBioType = 1
        Else
            tbBio1Chronic.Text = ""
            tbBio2Chronic.Text = ""
            tbBio3Chronic.Text = ""
            tbBio4Chronic.Text = ""
            Exit Sub
        End If
        If pBatch AndAlso pAttributes IsNot Nothing Then
            Dim lParams() As Integer = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration.ToString())
            pAttributes.SetValue(DFLOWAnalysis.InputNames.BioSelectedMethod, DFLOWAnalysis.InputNames.EBioDFlowType.Chronic_continuous_concentration)
            If lParams IsNot Nothing Then
                tbBio1Chronic.Text = lParams(0).ToString()
                tbBio2Chronic.Text = lParams(1).ToString()
                tbBio3Chronic.Text = lParams(2).ToString()
                tbBio4Chronic.Text = lParams(3).ToString()
            End If
        Else
            tbBio1Chronic.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 0)
            tbBio2Chronic.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 1)
            tbBio3Chronic.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 2)
            tbBio4Chronic.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 3)
        End If
    End Sub

    Private Sub chkBio3Ammonia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBio3Ammonia.CheckedChanged
        If chkBio3Ammonia.Checked Then
            DFLOWCalcs.fBioType = 2
        Else
            tbBio1Amm.Text = ""
            tbBio2Amm.Text = ""
            tbBio3Amm.Text = ""
            tbBio4Amm.Text = ""
            Exit Sub
        End If
        If pBatch AndAlso pAttributes IsNot Nothing Then
            Dim lParams() As Integer = pAttributes.GetValue(DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia.ToString())
            pAttributes.SetValue(DFLOWAnalysis.InputNames.BioSelectedMethod, DFLOWAnalysis.InputNames.EBioDFlowType.Ammonia)
            If lParams IsNot Nothing Then
                tbBio1Amm.Text = lParams(0).ToString()
                tbBio2Amm.Text = lParams(1).ToString()
                tbBio3Amm.Text = lParams(2).ToString()
                tbBio4Amm.Text = lParams(3).ToString()
            End If
        Else
            tbBio1Amm.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 0)
            tbBio2Amm.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 1)
            tbBio3Amm.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 2)
            tbBio4Amm.Text = DFLOWCalcs.fBioFPArray(DFLOWCalcs.fBioType, 3)
        End If
    End Sub

    Private Sub chkNonBioAcute_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNonBioAcute.CheckedChanged
        If chkNonBioAcute.Checked Then
            tbNonBio1.Text = "1"
            tbNonBio2.Text = "10"
        End If
    End Sub

    Private Sub chkNonBioChronic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNonBioChronic.CheckedChanged
        If chkNonBioAcute.Checked Then
            tbNonBio1.Text = "7"
            tbNonBio2.Text = "10"
        End If
    End Sub
End Class

