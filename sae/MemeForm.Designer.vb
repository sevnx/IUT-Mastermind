<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemeForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TimerPopupMeme = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TimerPopupMeme
        '
        '
        'memeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.sae.My.Resources.Resources._5kgqcv
        Me.ClientSize = New System.Drawing.Size(382, 345)
        Me.ControlBox = False
        Me.Enabled = False
        Me.Name = "memeForm"
        Me.Text = "GG"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TimerPopupMeme As Timer
End Class
