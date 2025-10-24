<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Concilacion
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
        lblTitulo = New Label()
        lblSaldoLibros = New Label()
        txtSaldoLibros = New TextBox()
        lblDepositosTransito = New Label()
        txtDepositosTransito = New TextBox()
        lblChequesPendientes = New Label()
        txtChequesPendientes = New TextBox()
        lblSaldoBancario = New Label()
        txtSaldoBancario = New TextBox()
        btnGrabar = New Button()
        MenuStrip1 = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ChequesToolStripMenuItem = New ToolStripMenuItem()
        DepositosToolStripMenuItem = New ToolStripMenuItem()
        ConciliacionToolStripMenuItem = New ToolStripMenuItem()
        SalirDelSistemaToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblTitulo.ForeColor = Color.FromArgb(CByte(60), CByte(120), CByte(200))
        lblTitulo.Location = New Point(50, 50)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(400, 30)
        lblTitulo.TabIndex = 10
        lblTitulo.Text = "Conciliación Bancaria"
        ' 
        ' lblSaldoLibros
        ' 
        lblSaldoLibros.Location = New Point(50, 100)
        lblSaldoLibros.Name = "lblSaldoLibros"
        lblSaldoLibros.Size = New Size(180, 23)
        lblSaldoLibros.TabIndex = 11
        lblSaldoLibros.Text = "Saldo según libros:"
        ' 
        ' txtSaldoLibros
        ' 
        txtSaldoLibros.Location = New Point(250, 100)
        txtSaldoLibros.Name = "txtSaldoLibros"
        txtSaldoLibros.ReadOnly = True
        txtSaldoLibros.Size = New Size(200, 23)
        txtSaldoLibros.TabIndex = 12
        ' 
        ' lblDepositosTransito
        ' 
        lblDepositosTransito.Location = New Point(50, 140)
        lblDepositosTransito.Name = "lblDepositosTransito"
        lblDepositosTransito.Size = New Size(180, 23)
        lblDepositosTransito.TabIndex = 13
        lblDepositosTransito.Text = "(+) Depósitos en tránsito:"
        ' 
        ' txtDepositosTransito
        ' 
        txtDepositosTransito.Location = New Point(250, 140)
        txtDepositosTransito.Name = "txtDepositosTransito"
        txtDepositosTransito.ReadOnly = True
        txtDepositosTransito.Size = New Size(200, 23)
        txtDepositosTransito.TabIndex = 14
        ' 
        ' lblChequesPendientes
        ' 
        lblChequesPendientes.Location = New Point(50, 180)
        lblChequesPendientes.Name = "lblChequesPendientes"
        lblChequesPendientes.Size = New Size(180, 23)
        lblChequesPendientes.TabIndex = 15
        lblChequesPendientes.Text = "(–) Cheques pendientes:"
        ' 
        ' txtChequesPendientes
        ' 
        txtChequesPendientes.Location = New Point(250, 180)
        txtChequesPendientes.Name = "txtChequesPendientes"
        txtChequesPendientes.ReadOnly = True
        txtChequesPendientes.Size = New Size(200, 23)
        txtChequesPendientes.TabIndex = 16
        ' 
        ' lblSaldoBancario
        ' 
        lblSaldoBancario.Location = New Point(50, 220)
        lblSaldoBancario.Name = "lblSaldoBancario"
        lblSaldoBancario.Size = New Size(180, 23)
        lblSaldoBancario.TabIndex = 17
        lblSaldoBancario.Text = "Saldo bancario:"
        ' 
        ' txtSaldoBancario
        ' 
        txtSaldoBancario.Location = New Point(250, 220)
        txtSaldoBancario.Name = "txtSaldoBancario"
        txtSaldoBancario.Size = New Size(200, 23)
        txtSaldoBancario.TabIndex = 18
        ' 
        ' btnGrabar
        ' 
        btnGrabar.BackColor = Color.FromArgb(CByte(60), CByte(120), CByte(200))
        btnGrabar.FlatStyle = FlatStyle.Flat
        btnGrabar.ForeColor = Color.White
        btnGrabar.Location = New Point(250, 270)
        btnGrabar.Name = "btnGrabar"
        btnGrabar.Size = New Size(150, 30)
        btnGrabar.TabIndex = 19
        btnGrabar.Text = "Grabar conciliación"
        btnGrabar.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.LightGray
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(500, 24)
        MenuStrip1.TabIndex = 20
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
        ' Concilacion
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(240), CByte(255))
        ClientSize = New Size(500, 350)
        Controls.Add(MenuStrip1)
        Controls.Add(lblTitulo)
        Controls.Add(lblSaldoLibros)
        Controls.Add(txtSaldoLibros)
        Controls.Add(lblDepositosTransito)
        Controls.Add(txtDepositosTransito)
        Controls.Add(lblChequesPendientes)
        Controls.Add(txtChequesPendientes)
        Controls.Add(lblSaldoBancario)
        Controls.Add(txtSaldoBancario)
        Controls.Add(btnGrabar)
        Name = "Concilacion"
        Text = "Conciliación Bancaria"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSaldoLibros As Label
    Friend WithEvents txtSaldoLibros As TextBox
    Friend WithEvents lblDepositosTransito As Label
    Friend WithEvents txtDepositosTransito As TextBox
    Friend WithEvents lblChequesPendientes As Label
    Friend WithEvents txtChequesPendientes As TextBox
    Friend WithEvents lblSaldoBancario As Label
    Friend WithEvents txtSaldoBancario As TextBox
    Friend WithEvents btnGrabar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ChequesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepositosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConciliacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As ToolStripMenuItem
End Class
