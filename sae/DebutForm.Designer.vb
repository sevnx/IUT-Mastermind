<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DebutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DebutForm))
        Me.Btn_Play = New System.Windows.Forms.Button()
        Me.Btn_Scores = New System.Windows.Forms.Button()
        Me.Btn_Quit = New System.Windows.Forms.Button()
        Me.Cbx_Chooser = New System.Windows.Forms.ComboBox()
        Me.Cbx_Guesser = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_Options = New System.Windows.Forms.Button()
        Me.Btn_Help = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Play
        '
        Me.Btn_Play.BackgroundImage = Global.sae.My.Resources.Resources.paper
        Me.Btn_Play.Font = New System.Drawing.Font("Segoe UI", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Play.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Btn_Play.Location = New System.Drawing.Point(20, 115)
        Me.Btn_Play.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Play.Name = "Btn_Play"
        Me.Btn_Play.Size = New System.Drawing.Size(509, 140)
        Me.Btn_Play.TabIndex = 2
        Me.Btn_Play.Text = "JOUER"
        Me.Btn_Play.UseVisualStyleBackColor = True
        '
        'Btn_Scores
        '
        Me.Btn_Scores.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_Scores.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Scores.ForeColor = System.Drawing.Color.White
        Me.Btn_Scores.Location = New System.Drawing.Point(201, 275)
        Me.Btn_Scores.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Scores.Name = "Btn_Scores"
        Me.Btn_Scores.Size = New System.Drawing.Size(148, 45)
        Me.Btn_Scores.TabIndex = 4
        Me.Btn_Scores.Text = "SCORES"
        Me.Btn_Scores.UseVisualStyleBackColor = True
        '
        'Btn_Quit
        '
        Me.Btn_Quit.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_Quit.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Quit.ForeColor = System.Drawing.Color.White
        Me.Btn_Quit.Location = New System.Drawing.Point(382, 275)
        Me.Btn_Quit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Quit.Name = "Btn_Quit"
        Me.Btn_Quit.Size = New System.Drawing.Size(148, 45)
        Me.Btn_Quit.TabIndex = 5
        Me.Btn_Quit.Text = "QUITTER"
        Me.Btn_Quit.UseVisualStyleBackColor = True
        '
        'Cbx_Chooser
        '
        Me.Cbx_Chooser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cbx_Chooser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Chooser.FormattingEnabled = True
        Me.Cbx_Chooser.Location = New System.Drawing.Point(47, 77)
        Me.Cbx_Chooser.Margin = New System.Windows.Forms.Padding(2)
        Me.Cbx_Chooser.Name = "Cbx_Chooser"
        Me.Cbx_Chooser.Size = New System.Drawing.Size(182, 21)
        Me.Cbx_Chooser.TabIndex = 0
        '
        'Cbx_Guesser
        '
        Me.Cbx_Guesser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cbx_Guesser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Guesser.FormattingEnabled = True
        Me.Cbx_Guesser.Location = New System.Drawing.Point(320, 77)
        Me.Cbx_Guesser.Margin = New System.Windows.Forms.Padding(2)
        Me.Cbx_Guesser.Name = "Cbx_Guesser"
        Me.Cbx_Guesser.Size = New System.Drawing.Size(182, 21)
        Me.Cbx_Guesser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(81, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "JOUEUR 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(351, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "JOUEUR 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(57, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sélectionneur de combinaison"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(387, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Devineur"
        '
        'Btn_Options
        '
        Me.Btn_Options.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_Options.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Options.ForeColor = System.Drawing.Color.White
        Me.Btn_Options.Location = New System.Drawing.Point(20, 275)
        Me.Btn_Options.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Options.Name = "Btn_Options"
        Me.Btn_Options.Size = New System.Drawing.Size(148, 45)
        Me.Btn_Options.TabIndex = 3
        Me.Btn_Options.Text = "OPTIONS"
        Me.Btn_Options.UseVisualStyleBackColor = True
        '
        'Btn_Help
        '
        Me.Btn_Help.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Help.Location = New System.Drawing.Point(523, 11)
        Me.Btn_Help.Name = "Btn_Help"
        Me.Btn_Help.Size = New System.Drawing.Size(24, 23)
        Me.Btn_Help.TabIndex = 9
        Me.Btn_Help.Text = "?"
        Me.Btn_Help.UseVisualStyleBackColor = True
        '
        'DebutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(557, 341)
        Me.Controls.Add(Me.Btn_Help)
        Me.Controls.Add(Me.Btn_Options)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cbx_Guesser)
        Me.Controls.Add(Me.Cbx_Chooser)
        Me.Controls.Add(Me.Btn_Quit)
        Me.Controls.Add(Me.Btn_Scores)
        Me.Controls.Add(Me.Btn_Play)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "DebutForm"
        Me.Text = "Master Mind"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Play As Button
    Friend WithEvents Btn_Scores As Button
    Friend WithEvents Btn_Quit As Button
    Friend WithEvents Cbx_Chooser As ComboBox
    Friend WithEvents Cbx_Guesser As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_Options As Button
    Friend WithEvents Btn_Help As Button
End Class
