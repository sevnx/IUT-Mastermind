<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsForm))
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.Btn_Reset = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Txt5 = New System.Windows.Forms.TextBox()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelChars = New System.Windows.Forms.Panel()
        Me.PanelColor = New System.Windows.Forms.Panel()
        Me.Btn_GoodPos = New System.Windows.Forms.Button()
        Me.Btn_Present = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Présent = New System.Windows.Forms.Label()
        Me.Btn_Absent = New System.Windows.Forms.Button()
        Me.Txt_AbsentColor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_GoodPositionColor = New System.Windows.Forms.TextBox()
        Me.Txt_PresentColor = New System.Windows.Forms.TextBox()
        Me.CheckBoxTimeLimit = New System.Windows.Forms.CheckBox()
        Me.Txt_Minute = New System.Windows.Forms.TextBox()
        Me.Lbl_min = New System.Windows.Forms.Label()
        Me.Txt_Second = New System.Windows.Forms.TextBox()
        Me.Lbl_sec = New System.Windows.Forms.Label()
        Me.Btn_PlusTime = New System.Windows.Forms.Button()
        Me.Btn_MinusTime = New System.Windows.Forms.Button()
        Me.CheckBoxPropositionLimit = New System.Windows.Forms.CheckBox()
        Me.Lbl_coups = New System.Windows.Forms.Label()
        Me.Txt_NbCoups = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_SavePath = New System.Windows.Forms.Button()
        Me.Txt_SavePath = New System.Windows.Forms.TextBox()
        Me.PanelChars.SuspendLayout()
        Me.PanelColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_Annuler.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Annuler.ForeColor = System.Drawing.Color.White
        Me.Btn_Annuler.Location = New System.Drawing.Point(341, 407)
        Me.Btn_Annuler.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(116, 43)
        Me.Btn_Annuler.TabIndex = 10
        Me.Btn_Annuler.Text = "ANNULER"
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'Btn_Reset
        '
        Me.Btn_Reset.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_Reset.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Reset.ForeColor = System.Drawing.Color.White
        Me.Btn_Reset.Location = New System.Drawing.Point(186, 407)
        Me.Btn_Reset.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Reset.Name = "Btn_Reset"
        Me.Btn_Reset.Size = New System.Drawing.Size(116, 43)
        Me.Btn_Reset.TabIndex = 9
        Me.Btn_Reset.Text = "REINITIALISER"
        Me.Btn_Reset.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_Save.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.ForeColor = System.Drawing.Color.White
        Me.Btn_Save.Location = New System.Drawing.Point(34, 407)
        Me.Btn_Save.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(116, 43)
        Me.Btn_Save.TabIndex = 8
        Me.Btn_Save.Text = "ENREGISTRER"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Txt5
        '
        Me.Txt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt5.Location = New System.Drawing.Point(332, 58)
        Me.Txt5.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt5.MaxLength = 1
        Me.Txt5.Name = "Txt5"
        Me.Txt5.Size = New System.Drawing.Size(55, 22)
        Me.Txt5.TabIndex = 4
        Me.Txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt4
        '
        Me.Txt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt4.Location = New System.Drawing.Point(257, 58)
        Me.Txt4.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt4.MaxLength = 1
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(55, 22)
        Me.Txt4.TabIndex = 3
        Me.Txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt3
        '
        Me.Txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt3.Location = New System.Drawing.Point(182, 58)
        Me.Txt3.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt3.MaxLength = 1
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(55, 22)
        Me.Txt3.TabIndex = 2
        Me.Txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt2
        '
        Me.Txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt2.Location = New System.Drawing.Point(107, 58)
        Me.Txt2.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt2.MaxLength = 1
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(55, 22)
        Me.Txt2.TabIndex = 1
        Me.Txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt1
        '
        Me.Txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt1.Location = New System.Drawing.Point(32, 58)
        Me.Txt1.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt1.MaxLength = 1
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(55, 22)
        Me.Txt1.TabIndex = 0
        Me.Txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 32)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Caractères jouables"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelChars
        '
        Me.PanelChars.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.PanelChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelChars.Controls.Add(Me.Txt1)
        Me.PanelChars.Controls.Add(Me.Label2)
        Me.PanelChars.Controls.Add(Me.Txt2)
        Me.PanelChars.Controls.Add(Me.Txt5)
        Me.PanelChars.Controls.Add(Me.Txt3)
        Me.PanelChars.Controls.Add(Me.Txt4)
        Me.PanelChars.Location = New System.Drawing.Point(34, 11)
        Me.PanelChars.Name = "PanelChars"
        Me.PanelChars.Size = New System.Drawing.Size(424, 100)
        Me.PanelChars.TabIndex = 13
        '
        'PanelColor
        '
        Me.PanelColor.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.PanelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelColor.Controls.Add(Me.Btn_GoodPos)
        Me.PanelColor.Controls.Add(Me.Btn_Present)
        Me.PanelColor.Controls.Add(Me.Label5)
        Me.PanelColor.Controls.Add(Me.Label4)
        Me.PanelColor.Controls.Add(Me.Présent)
        Me.PanelColor.Controls.Add(Me.Btn_Absent)
        Me.PanelColor.Controls.Add(Me.Txt_AbsentColor)
        Me.PanelColor.Controls.Add(Me.Label3)
        Me.PanelColor.Controls.Add(Me.Txt_GoodPositionColor)
        Me.PanelColor.Controls.Add(Me.Txt_PresentColor)
        Me.PanelColor.Location = New System.Drawing.Point(34, 117)
        Me.PanelColor.Name = "PanelColor"
        Me.PanelColor.Size = New System.Drawing.Size(424, 133)
        Me.PanelColor.TabIndex = 1
        '
        'Btn_GoodPos
        '
        Me.Btn_GoodPos.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_GoodPos.Location = New System.Drawing.Point(314, 98)
        Me.Btn_GoodPos.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_GoodPos.Name = "Btn_GoodPos"
        Me.Btn_GoodPos.Size = New System.Drawing.Size(70, 22)
        Me.Btn_GoodPos.TabIndex = 2
        Me.Btn_GoodPos.Text = "CHANGER"
        Me.Btn_GoodPos.UseVisualStyleBackColor = True
        '
        'Btn_Present
        '
        Me.Btn_Present.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Present.Location = New System.Drawing.Point(174, 98)
        Me.Btn_Present.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Present.Name = "Btn_Present"
        Me.Btn_Present.Size = New System.Drawing.Size(70, 22)
        Me.Btn_Present.TabIndex = 1
        Me.Btn_Present.Text = "CHANGER"
        Me.Btn_Present.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(298, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Bonne position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(182, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Présent"
        '
        'Présent
        '
        Me.Présent.AutoSize = True
        Me.Présent.BackColor = System.Drawing.Color.Transparent
        Me.Présent.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Présent.Location = New System.Drawing.Point(46, 52)
        Me.Présent.Name = "Présent"
        Me.Présent.Size = New System.Drawing.Size(51, 17)
        Me.Présent.TabIndex = 21
        Me.Présent.Text = "Absent"
        '
        'Btn_Absent
        '
        Me.Btn_Absent.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Absent.Location = New System.Drawing.Point(35, 98)
        Me.Btn_Absent.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Absent.Name = "Btn_Absent"
        Me.Btn_Absent.Size = New System.Drawing.Size(70, 22)
        Me.Btn_Absent.TabIndex = 0
        Me.Btn_Absent.Text = "CHANGER"
        Me.Btn_Absent.UseVisualStyleBackColor = True
        '
        'Txt_AbsentColor
        '
        Me.Txt_AbsentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_AbsentColor.Enabled = False
        Me.Txt_AbsentColor.Location = New System.Drawing.Point(35, 74)
        Me.Txt_AbsentColor.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_AbsentColor.MaxLength = 1
        Me.Txt_AbsentColor.Name = "Txt_AbsentColor"
        Me.Txt_AbsentColor.Size = New System.Drawing.Size(70, 20)
        Me.Txt_AbsentColor.TabIndex = 13
        Me.Txt_AbsentColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(153, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 32)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Couleurs"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_GoodPositionColor
        '
        Me.Txt_GoodPositionColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_GoodPositionColor.Enabled = False
        Me.Txt_GoodPositionColor.Location = New System.Drawing.Point(314, 74)
        Me.Txt_GoodPositionColor.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_GoodPositionColor.MaxLength = 1
        Me.Txt_GoodPositionColor.Name = "Txt_GoodPositionColor"
        Me.Txt_GoodPositionColor.Size = New System.Drawing.Size(70, 20)
        Me.Txt_GoodPositionColor.TabIndex = 17
        Me.Txt_GoodPositionColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_PresentColor
        '
        Me.Txt_PresentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PresentColor.Enabled = False
        Me.Txt_PresentColor.Location = New System.Drawing.Point(174, 74)
        Me.Txt_PresentColor.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_PresentColor.MaxLength = 1
        Me.Txt_PresentColor.Name = "Txt_PresentColor"
        Me.Txt_PresentColor.Size = New System.Drawing.Size(70, 20)
        Me.Txt_PresentColor.TabIndex = 15
        Me.Txt_PresentColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBoxTimeLimit
        '
        Me.CheckBoxTimeLimit.AutoSize = True
        Me.CheckBoxTimeLimit.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxTimeLimit.Checked = True
        Me.CheckBoxTimeLimit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTimeLimit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxTimeLimit.Location = New System.Drawing.Point(37, 265)
        Me.CheckBoxTimeLimit.Name = "CheckBoxTimeLimit"
        Me.CheckBoxTimeLimit.Size = New System.Drawing.Size(153, 24)
        Me.CheckBoxTimeLimit.TabIndex = 2
        Me.CheckBoxTimeLimit.Text = "Limite de temps : "
        Me.CheckBoxTimeLimit.UseVisualStyleBackColor = False
        '
        'Txt_Minute
        '
        Me.Txt_Minute.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Minute.Location = New System.Drawing.Point(187, 269)
        Me.Txt_Minute.Name = "Txt_Minute"
        Me.Txt_Minute.Size = New System.Drawing.Size(26, 19)
        Me.Txt_Minute.TabIndex = 3
        Me.Txt_Minute.Text = "0"
        Me.Txt_Minute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_min
        '
        Me.Lbl_min.AutoSize = True
        Me.Lbl_min.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_min.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_min.Location = New System.Drawing.Point(216, 268)
        Me.Lbl_min.Name = "Lbl_min"
        Me.Lbl_min.Size = New System.Drawing.Size(36, 20)
        Me.Lbl_min.TabIndex = 26
        Me.Lbl_min.Text = "min"
        '
        'Txt_Second
        '
        Me.Txt_Second.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Second.Location = New System.Drawing.Point(253, 269)
        Me.Txt_Second.Name = "Txt_Second"
        Me.Txt_Second.Size = New System.Drawing.Size(26, 19)
        Me.Txt_Second.TabIndex = 4
        Me.Txt_Second.Text = "0"
        Me.Txt_Second.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_sec
        '
        Me.Lbl_sec.AutoSize = True
        Me.Lbl_sec.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sec.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sec.Location = New System.Drawing.Point(283, 268)
        Me.Lbl_sec.Name = "Lbl_sec"
        Me.Lbl_sec.Size = New System.Drawing.Size(31, 20)
        Me.Lbl_sec.TabIndex = 28
        Me.Lbl_sec.Text = "sec"
        '
        'Btn_PlusTime
        '
        Me.Btn_PlusTime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_PlusTime.Location = New System.Drawing.Point(315, 268)
        Me.Btn_PlusTime.Name = "Btn_PlusTime"
        Me.Btn_PlusTime.Size = New System.Drawing.Size(18, 21)
        Me.Btn_PlusTime.TabIndex = 29
        Me.Btn_PlusTime.Text = "+"
        Me.Btn_PlusTime.UseVisualStyleBackColor = True
        '
        'Btn_MinusTime
        '
        Me.Btn_MinusTime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MinusTime.Location = New System.Drawing.Point(339, 268)
        Me.Btn_MinusTime.Name = "Btn_MinusTime"
        Me.Btn_MinusTime.Size = New System.Drawing.Size(18, 21)
        Me.Btn_MinusTime.TabIndex = 30
        Me.Btn_MinusTime.Text = "-"
        Me.Btn_MinusTime.UseVisualStyleBackColor = True
        '
        'CheckBoxPropositionLimit
        '
        Me.CheckBoxPropositionLimit.AutoSize = True
        Me.CheckBoxPropositionLimit.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxPropositionLimit.Checked = True
        Me.CheckBoxPropositionLimit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxPropositionLimit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPropositionLimit.Location = New System.Drawing.Point(37, 296)
        Me.CheckBoxPropositionLimit.Name = "CheckBoxPropositionLimit"
        Me.CheckBoxPropositionLimit.Size = New System.Drawing.Size(190, 24)
        Me.CheckBoxPropositionLimit.TabIndex = 5
        Me.CheckBoxPropositionLimit.Text = "Limite de proposition : "
        Me.CheckBoxPropositionLimit.UseVisualStyleBackColor = False
        '
        'Lbl_coups
        '
        Me.Lbl_coups.AutoSize = True
        Me.Lbl_coups.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_coups.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_coups.Location = New System.Drawing.Point(253, 298)
        Me.Lbl_coups.Name = "Lbl_coups"
        Me.Lbl_coups.Size = New System.Drawing.Size(50, 20)
        Me.Lbl_coups.TabIndex = 33
        Me.Lbl_coups.Text = "coups"
        '
        'Txt_NbCoups
        '
        Me.Txt_NbCoups.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NbCoups.Location = New System.Drawing.Point(224, 299)
        Me.Txt_NbCoups.Name = "Txt_NbCoups"
        Me.Txt_NbCoups.Size = New System.Drawing.Size(26, 20)
        Me.Txt_NbCoups.TabIndex = 6
        Me.Txt_NbCoups.Text = "0"
        Me.Txt_NbCoups.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 20)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Chemin vers save :"
        '
        'Btn_SavePath
        '
        Me.Btn_SavePath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SavePath.Location = New System.Drawing.Point(386, 353)
        Me.Btn_SavePath.Name = "Btn_SavePath"
        Me.Btn_SavePath.Size = New System.Drawing.Size(72, 30)
        Me.Btn_SavePath.TabIndex = 7
        Me.Btn_SavePath.Text = "Parcourir"
        Me.Btn_SavePath.UseVisualStyleBackColor = True
        '
        'Txt_SavePath
        '
        Me.Txt_SavePath.Enabled = False
        Me.Txt_SavePath.Location = New System.Drawing.Point(175, 329)
        Me.Txt_SavePath.Name = "Txt_SavePath"
        Me.Txt_SavePath.Size = New System.Drawing.Size(282, 20)
        Me.Txt_SavePath.TabIndex = 36
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(487, 464)
        Me.Controls.Add(Me.Txt_SavePath)
        Me.Controls.Add(Me.Btn_SavePath)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Lbl_coups)
        Me.Controls.Add(Me.Txt_NbCoups)
        Me.Controls.Add(Me.CheckBoxPropositionLimit)
        Me.Controls.Add(Me.Btn_MinusTime)
        Me.Controls.Add(Me.Btn_PlusTime)
        Me.Controls.Add(Me.Lbl_sec)
        Me.Controls.Add(Me.Txt_Second)
        Me.Controls.Add(Me.Lbl_min)
        Me.Controls.Add(Me.Txt_Minute)
        Me.Controls.Add(Me.CheckBoxTimeLimit)
        Me.Controls.Add(Me.PanelColor)
        Me.Controls.Add(Me.PanelChars)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.Btn_Reset)
        Me.Controls.Add(Me.Btn_Annuler)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "OptionsForm"
        Me.Text = "Options"
        Me.PanelChars.ResumeLayout(False)
        Me.PanelChars.PerformLayout()
        Me.PanelColor.ResumeLayout(False)
        Me.PanelColor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Annuler As Button
    Friend WithEvents Btn_Reset As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Txt5 As TextBox
    Friend WithEvents Txt4 As TextBox
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelChars As Panel
    Friend WithEvents PanelColor As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Présent As Label
    Friend WithEvents Btn_Absent As Button
    Friend WithEvents Txt_AbsentColor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_GoodPositionColor As TextBox
    Friend WithEvents Txt_PresentColor As TextBox
    Friend WithEvents Btn_GoodPos As Button
    Friend WithEvents Btn_Present As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBoxTimeLimit As CheckBox
    Friend WithEvents Txt_Minute As TextBox
    Friend WithEvents Lbl_min As Label
    Friend WithEvents Txt_Second As TextBox
    Friend WithEvents Lbl_sec As Label
    Friend WithEvents Btn_PlusTime As Button
    Friend WithEvents Btn_MinusTime As Button
    Friend WithEvents CheckBoxPropositionLimit As CheckBox
    Friend WithEvents Lbl_coups As Label
    Friend WithEvents Txt_NbCoups As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_SavePath As Button
    Friend WithEvents Txt_SavePath As TextBox
End Class
