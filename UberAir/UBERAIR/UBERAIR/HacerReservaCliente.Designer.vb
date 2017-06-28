<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HacerReservaCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Lbl_IdReserva As System.Windows.Forms.Label
        Me.Lbl_NumeroDePasajeros = New System.Windows.Forms.Label()
        Me.Lbl_SeleccioneUnaHora = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Lbl_FechaSeleccionada = New System.Windows.Forms.Label()
        Me.Lbl_SeleccioneUnaFecha = New System.Windows.Forms.Label()
        Me.TxtB_IdReserva = New System.Windows.Forms.TextBox()
        Me.TxtB_NumeroDePasajeros = New System.Windows.Forms.TextBox()
        Me.Lbl_Pasajero1 = New System.Windows.Forms.Label()
        Me.TxtB_Pasajero1 = New System.Windows.Forms.TextBox()
        Me.TxtB_Pasajero2 = New System.Windows.Forms.TextBox()
        Me.Lbl_Pasajero2 = New System.Windows.Forms.Label()
        Me.TxtB_Pasajero3 = New System.Windows.Forms.TextBox()
        Me.Lbl_Pasajero3 = New System.Windows.Forms.Label()
        Me.TxtB_Pasajero4 = New System.Windows.Forms.TextBox()
        Me.Lbl_Pasajero4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListB_TodosLosPasajeros = New System.Windows.Forms.ListBox()
        Me.Lbl_Pasajeros = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_ConfirmarPasajeros = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Btn_VerReservas = New System.Windows.Forms.Button()
        Me.ConfirmarReserva = New System.Windows.Forms.Button()
        Me.PasajerosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservasTableAdapter = New UBERAIR.BDUberAirDataSetTableAdapters.ReservasTableAdapter()
        Me.BdUberAirDataSet = New UBERAIR.BDUberAirDataSet()
        Lbl_IdReserva = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasajerosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdUberAirDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_IdReserva
        '
        Lbl_IdReserva.AutoSize = True
        Lbl_IdReserva.Location = New System.Drawing.Point(63, 43)
        Lbl_IdReserva.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Lbl_IdReserva.Name = "Lbl_IdReserva"
        Lbl_IdReserva.Size = New System.Drawing.Size(80, 17)
        Lbl_IdReserva.TabIndex = 9
        Lbl_IdReserva.Text = "Id Reserva:"
        '
        'Lbl_NumeroDePasajeros
        '
        Me.Lbl_NumeroDePasajeros.AutoSize = True
        Me.Lbl_NumeroDePasajeros.Location = New System.Drawing.Point(442, 39)
        Me.Lbl_NumeroDePasajeros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_NumeroDePasajeros.Name = "Lbl_NumeroDePasajeros"
        Me.Lbl_NumeroDePasajeros.Size = New System.Drawing.Size(145, 17)
        Me.Lbl_NumeroDePasajeros.TabIndex = 15
        Me.Lbl_NumeroDePasajeros.Text = "Numero de Pasajeros"
        '
        'Lbl_SeleccioneUnaHora
        '
        Me.Lbl_SeleccioneUnaHora.AutoSize = True
        Me.Lbl_SeleccioneUnaHora.Location = New System.Drawing.Point(62, 337)
        Me.Lbl_SeleccioneUnaHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_SeleccioneUnaHora.Name = "Lbl_SeleccioneUnaHora"
        Me.Lbl_SeleccioneUnaHora.Size = New System.Drawing.Size(140, 17)
        Me.Lbl_SeleccioneUnaHora.TabIndex = 14
        Me.Lbl_SeleccioneUnaHora.Text = "Seleccione una Hora"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(66, 105)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 13
        '
        'Lbl_FechaSeleccionada
        '
        Me.Lbl_FechaSeleccionada.AutoSize = True
        Me.Lbl_FechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FechaSeleccionada.Location = New System.Drawing.Point(192, 313)
        Me.Lbl_FechaSeleccionada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_FechaSeleccionada.Name = "Lbl_FechaSeleccionada"
        Me.Lbl_FechaSeleccionada.Size = New System.Drawing.Size(44, 17)
        Me.Lbl_FechaSeleccionada.TabIndex = 12
        Me.Lbl_FechaSeleccionada.Text = "____"
        '
        'Lbl_SeleccioneUnaFecha
        '
        Me.Lbl_SeleccioneUnaFecha.AutoSize = True
        Me.Lbl_SeleccioneUnaFecha.Location = New System.Drawing.Point(62, 77)
        Me.Lbl_SeleccioneUnaFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_SeleccioneUnaFecha.Name = "Lbl_SeleccioneUnaFecha"
        Me.Lbl_SeleccioneUnaFecha.Size = New System.Drawing.Size(148, 17)
        Me.Lbl_SeleccioneUnaFecha.TabIndex = 11
        Me.Lbl_SeleccioneUnaFecha.Text = "Seleccione una Fecha"
        '
        'TxtB_IdReserva
        '
        Me.TxtB_IdReserva.Location = New System.Drawing.Point(189, 39)
        Me.TxtB_IdReserva.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtB_IdReserva.Name = "TxtB_IdReserva"
        Me.TxtB_IdReserva.Size = New System.Drawing.Size(132, 22)
        Me.TxtB_IdReserva.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.TxtB_IdReserva, "Ingrese la/s inicial/es de su empresa y el número de reserva.")
        '
        'TxtB_NumeroDePasajeros
        '
        Me.TxtB_NumeroDePasajeros.Location = New System.Drawing.Point(595, 36)
        Me.TxtB_NumeroDePasajeros.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtB_NumeroDePasajeros.Name = "TxtB_NumeroDePasajeros"
        Me.TxtB_NumeroDePasajeros.Size = New System.Drawing.Size(132, 22)
        Me.TxtB_NumeroDePasajeros.TabIndex = 16
        '
        'Lbl_Pasajero1
        '
        Me.Lbl_Pasajero1.AutoSize = True
        Me.Lbl_Pasajero1.Location = New System.Drawing.Point(465, 316)
        Me.Lbl_Pasajero1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Pasajero1.Name = "Lbl_Pasajero1"
        Me.Lbl_Pasajero1.Size = New System.Drawing.Size(72, 17)
        Me.Lbl_Pasajero1.TabIndex = 18
        Me.Lbl_Pasajero1.Text = "Pasajero1"
        Me.Lbl_Pasajero1.Visible = False
        '
        'TxtB_Pasajero1
        '
        Me.TxtB_Pasajero1.Location = New System.Drawing.Point(503, 336)
        Me.TxtB_Pasajero1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtB_Pasajero1.Name = "TxtB_Pasajero1"
        Me.TxtB_Pasajero1.Size = New System.Drawing.Size(132, 22)
        Me.TxtB_Pasajero1.TabIndex = 19
        Me.TxtB_Pasajero1.Visible = False
        '
        'TxtB_Pasajero2
        '
        Me.TxtB_Pasajero2.Location = New System.Drawing.Point(503, 387)
        Me.TxtB_Pasajero2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtB_Pasajero2.Name = "TxtB_Pasajero2"
        Me.TxtB_Pasajero2.Size = New System.Drawing.Size(132, 22)
        Me.TxtB_Pasajero2.TabIndex = 21
        Me.TxtB_Pasajero2.Visible = False
        '
        'Lbl_Pasajero2
        '
        Me.Lbl_Pasajero2.AutoSize = True
        Me.Lbl_Pasajero2.Location = New System.Drawing.Point(465, 368)
        Me.Lbl_Pasajero2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Pasajero2.Name = "Lbl_Pasajero2"
        Me.Lbl_Pasajero2.Size = New System.Drawing.Size(76, 17)
        Me.Lbl_Pasajero2.TabIndex = 20
        Me.Lbl_Pasajero2.Text = "Pasajero 2"
        Me.Lbl_Pasajero2.Visible = False
        '
        'TxtB_Pasajero3
        '
        Me.TxtB_Pasajero3.Location = New System.Drawing.Point(693, 337)
        Me.TxtB_Pasajero3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtB_Pasajero3.Name = "TxtB_Pasajero3"
        Me.TxtB_Pasajero3.Size = New System.Drawing.Size(132, 22)
        Me.TxtB_Pasajero3.TabIndex = 23
        Me.TxtB_Pasajero3.Visible = False
        '
        'Lbl_Pasajero3
        '
        Me.Lbl_Pasajero3.AutoSize = True
        Me.Lbl_Pasajero3.Location = New System.Drawing.Point(655, 318)
        Me.Lbl_Pasajero3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Pasajero3.Name = "Lbl_Pasajero3"
        Me.Lbl_Pasajero3.Size = New System.Drawing.Size(76, 17)
        Me.Lbl_Pasajero3.TabIndex = 22
        Me.Lbl_Pasajero3.Text = "Pasajero 3"
        Me.Lbl_Pasajero3.Visible = False
        '
        'TxtB_Pasajero4
        '
        Me.TxtB_Pasajero4.Location = New System.Drawing.Point(693, 387)
        Me.TxtB_Pasajero4.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtB_Pasajero4.Name = "TxtB_Pasajero4"
        Me.TxtB_Pasajero4.Size = New System.Drawing.Size(132, 22)
        Me.TxtB_Pasajero4.TabIndex = 25
        Me.TxtB_Pasajero4.Visible = False
        '
        'Lbl_Pasajero4
        '
        Me.Lbl_Pasajero4.AutoSize = True
        Me.Lbl_Pasajero4.Location = New System.Drawing.Point(655, 367)
        Me.Lbl_Pasajero4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Pasajero4.Name = "Lbl_Pasajero4"
        Me.Lbl_Pasajero4.Size = New System.Drawing.Size(76, 17)
        Me.Lbl_Pasajero4.TabIndex = 24
        Me.Lbl_Pasajero4.Text = "Pasajero 4"
        Me.Lbl_Pasajero4.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(420, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 546)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'ListB_TodosLosPasajeros
        '
        Me.ListB_TodosLosPasajeros.FormattingEnabled = True
        Me.ListB_TodosLosPasajeros.ItemHeight = 16
        Me.ListB_TodosLosPasajeros.Location = New System.Drawing.Point(468, 121)
        Me.ListB_TodosLosPasajeros.Margin = New System.Windows.Forms.Padding(4)
        Me.ListB_TodosLosPasajeros.Name = "ListB_TodosLosPasajeros"
        Me.ListB_TodosLosPasajeros.Size = New System.Drawing.Size(357, 180)
        Me.ListB_TodosLosPasajeros.TabIndex = 27
        '
        'Lbl_Pasajeros
        '
        Me.Lbl_Pasajeros.AutoSize = True
        Me.Lbl_Pasajeros.Location = New System.Drawing.Point(611, 93)
        Me.Lbl_Pasajeros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Pasajeros.Name = "Lbl_Pasajeros"
        Me.Lbl_Pasajeros.Size = New System.Drawing.Size(71, 17)
        Me.Lbl_Pasajeros.TabIndex = 28
        Me.Lbl_Pasajeros.Text = "Pasajeros"
        '
        'Btn_ConfirmarPasajeros
        '
        Me.Btn_ConfirmarPasajeros.Location = New System.Drawing.Point(734, 34)
        Me.Btn_ConfirmarPasajeros.Name = "Btn_ConfirmarPasajeros"
        Me.Btn_ConfirmarPasajeros.Size = New System.Drawing.Size(82, 24)
        Me.Btn_ConfirmarPasajeros.TabIndex = 29
        Me.Btn_ConfirmarPasajeros.Text = "Aceptar"
        Me.Btn_ConfirmarPasajeros.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox2.Location = New System.Drawing.Point(848, 13)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(13, 546)
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Btn_VerReservas
        '
        Me.Btn_VerReservas.Location = New System.Drawing.Point(868, 12)
        Me.Btn_VerReservas.Name = "Btn_VerReservas"
        Me.Btn_VerReservas.Size = New System.Drawing.Size(92, 51)
        Me.Btn_VerReservas.TabIndex = 31
        Me.Btn_VerReservas.Text = "Ver Reservas"
        Me.Btn_VerReservas.UseVisualStyleBackColor = True
        '
        'ConfirmarReserva
        '
        Me.ConfirmarReserva.Location = New System.Drawing.Point(868, 516)
        Me.ConfirmarReserva.Name = "ConfirmarReserva"
        Me.ConfirmarReserva.Size = New System.Drawing.Size(94, 48)
        Me.ConfirmarReserva.TabIndex = 32
        Me.ConfirmarReserva.Text = "Confirmar"
        Me.ConfirmarReserva.UseVisualStyleBackColor = True
        '
        'ReservasTableAdapter
        '
        Me.ReservasTableAdapter.ClearBeforeFill = True
        '
        'BdUberAirDataSet
        '
        Me.BdUberAirDataSet.DataSetName = "BDUberAirDataSet"
        Me.BdUberAirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HacerReservaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 576)
        Me.Controls.Add(Me.ConfirmarReserva)
        Me.Controls.Add(Me.Btn_VerReservas)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Btn_ConfirmarPasajeros)
        Me.Controls.Add(Me.Lbl_Pasajeros)
        Me.Controls.Add(Me.ListB_TodosLosPasajeros)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtB_Pasajero4)
        Me.Controls.Add(Me.Lbl_Pasajero4)
        Me.Controls.Add(Me.TxtB_Pasajero3)
        Me.Controls.Add(Me.Lbl_Pasajero3)
        Me.Controls.Add(Me.TxtB_Pasajero2)
        Me.Controls.Add(Me.Lbl_Pasajero2)
        Me.Controls.Add(Me.TxtB_Pasajero1)
        Me.Controls.Add(Me.Lbl_Pasajero1)
        Me.Controls.Add(Me.TxtB_NumeroDePasajeros)
        Me.Controls.Add(Me.Lbl_NumeroDePasajeros)
        Me.Controls.Add(Me.Lbl_SeleccioneUnaHora)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Lbl_FechaSeleccionada)
        Me.Controls.Add(Me.Lbl_SeleccioneUnaFecha)
        Me.Controls.Add(Lbl_IdReserva)
        Me.Controls.Add(Me.TxtB_IdReserva)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HacerReservaCliente"
        Me.Text = "HacerReservaCliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasajerosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdUberAirDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_NumeroDePasajeros As System.Windows.Forms.Label
    Friend WithEvents Lbl_SeleccioneUnaHora As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Lbl_FechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents Lbl_SeleccioneUnaFecha As System.Windows.Forms.Label
    Friend WithEvents TxtB_IdReserva As System.Windows.Forms.TextBox
    Friend WithEvents TxtB_NumeroDePasajeros As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Pasajero1 As System.Windows.Forms.Label
    Friend WithEvents TxtB_Pasajero1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtB_Pasajero2 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Pasajero2 As System.Windows.Forms.Label
    Friend WithEvents TxtB_Pasajero3 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Pasajero3 As System.Windows.Forms.Label
    Friend WithEvents TxtB_Pasajero4 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Pasajero4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListB_TodosLosPasajeros As System.Windows.Forms.ListBox
    Friend WithEvents Lbl_Pasajeros As System.Windows.Forms.Label
    Friend WithEvents PasajerosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_ConfirmarPasajeros As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ReservasBindingSource As BindingSource
    Friend WithEvents Btn_VerReservas As Button
    Friend WithEvents ConfirmarReserva As Button
    Friend WithEvents ReservasTableAdapter As BDUberAirDataSetTableAdapters.ReservasTableAdapter
    Friend WithEvents BdUberAirDataSet As BDUberAirDataSet
End Class
