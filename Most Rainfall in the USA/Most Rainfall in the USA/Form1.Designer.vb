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
        Me.SuspendLayout()
        '
        'mnuRainfall
        '
        Me.mnuRainfall.Location = New System.Drawing.Point(0, 0)
        Me.mnuRainfall.Name = "mnuRainfall"
        Me.mnuRainfall.Size = New System.Drawing.Size(800, 24)
        Me.mnuRainfall.TabIndex = 0
        Me.mnuRainfall.Text = "MenuStrip1"
        '
        'frmRainfall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mnuRainfall)
        Me.MainMenuStrip = Me.mnuRainfall
        Me.Name = "frmRainfall"
        Me.Text = "Most Rainfall in the USA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuRainfall As MenuStrip
End Class
