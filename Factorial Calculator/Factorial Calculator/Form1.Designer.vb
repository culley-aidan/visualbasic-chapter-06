<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactorial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.mnuCalculator = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstFactorials = New System.Windows.Forms.ListBox()
        Me.mnuCalculator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblTitle.Location = New System.Drawing.Point(53, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(361, 42)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Factorial Calculator"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Black
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Chartreuse
        Me.btnCalculate.Location = New System.Drawing.Point(104, 81)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(249, 47)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate Factorials"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'mnuCalculator
        '
        Me.mnuCalculator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuCalculator.Location = New System.Drawing.Point(0, 0)
        Me.mnuCalculator.Name = "mnuCalculator"
        Me.mnuCalculator.Size = New System.Drawing.Size(462, 24)
        Me.mnuCalculator.TabIndex = 2
        Me.mnuCalculator.Text = "mnuCalculator"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lstFactorials
        '
        Me.lstFactorials.BackColor = System.Drawing.Color.Black
        Me.lstFactorials.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFactorials.ForeColor = System.Drawing.Color.Chartreuse
        Me.lstFactorials.FormattingEnabled = True
        Me.lstFactorials.ItemHeight = 23
        Me.lstFactorials.Location = New System.Drawing.Point(60, 158)
        Me.lstFactorials.Name = "lstFactorials"
        Me.lstFactorials.Size = New System.Drawing.Size(354, 280)
        Me.lstFactorials.TabIndex = 3
        '
        'frmFactorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Factorial_Calculator.My.Resources.Resources.matrix_full_3145364_960_720
        Me.ClientSize = New System.Drawing.Size(462, 450)
        Me.Controls.Add(Me.lstFactorials)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuCalculator)
        Me.MainMenuStrip = Me.mnuCalculator
        Me.Name = "frmFactorial"
        Me.Text = "Factorial Calculator"
        Me.mnuCalculator.ResumeLayout(False)
        Me.mnuCalculator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents mnuCalculator As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lstFactorials As ListBox
End Class
