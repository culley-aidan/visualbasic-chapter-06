<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftball
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
        Me.mnuScoreboard = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFinalScore = New System.Windows.Forms.Label()
        Me.btnInnings = New System.Windows.Forms.Button()
        Me.lstInnings = New System.Windows.Forms.ListBox()
        Me.mnuScoreboard.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuScoreboard
        '
        Me.mnuScoreboard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuScoreboard.Location = New System.Drawing.Point(0, 0)
        Me.mnuScoreboard.Name = "mnuScoreboard"
        Me.mnuScoreboard.Size = New System.Drawing.Size(375, 24)
        Me.mnuScoreboard.TabIndex = 0
        Me.mnuScoreboard.Text = "MenuStrip1"
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(365, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Softball Scoreboard"
        '
        'lblFinalScore
        '
        Me.lblFinalScore.AutoSize = True
        Me.lblFinalScore.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalScore.Location = New System.Drawing.Point(42, 322)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(276, 29)
        Me.lblFinalScore.TabIndex = 2
        Me.lblFinalScore.Text = "The final score is XX.X"
        '
        'btnInnings
        '
        Me.btnInnings.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInnings.Location = New System.Drawing.Point(98, 79)
        Me.btnInnings.Name = "btnInnings"
        Me.btnInnings.Size = New System.Drawing.Size(167, 38)
        Me.btnInnings.TabIndex = 3
        Me.btnInnings.Text = "Enter Innings"
        Me.btnInnings.UseVisualStyleBackColor = True
        '
        'lstInnings
        '
        Me.lstInnings.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInnings.FormattingEnabled = True
        Me.lstInnings.ItemHeight = 19
        Me.lstInnings.Location = New System.Drawing.Point(144, 142)
        Me.lstInnings.Name = "lstInnings"
        Me.lstInnings.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstInnings.Size = New System.Drawing.Size(62, 137)
        Me.lstInnings.TabIndex = 4
        '
        'frmSoftball
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 391)
        Me.Controls.Add(Me.lstInnings)
        Me.Controls.Add(Me.btnInnings)
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuScoreboard)
        Me.MainMenuStrip = Me.mnuScoreboard
        Me.Name = "frmSoftball"
        Me.Text = "Softball Scoreboard"
        Me.mnuScoreboard.ResumeLayout(False)
        Me.mnuScoreboard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuScoreboard As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFinalScore As Label
    Friend WithEvents btnInnings As Button
    Friend WithEvents lstInnings As ListBox
End Class
