<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChooseGraphs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChooseGraphs))
        Me.lstChooseGraphs = New System.Windows.Forms.CheckedListBox
        Me.lblChooseGraphs = New System.Windows.Forms.Label
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstChooseGraphs
        '
        Me.lstChooseGraphs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstChooseGraphs.FormattingEnabled = True
        Me.lstChooseGraphs.IntegralHeight = False
        Me.lstChooseGraphs.Location = New System.Drawing.Point(12, 12)
        Me.lstChooseGraphs.Name = "lstChooseGraphs"
        Me.lstChooseGraphs.Size = New System.Drawing.Size(331, 146)
        Me.lstChooseGraphs.TabIndex = 0
        '
        'lblChooseGraphs
        '
        Me.lblChooseGraphs.AutoSize = True
        Me.lblChooseGraphs.Location = New System.Drawing.Point(12, 9)
        Me.lblChooseGraphs.Name = "lblChooseGraphs"
        Me.lblChooseGraphs.Size = New System.Drawing.Size(0, 13)
        Me.lblChooseGraphs.TabIndex = 1
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.Location = New System.Drawing.Point(268, 164)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(187, 164)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmChooseGraphs
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(355, 199)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblChooseGraphs)
        Me.Controls.Add(Me.lstChooseGraphs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChooseGraphs"
        Me.Text = "Choose Graphs to Create"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstChooseGraphs As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblChooseGraphs As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
