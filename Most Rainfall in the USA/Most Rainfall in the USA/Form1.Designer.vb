<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainfall
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
        Me.mnuRainfall = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnRainfall = New System.Windows.Forms.Button()
        Me.mnuRainfall.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuRainfall
        '
        Me.mnuRainfall.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuRainfall.Location = New System.Drawing.Point(0, 0)
        Me.mnuRainfall.Name = "mnuRainfall"
        Me.mnuRainfall.Size = New System.Drawing.Size(800, 24)
        Me.mnuRainfall.TabIndex = 0
        Me.mnuRainfall.Text = "MenuStrip1"
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
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Tomato
        Me.lblTitle.Location = New System.Drawing.Point(12, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(328, 29)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Most Rainfall in US - Kauai"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblAverage.Location = New System.Drawing.Point(110, 76)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(101, 16)
        Me.lblAverage.TabIndex = 2
        Me.lblAverage.Text = "Rainfall Average"
        '
        'btnRainfall
        '
        Me.btnRainfall.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnRainfall.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRainfall.Location = New System.Drawing.Point(78, 118)
        Me.btnRainfall.Name = "btnRainfall"
        Me.btnRainfall.Size = New System.Drawing.Size(167, 33)
        Me.btnRainfall.TabIndex = 3
        Me.btnRainfall.Text = "Enter rainfall"
        Me.btnRainfall.UseVisualStyleBackColor = False
        '
        'frmRainfall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRainfall)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuRainfall)
        Me.MainMenuStrip = Me.mnuRainfall
        Me.Name = "frmRainfall"
        Me.Text = "Most Rainfall in the USA"
        Me.mnuRainfall.ResumeLayout(False)
        Me.mnuRainfall.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuRainfall As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnRainfall As Button
End Class
