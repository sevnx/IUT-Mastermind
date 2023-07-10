<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorPickerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ColorPickerForm))
        Me.HScroll_R = New System.Windows.Forms.HScrollBar()
        Me.Txt_R = New System.Windows.Forms.TextBox()
        Me.Txt_G = New System.Windows.Forms.TextBox()
        Me.HScroll_G = New System.Windows.Forms.HScrollBar()
        Me.Txt_B = New System.Windows.Forms.TextBox()
        Me.HScroll_B = New System.Windows.Forms.HScrollBar()
        Me.LabelR = New System.Windows.Forms.Label()
        Me.LabelG = New System.Windows.Forms.Label()
        Me.LabelB = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelColor = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Hex = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelPredefined = New System.Windows.Forms.Panel()
        Me.PanelFusionMauve = New System.Windows.Forms.Panel()
        Me.PanelOrange = New System.Windows.Forms.Panel()
        Me.PanelYellow = New System.Windows.Forms.Panel()
        Me.PanelBlue = New System.Windows.Forms.Panel()
        Me.PanelGreen = New System.Windows.Forms.Panel()
        Me.PanelWhite = New System.Windows.Forms.Panel()
        Me.PanelBlack = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_Confirm = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.PanelPredefined.SuspendLayout()
        Me.SuspendLayout()
        '
        'HScroll_R
        '
        Me.HScroll_R.LargeChange = 1
        Me.HScroll_R.Location = New System.Drawing.Point(58, 23)
        Me.HScroll_R.Maximum = 255
        Me.HScroll_R.Name = "HScroll_R"
        Me.HScroll_R.Size = New System.Drawing.Size(310, 38)
        Me.HScroll_R.TabIndex = 0
        Me.HScroll_R.TabStop = True
        '
        'Txt_R
        '
        Me.Txt_R.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_R.Location = New System.Drawing.Point(386, 24)
        Me.Txt_R.MaxLength = 3
        Me.Txt_R.Name = "Txt_R"
        Me.Txt_R.Size = New System.Drawing.Size(65, 37)
        Me.Txt_R.TabIndex = 1
        '
        'Txt_G
        '
        Me.Txt_G.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_G.Location = New System.Drawing.Point(386, 87)
        Me.Txt_G.MaxLength = 3
        Me.Txt_G.Name = "Txt_G"
        Me.Txt_G.Size = New System.Drawing.Size(65, 37)
        Me.Txt_G.TabIndex = 3
        '
        'HScroll_G
        '
        Me.HScroll_G.LargeChange = 1
        Me.HScroll_G.Location = New System.Drawing.Point(58, 86)
        Me.HScroll_G.Maximum = 255
        Me.HScroll_G.Name = "HScroll_G"
        Me.HScroll_G.Size = New System.Drawing.Size(310, 39)
        Me.HScroll_G.TabIndex = 2
        '
        'Txt_B
        '
        Me.Txt_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_B.Location = New System.Drawing.Point(386, 157)
        Me.Txt_B.MaxLength = 3
        Me.Txt_B.Name = "Txt_B"
        Me.Txt_B.Size = New System.Drawing.Size(65, 37)
        Me.Txt_B.TabIndex = 5
        '
        'HScroll_B
        '
        Me.HScroll_B.LargeChange = 1
        Me.HScroll_B.Location = New System.Drawing.Point(58, 156)
        Me.HScroll_B.Maximum = 255
        Me.HScroll_B.Name = "HScroll_B"
        Me.HScroll_B.Size = New System.Drawing.Size(310, 39)
        Me.HScroll_B.TabIndex = 4
        '
        'LabelR
        '
        Me.LabelR.AutoSize = True
        Me.LabelR.BackColor = System.Drawing.Color.Transparent
        Me.LabelR.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelR.Location = New System.Drawing.Point(19, 21)
        Me.LabelR.Name = "LabelR"
        Me.LabelR.Size = New System.Drawing.Size(35, 37)
        Me.LabelR.TabIndex = 6
        Me.LabelR.Text = "R"
        '
        'LabelG
        '
        Me.LabelG.AutoSize = True
        Me.LabelG.BackColor = System.Drawing.Color.Transparent
        Me.LabelG.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelG.Location = New System.Drawing.Point(18, 85)
        Me.LabelG.Name = "LabelG"
        Me.LabelG.Size = New System.Drawing.Size(36, 37)
        Me.LabelG.TabIndex = 7
        Me.LabelG.Text = "G"
        '
        'LabelB
        '
        Me.LabelB.AutoSize = True
        Me.LabelB.BackColor = System.Drawing.Color.Transparent
        Me.LabelB.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelB.Location = New System.Drawing.Point(19, 155)
        Me.LabelB.Name = "LabelB"
        Me.LabelB.Size = New System.Drawing.Size(34, 37)
        Me.LabelB.TabIndex = 8
        Me.LabelB.Text = "B"
        Me.LabelB.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(496, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 45)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "COULEUR"
        '
        'PanelColor
        '
        Me.PanelColor.Location = New System.Drawing.Point(510, 180)
        Me.PanelColor.Name = "PanelColor"
        Me.PanelColor.Size = New System.Drawing.Size(131, 127)
        Me.PanelColor.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(539, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 45)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "HEX"
        '
        'Txt_Hex
        '
        Me.Txt_Hex.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Hex.Location = New System.Drawing.Point(510, 65)
        Me.Txt_Hex.MaxLength = 6
        Me.Txt_Hex.Name = "Txt_Hex"
        Me.Txt_Hex.Size = New System.Drawing.Size(132, 37)
        Me.Txt_Hex.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.Panel2.Controls.Add(Me.Txt_R)
        Me.Panel2.Controls.Add(Me.HScroll_R)
        Me.Panel2.Controls.Add(Me.LabelR)
        Me.Panel2.Controls.Add(Me.HScroll_G)
        Me.Panel2.Controls.Add(Me.Txt_G)
        Me.Panel2.Controls.Add(Me.LabelB)
        Me.Panel2.Controls.Add(Me.LabelG)
        Me.Panel2.Controls.Add(Me.Txt_B)
        Me.Panel2.Controls.Add(Me.HScroll_B)
        Me.Panel2.Location = New System.Drawing.Point(12, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 215)
        Me.Panel2.TabIndex = 13
        '
        'PanelPredefined
        '
        Me.PanelPredefined.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.PanelPredefined.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelPredefined.Controls.Add(Me.PanelFusionMauve)
        Me.PanelPredefined.Controls.Add(Me.PanelOrange)
        Me.PanelPredefined.Controls.Add(Me.PanelYellow)
        Me.PanelPredefined.Controls.Add(Me.PanelBlue)
        Me.PanelPredefined.Controls.Add(Me.PanelGreen)
        Me.PanelPredefined.Controls.Add(Me.PanelWhite)
        Me.PanelPredefined.Controls.Add(Me.PanelBlack)
        Me.PanelPredefined.Controls.Add(Me.Label5)
        Me.PanelPredefined.Location = New System.Drawing.Point(12, 12)
        Me.PanelPredefined.Name = "PanelPredefined"
        Me.PanelPredefined.Size = New System.Drawing.Size(478, 110)
        Me.PanelPredefined.TabIndex = 2
        '
        'PanelFusionMauve
        '
        Me.PanelFusionMauve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFusionMauve.Location = New System.Drawing.Point(410, 52)
        Me.PanelFusionMauve.Name = "PanelFusionMauve"
        Me.PanelFusionMauve.Size = New System.Drawing.Size(48, 37)
        Me.PanelFusionMauve.TabIndex = 2
        '
        'PanelOrange
        '
        Me.PanelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelOrange.Location = New System.Drawing.Point(342, 52)
        Me.PanelOrange.Name = "PanelOrange"
        Me.PanelOrange.Size = New System.Drawing.Size(48, 37)
        Me.PanelOrange.TabIndex = 2
        '
        'PanelYellow
        '
        Me.PanelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelYellow.Location = New System.Drawing.Point(277, 52)
        Me.PanelYellow.Name = "PanelYellow"
        Me.PanelYellow.Size = New System.Drawing.Size(48, 37)
        Me.PanelYellow.TabIndex = 2
        '
        'PanelBlue
        '
        Me.PanelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBlue.Location = New System.Drawing.Point(214, 52)
        Me.PanelBlue.Name = "PanelBlue"
        Me.PanelBlue.Size = New System.Drawing.Size(48, 37)
        Me.PanelBlue.TabIndex = 2
        '
        'PanelGreen
        '
        Me.PanelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelGreen.Location = New System.Drawing.Point(150, 52)
        Me.PanelGreen.Name = "PanelGreen"
        Me.PanelGreen.Size = New System.Drawing.Size(48, 37)
        Me.PanelGreen.TabIndex = 7
        '
        'PanelWhite
        '
        Me.PanelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelWhite.Location = New System.Drawing.Point(85, 52)
        Me.PanelWhite.Name = "PanelWhite"
        Me.PanelWhite.Size = New System.Drawing.Size(48, 37)
        Me.PanelWhite.TabIndex = 2
        '
        'PanelBlack
        '
        Me.PanelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBlack.Location = New System.Drawing.Point(20, 52)
        Me.PanelBlack.Name = "PanelBlack"
        Me.PanelBlack.Size = New System.Drawing.Size(48, 37)
        Me.PanelBlack.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Couleurs prédéfinies"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Confirm
        '
        Me.Btn_Confirm.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Confirm.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_Confirm.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Confirm.ForeColor = System.Drawing.Color.White
        Me.Btn_Confirm.Location = New System.Drawing.Point(510, 316)
        Me.Btn_Confirm.Name = "Btn_Confirm"
        Me.Btn_Confirm.Size = New System.Drawing.Size(131, 40)
        Me.Btn_Confirm.TabIndex = 0
        Me.Btn_Confirm.Text = "ENREGISTRER"
        Me.Btn_Confirm.UseVisualStyleBackColor = False
        '
        'ColorPickerForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.ClientSize = New System.Drawing.Size(659, 370)
        Me.Controls.Add(Me.Btn_Confirm)
        Me.Controls.Add(Me.PanelPredefined)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Txt_Hex)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PanelColor)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ColorPickerForm"
        Me.Text = "ColorPicker"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelPredefined.ResumeLayout(False)
        Me.PanelPredefined.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HScroll_R As HScrollBar
    Friend WithEvents Txt_R As TextBox
    Friend WithEvents Txt_G As TextBox
    Friend WithEvents HScroll_G As HScrollBar
    Friend WithEvents Txt_B As TextBox
    Friend WithEvents HScroll_B As HScrollBar
    Friend WithEvents LabelR As Label
    Friend WithEvents LabelG As Label
    Friend WithEvents LabelB As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelColor As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Hex As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelPredefined As Panel
    Friend WithEvents Btn_Confirm As Button
    Friend WithEvents PanelFusionMauve As Panel
    Friend WithEvents PanelOrange As Panel
    Friend WithEvents PanelYellow As Panel
    Friend WithEvents PanelBlue As Panel
    Friend WithEvents PanelGreen As Panel
    Friend WithEvents PanelWhite As Panel
    Friend WithEvents PanelBlack As Panel
    Friend WithEvents Label5 As Label
End Class
