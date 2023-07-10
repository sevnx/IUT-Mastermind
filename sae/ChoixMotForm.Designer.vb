<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChoixMotForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChoixMotForm))
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_MakeGuess = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Playable = New System.Windows.Forms.Label()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        Me.Txt5 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt1
        '
        Me.Txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt1.Location = New System.Drawing.Point(61, 82)
        Me.Txt1.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt1.MaxLength = 1
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(55, 20)
        Me.Txt1.TabIndex = 0
        Me.Txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(93, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Mind"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_MakeGuess
        '
        Me.Btn_MakeGuess.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_MakeGuess.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.Btn_MakeGuess.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MakeGuess.ForeColor = System.Drawing.Color.Black
        Me.Btn_MakeGuess.Location = New System.Drawing.Point(30, 119)
        Me.Btn_MakeGuess.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_MakeGuess.Name = "Btn_MakeGuess"
        Me.Btn_MakeGuess.Size = New System.Drawing.Size(205, 92)
        Me.Btn_MakeGuess.TabIndex = 5
        Me.Btn_MakeGuess.Text = "FAIRE DEVINER"
        Me.Btn_MakeGuess.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Caractères jouables"
        '
        'Lbl_Playable
        '
        Me.Lbl_Playable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Playable.AutoSize = True
        Me.Lbl_Playable.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Playable.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Playable.Location = New System.Drawing.Point(37, 41)
        Me.Lbl_Playable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Playable.Name = "Lbl_Playable"
        Me.Lbl_Playable.Size = New System.Drawing.Size(88, 32)
        Me.Lbl_Playable.TabIndex = 8
        Me.Lbl_Playable.Text = "Label3"
        Me.Lbl_Playable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt2
        '
        Me.Txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt2.Location = New System.Drawing.Point(136, 82)
        Me.Txt2.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt2.MaxLength = 1
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(55, 20)
        Me.Txt2.TabIndex = 1
        Me.Txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt3
        '
        Me.Txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt3.Location = New System.Drawing.Point(209, 82)
        Me.Txt3.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt3.MaxLength = 1
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(55, 20)
        Me.Txt3.TabIndex = 2
        Me.Txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt4
        '
        Me.Txt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt4.Location = New System.Drawing.Point(283, 82)
        Me.Txt4.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt4.MaxLength = 1
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(55, 20)
        Me.Txt4.TabIndex = 3
        Me.Txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt5
        '
        Me.Txt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt5.Location = New System.Drawing.Point(356, 82)
        Me.Txt5.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt5.MaxLength = 1
        Me.Txt5.Name = "Txt5"
        Me.Txt5.Size = New System.Drawing.Size(55, 20)
        Me.Txt5.TabIndex = 4
        Me.Txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Lbl_Playable)
        Me.Panel1.Location = New System.Drawing.Point(263, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 92)
        Me.Panel1.TabIndex = 13
        '
        'ChoixMotForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.ClientSize = New System.Drawing.Size(466, 223)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txt5)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Btn_MakeGuess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ChoixMotForm"
        Me.Text = "Pattern à deviner"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_MakeGuess As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_Playable As Label
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Txt4 As TextBox
    Friend WithEvents Txt5 As TextBox
    Friend WithEvents Panel1 As Panel
End Class
