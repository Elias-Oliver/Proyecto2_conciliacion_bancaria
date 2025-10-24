<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Depositos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        cmbTipoDeposito = New ComboBox()
        dtpFechaDeposito = New DateTimePicker()
        txtMonto = New TextBox()
        lblTipoDeposito = New Label()
        lblFechaDeposito = New Label()
        lblMonto = New Label()
        btnRegistrarDeposito = New Button()
        dgvHistorialDepositos = New DataGridView()
        lblTitulo = New Label()
        MenuStrip1 = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ChequesToolStripMenuItem = New ToolStripMenuItem()
        DepositosToolStripMenuItem = New ToolStripMenuItem()
        ConciliacionToolStripMenuItem = New ToolStripMenuItem()
        SalirDelSistemaToolStripMenuItem = New ToolStripMenuItem()
        CType(dgvHistorialDepositos, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbTipoDeposito
        ' 
        cmbTipoDeposito.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTipoDeposito.Items.AddRange(New Object() {"Transferencia", "Depósito directo"})
        cmbTipoDeposito.Location = New Point(178, 100)
        cmbTipoDeposito.Name = "cmbTipoDeposito"
        cmbTipoDeposito.Size = New Size(200, 23)
        cmbTipoDeposito.TabIndex = 2
        ' 
        ' dtpFechaDeposito
        ' 
        dtpFechaDeposito.Location = New Point(178, 140)
        dtpFechaDeposito.Name = "dtpFechaDeposito"
        dtpFechaDeposito.Size = New Size(200, 23)
        dtpFechaDeposito.TabIndex = 4
        ' 
        ' txtMonto
        ' 
        txtMonto.Location = New Point(178, 180)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(200, 23)
        txtMonto.TabIndex = 6
        ' 
        ' lblTipoDeposito
        ' 
        lblTipoDeposito.Location = New Point(18, 100)
        lblTipoDeposito.Name = "lblTipoDeposito"
        lblTipoDeposito.Size = New Size(150, 23)
        lblTipoDeposito.TabIndex = 1
        lblTipoDeposito.Text = "Tipo de depósito:"
        ' 
        ' lblFechaDeposito
        ' 
        lblFechaDeposito.Location = New Point(18, 140)
        lblFechaDeposito.Name = "lblFechaDeposito"
        lblFechaDeposito.Size = New Size(150, 23)
        lblFechaDeposito.TabIndex = 3
        lblFechaDeposito.Text = "Fecha del depósito:"
        ' 
        ' lblMonto
        ' 
        lblMonto.Location = New Point(18, 180)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(150, 23)
        lblMonto.TabIndex = 5
        lblMonto.Text = "Monto:"
        ' 
        ' btnRegistrarDeposito
        ' 
        btnRegistrarDeposito.BackColor = Color.FromArgb(CByte(60), CByte(120), CByte(200))
        btnRegistrarDeposito.FlatStyle = FlatStyle.Flat
        btnRegistrarDeposito.ForeColor = Color.White
        btnRegistrarDeposito.Location = New Point(178, 220)
        btnRegistrarDeposito.Name = "btnRegistrarDeposito"
        btnRegistrarDeposito.Size = New Size(150, 30)
        btnRegistrarDeposito.TabIndex = 7
        btnRegistrarDeposito.Text = "Registrar depósito"
        btnRegistrarDeposito.UseVisualStyleBackColor = False
        ' 
        ' dgvHistorialDepositos
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(220), CByte(230), CByte(240))
        dgvHistorialDepositos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvHistorialDepositos.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dgvHistorialDepositos.BackgroundColor = Color.White
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(60), CByte(120), CByte(200))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvHistorialDepositos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvHistorialDepositos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvHistorialDepositos.DefaultCellStyle = DataGridViewCellStyle6
        dgvHistorialDepositos.EnableHeadersVisualStyles = False
        dgvHistorialDepositos.GridColor = Color.LightGray
        dgvHistorialDepositos.Location = New Point(418, 100)
        dgvHistorialDepositos.Name = "dgvHistorialDepositos"
        dgvHistorialDepositos.Size = New Size(250, 200)
        dgvHistorialDepositos.TabIndex = 8
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTitulo.ForeColor = Color.FromArgb(CByte(60), CByte(120), CByte(200))
        lblTitulo.Location = New Point(18, 50)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(400, 30)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Registro de Depósitos Bancarios"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.LightGray
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(700, 24)
        MenuStrip1.TabIndex = 9
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripSeparator1, ChequesToolStripMenuItem, DepositosToolStripMenuItem, ConciliacionToolStripMenuItem, SalirDelSistemaToolStripMenuItem})
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(50, 20)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(155, 6)
        ' 
        ' ChequesToolStripMenuItem
        ' 
        ChequesToolStripMenuItem.Name = "ChequesToolStripMenuItem"
        ChequesToolStripMenuItem.Size = New Size(158, 22)
        ChequesToolStripMenuItem.Text = "Cheques "
        ' 
        ' DepositosToolStripMenuItem
        ' 
        DepositosToolStripMenuItem.Name = "DepositosToolStripMenuItem"
        DepositosToolStripMenuItem.Size = New Size(158, 22)
        DepositosToolStripMenuItem.Text = "Depositos"
        ' 
        ' ConciliacionToolStripMenuItem
        ' 
        ConciliacionToolStripMenuItem.Name = "ConciliacionToolStripMenuItem"
        ConciliacionToolStripMenuItem.Size = New Size(158, 22)
        ConciliacionToolStripMenuItem.Text = "Conciliacion"
        ' 
        ' SalirDelSistemaToolStripMenuItem
        ' 
        SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        SalirDelSistemaToolStripMenuItem.Size = New Size(158, 22)
        SalirDelSistemaToolStripMenuItem.Text = "Salir del sistema"
        ' 
        ' Depositos
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(240), CByte(255))
        ClientSize = New Size(700, 400)
        Controls.Add(MenuStrip1)
        Controls.Add(lblTitulo)
        Controls.Add(lblTipoDeposito)
        Controls.Add(cmbTipoDeposito)
        Controls.Add(lblFechaDeposito)
        Controls.Add(dtpFechaDeposito)
        Controls.Add(lblMonto)
        Controls.Add(txtMonto)
        Controls.Add(btnRegistrarDeposito)
        Controls.Add(dgvHistorialDepositos)
        Name = "Depositos"
        Text = "Depósitos"
        CType(dgvHistorialDepositos, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbTipoDeposito As ComboBox
    Friend WithEvents dtpFechaDeposito As DateTimePicker
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents btnRegistrarDeposito As Button
    Friend WithEvents dgvHistorialDepositos As DataGridView
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblTipoDeposito As Label
    Friend WithEvents lblFechaDeposito As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ChequesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepositosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConciliacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As ToolStripMenuItem
End Class
