Imports atcUtility
Imports atcMwGisUtility
Imports MapWinUtility
Imports atcData
Imports System.Drawing
Imports System
Imports atcWASP

Public Class frmWASPSetup
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
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
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdExisting As System.Windows.Forms.Button
    Friend WithEvents cmdHelp As System.Windows.Forms.Button
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cboMet As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboStreams As System.Windows.Forms.ComboBox
    Friend WithEvents tbxName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMetWDMName As System.Windows.Forms.TextBox
    Friend WithEvents cmdSelectWDM As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ofdMetWDM As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents atxEDay As atcControls.atcText
    Friend WithEvents atxSDay As atcControls.atcText
    Friend WithEvents atxSYear As atcControls.atcText
    Friend WithEvents atxEMonth As atcControls.atcText
    Friend WithEvents atxSMonth As atcControls.atcText
    Friend WithEvents atxEYear As atcControls.atcText
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents AtcConnectFields As atcControls.atcConnectFields
    Friend WithEvents AtcGridFlow As atcControls.atcGrid
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents AtcGridSegmentation As atcControls.atcGrid
    Friend WithEvents AtcGridMet As atcControls.atcGrid
    Friend WithEvents AtcGridLoad As atcControls.atcGrid
    Friend WithEvents ofdExisting As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWASPSetup))
        Me.cmdOK = New System.Windows.Forms.Button
        Me.cmdExisting = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdHelp = New System.Windows.Forms.Button
        Me.cmdAbout = New System.Windows.Forms.Button
        Me.ofdExisting = New System.Windows.Forms.OpenFileDialog
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblEnd = New System.Windows.Forms.Label
        Me.lblStart = New System.Windows.Forms.Label
        Me.lblDay = New System.Windows.Forms.Label
        Me.lblMonth = New System.Windows.Forms.Label
        Me.lblYear = New System.Windows.Forms.Label
        Me.atxEDay = New atcControls.atcText
        Me.atxSDay = New atcControls.atcText
        Me.atxSYear = New atcControls.atcText
        Me.atxEMonth = New atcControls.atcText
        Me.atxSMonth = New atcControls.atcText
        Me.atxEYear = New atcControls.atcText
        Me.cboMet = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboStreams = New System.Windows.Forms.ComboBox
        Me.tbxName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.AtcConnectFields = New atcControls.atcConnectFields
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.cmdGenerate = New System.Windows.Forms.Button
        Me.AtcGridSegmentation = New atcControls.atcGrid
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.AtcGridFlow = New atcControls.atcGrid
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.AtcGridLoad = New atcControls.atcGrid
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.AtcGridMet = New atcControls.atcGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtMetWDMName = New System.Windows.Forms.TextBox
        Me.cmdSelectWDM = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.ofdMetWDM = New System.Windows.Forms.OpenFileDialog
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Location = New System.Drawing.Point(16, 523)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(72, 32)
        Me.cmdOK.TabIndex = 2
        Me.cmdOK.Text = "OK"
        '
        'cmdExisting
        '
        Me.cmdExisting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdExisting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExisting.Location = New System.Drawing.Point(96, 523)
        Me.cmdExisting.Name = "cmdExisting"
        Me.cmdExisting.Size = New System.Drawing.Size(120, 32)
        Me.cmdExisting.TabIndex = 4
        Me.cmdExisting.Text = "Open Existing"
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(224, 523)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(88, 32)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdHelp
        '
        Me.cmdHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.Location = New System.Drawing.Point(467, 523)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(79, 32)
        Me.cmdHelp.TabIndex = 6
        Me.cmdHelp.Text = "Help"
        '
        'cmdAbout
        '
        Me.cmdAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.Location = New System.Drawing.Point(555, 523)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(87, 32)
        Me.cmdAbout.TabIndex = 7
        Me.cmdAbout.Text = "About"
        '
        'ofdExisting
        '
        Me.ofdExisting.DefaultExt = "inp"
        Me.ofdExisting.Filter = "WASP INP files (*.inp)|*.inp"
        Me.ofdExisting.InitialDirectory = "/BASINS/modelout/"
        Me.ofdExisting.Title = "Select WASP inp file"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(60, 21)
        Me.TabControl1.Location = New System.Drawing.Point(18, 17)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(622, 427)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.cboMet)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cboStreams)
        Me.TabPage1.Controls.Add(Me.tbxName)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(614, 398)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lblEnd)
        Me.GroupBox3.Controls.Add(Me.lblStart)
        Me.GroupBox3.Controls.Add(Me.lblDay)
        Me.GroupBox3.Controls.Add(Me.lblMonth)
        Me.GroupBox3.Controls.Add(Me.lblYear)
        Me.GroupBox3.Controls.Add(Me.atxEDay)
        Me.GroupBox3.Controls.Add(Me.atxSDay)
        Me.GroupBox3.Controls.Add(Me.atxSYear)
        Me.GroupBox3.Controls.Add(Me.atxEMonth)
        Me.GroupBox3.Controls.Add(Me.atxSMonth)
        Me.GroupBox3.Controls.Add(Me.atxEYear)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(587, 111)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Simulation Dates"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(105, 67)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(33, 17)
        Me.lblEnd.TabIndex = 37
        Me.lblEnd.Text = "End"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(100, 37)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(38, 17)
        Me.lblStart.TabIndex = 36
        Me.lblStart.Text = "Start"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(291, 16)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(33, 17)
        Me.lblDay.TabIndex = 35
        Me.lblDay.Text = "Day"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(232, 16)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(47, 17)
        Me.lblMonth.TabIndex = 34
        Me.lblMonth.Text = "Month"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(150, 16)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(38, 17)
        Me.lblYear.TabIndex = 33
        Me.lblYear.Text = "Year"
        '
        'atxEDay
        '
        Me.atxEDay.Alignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.atxEDay.DataType = atcControls.atcText.ATCoDataType.ATCoInt
        Me.atxEDay.DefaultValue = ""
        Me.atxEDay.HardMax = 31
        Me.atxEDay.HardMin = 1
        Me.atxEDay.InsideLimitsBackground = System.Drawing.Color.White
        Me.atxEDay.Location = New System.Drawing.Point(294, 67)
        Me.atxEDay.MaxWidth = 20
        Me.atxEDay.Name = "atxEDay"
        Me.atxEDay.NumericFormat = "0"
        Me.atxEDay.OutsideHardLimitBackground = System.Drawing.Color.Coral
        Me.atxEDay.OutsideSoftLimitBackground = System.Drawing.Color.Yellow
        Me.atxEDay.SelLength = 2
        Me.atxEDay.SelStart = 0
        Me.atxEDay.Size = New System.Drawing.Size(53, 24)
        Me.atxEDay.SoftMax = -999
        Me.atxEDay.SoftMin = -999
        Me.atxEDay.TabIndex = 32
        Me.atxEDay.ValueDouble = 31
        Me.atxEDay.ValueInteger = 31
        '
        'atxSDay
        '
        Me.atxSDay.Alignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.atxSDay.DataType = atcControls.atcText.ATCoDataType.ATCoInt
        Me.atxSDay.DefaultValue = ""
        Me.atxSDay.HardMax = 31
        Me.atxSDay.HardMin = 1
        Me.atxSDay.InsideLimitsBackground = System.Drawing.Color.White
        Me.atxSDay.Location = New System.Drawing.Point(294, 37)
        Me.atxSDay.MaxWidth = 20
        Me.atxSDay.Name = "atxSDay"
        Me.atxSDay.NumericFormat = "0"
        Me.atxSDay.OutsideHardLimitBackground = System.Drawing.Color.Coral
        Me.atxSDay.OutsideSoftLimitBackground = System.Drawing.Color.Yellow
        Me.atxSDay.SelLength = 1
        Me.atxSDay.SelStart = 0
        Me.atxSDay.Size = New System.Drawing.Size(53, 24)
        Me.atxSDay.SoftMax = -999
        Me.atxSDay.SoftMin = -999
        Me.atxSDay.TabIndex = 31
        Me.atxSDay.ValueDouble = 1
        Me.atxSDay.ValueInteger = 1
        '
        'atxSYear
        '
        Me.atxSYear.Alignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.atxSYear.DataType = atcControls.atcText.ATCoDataType.ATCoInt
        Me.atxSYear.DefaultValue = ""
        Me.atxSYear.HardMax = 9999
        Me.atxSYear.HardMin = 0
        Me.atxSYear.InsideLimitsBackground = System.Drawing.Color.White
        Me.atxSYear.Location = New System.Drawing.Point(153, 37)
        Me.atxSYear.MaxWidth = 20
        Me.atxSYear.Name = "atxSYear"
        Me.atxSYear.NumericFormat = "0"
        Me.atxSYear.OutsideHardLimitBackground = System.Drawing.Color.Coral
        Me.atxSYear.OutsideSoftLimitBackground = System.Drawing.Color.Yellow
        Me.atxSYear.SelLength = 4
        Me.atxSYear.SelStart = 0
        Me.atxSYear.Size = New System.Drawing.Size(76, 24)
        Me.atxSYear.SoftMax = -999
        Me.atxSYear.SoftMin = -999
        Me.atxSYear.TabIndex = 30
        Me.atxSYear.ValueDouble = 2000
        Me.atxSYear.ValueInteger = 2000
        '
        'atxEMonth
        '
        Me.atxEMonth.Alignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.atxEMonth.DataType = atcControls.atcText.ATCoDataType.ATCoInt
        Me.atxEMonth.DefaultValue = ""
        Me.atxEMonth.HardMax = 12
        Me.atxEMonth.HardMin = 1
        Me.atxEMonth.InsideLimitsBackground = System.Drawing.Color.White
        Me.atxEMonth.Location = New System.Drawing.Point(235, 67)
        Me.atxEMonth.MaxWidth = 20
        Me.atxEMonth.Name = "atxEMonth"
        Me.atxEMonth.NumericFormat = "0"
        Me.atxEMonth.OutsideHardLimitBackground = System.Drawing.Color.Coral
        Me.atxEMonth.OutsideSoftLimitBackground = System.Drawing.Color.Yellow
        Me.atxEMonth.SelLength = 2
        Me.atxEMonth.SelStart = 0
        Me.atxEMonth.Size = New System.Drawing.Size(53, 24)
        Me.atxEMonth.SoftMax = -999
        Me.atxEMonth.SoftMin = -999
        Me.atxEMonth.TabIndex = 29
        Me.atxEMonth.ValueDouble = 12
        Me.atxEMonth.ValueInteger = 12
        '
        'atxSMonth
        '
        Me.atxSMonth.Alignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.atxSMonth.DataType = atcControls.atcText.ATCoDataType.ATCoInt
        Me.atxSMonth.DefaultValue = ""
        Me.atxSMonth.HardMax = 12
        Me.atxSMonth.HardMin = 1
        Me.atxSMonth.InsideLimitsBackground = System.Drawing.Color.White
        Me.atxSMonth.Location = New System.Drawing.Point(235, 37)
        Me.atxSMonth.MaxWidth = 20
        Me.atxSMonth.Name = "atxSMonth"
        Me.atxSMonth.NumericFormat = "0"
        Me.atxSMonth.OutsideHardLimitBackground = System.Drawing.Color.Coral
        Me.atxSMonth.OutsideSoftLimitBackground = System.Drawing.Color.Yellow
        Me.atxSMonth.SelLength = 1
        Me.atxSMonth.SelStart = 0
        Me.atxSMonth.Size = New System.Drawing.Size(53, 24)
        Me.atxSMonth.SoftMax = -999
        Me.atxSMonth.SoftMin = -999
        Me.atxSMonth.TabIndex = 28
        Me.atxSMonth.ValueDouble = 1
        Me.atxSMonth.ValueInteger = 1
        '
        'atxEYear
        '
        Me.atxEYear.Alignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.atxEYear.DataType = atcControls.atcText.ATCoDataType.ATCoInt
        Me.atxEYear.DefaultValue = ""
        Me.atxEYear.HardMax = 9999
        Me.atxEYear.HardMin = 0
        Me.atxEYear.InsideLimitsBackground = System.Drawing.Color.White
        Me.atxEYear.Location = New System.Drawing.Point(153, 67)
        Me.atxEYear.MaxWidth = 20
        Me.atxEYear.Name = "atxEYear"
        Me.atxEYear.NumericFormat = "0"
        Me.atxEYear.OutsideHardLimitBackground = System.Drawing.Color.Coral
        Me.atxEYear.OutsideSoftLimitBackground = System.Drawing.Color.Yellow
        Me.atxEYear.SelLength = 4
        Me.atxEYear.SelStart = 0
        Me.atxEYear.Size = New System.Drawing.Size(76, 24)
        Me.atxEYear.SoftMax = -999
        Me.atxEYear.SoftMin = -999
        Me.atxEYear.TabIndex = 27
        Me.atxEYear.ValueDouble = 2000
        Me.atxEYear.ValueInteger = 2000
        '
        'cboMet
        '
        Me.cboMet.AllowDrop = True
        Me.cboMet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMet.Location = New System.Drawing.Point(168, 127)
        Me.cboMet.Name = "cboMet"
        Me.cboMet.Size = New System.Drawing.Size(434, 25)
        Me.cboMet.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Met Stations Layer:"
        '
        'cboStreams
        '
        Me.cboStreams.AllowDrop = True
        Me.cboStreams.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStreams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStreams.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStreams.Location = New System.Drawing.Point(168, 87)
        Me.cboStreams.Name = "cboStreams"
        Me.cboStreams.Size = New System.Drawing.Size(434, 25)
        Me.cboStreams.TabIndex = 9
        '
        'tbxName
        '
        Me.tbxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxName.Location = New System.Drawing.Point(168, 40)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(268, 23)
        Me.tbxName.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Streams Layer:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WASP Project Name:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.AtcConnectFields)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(614, 398)
        Me.TabPage5.TabIndex = 7
        Me.TabPage5.Text = "Field Mapping"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'AtcConnectFields
        '
        Me.AtcConnectFields.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AtcConnectFields.Location = New System.Drawing.Point(3, 3)
        Me.AtcConnectFields.Name = "AtcConnectFields"
        Me.AtcConnectFields.Size = New System.Drawing.Size(608, 395)
        Me.AtcConnectFields.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmdGenerate)
        Me.TabPage2.Controls.Add(Me.AtcGridSegmentation)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(614, 398)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Segmentation"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Location = New System.Drawing.Point(23, 14)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(126, 25)
        Me.cmdGenerate.TabIndex = 1
        Me.cmdGenerate.Text = "Generate"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'AtcGridSegmentation
        '
        Me.AtcGridSegmentation.AllowHorizontalScrolling = True
        Me.AtcGridSegmentation.AllowNewValidValues = False
        Me.AtcGridSegmentation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AtcGridSegmentation.CellBackColor = System.Drawing.SystemColors.Window
        Me.AtcGridSegmentation.Fixed3D = False
        Me.AtcGridSegmentation.LineColor = System.Drawing.SystemColors.Control
        Me.AtcGridSegmentation.LineWidth = 1.0!
        Me.AtcGridSegmentation.Location = New System.Drawing.Point(23, 74)
        Me.AtcGridSegmentation.Name = "AtcGridSegmentation"
        Me.AtcGridSegmentation.Size = New System.Drawing.Size(569, 307)
        Me.AtcGridSegmentation.Source = Nothing
        Me.AtcGridSegmentation.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.AtcGridFlow)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(614, 398)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Flows"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'AtcGridFlow
        '
        Me.AtcGridFlow.AllowHorizontalScrolling = True
        Me.AtcGridFlow.AllowNewValidValues = False
        Me.AtcGridFlow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AtcGridFlow.CellBackColor = System.Drawing.Color.Empty
        Me.AtcGridFlow.Fixed3D = False
        Me.AtcGridFlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtcGridFlow.LineColor = System.Drawing.Color.Empty
        Me.AtcGridFlow.LineWidth = 0.0!
        Me.AtcGridFlow.Location = New System.Drawing.Point(23, 74)
        Me.AtcGridFlow.Name = "AtcGridFlow"
        Me.AtcGridFlow.Size = New System.Drawing.Size(569, 307)
        Me.AtcGridFlow.Source = Nothing
        Me.AtcGridFlow.TabIndex = 20
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.AtcGridLoad)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(614, 398)
        Me.TabPage4.TabIndex = 6
        Me.TabPage4.Text = "Boundaries/Loads"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'AtcGridLoad
        '
        Me.AtcGridLoad.AllowHorizontalScrolling = True
        Me.AtcGridLoad.AllowNewValidValues = False
        Me.AtcGridLoad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AtcGridLoad.CellBackColor = System.Drawing.Color.Empty
        Me.AtcGridLoad.Fixed3D = False
        Me.AtcGridLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtcGridLoad.LineColor = System.Drawing.Color.Empty
        Me.AtcGridLoad.LineWidth = 0.0!
        Me.AtcGridLoad.Location = New System.Drawing.Point(23, 74)
        Me.AtcGridLoad.Name = "AtcGridLoad"
        Me.AtcGridLoad.Size = New System.Drawing.Size(569, 307)
        Me.AtcGridLoad.Source = Nothing
        Me.AtcGridLoad.TabIndex = 21
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.AtcGridMet)
        Me.TabPage6.Controls.Add(Me.GroupBox2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(614, 398)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Meteorologic Time Series"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'AtcGridMet
        '
        Me.AtcGridMet.AllowHorizontalScrolling = True
        Me.AtcGridMet.AllowNewValidValues = False
        Me.AtcGridMet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AtcGridMet.CellBackColor = System.Drawing.Color.Empty
        Me.AtcGridMet.Fixed3D = False
        Me.AtcGridMet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtcGridMet.LineColor = System.Drawing.Color.Empty
        Me.AtcGridMet.LineWidth = 0.0!
        Me.AtcGridMet.Location = New System.Drawing.Point(23, 97)
        Me.AtcGridMet.Name = "AtcGridMet"
        Me.AtcGridMet.Size = New System.Drawing.Size(570, 283)
        Me.AtcGridMet.Source = Nothing
        Me.AtcGridMet.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtMetWDMName)
        Me.GroupBox2.Controls.Add(Me.cmdSelectWDM)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(570, 59)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Met WDM File"
        '
        'txtMetWDMName
        '
        Me.txtMetWDMName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMetWDMName.Location = New System.Drawing.Point(21, 34)
        Me.txtMetWDMName.Name = "txtMetWDMName"
        Me.txtMetWDMName.ReadOnly = True
        Me.txtMetWDMName.Size = New System.Drawing.Size(442, 23)
        Me.txtMetWDMName.TabIndex = 2
        '
        'cmdSelectWDM
        '
        Me.cmdSelectWDM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSelectWDM.Location = New System.Drawing.Point(479, 32)
        Me.cmdSelectWDM.Name = "cmdSelectWDM"
        Me.cmdSelectWDM.Size = New System.Drawing.Size(80, 27)
        Me.cmdSelectWDM.TabIndex = 1
        Me.cmdSelectWDM.Text = "Select"
        Me.cmdSelectWDM.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 451)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 55)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(16, 24)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(593, 16)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Update specifications if desired, then click OK to proceed."
        '
        'ofdMetWDM
        '
        Me.ofdMetWDM.DefaultExt = "wdm"
        Me.ofdMetWDM.Filter = "Met WDM files (*.wdm)|*.wdm"
        Me.ofdMetWDM.InitialDirectory = "/BASINS/data/"
        Me.ofdMetWDM.Title = "Select Met WDM File"
        '
        'frmWASPSetup
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(659, 568)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdExisting)
        Me.Controls.Add(Me.cmdOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmWASPSetup"
        Me.Text = "BASINS WASP"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend pDefaultSegmentFieldMap As New atcUtility.atcCollection
    Friend pPlugIn As PlugIn
    Friend pBasinsFolder As String

    Friend pFlowStationCandidates As WASPTimeseriesCollection
    Friend pAirTempStationCandidates As WASPTimeseriesCollection
    Friend pSolRadStationCandidates As WASPTimeseriesCollection
    Friend pWindStationCandidates As WASPTimeseriesCollection
    Friend pWaterTempStationCandidates As WASPTimeseriesCollection

    Private pInitializing As Boolean = True
    Private pSelectedRow As Integer
    Private pSelectedColumn As Integer

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cboStreams_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStreams.SelectedIndexChanged
        SetFieldMappingControl()
    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        Logger.Msg("BASINS WASP for MapWindow" & vbCrLf & vbCrLf & "Version 1.0", MsgBoxStyle.OkOnly, "BASINS WASP")
    End Sub

    Private Sub cmdExisting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExisting.Click
        If ofdExisting.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Logger.Dbg("Run WASP with " & ofdExisting.FileName)
            pPlugIn.WASPProject.Run(ofdExisting.FileName)
        End If
    End Sub

    Private Sub cmdHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHelp.Click
        ShowHelp("BASINS Details\Watershed and Instream Model Setup\WASP.html")
    End Sub

    Private Sub frmWASPSetup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Windows.Forms.Keys.F1 Then
            ShowHelp("BASINS Details\Watershed and Instream Model Setup\WASP.html")
        End If
    End Sub

    Friend Sub EnableControls(ByVal aEnabled As Boolean)
        cmdOK.Enabled = aEnabled
        cmdExisting.Enabled = aEnabled
        cmdCancel.Enabled = aEnabled
        If Not pInitializing Then
            cmdHelp.Enabled = aEnabled
            cmdAbout.Enabled = aEnabled
        End If
    End Sub

    Private Sub SetFieldMappingControl()
        If pInitializing Then
            Logger.Dbg("SetFieldMappingControl Skipped while initializing")
        Else
            Logger.Dbg("SetFieldMappingControl Begin")

            'add source fields from dbf
            AtcConnectFields.lstSource.Items.Clear()
            If cboStreams.SelectedIndex > -1 Then
                Dim lStreamsLayerIndex As Integer = GisUtil.LayerIndex(cboStreams.Items(cboStreams.SelectedIndex))
                For lFieldIndex As Integer = 0 To GisUtil.NumFields(lStreamsLayerIndex) - 1
                    AtcConnectFields.lstSource.Items.Add("Segment:" & GisUtil.FieldName(lFieldIndex, lStreamsLayerIndex))
                Next
            End If

            'add target properties from introspection on the swmm classes
            AtcConnectFields.lstTarget.Items.Clear()
            Dim lSegment As New atcWASP.Segment
            For Each lField As Reflection.FieldInfo In lSegment.GetType.GetFields
                AtcConnectFields.lstTarget.Items.Add("Segment:" & lField.Name)
            Next

            'add existing connections from default field maps
            AtcConnectFields.lstConnections.Items.Clear()
            Dim lConn As String
            Dim lType As String = "Segment"
            For lIndex As Integer = 0 To pDefaultSegmentFieldMap.Count - 1
                lConn = lType & ":" & pDefaultSegmentFieldMap.Keys(lIndex) & " <-> " & lType & ":" & pDefaultSegmentFieldMap(lIndex)
                AtcConnectFields.AddConnection(lConn, True)
            Next
        End If
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Logger.Dbg("Setup WASP input files")

        lblStatus.Text = "Preparing to process"
        Me.Refresh()
        EnableControls(False)

        'put contents of segment class back into structure
        With AtcGridSegmentation.Source
            For lIndex As Integer = 1 To pPlugIn.WASPProject.Segments.Count
                pPlugIn.WASPProject.Segments(lIndex - 1).Length = .CellValue(lIndex, 1)
                pPlugIn.WASPProject.Segments(lIndex - 1).Width = .CellValue(lIndex, 2)
                pPlugIn.WASPProject.Segments(lIndex - 1).Dmult = .CellValue(lIndex, 3)
                pPlugIn.WASPProject.Segments(lIndex - 1).Vmult = .CellValue(lIndex, 4)
                pPlugIn.WASPProject.Segments(lIndex - 1).Slope = .CellValue(lIndex, 5)
                pPlugIn.WASPProject.Segments(lIndex - 1).Roughness = .CellValue(lIndex, 6)
                pPlugIn.WASPProject.Segments(lIndex - 1).DownID = .CellValue(lIndex, 7)
            Next
        End With

        'clear out collections of timeseries prior to rebuilding
        pPlugIn.WASPProject.InputTimeseriesCollection.Clear()
        For lIndex As Integer = 1 To pPlugIn.WASPProject.Segments.Count
            pPlugIn.WASPProject.Segments(lIndex - 1).InputTimeseriesCollection.Clear()
        Next

        'rebuild collections of timeseries 
        'With AtcGridFlow.Source
        '    For lIndex As Integer = 1 To pPlugIn.WASPProject.Segments.Count
        '        If .CellValue(lIndex, 1).Trim.Length = 0 Or .CellValue(lIndex, 1) = "<none>" Then
        '            pPlugIn.WASPProject.Segments(lIndex - 1).InflowTimeseries = Nothing
        '        Else
        '            'need to make sure this timeseries is in the class structure
        '            Dim lTimeseriesName As String = ""
        '            Dim lParenPos As Integer = InStr(.CellValue(lIndex, 1), "(")
        '            If lParenPos > 0 Then
        '                lTimeseriesName = .CellValue(lIndex, 1).Substring(1, lParenPos)  'take the date portion off the name
        '            Else
        '                lTimeseriesName = .CellValue(lIndex, 1)
        '            End If

        '            If pPlugIn.WASPProject.InputTimeseriesCollection.Contains(lTimeseriesName) Then
        '                'already in the project, just reference it from this segment
        '                pPlugIn.WASPProject.Segments(lIndex - 1).InflowTimeseries = pPlugIn.WASPProject.InputTimeseriesCollection(lTimeseriesName)
        '            Else
        '                'not yet in the project, add it
        '                Dim lTimeseries As New atcWASP.WASPTimeseries
        '                lTimeseries.Type = "FLOW"
        '                lTimeseries.Identifier = lTimeseriesName
        '                'lTimeseries.TimeSeries = GetTimeseries(lWDMFileName, "OBSERVED", aGageId, "PREC")
        '                pPlugIn.WASPProject.InputTimeseriesCollection.Add(lTimeseries)
        '                pPlugIn.WASPProject.Segments(lIndex - 1).InflowTimeseries = lTimeseries
        '            End If
        '        End If
        '    Next
        'End With

        Dim lName As String = tbxName.Text
        'TODO: still use modelout?
        Dim lWASPProjectFileName As String = pBasinsFolder & "\modelout\" & lName & "\" & lName & ".wnf"
        MkDirPath(PathNameOnly(lWASPProjectFileName))

        If PreProcessChecking(lWASPProjectFileName) Then
            With pPlugIn.WASPProject
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

                .Name = lName

                'save project file and start WASP
                Logger.Dbg("Save WASP network import file" & lWASPProjectFileName)
                .Save(lWASPProjectFileName)
                Logger.Dbg("Run WASP")
                .Run(lWASPProjectFileName)
                Logger.Dbg("BackFromWASP")
            End With
            lblStatus.Text = ""
            Me.Refresh()
            Me.Dispose()
            Me.Close()
            Logger.Dbg("Done")
        Else
            Logger.Dbg("Failed PreProcess Check")
        End If
        Logger.Flush()
    End Sub

    Private Function PreProcessChecking(ByVal aOutputFileName As String) As Boolean
        Logger.Dbg("PreprocessChecking " & aOutputFileName)

        'see if this file already exists
        If FileExists(aOutputFileName) Then  'already exists
            If Logger.Msg("WASP Project '" & FilenameNoPath(aOutputFileName) & "' already exists.  Do you want to overwrite it?", vbOKCancel, "Overwrite?") = MsgBoxResult.Cancel Then
                EnableControls(True)
                Return False
            End If
        End If

        Logger.Dbg("PreprocessChecking OK")
        Return True
    End Function

    Public Sub InitializeUI(ByVal aPlugIn As PlugIn)
        Logger.Dbg("InitializeUI")
        EnableControls(False)
        pPlugIn = aPlugIn
        pBasinsFolder = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\AQUA TERRA Consultants\BASINS", "Base Directory", "C:\Basins")

        pFlowStationCandidates = New WASPTimeseriesCollection
        pAirTempStationCandidates = New WASPTimeseriesCollection
        pSolRadStationCandidates = New WASPTimeseriesCollection
        pWindStationCandidates = New WASPTimeseriesCollection
        pWaterTempStationCandidates = New WASPTimeseriesCollection

        'set field mapping for segments
        pDefaultSegmentFieldMap.Clear()
        pDefaultSegmentFieldMap.Add("GNIS_NAME", "Name")
        pDefaultSegmentFieldMap.Add("COMID", "ID")
        pDefaultSegmentFieldMap.Add("LINKNO", "ID")
        pDefaultSegmentFieldMap.Add("LENGTHKM", "Length")
        pDefaultSegmentFieldMap.Add("MeanWidth", "Width")
        pDefaultSegmentFieldMap.Add("DSCOMID", "DownID")
        pDefaultSegmentFieldMap.Add("DSLINKNO", "DownID")
        pDefaultSegmentFieldMap.Add("TOCOMID", "DownID")

        cboMet.Items.Add("<none>")

        With AtcGridSegmentation
            .Source = New atcControls.atcGridSource
            .AllowHorizontalScrolling = False
        End With

        With AtcGridFlow
            .Source = New atcControls.atcGridSource
            .AllowHorizontalScrolling = False
        End With

        With AtcGridLoad
            .Source = New atcControls.atcGridSource
            .AllowHorizontalScrolling = False
        End With

        With AtcGridMet
            .Source = New atcControls.atcGridSource
            .AllowHorizontalScrolling = False
        End With

        For lLayerIndex As Integer = 0 To GisUtil.NumLayers() - 1
            Dim lLayerName As String = GisUtil.LayerName(lLayerIndex)
            If GisUtil.LayerType(lLayerIndex) = 3 Then 'PolygonShapefile 

            ElseIf GisUtil.LayerType(lLayerIndex) = 2 Then 'LineShapefile 
                cboStreams.Items.Add(lLayerName)
                'see if there are any selected features in this layer, if so assume this is the stream segment layer
                If GisUtil.NumSelectedFeatures(lLayerIndex) > 0 Then
                    cboStreams.SelectedIndex = cboStreams.Items.Count - 1
                End If
            ElseIf GisUtil.LayerType(lLayerIndex) = 1 Then 'PointShapefile
                cboMet.Items.Add(lLayerName)
                If lLayerName.ToUpper.IndexOf("WEATHER STATION SITES 20") > -1 Then
                    'this takes some time, show window and then do this
                    'cboMet.SelectedIndex = cboMet.Items.Count - 1
                End If
            ElseIf GisUtil.LayerType(lLayerIndex) = 4 Then 'Grid

            End If
        Next

        'if no stream layer selected and there is an nhd layer on the map, make it selected
        If cboStreams.SelectedIndex < 0 Then
            For lIndex As Integer = 1 To cboStreams.Items.Count
                Dim lLayerName As String = cboStreams.Items(lIndex - 1).ToString
                If lLayerName.ToUpper.IndexOf("FLOWLINE") > -1 Then
                    cboStreams.SelectedIndex = lIndex - 1
                End If
            Next
        End If
        If cboStreams.SelectedIndex < 0 Then
            For lIndex As Integer = 1 To cboStreams.Items.Count
                Dim lLayerName As String = cboStreams.Items(lIndex - 1).ToString
                If lLayerName.ToUpper.IndexOf("NHD") > -1 Then
                    cboStreams.SelectedIndex = lIndex - 1
                End If
            Next
        End If

        If cboStreams.Items.Count > 0 And cboStreams.SelectedIndex < 0 Then
            cboStreams.SelectedIndex = 0
        End If
        If cboMet.Items.Count > 0 And cboMet.SelectedIndex < 0 Then
            cboMet.SelectedIndex = 0
        End If

        tbxName.Text = IO.Path.GetFileNameWithoutExtension(GisUtil.ProjectFileName)

        BuildListofValidStationNames("FLOW", pFlowStationCandidates)
        BuildListofValidStationNames("WTMP", pWaterTempStationCandidates)

        AtcGridSegmentation.Clear()
        With AtcGridSegmentation.Source
            .Columns = 8
            .ColorCells = True
            .FixedRows = 1
            .FixedColumns = 1
            .CellColor(0, 0) = SystemColors.ControlDark
            .CellColor(0, 1) = SystemColors.ControlDark
            .CellColor(0, 2) = SystemColors.ControlDark
            .CellColor(0, 3) = SystemColors.ControlDark
            .CellColor(0, 4) = SystemColors.ControlDark
            .CellColor(0, 5) = SystemColors.ControlDark
            .CellColor(0, 6) = SystemColors.ControlDark
            .CellColor(0, 7) = SystemColors.ControlDark
            .Rows = 1 + pPlugIn.WASPProject.Segments.Count
            .CellValue(0, 0) = "Segment"
            .CellValue(0, 1) = "Length"
            .CellValue(0, 2) = "Width"
            .CellValue(0, 3) = "DMult"
            .CellValue(0, 4) = "VMult"
            .CellValue(0, 5) = "Slope"
            .CellValue(0, 6) = "Roughness"
            .CellValue(0, 7) = "DownStream ID"
        End With

        AtcGridFlow.Clear()
        With AtcGridFlow.Source
            .Columns = 2
            .ColorCells = True
            .FixedRows = 1
            .FixedColumns = 1
            .CellColor(0, 0) = SystemColors.ControlDark
            .CellColor(0, 1) = SystemColors.ControlDark
            .Rows = 1 + pPlugIn.WASPProject.Segments.Count
            .CellValue(0, 0) = "Segment"
            .CellValue(0, 1) = "Input Flow Timeseries"
        End With

        AtcGridLoad.Clear()
        With AtcGridLoad.Source
            .Columns = 2
            .ColorCells = True
            .FixedRows = 1
            .FixedColumns = 1
            .CellColor(0, 0) = SystemColors.ControlDark
            .CellColor(0, 1) = SystemColors.ControlDark
            .Rows = 1 + pPlugIn.WASPProject.Segments.Count
            .CellValue(0, 0) = "Segment"
            .CellValue(0, 1) = "Water Temp Timeseries"
        End With

        AtcGridMet.Clear()
        With AtcGridMet.Source
            .Columns = 4
            .ColorCells = True
            .FixedRows = 1
            .FixedColumns = 1
            .CellColor(0, 0) = SystemColors.ControlDark
            .CellColor(0, 1) = SystemColors.ControlDark
            .CellColor(0, 2) = SystemColors.ControlDark
            .CellColor(0, 3) = SystemColors.ControlDark
            .Rows = 1 + pPlugIn.WASPProject.Segments.Count
            .CellValue(0, 0) = "Segment"
            .CellValue(0, 1) = "Air Temperature"
            .CellValue(0, 2) = "Solar Radiation"
            .CellValue(0, 3) = "Wind Speed"
        End With

        pInitializing = False
        SetFieldMappingControl()
        Logger.Dbg("InitializeUI Complete")
    End Sub

    Friend Sub InitializeMetStationList()
        For lLayerIndex As Integer = 0 To cboMet.Items.Count - 1
            Dim lLayerName As String = cboMet.Items(lLayerIndex)
            If lLayerName.IndexOf("Weather Station Sites 20") > -1 Then
                'this takes some time, show window and then do this
                Logger.Dbg("Initializing MetStationList")
                cboMet.SelectedIndex = lLayerIndex
            End If
        Next
    End Sub

    Private Sub cboMet_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMet.SelectedIndexChanged
        'fill in met wdm file name as appropriate
        Dim lMetLayerName As String = cboMet.Items(cboMet.SelectedIndex)
        If lMetLayerName.IndexOf("Weather Station Sites 20") > -1 Then 'new basins met
            Dim lMetWDMName As String = GisUtil.LayerFileName(GisUtil.LayerIndex(lMetLayerName))
            lMetWDMName = FilenameSetExt(lMetWDMName, "wdm")
            txtMetWDMName.Text = lMetWDMName
        ElseIf lMetLayerName.IndexOf("WDM Weather") > -1 Then 'old basins met 
            If GisUtil.IsLayer("State Boundaries") Then
                Dim lStateIndex As Integer = GisUtil.LayerIndex("State Boundaries")
                Dim lDefaultState As String = GisUtil.FieldValue(lStateIndex, 0, GisUtil.FieldIndex(lStateIndex, "ST"))
                Dim lBasinsBinLoc As String = PathNameOnly(System.Reflection.Assembly.GetEntryAssembly.Location)
                Dim lDataPath As String = lBasinsBinLoc.Substring(0, lBasinsBinLoc.Length - 3) & "data\"
                txtMetWDMName.Text = lDataPath & "met_data\" & lDefaultState & ".wdm"
            End If
        End If
    End Sub

    Private Sub cmdSelectWDM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelectWDM.Click
        If ofdMetWDM.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtMetWDMName.Text = ofdMetWDM.FileName
        End If
    End Sub

    Private Sub txtMetWDMName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMetWDMName.TextChanged
        If Len(txtMetWDMName.Text) > 0 Then
            lblStatus.Text = "Reading Meteorological Data from WDM File..."
            Me.Refresh()
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            EnableControls(False)

            Dim lMetFile As atcWDM.atcDataSourceWDM = GetMetFile(txtMetWDMName.Text)
            pAirTempStationCandidates.Clear()
            BuildListofValidStationNamesFromDataSource(lMetFile, "ATMP", pAirTempStationCandidates)
            BuildListofValidStationNamesFromDataSource(lMetFile, "ATEM", pAirTempStationCandidates)
            pSolRadStationCandidates.Clear()
            BuildListofValidStationNamesFromDataSource(lMetFile, "SOLRAD", pSolRadStationCandidates)
            BuildListofValidStationNamesFromDataSource(lMetFile, "SOLR", pSolRadStationCandidates)
            pWindStationCandidates.Clear()
            BuildListofValidStationNamesFromDataSource(lMetFile, "WIND", pWindStationCandidates)

            lblStatus.Text = "Update specifications if desired, then click OK to proceed."
            Me.Refresh()
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            EnableControls(True)
        Else
            'clear lists of met stations
            pAirTempStationCandidates.Clear()
            pSolRadStationCandidates.Clear()
            pWindStationCandidates.Clear()
        End If
    End Sub

    Private Sub lblStatus_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStatus.TextChanged
        Logger.Dbg(lblStatus.Text)
    End Sub

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click

        'set field mapping as specified in field mapping control
        Dim lSegmentFieldMap As New atcCollection
        lSegmentFieldMap.Clear()
        For lIndex As Integer = 0 To AtcConnectFields.lstConnections.Items.Count - 1
            Dim lTxt As String = AtcConnectFields.lstConnections.Items(lIndex)
            Dim lBaseLen As Integer = 0
            Dim lBaseName As String = ""
            If Mid(lTxt, 1, 7) = "Segment" Then
                lBaseLen = 7
                lBaseName = "Segment"
            End If
            Dim lSpacePos As Integer = InStr(lTxt, " ")
            Dim lGTPos As Integer = InStr(lTxt, ">")
            Dim lSrc As String = Mid(lTxt, lBaseLen + 2, lSpacePos - lBaseLen - 2)

            If Mid(lTxt, lGTPos + 2, lBaseLen) = lBaseName Then
                Dim lTar As String = Mid(lTxt, lGTPos + lBaseLen + 3)
                If Mid(lTxt, 1, 7) = "Segment" Then
                    lSegmentFieldMap.Add(lSrc, lTar)
                End If
            End If
        Next

        'set file names for segments
        Dim lSegmentLayerIndex As Integer = GisUtil.LayerIndex(cboStreams.Items(cboStreams.SelectedIndex))
        Dim lSegmentShapefileName As String = GisUtil.LayerFileName(lSegmentLayerIndex)

        'populate the SWMM classes from the shapefiles'
        With pPlugIn.WASPProject
            .Segments.Clear()
            Dim lTable As New atcUtility.atcTableDBF

            'add only selected segments
            Dim lTempSegments As New atcWASP.Segments
            If lTable.OpenFile(FilenameSetExt(lSegmentShapefileName, "dbf")) Then
                Logger.Dbg("Add " & lTable.NumRecords & " SegmentsFrom " & lSegmentShapefileName)
                lTempSegments.AddRange(NumberObjects(lTable.PopulateObjects((New atcWASP.Segment).GetType, lSegmentFieldMap), "Name"))
            End If
            Logger.Dbg("SegmentsCount " & lTempSegments.Count)

            'after reading the attribute table, see if any are selected
            If GisUtil.NumSelectedFeatures(lSegmentLayerIndex) > 0 Then
                'put only selected segments in .segments 
                For lIndex As Integer = 0 To GisUtil.NumSelectedFeatures(lSegmentLayerIndex) - 1
                    .Segments.Add(lTempSegments(GisUtil.IndexOfNthSelectedFeatureInLayer(lIndex, lSegmentLayerIndex)))
                Next
            Else
                'add all 
                .Segments = lTempSegments
            End If

        End With

        SetSegmentationGrid()
        SetFlowStationGrid()
        SetLoadStationGrid()
        SetMetStationGrid()

    End Sub

    Private Sub SetSegmentationGrid()
        If AtcGridSegmentation.Source Is Nothing Then
            Logger.Dbg("No atcGridSegmentation")
        Else
            Logger.Dbg("Begin")

            With AtcGridSegmentation.Source
                .Rows = 1 + pPlugIn.WASPProject.Segments.Count
                For lIndex As Integer = 1 To pPlugIn.WASPProject.Segments.Count
                    .CellValue(lIndex, 0) = pPlugIn.WASPProject.Segments(lIndex - 1).ID & ":" & pPlugIn.WASPProject.Segments(lIndex - 1).Name
                    .CellColor(lIndex, 0) = SystemColors.ControlDark
                    .CellValue(lIndex, 1) = pPlugIn.WASPProject.Segments(lIndex - 1).Length
                    .CellEditable(lIndex, 1) = True
                    .CellValue(lIndex, 2) = pPlugIn.WASPProject.Segments(lIndex - 1).Width
                    .CellEditable(lIndex, 2) = True
                    .CellValue(lIndex, 3) = pPlugIn.WASPProject.Segments(lIndex - 1).Dmult
                    .CellEditable(lIndex, 3) = True
                    .CellValue(lIndex, 4) = pPlugIn.WASPProject.Segments(lIndex - 1).Vmult
                    .CellEditable(lIndex, 4) = True
                    .CellValue(lIndex, 5) = pPlugIn.WASPProject.Segments(lIndex - 1).Slope
                    .CellEditable(lIndex, 5) = True
                    .CellValue(lIndex, 6) = pPlugIn.WASPProject.Segments(lIndex - 1).Roughness
                    .CellEditable(lIndex, 6) = True
                    .CellValue(lIndex, 7) = pPlugIn.WASPProject.Segments(lIndex - 1).DownID
                Next
            End With

            AtcGridSegmentation.SizeAllColumnsToContents()
            AtcGridSegmentation.Refresh()

            Logger.Dbg("SegmentationGrid refreshed")
        End If
    End Sub

    Private Sub SetFlowStationGrid()
        If AtcGridFlow.Source Is Nothing OrElse cboStreams.SelectedIndex = -1 Then
            Logger.Dbg("No atcGridFlow or Streams layer selected")
        Else
            Logger.Dbg("Begin")

            With AtcGridFlow.Source
                .Rows = 1 + pPlugIn.WASPProject.Segments.Count
                For lIndex As Integer = 1 To pPlugIn.WASPProject.Segments.Count
                    .CellValue(lIndex, 0) = pPlugIn.WASPProject.Segments(lIndex - 1).ID & ":" & pPlugIn.WASPProject.Segments(lIndex - 1).Name
                    .CellColor(lIndex, 0) = SystemColors.ControlDark
                    .CellValue(lIndex, 1) = "<none>"
                    If pFlowStationCandidates.Count > 0 Then
                        .CellEditable(lIndex, 1) = True
                    Else
                        .CellEditable(lIndex, 1) = False
                    End If
                Next
            End With

            Logger.Dbg("SetValidValues")
            Dim lValidValues As New atcCollection
            lValidValues.Add("<none>")
            For Each lFlowStation As WASPTimeseries In pFlowStationCandidates
                lValidValues.Add(lFlowStation.Description)
            Next
            AtcGridFlow.ValidValues = lValidValues
            AtcGridFlow.SizeAllColumnsToContents()
            AtcGridFlow.Refresh()

            Logger.Dbg("FlowStationGrid refreshed")
        End If
    End Sub

    Private Sub SetLoadStationGrid()
        If AtcGridLoad.Source Is Nothing Then
            Logger.Dbg("No atcGridLoad")
        Else
            Logger.Dbg("Begin")

            With AtcGridLoad.Source
                .Rows = 1 + pPlugIn.WASPProject.Segments.Count
                For lIndex As Integer = 1 To pPlugIn.WASPProject.Segments.Count
                    .CellValue(lIndex, 0) = pPlugIn.WASPProject.Segments(lIndex - 1).ID & ":" & pPlugIn.WASPProject.Segments(lIndex - 1).Name
                    .CellColor(lIndex, 0) = SystemColors.ControlDark
                    .CellValue(lIndex, 1) = "<none>"
                    If pWaterTempStationCandidates.Count > 0 Then
                        .CellValue(lIndex, 1) = "<none>"
                        .CellEditable(lIndex, 1) = True
                    Else
                        .CellEditable(lIndex, 1) = False
                    End If
                Next
            End With

            Logger.Dbg("SetValidValues")
            Dim lValidValues As New atcCollection
            lValidValues.Add("<none>")
            For Each lWaterTempStation As WASPTimeseries In pWaterTempStationCandidates
                lValidValues.Add(lWaterTempStation.Description)
            Next
            AtcGridLoad.ValidValues = lValidValues
            AtcGridLoad.SizeAllColumnsToContents()
            AtcGridLoad.Refresh()

            Logger.Dbg("LoadStationGrid refreshed")
        End If
    End Sub

    Private Sub SetMetStationGrid()
        If AtcGridMet.Source Is Nothing Then
            Logger.Dbg("No atcGridMet")
        Else
            Logger.Dbg("Begin")

            With AtcGridMet.Source
                .Rows = 1 + pPlugIn.WASPProject.Segments.Count
                For lIndex As Integer = 1 To pPlugIn.WASPProject.Segments.Count
                    .CellValue(lIndex, 0) = pPlugIn.WASPProject.Segments(lIndex - 1).ID & ":" & pPlugIn.WASPProject.Segments(lIndex - 1).Name
                    .CellColor(lIndex, 0) = SystemColors.ControlDark
                    .CellValue(lIndex, 1) = "<none>"
                    .CellEditable(lIndex, 1) = True
                    .CellValue(lIndex, 2) = "<none>"
                    .CellEditable(lIndex, 2) = True
                    .CellValue(lIndex, 3) = "<none>"
                    .CellEditable(lIndex, 3) = True
                Next
            End With

            AtcGridMet.SizeAllColumnsToContents()
            AtcGridMet.Refresh()

            Logger.Dbg("MetStationGrid refreshed")
        End If
    End Sub

    Friend Function GetMetFile(ByRef aMetWDMName As String) As atcWDM.atcDataSourceWDM
        Logger.Dbg("MetWDMName " & aMetWDMName)

        Dim lDataSource As atcWDM.atcDataSourceWDM = Nothing
        If FileExists(aMetWDMName) Then
            Dim lFound As Boolean = False
            For Each lBASINSDataSource As atcTimeseriesSource In atcDataManager.DataSources
                If lBASINSDataSource.Specification.ToUpper = aMetWDMName.ToUpper Then
                    'found it in the BASINS data sources
                    lDataSource = lBASINSDataSource
                    lFound = True
                    Exit For
                End If
            Next

            If Not lFound Then 'need to open it here
                lDataSource = New atcWDM.atcDataSourceWDM
                If lDataSource.Open(aMetWDMName) Then
                    lFound = True
                End If
            End If
        End If
        Return lDataSource
    End Function

    Private Sub AtcGridMet_MouseDownCell(ByVal aGrid As atcControls.atcGrid, ByVal aRow As Integer, ByVal aColumn As Integer) Handles AtcGridMet.MouseDownCell
        pSelectedColumn = aColumn
        pSelectedRow = aRow

        DoLimitsMet()
    End Sub

    Private Sub DoLimitsMet()

        With AtcGridMet
            Dim lValidValues As New Collection
            If pSelectedColumn = 1 Then 'air temp
                For Each lStationCandidate As WASPTimeseries In pAirTempStationCandidates
                    lValidValues.Add(lStationCandidate.Description)
                Next
                If lValidValues.Count = 0 Then
                    .Source.CellEditable(pSelectedRow, 1) = False
                End If
            ElseIf pSelectedColumn = 2 Then  'sol rad
                For Each lStationCandidate As WASPTimeseries In pSolRadStationCandidates
                    lValidValues.Add(lStationCandidate.Description)
                Next
                If lValidValues.Count = 0 Then
                    .Source.CellEditable(pSelectedRow, 3) = False
                End If
            ElseIf pSelectedColumn = 3 Then 'wind
                For Each lStationCandidate As WASPTimeseries In pWindStationCandidates
                    lValidValues.Add(lStationCandidate.Description)
                Next
                If lValidValues.Count = 0 Then
                    .Source.CellEditable(pSelectedRow, 4) = False
                End If
            End If
            .ValidValues = lValidValues
            .AllowNewValidValues = False
            .Refresh()
        End With
    End Sub
End Class