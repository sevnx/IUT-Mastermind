<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MastermindGameForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MastermindGameForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Submit_Answer = New System.Windows.Forms.Button()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        Me.Lbl_Playable = New System.Windows.Forms.Label()
        Me.CharJouable = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CodeColor = New System.Windows.Forms.Label()
        Me.Present = New System.Windows.Forms.Label()
        Me.PresentBien = New System.Windows.Forms.Label()
        Me.PrecedentEssais = New System.Windows.Forms.Label()
        Me.Btn_Replay = New System.Windows.Forms.Button()
        Me.Label_Result = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Txt5 = New System.Windows.Forms.TextBox()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Btn_Quit = New System.Windows.Forms.Button()
        Me.Btn_GoUpTries = New System.Windows.Forms.Button()
        Me.Btn_GoDownTries = New System.Windows.Forms.Button()
        Me.PanelChars = New System.Windows.Forms.Panel()
        Me.PanelColors = New System.Windows.Forms.Panel()
        Me.PanelGoodPlacement = New System.Windows.Forms.Panel()
        Me.PanelPresent = New System.Windows.Forms.Panel()
        Me.PanelAbsent = New System.Windows.Forms.Panel()
        Me.PanelHistory = New System.Windows.Forms.Panel()
        Me.PanelGuess = New System.Windows.Forms.Panel()
        Me.PanelTitleAndTime = New System.Windows.Forms.Panel()
        Me.PanelChars.SuspendLayout()
        Me.PanelColors.SuspendLayout()
        Me.PanelHistory.SuspendLayout()
        Me.PanelGuess.SuspendLayout()
        Me.PanelTitleAndTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Master Mind"
        '
        'Btn_Submit_Answer
        '
        Me.Btn_Submit_Answer.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_Submit_Answer.ForeColor = System.Drawing.Color.White
        Me.Btn_Submit_Answer.Location = New System.Drawing.Point(325, 11)
        Me.Btn_Submit_Answer.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Submit_Answer.Name = "Btn_Submit_Answer"
        Me.Btn_Submit_Answer.Size = New System.Drawing.Size(98, 38)
        Me.Btn_Submit_Answer.TabIndex = 5
        Me.Btn_Submit_Answer.Text = "Guess"
        Me.Btn_Submit_Answer.UseVisualStyleBackColor = True
        '
        'Txt4
        '
        Me.Txt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt4.Location = New System.Drawing.Point(201, 11)
        Me.Txt4.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt4.MaxLength = 1
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(45, 38)
        Me.Txt4.TabIndex = 3
        Me.Txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_Playable
        '
        Me.Lbl_Playable.AutoSize = True
        Me.Lbl_Playable.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Playable.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Playable.Location = New System.Drawing.Point(31, 37)
        Me.Lbl_Playable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Playable.Name = "Lbl_Playable"
        Me.Lbl_Playable.Size = New System.Drawing.Size(107, 40)
        Me.Lbl_Playable.TabIndex = 14
        Me.Lbl_Playable.Text = "Label3"
        Me.Lbl_Playable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CharJouable
        '
        Me.CharJouable.BackColor = System.Drawing.Color.Transparent
        Me.CharJouable.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharJouable.Location = New System.Drawing.Point(7, 5)
        Me.CharJouable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CharJouable.Name = "CharJouable"
        Me.CharJouable.Size = New System.Drawing.Size(167, 30)
        Me.CharJouable.TabIndex = 13
        Me.CharJouable.Text = "Caractères jouables"
        Me.CharJouable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Absent"
        '
        'CodeColor
        '
        Me.CodeColor.AutoSize = True
        Me.CodeColor.BackColor = System.Drawing.Color.Transparent
        Me.CodeColor.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeColor.Location = New System.Drawing.Point(34, 11)
        Me.CodeColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CodeColor.Name = "CodeColor"
        Me.CodeColor.Size = New System.Drawing.Size(115, 23)
        Me.CodeColor.TabIndex = 15
        Me.CodeColor.Text = "Code couleur"
        '
        'Present
        '
        Me.Present.AutoSize = True
        Me.Present.BackColor = System.Drawing.Color.Transparent
        Me.Present.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Present.Location = New System.Drawing.Point(50, 73)
        Me.Present.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Present.Name = "Present"
        Me.Present.Size = New System.Drawing.Size(46, 13)
        Me.Present.TabIndex = 18
        Me.Present.Text = "Présent"
        '
        'PresentBien
        '
        Me.PresentBien.AutoSize = True
        Me.PresentBien.BackColor = System.Drawing.Color.Transparent
        Me.PresentBien.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PresentBien.Location = New System.Drawing.Point(50, 101)
        Me.PresentBien.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PresentBien.Name = "PresentBien"
        Me.PresentBien.Size = New System.Drawing.Size(115, 13)
        Me.PresentBien.TabIndex = 19
        Me.PresentBien.Text = "Présent et Bien Placé"
        '
        'PrecedentEssais
        '
        Me.PrecedentEssais.AutoSize = True
        Me.PrecedentEssais.BackColor = System.Drawing.Color.Transparent
        Me.PrecedentEssais.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecedentEssais.Location = New System.Drawing.Point(39, 1)
        Me.PrecedentEssais.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PrecedentEssais.Name = "PrecedentEssais"
        Me.PrecedentEssais.Size = New System.Drawing.Size(164, 25)
        Me.PrecedentEssais.TabIndex = 20
        Me.PrecedentEssais.Text = "Précédents essais"
        '
        'Btn_Replay
        '
        Me.Btn_Replay.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_Replay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Replay.ForeColor = System.Drawing.Color.White
        Me.Btn_Replay.Location = New System.Drawing.Point(260, 371)
        Me.Btn_Replay.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Replay.Name = "Btn_Replay"
        Me.Btn_Replay.Size = New System.Drawing.Size(182, 66)
        Me.Btn_Replay.TabIndex = 22
        Me.Btn_Replay.Text = "RETOURNER À " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L'ECRAN TITRE"
        Me.Btn_Replay.UseVisualStyleBackColor = True
        '
        'Label_Result
        '
        Me.Label_Result.AutoSize = True
        Me.Label_Result.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Result.Location = New System.Drawing.Point(9, 17)
        Me.Label_Result.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Result.Name = "Label_Result"
        Me.Label_Result.Size = New System.Drawing.Size(65, 30)
        Me.Label_Result.TabIndex = 23
        Me.Label_Result.Text = "Label"
        Me.Label_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Result.Visible = False
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.TimeLabel.Location = New System.Drawing.Point(21, 37)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(39, 13)
        Me.TimeLabel.TabIndex = 28
        Me.TimeLabel.Text = "Label2"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt3
        '
        Me.Txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt3.Location = New System.Drawing.Point(136, 11)
        Me.Txt3.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt3.MaxLength = 1
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(45, 38)
        Me.Txt3.TabIndex = 2
        Me.Txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt5
        '
        Me.Txt5.BackColor = System.Drawing.SystemColors.Window
        Me.Txt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt5.Location = New System.Drawing.Point(266, 11)
        Me.Txt5.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt5.MaxLength = 1
        Me.Txt5.Name = "Txt5"
        Me.Txt5.Size = New System.Drawing.Size(45, 38)
        Me.Txt5.TabIndex = 4
        Me.Txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt1
        '
        Me.Txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt1.Location = New System.Drawing.Point(9, 11)
        Me.Txt1.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt1.MaxLength = 1
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(45, 38)
        Me.Txt1.TabIndex = 0
        Me.Txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt2
        '
        Me.Txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt2.Location = New System.Drawing.Point(73, 11)
        Me.Txt2.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt2.MaxLength = 1
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(45, 38)
        Me.Txt2.TabIndex = 1
        Me.Txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_Quit
        '
        Me.Btn_Quit.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_Quit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Quit.ForeColor = System.Drawing.Color.White
        Me.Btn_Quit.Location = New System.Drawing.Point(260, 441)
        Me.Btn_Quit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Quit.Name = "Btn_Quit"
        Me.Btn_Quit.Size = New System.Drawing.Size(182, 58)
        Me.Btn_Quit.TabIndex = 29
        Me.Btn_Quit.Text = "QUITTER"
        Me.Btn_Quit.UseVisualStyleBackColor = True
        '
        'Btn_GoUpTries
        '
        Me.Btn_GoUpTries.Location = New System.Drawing.Point(201, 141)
        Me.Btn_GoUpTries.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_GoUpTries.Name = "Btn_GoUpTries"
        Me.Btn_GoUpTries.Size = New System.Drawing.Size(30, 30)
        Me.Btn_GoUpTries.TabIndex = 0
        Me.Btn_GoUpTries.Text = "▲"
        Me.Btn_GoUpTries.UseVisualStyleBackColor = True
        '
        'Btn_GoDownTries
        '
        Me.Btn_GoDownTries.Location = New System.Drawing.Point(201, 175)
        Me.Btn_GoDownTries.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_GoDownTries.Name = "Btn_GoDownTries"
        Me.Btn_GoDownTries.Size = New System.Drawing.Size(30, 30)
        Me.Btn_GoDownTries.TabIndex = 31
        Me.Btn_GoDownTries.Text = "▼"
        Me.Btn_GoDownTries.UseVisualStyleBackColor = True
        '
        'PanelChars
        '
        Me.PanelChars.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.PanelChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelChars.Controls.Add(Me.CharJouable)
        Me.PanelChars.Controls.Add(Me.Lbl_Playable)
        Me.PanelChars.Location = New System.Drawing.Point(260, 130)
        Me.PanelChars.Name = "PanelChars"
        Me.PanelChars.Size = New System.Drawing.Size(182, 92)
        Me.PanelChars.TabIndex = 32
        '
        'PanelColors
        '
        Me.PanelColors.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.PanelColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelColors.Controls.Add(Me.PanelGoodPlacement)
        Me.PanelColors.Controls.Add(Me.PanelPresent)
        Me.PanelColors.Controls.Add(Me.PanelAbsent)
        Me.PanelColors.Controls.Add(Me.CodeColor)
        Me.PanelColors.Controls.Add(Me.Label4)
        Me.PanelColors.Controls.Add(Me.Present)
        Me.PanelColors.Controls.Add(Me.PresentBien)
        Me.PanelColors.Location = New System.Drawing.Point(260, 233)
        Me.PanelColors.Name = "PanelColors"
        Me.PanelColors.Size = New System.Drawing.Size(182, 133)
        Me.PanelColors.TabIndex = 33
        '
        'PanelGoodPlacement
        '
        Me.PanelGoodPlacement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelGoodPlacement.Location = New System.Drawing.Point(19, 102)
        Me.PanelGoodPlacement.Name = "PanelGoodPlacement"
        Me.PanelGoodPlacement.Size = New System.Drawing.Size(24, 13)
        Me.PanelGoodPlacement.TabIndex = 21
        '
        'PanelPresent
        '
        Me.PanelPresent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPresent.Location = New System.Drawing.Point(19, 74)
        Me.PanelPresent.Name = "PanelPresent"
        Me.PanelPresent.Size = New System.Drawing.Size(24, 13)
        Me.PanelPresent.TabIndex = 21
        '
        'PanelAbsent
        '
        Me.PanelAbsent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAbsent.Location = New System.Drawing.Point(19, 47)
        Me.PanelAbsent.Name = "PanelAbsent"
        Me.PanelAbsent.Size = New System.Drawing.Size(24, 13)
        Me.PanelAbsent.TabIndex = 20
        '
        'PanelHistory
        '
        Me.PanelHistory.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.PanelHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelHistory.Controls.Add(Me.PrecedentEssais)
        Me.PanelHistory.Controls.Add(Me.Btn_GoUpTries)
        Me.PanelHistory.Controls.Add(Me.Btn_GoDownTries)
        Me.PanelHistory.Location = New System.Drawing.Point(8, 130)
        Me.PanelHistory.Name = "PanelHistory"
        Me.PanelHistory.Size = New System.Drawing.Size(245, 368)
        Me.PanelHistory.TabIndex = 0
        '
        'PanelGuess
        '
        Me.PanelGuess.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.PanelGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelGuess.Controls.Add(Me.Txt5)
        Me.PanelGuess.Controls.Add(Me.Txt4)
        Me.PanelGuess.Controls.Add(Me.Txt3)
        Me.PanelGuess.Controls.Add(Me.Txt2)
        Me.PanelGuess.Controls.Add(Me.Btn_Submit_Answer)
        Me.PanelGuess.Controls.Add(Me.Txt1)
        Me.PanelGuess.Location = New System.Drawing.Point(8, 60)
        Me.PanelGuess.Name = "PanelGuess"
        Me.PanelGuess.Size = New System.Drawing.Size(434, 61)
        Me.PanelGuess.TabIndex = 0
        '
        'PanelTitleAndTime
        '
        Me.PanelTitleAndTime.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.PanelTitleAndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTitleAndTime.Controls.Add(Me.TimeLabel)
        Me.PanelTitleAndTime.Controls.Add(Me.Label1)
        Me.PanelTitleAndTime.Location = New System.Drawing.Point(155, -9)
        Me.PanelTitleAndTime.Name = "PanelTitleAndTime"
        Me.PanelTitleAndTime.Size = New System.Drawing.Size(166, 59)
        Me.PanelTitleAndTime.TabIndex = 29
        '
        'MastermindGameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.ClientSize = New System.Drawing.Size(450, 507)
        Me.Controls.Add(Me.PanelTitleAndTime)
        Me.Controls.Add(Me.PanelGuess)
        Me.Controls.Add(Me.Label_Result)
        Me.Controls.Add(Me.PanelHistory)
        Me.Controls.Add(Me.PanelColors)
        Me.Controls.Add(Me.PanelChars)
        Me.Controls.Add(Me.Btn_Quit)
        Me.Controls.Add(Me.Btn_Replay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MastermindGameForm"
        Me.Text = "SS"
        Me.PanelChars.ResumeLayout(False)
        Me.PanelChars.PerformLayout()
        Me.PanelColors.ResumeLayout(False)
        Me.PanelColors.PerformLayout()
        Me.PanelHistory.ResumeLayout(False)
        Me.PanelHistory.PerformLayout()
        Me.PanelGuess.ResumeLayout(False)
        Me.PanelGuess.PerformLayout()
        Me.PanelTitleAndTime.ResumeLayout(False)
        Me.PanelTitleAndTime.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Submit_Answer As Button
    Friend WithEvents Txt4 As TextBox
    Friend WithEvents Lbl_Playable As Label
    Friend WithEvents CharJouable As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CodeColor As Label
    Friend WithEvents Present As Label
    Friend WithEvents PresentBien As Label
    Friend WithEvents PrecedentEssais As Label
    Friend WithEvents Btn_Replay As Button
    Friend WithEvents Label_Result As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Txt5 As TextBox
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Btn_Quit As Button
    Friend WithEvents Btn_GoUpTries As Button
    Friend WithEvents Btn_GoDownTries As Button
    Friend WithEvents PanelChars As Panel
    Friend WithEvents PanelColors As Panel
    Friend WithEvents PanelGoodPlacement As Panel
    Friend WithEvents PanelPresent As Panel
    Friend WithEvents PanelAbsent As Panel
    Friend WithEvents PanelHistory As Panel
    Friend WithEvents PanelGuess As Panel
    Friend WithEvents PanelTitleAndTime As Panel
End Class
