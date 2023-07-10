<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatsForm))
        Me.DataGrid_PlayerStats = New System.Windows.Forms.DataGridView()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Score = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeilleurTemps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NbDevineur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NbSelect = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TempsTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cbx_PlayerInfo = New System.Windows.Forms.ComboBox()
        Me.Btn_NameSort = New System.Windows.Forms.Button()
        Me.Btn_ScoreSort = New System.Windows.Forms.Button()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.Btn_TimeSort = New System.Windows.Forms.Button()
        CType(Me.DataGrid_PlayerStats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid_PlayerStats
        '
        Me.DataGrid_PlayerStats.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid_PlayerStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_PlayerStats.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom, Me.Score, Me.MeilleurTemps, Me.NbDevineur, Me.NbSelect, Me.TempsTotal})
        Me.DataGrid_PlayerStats.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGrid_PlayerStats.Location = New System.Drawing.Point(20, 58)
        Me.DataGrid_PlayerStats.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGrid_PlayerStats.Name = "DataGrid_PlayerStats"
        Me.DataGrid_PlayerStats.RowHeadersWidth = 51
        Me.DataGrid_PlayerStats.RowTemplate.Height = 24
        Me.DataGrid_PlayerStats.Size = New System.Drawing.Size(584, 382)
        Me.DataGrid_PlayerStats.TabIndex = 0
        '
        'Nom
        '
        Me.Nom.FillWeight = 50.0!
        Me.Nom.HeaderText = "Nom"
        Me.Nom.MinimumWidth = 6
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        Me.Nom.Width = 70
        '
        'Score
        '
        Me.Score.FillWeight = 50.0!
        Me.Score.HeaderText = "Score"
        Me.Score.MinimumWidth = 6
        Me.Score.Name = "Score"
        Me.Score.ReadOnly = True
        Me.Score.Width = 50
        '
        'MeilleurTemps
        '
        Me.MeilleurTemps.FillWeight = 50.0!
        Me.MeilleurTemps.HeaderText = "Meilleur temps"
        Me.MeilleurTemps.MinimumWidth = 6
        Me.MeilleurTemps.Name = "MeilleurTemps"
        Me.MeilleurTemps.ReadOnly = True
        Me.MeilleurTemps.Width = 125
        '
        'NbDevineur
        '
        Me.NbDevineur.FillWeight = 50.0!
        Me.NbDevineur.HeaderText = "Nb Devineur"
        Me.NbDevineur.MinimumWidth = 6
        Me.NbDevineur.Name = "NbDevineur"
        Me.NbDevineur.ReadOnly = True
        Me.NbDevineur.Width = 95
        '
        'NbSelect
        '
        Me.NbSelect.FillWeight = 50.0!
        Me.NbSelect.HeaderText = "Nb Sélectionneur"
        Me.NbSelect.MinimumWidth = 6
        Me.NbSelect.Name = "NbSelect"
        Me.NbSelect.ReadOnly = True
        Me.NbSelect.Width = 95
        '
        'TempsTotal
        '
        Me.TempsTotal.FillWeight = 50.0!
        Me.TempsTotal.HeaderText = "Temps Total"
        Me.TempsTotal.MinimumWidth = 6
        Me.TempsTotal.Name = "TempsTotal"
        Me.TempsTotal.ReadOnly = True
        Me.TempsTotal.Width = 95
        '
        'Cbx_PlayerInfo
        '
        Me.Cbx_PlayerInfo.BackColor = System.Drawing.Color.White
        Me.Cbx_PlayerInfo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_PlayerInfo.FormattingEnabled = True
        Me.Cbx_PlayerInfo.Location = New System.Drawing.Point(20, 467)
        Me.Cbx_PlayerInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.Cbx_PlayerInfo.Name = "Cbx_PlayerInfo"
        Me.Cbx_PlayerInfo.Size = New System.Drawing.Size(189, 40)
        Me.Cbx_PlayerInfo.TabIndex = 3
        '
        'Btn_NameSort
        '
        Me.Btn_NameSort.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_NameSort.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_NameSort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NameSort.ForeColor = System.Drawing.Color.White
        Me.Btn_NameSort.Location = New System.Drawing.Point(78, 13)
        Me.Btn_NameSort.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_NameSort.Name = "Btn_NameSort"
        Me.Btn_NameSort.Size = New System.Drawing.Size(147, 33)
        Me.Btn_NameSort.TabIndex = 0
        Me.Btn_NameSort.Text = "Tri Nom"
        Me.Btn_NameSort.UseVisualStyleBackColor = False
        '
        'Btn_ScoreSort
        '
        Me.Btn_ScoreSort.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_ScoreSort.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_ScoreSort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ScoreSort.ForeColor = System.Drawing.Color.White
        Me.Btn_ScoreSort.Location = New System.Drawing.Point(243, 13)
        Me.Btn_ScoreSort.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_ScoreSort.Name = "Btn_ScoreSort"
        Me.Btn_ScoreSort.Size = New System.Drawing.Size(147, 33)
        Me.Btn_ScoreSort.TabIndex = 1
        Me.Btn_ScoreSort.Text = "Tri Score"
        Me.Btn_ScoreSort.UseVisualStyleBackColor = False
        '
        'Btn_Back
        '
        Me.Btn_Back.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_Back.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Back.ForeColor = System.Drawing.Color.White
        Me.Btn_Back.Location = New System.Drawing.Point(472, 467)
        Me.Btn_Back.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(132, 37)
        Me.Btn_Back.TabIndex = 4
        Me.Btn_Back.Text = "RETOUR"
        Me.Btn_Back.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Back.UseVisualStyleBackColor = True
        '
        'Btn_TimeSort
        '
        Me.Btn_TimeSort.BackColor = System.Drawing.Color.Transparent
        Me.Btn_TimeSort.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.Btn_TimeSort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_TimeSort.ForeColor = System.Drawing.Color.White
        Me.Btn_TimeSort.Location = New System.Drawing.Point(408, 13)
        Me.Btn_TimeSort.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_TimeSort.Name = "Btn_TimeSort"
        Me.Btn_TimeSort.Size = New System.Drawing.Size(147, 33)
        Me.Btn_TimeSort.TabIndex = 2
        Me.Btn_TimeSort.Text = "Tri Meilleur Temps"
        Me.Btn_TimeSort.UseVisualStyleBackColor = False
        '
        'StatsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sae.My.Resources.Resources.fond
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(626, 535)
        Me.Controls.Add(Me.Btn_TimeSort)
        Me.Controls.Add(Me.Btn_Back)
        Me.Controls.Add(Me.Btn_ScoreSort)
        Me.Controls.Add(Me.Btn_NameSort)
        Me.Controls.Add(Me.Cbx_PlayerInfo)
        Me.Controls.Add(Me.DataGrid_PlayerStats)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StatsForm"
        Me.Text = "Tableau des scores"
        CType(Me.DataGrid_PlayerStats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGrid_PlayerStats As DataGridView
    Friend WithEvents Cbx_PlayerInfo As ComboBox
    Friend WithEvents Btn_NameSort As Button
    Friend WithEvents Btn_ScoreSort As Button
    Friend WithEvents Btn_Back As Button
    Friend WithEvents Btn_TimeSort As Button
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Score As DataGridViewTextBoxColumn
    Friend WithEvents MeilleurTemps As DataGridViewTextBoxColumn
    Friend WithEvents NbDevineur As DataGridViewTextBoxColumn
    Friend WithEvents NbSelect As DataGridViewTextBoxColumn
    Friend WithEvents TempsTotal As DataGridViewTextBoxColumn
End Class
