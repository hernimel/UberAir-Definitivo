<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Me.components = New System.ComponentModel.Container()
        Dim Id_empresaLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim RolLabel As System.Windows.Forms.Label
        Dim Creditos_MensualesLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Id_EmpresaLabel1 As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DronesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DronesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDUberAirDataSet = New UBERAIR.BDUberAirDataSet()
        Me.Btn_BorrarDrone = New System.Windows.Forms.Button()
        Me.Btn_AgregarDrone = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Btn_BorrarUsuarios = New System.Windows.Forms.Button()
        Me.Btn_ModificarUsuarios = New System.Windows.Forms.Button()
        Me.Creditos_MensualesTextBoxUsuarios = New System.Windows.Forms.TextBox()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RolTextBoxUsuarios = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBoxUsuarios = New System.Windows.Forms.TextBox()
        Me.Id_empresaTextBoxUsuarios = New System.Windows.Forms.TextBox()
        Me.Btn_AgregarUsuarios = New System.Windows.Forms.Button()
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.PasajerosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Btn_EliminarPasajeros = New System.Windows.Forms.Button()
        Me.Btn_ModificarPasajeros = New System.Windows.Forms.Button()
        Me.Btn_AgregarPasajeros = New System.Windows.Forms.Button()
        Me.PasajerosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Btn_CancelarReserva = New System.Windows.Forms.Button()
        Me.Btn_ConfirmarReserva = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ReservasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DronesTableAdapter = New UBERAIR.BDUberAirDataSetTableAdapters.DronesTableAdapter()
        Me.TableAdapterManager = New UBERAIR.BDUberAirDataSetTableAdapters.TableAdapterManager()
        Me.UsuariosTableAdapter = New UBERAIR.BDUberAirDataSetTableAdapters.UsuariosTableAdapter()
        Me.PasajerosTableAdapter = New UBERAIR.BDUberAirDataSetTableAdapters.PasajerosTableAdapter()
        Me.ReservasTableAdapter = New UBERAIR.BDUberAirDataSetTableAdapters.ReservasTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Id_empresaLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        RolLabel = New System.Windows.Forms.Label()
        Creditos_MensualesLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Id_EmpresaLabel1 = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DronesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DronesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDUberAirDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PasajerosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasajerosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ReservasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_empresaLabel
        '
        Id_empresaLabel.AutoSize = True
        Id_empresaLabel.Location = New System.Drawing.Point(507, 34)
        Id_empresaLabel.Name = "Id_empresaLabel"
        Id_empresaLabel.Size = New System.Drawing.Size(62, 13)
        Id_empresaLabel.TabIndex = 2
        Id_empresaLabel.Text = "Id empresa:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(507, 80)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(64, 13)
        ContraseñaLabel.TabIndex = 4
        ContraseñaLabel.Text = "Contraseña:"
        '
        'RolLabel
        '
        RolLabel.AutoSize = True
        RolLabel.Location = New System.Drawing.Point(520, 128)
        RolLabel.Name = "RolLabel"
        RolLabel.Size = New System.Drawing.Size(26, 13)
        RolLabel.TabIndex = 6
        RolLabel.Text = "Rol:"
        '
        'Creditos_MensualesLabel
        '
        Creditos_MensualesLabel.AutoSize = True
        Creditos_MensualesLabel.Location = New System.Drawing.Point(469, 176)
        Creditos_MensualesLabel.Name = "Creditos_MensualesLabel"
        Creditos_MensualesLabel.Size = New System.Drawing.Size(102, 13)
        Creditos_MensualesLabel.TabIndex = 8
        Creditos_MensualesLabel.Text = "Creditos Mensuales:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(573, 276)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'Id_EmpresaLabel1
        '
        Id_EmpresaLabel1.AutoSize = True
        Id_EmpresaLabel1.Location = New System.Drawing.Point(557, 245)
        Id_EmpresaLabel1.Name = "Id_EmpresaLabel1"
        Id_EmpresaLabel1.Size = New System.Drawing.Size(63, 13)
        Id_EmpresaLabel1.TabIndex = 6
        Id_EmpresaLabel1.Text = "Id Empresa:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(573, 305)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 8
        ApellidoLabel.Text = "Apellido:"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(591, 331)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(29, 13)
        DNILabel.TabIndex = 10
        DNILabel.Text = "DNI:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(578, 357)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(42, 13)
        CelularLabel.TabIndex = 12
        CelularLabel.Text = "Celular:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(2, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(979, 459)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.DronesDataGridView)
        Me.TabPage1.Controls.Add(Me.Btn_BorrarDrone)
        Me.TabPage1.Controls.Add(Me.Btn_AgregarDrone)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(971, 433)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Drone"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DronesDataGridView
        '
        Me.DronesDataGridView.AutoGenerateColumns = False
        Me.DronesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DronesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn5})
        Me.DronesDataGridView.DataSource = Me.DronesBindingSource
        Me.DronesDataGridView.Location = New System.Drawing.Point(0, 3)
        Me.DronesDataGridView.Name = "DronesDataGridView"
        Me.DronesDataGridView.Size = New System.Drawing.Size(655, 238)
        Me.DronesDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Drone"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Drone"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Capacidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Capacidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Autonomia"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Autonomia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Estado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Estado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Creditos"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Creditos"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DronesBindingSource
        '
        Me.DronesBindingSource.DataMember = "Drones"
        Me.DronesBindingSource.DataSource = Me.BDUberAirDataSet
        '
        'BDUberAirDataSet
        '
        Me.BDUberAirDataSet.DataSetName = "BDUberAirDataSet"
        Me.BDUberAirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Btn_BorrarDrone
        '
        Me.Btn_BorrarDrone.Location = New System.Drawing.Point(661, 45)
        Me.Btn_BorrarDrone.Name = "Btn_BorrarDrone"
        Me.Btn_BorrarDrone.Padding = New System.Windows.Forms.Padding(5)
        Me.Btn_BorrarDrone.Size = New System.Drawing.Size(106, 33)
        Me.Btn_BorrarDrone.TabIndex = 2
        Me.Btn_BorrarDrone.Text = "Borrar Drone"
        Me.Btn_BorrarDrone.UseVisualStyleBackColor = True
        '
        'Btn_AgregarDrone
        '
        Me.Btn_AgregarDrone.Location = New System.Drawing.Point(661, 6)
        Me.Btn_AgregarDrone.Name = "Btn_AgregarDrone"
        Me.Btn_AgregarDrone.Padding = New System.Windows.Forms.Padding(5)
        Me.Btn_AgregarDrone.Size = New System.Drawing.Size(106, 33)
        Me.Btn_AgregarDrone.TabIndex = 1
        Me.Btn_AgregarDrone.Text = "Agregar Drone"
        Me.Btn_AgregarDrone.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Btn_BorrarUsuarios)
        Me.TabPage2.Controls.Add(Me.Btn_ModificarUsuarios)
        Me.TabPage2.Controls.Add(Creditos_MensualesLabel)
        Me.TabPage2.Controls.Add(Me.Creditos_MensualesTextBoxUsuarios)
        Me.TabPage2.Controls.Add(RolLabel)
        Me.TabPage2.Controls.Add(Me.RolTextBoxUsuarios)
        Me.TabPage2.Controls.Add(ContraseñaLabel)
        Me.TabPage2.Controls.Add(Me.ContraseñaTextBoxUsuarios)
        Me.TabPage2.Controls.Add(Id_empresaLabel)
        Me.TabPage2.Controls.Add(Me.Id_empresaTextBoxUsuarios)
        Me.TabPage2.Controls.Add(Me.Btn_AgregarUsuarios)
        Me.TabPage2.Controls.Add(Me.UsuariosDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(971, 433)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Usuarios"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Btn_BorrarUsuarios
        '
        Me.Btn_BorrarUsuarios.Location = New System.Drawing.Point(778, 89)
        Me.Btn_BorrarUsuarios.Name = "Btn_BorrarUsuarios"
        Me.Btn_BorrarUsuarios.Size = New System.Drawing.Size(75, 23)
        Me.Btn_BorrarUsuarios.TabIndex = 11
        Me.Btn_BorrarUsuarios.Text = "Borrar"
        Me.Btn_BorrarUsuarios.UseVisualStyleBackColor = True
        '
        'Btn_ModificarUsuarios
        '
        Me.Btn_ModificarUsuarios.Location = New System.Drawing.Point(778, 128)
        Me.Btn_ModificarUsuarios.Name = "Btn_ModificarUsuarios"
        Me.Btn_ModificarUsuarios.Size = New System.Drawing.Size(75, 23)
        Me.Btn_ModificarUsuarios.TabIndex = 10
        Me.Btn_ModificarUsuarios.Text = "Modificar"
        Me.Btn_ModificarUsuarios.UseVisualStyleBackColor = True
        '
        'Creditos_MensualesTextBoxUsuarios
        '
        Me.Creditos_MensualesTextBoxUsuarios.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Creditos_Mensuales", True))
        Me.Creditos_MensualesTextBoxUsuarios.Location = New System.Drawing.Point(577, 173)
        Me.Creditos_MensualesTextBoxUsuarios.Name = "Creditos_MensualesTextBoxUsuarios"
        Me.Creditos_MensualesTextBoxUsuarios.Size = New System.Drawing.Size(100, 20)
        Me.Creditos_MensualesTextBoxUsuarios.TabIndex = 9
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.BDUberAirDataSet
        '
        'RolTextBoxUsuarios
        '
        Me.RolTextBoxUsuarios.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Rol", True))
        Me.RolTextBoxUsuarios.Location = New System.Drawing.Point(575, 128)
        Me.RolTextBoxUsuarios.Name = "RolTextBoxUsuarios"
        Me.RolTextBoxUsuarios.Size = New System.Drawing.Size(100, 20)
        Me.RolTextBoxUsuarios.TabIndex = 7
        '
        'ContraseñaTextBoxUsuarios
        '
        Me.ContraseñaTextBoxUsuarios.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Contraseña", True))
        Me.ContraseñaTextBoxUsuarios.Location = New System.Drawing.Point(575, 80)
        Me.ContraseñaTextBoxUsuarios.Name = "ContraseñaTextBoxUsuarios"
        Me.ContraseñaTextBoxUsuarios.Size = New System.Drawing.Size(100, 20)
        Me.ContraseñaTextBoxUsuarios.TabIndex = 5
        '
        'Id_empresaTextBoxUsuarios
        '
        Me.Id_empresaTextBoxUsuarios.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Id_empresa", True))
        Me.Id_empresaTextBoxUsuarios.Location = New System.Drawing.Point(575, 31)
        Me.Id_empresaTextBoxUsuarios.Name = "Id_empresaTextBoxUsuarios"
        Me.Id_empresaTextBoxUsuarios.Size = New System.Drawing.Size(100, 20)
        Me.Id_empresaTextBoxUsuarios.TabIndex = 3
        '
        'Btn_AgregarUsuarios
        '
        Me.Btn_AgregarUsuarios.Location = New System.Drawing.Point(778, 51)
        Me.Btn_AgregarUsuarios.Name = "Btn_AgregarUsuarios"
        Me.Btn_AgregarUsuarios.Size = New System.Drawing.Size(75, 23)
        Me.Btn_AgregarUsuarios.TabIndex = 1
        Me.Btn_AgregarUsuarios.Text = "Agregar"
        Me.Btn_AgregarUsuarios.UseVisualStyleBackColor = True
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(449, 219)
        Me.UsuariosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Id_empresa"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Id_empresa"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Contraseña"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contraseña"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Rol"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Rol"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Creditos_Mensuales"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Creditos_Mensuales"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(CelularLabel)
        Me.TabPage3.Controls.Add(Me.CelularTextBox)
        Me.TabPage3.Controls.Add(DNILabel)
        Me.TabPage3.Controls.Add(Me.DNITextBox)
        Me.TabPage3.Controls.Add(ApellidoLabel)
        Me.TabPage3.Controls.Add(Me.ApellidoTextBox)
        Me.TabPage3.Controls.Add(Id_EmpresaLabel1)
        Me.TabPage3.Controls.Add(Me.Id_EmpresaTextBox)
        Me.TabPage3.Controls.Add(NombreLabel)
        Me.TabPage3.Controls.Add(Me.NombreTextBox)
        Me.TabPage3.Controls.Add(Me.Btn_EliminarPasajeros)
        Me.TabPage3.Controls.Add(Me.Btn_ModificarPasajeros)
        Me.TabPage3.Controls.Add(Me.Btn_AgregarPasajeros)
        Me.TabPage3.Controls.Add(Me.PasajerosDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(971, 433)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Pasajeros"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasajerosBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(626, 354)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CelularTextBox.TabIndex = 13
        '
        'PasajerosBindingSource
        '
        Me.PasajerosBindingSource.DataMember = "Pasajeros"
        Me.PasajerosBindingSource.DataSource = Me.BDUberAirDataSet
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasajerosBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(626, 328)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(100, 20)
        Me.DNITextBox.TabIndex = 11
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasajerosBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(626, 302)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 9
        '
        'Id_EmpresaTextBox
        '
        Me.Id_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasajerosBindingSource, "Id_Empresa", True))
        Me.Id_EmpresaTextBox.Location = New System.Drawing.Point(626, 242)
        Me.Id_EmpresaTextBox.Name = "Id_EmpresaTextBox"
        Me.Id_EmpresaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_EmpresaTextBox.TabIndex = 7
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasajerosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(626, 273)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 5
        '
        'Btn_EliminarPasajeros
        '
        Me.Btn_EliminarPasajeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EliminarPasajeros.Location = New System.Drawing.Point(560, 146)
        Me.Btn_EliminarPasajeros.Name = "Btn_EliminarPasajeros"
        Me.Btn_EliminarPasajeros.Size = New System.Drawing.Size(194, 43)
        Me.Btn_EliminarPasajeros.TabIndex = 3
        Me.Btn_EliminarPasajeros.Text = "Eliminar Pasajero"
        Me.Btn_EliminarPasajeros.UseVisualStyleBackColor = True
        '
        'Btn_ModificarPasajeros
        '
        Me.Btn_ModificarPasajeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ModificarPasajeros.Location = New System.Drawing.Point(560, 87)
        Me.Btn_ModificarPasajeros.Name = "Btn_ModificarPasajeros"
        Me.Btn_ModificarPasajeros.Size = New System.Drawing.Size(194, 43)
        Me.Btn_ModificarPasajeros.TabIndex = 2
        Me.Btn_ModificarPasajeros.Text = "Modificar Pasajero"
        Me.Btn_ModificarPasajeros.UseVisualStyleBackColor = True
        '
        'Btn_AgregarPasajeros
        '
        Me.Btn_AgregarPasajeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AgregarPasajeros.Location = New System.Drawing.Point(560, 25)
        Me.Btn_AgregarPasajeros.Name = "Btn_AgregarPasajeros"
        Me.Btn_AgregarPasajeros.Size = New System.Drawing.Size(194, 43)
        Me.Btn_AgregarPasajeros.TabIndex = 1
        Me.Btn_AgregarPasajeros.Text = "Agregar Pasajero"
        Me.Btn_AgregarPasajeros.UseVisualStyleBackColor = True
        '
        'PasajerosDataGridView
        '
        Me.PasajerosDataGridView.AutoGenerateColumns = False
        Me.PasajerosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PasajerosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.PasajerosDataGridView.DataSource = Me.PasajerosBindingSource
        Me.PasajerosDataGridView.Location = New System.Drawing.Point(0, 6)
        Me.PasajerosDataGridView.Name = "PasajerosDataGridView"
        Me.PasajerosDataGridView.Size = New System.Drawing.Size(540, 183)
        Me.PasajerosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Id_Empresa"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Id_Empresa"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn13.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Celular"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Celular"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.StatusStrip1)
        Me.TabPage4.Controls.Add(Me.Btn_CancelarReserva)
        Me.TabPage4.Controls.Add(Me.Btn_ConfirmarReserva)
        Me.TabPage4.Controls.Add(Me.ListBox1)
        Me.TabPage4.Controls.Add(Me.ReservasDataGridView)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(971, 433)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Reservas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 408)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(965, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'Btn_CancelarReserva
        '
        Me.Btn_CancelarReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CancelarReserva.Location = New System.Drawing.Point(610, 237)
        Me.Btn_CancelarReserva.Name = "Btn_CancelarReserva"
        Me.Btn_CancelarReserva.Size = New System.Drawing.Size(179, 33)
        Me.Btn_CancelarReserva.TabIndex = 3
        Me.Btn_CancelarReserva.Text = "Cancelar Reserva"
        Me.Btn_CancelarReserva.UseVisualStyleBackColor = True
        '
        'Btn_ConfirmarReserva
        '
        Me.Btn_ConfirmarReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ConfirmarReserva.Location = New System.Drawing.Point(610, 198)
        Me.Btn_ConfirmarReserva.Name = "Btn_ConfirmarReserva"
        Me.Btn_ConfirmarReserva.Size = New System.Drawing.Size(179, 33)
        Me.Btn_ConfirmarReserva.TabIndex = 2
        Me.Btn_ConfirmarReserva.Text = "Confirmar Reserva"
        Me.Btn_ConfirmarReserva.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(35, 198)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(338, 160)
        Me.ListBox1.TabIndex = 1
        '
        'ReservasDataGridView
        '
        Me.ReservasDataGridView.AutoGenerateColumns = False
        Me.ReservasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReservasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.ReservasDataGridView.DataSource = Me.ReservasBindingSource
        Me.ReservasDataGridView.Location = New System.Drawing.Point(6, 20)
        Me.ReservasDataGridView.Name = "ReservasDataGridView"
        Me.ReservasDataGridView.Size = New System.Drawing.Size(936, 155)
        Me.ReservasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Id_Reserva"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Id_Reserva"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Id_Drone"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Id_Drone"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Fecha y hora"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Fecha y hora"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Lugar"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Lugar"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Dni_Pasajero1"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Dni_Pasajero1"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Dni_Pasajero2"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Dni_Pasajero2"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Dni_Pasajero3"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Dni_Pasajero3"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Dni_Pasajero4"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Dni_Pasajero4"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'ReservasBindingSource
        '
        Me.ReservasBindingSource.DataMember = "Reservas"
        Me.ReservasBindingSource.DataSource = Me.BDUberAirDataSet
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(971, 433)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Bases"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(971, 433)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Hoja de Ruta"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DronesTableAdapter
        '
        Me.DronesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BasesTableAdapter = Nothing
        Me.TableAdapterManager.DronesTableAdapter = Me.DronesTableAdapter
        Me.TableAdapterManager.Hoja_de_RutaTableAdapter = Nothing
        Me.TableAdapterManager.PasajerosTableAdapter = Nothing
        Me.TableAdapterManager.ReservasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UBERAIR.BDUberAirDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'PasajerosTableAdapter
        '
        Me.PasajerosTableAdapter.ClearBeforeFill = True
        '
        'ReservasTableAdapter
        '
        Me.ReservasTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 500)
        Me.Name = "Administrador"
        Me.Text = "Administrador"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DronesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DronesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDUberAirDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PasajerosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasajerosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ReservasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents BDUberAirDataSet As UBERAIR.BDUberAirDataSet
    Friend WithEvents DronesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DronesTableAdapter As UBERAIR.BDUberAirDataSetTableAdapters.DronesTableAdapter
    Friend WithEvents TableAdapterManager As UBERAIR.BDUberAirDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Btn_AgregarDrone As System.Windows.Forms.Button
    Friend WithEvents Btn_BorrarDrone As System.Windows.Forms.Button
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As UBERAIR.BDUberAirDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents Btn_AgregarUsuarios As System.Windows.Forms.Button
    Friend WithEvents UsuariosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DronesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btn_BorrarUsuarios As System.Windows.Forms.Button
    Friend WithEvents Btn_ModificarUsuarios As System.Windows.Forms.Button
    Friend WithEvents Creditos_MensualesTextBoxUsuarios As System.Windows.Forms.TextBox
    Friend WithEvents RolTextBoxUsuarios As System.Windows.Forms.TextBox
    Friend WithEvents ContraseñaTextBoxUsuarios As System.Windows.Forms.TextBox
    Friend WithEvents Id_empresaTextBoxUsuarios As System.Windows.Forms.TextBox
    Friend WithEvents PasajerosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PasajerosTableAdapter As UBERAIR.BDUberAirDataSetTableAdapters.PasajerosTableAdapter
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DNITextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_EmpresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Btn_EliminarPasajeros As System.Windows.Forms.Button
    Friend WithEvents Btn_ModificarPasajeros As System.Windows.Forms.Button
    Friend WithEvents Btn_AgregarPasajeros As System.Windows.Forms.Button
    Friend WithEvents PasajerosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReservasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservasTableAdapter As UBERAIR.BDUberAirDataSetTableAdapters.ReservasTableAdapter
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ReservasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Btn_CancelarReserva As System.Windows.Forms.Button
    Friend WithEvents Btn_ConfirmarReserva As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel

End Class
