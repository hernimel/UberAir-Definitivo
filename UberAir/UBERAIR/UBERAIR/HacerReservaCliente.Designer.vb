<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HacerReservaCliente
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
        Dim Lbl_IdReserva As System.Windows.Forms.Label
        Me.Lbl_NumeroDePasajeros = New System.Windows.Forms.Label()
        Me.Lbl_SeleccioneUnaHora = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Lbl_FechaSeleccionada = New System.Windows.Forms.Label()
        Me.Lbl_SeleccioneUnaFecha = New System.Windows.Forms.Label()
        Me.TxtB_IdReserva = New System.Windows.Forms.TextBox()
        Me.TxtB_NumeroDePasajeros = New System.Windows.Forms.TextBox()
        Me.Divisor = New System.Windows.Forms.PictureBox()
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
        Me.Lbl_Drones = New System.Windows.Forms.Label()
        Me.PasajerosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Lbl_IdReserva = New System.Windows.Forms.Label()
        CType(Me.Divisor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasajerosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_IdReserva
        '
        Lbl_IdReserva.AutoSize = True
        Lbl_IdReserva.Location = New System.Drawing.Point(43, 50)
        Lbl_IdReserva.Name = "Lbl_IdReserva"
        Lbl_IdReserva.Size = New System.Drawing.Size(62, 13)
        Lbl_IdReserva.TabIndex = 9
        Lbl_IdReserva.Text = "Id Reserva:"
        '
        'Lbl_NumeroDePasajeros
        '
        Me.Lbl_NumeroDePasajeros.AutoSize = True
        Me.Lbl_NumeroDePasajeros.Location = New System.Drawing.Point(371, 50)
        Me.Lbl_NumeroDePasajeros.Name = "Lbl_NumeroDePasajeros"
        Me.Lbl_NumeroDePasajeros.Size = New System.Drawing.Size(108, 13)
        Me.Lbl_NumeroDePasajeros.TabIndex = 15
        Me.Lbl_NumeroDePasajeros.Text = "Numero de Pasajeros"
        '
        'Lbl_SeleccioneUnaHora
        '
        Me.Lbl_SeleccioneUnaHora.AutoSize = True
        Me.Lbl_SeleccioneUnaHora.Location = New System.Drawing.Point(43, 291)
        Me.Lbl_SeleccioneUnaHora.Name = "Lbl_SeleccioneUnaHora"
        Me.Lbl_SeleccioneUnaHora.Size = New System.Drawing.Size(107, 13)
        Me.Lbl_SeleccioneUnaHora.TabIndex = 14
        Me.Lbl_SeleccioneUnaHora.Text = "Seleccione una Hora"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(46, 102)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 13
        '
        'Lbl_FechaSeleccionada
        '
        Me.Lbl_FechaSeleccionada.AutoSize = True
        Me.Lbl_FechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FechaSeleccionada.Location = New System.Drawing.Point(140, 271)
        Me.Lbl_FechaSeleccionada.Name = "Lbl_FechaSeleccionada"
        Me.Lbl_FechaSeleccionada.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_FechaSeleccionada.TabIndex = 12
        Me.Lbl_FechaSeleccionada.Text = "____"
        '
        'Lbl_SeleccioneUnaFecha
        '
        Me.Lbl_SeleccioneUnaFecha.AutoSize = True
        Me.Lbl_SeleccioneUnaFecha.Location = New System.Drawing.Point(43, 80)
        Me.Lbl_SeleccioneUnaFecha.Name = "Lbl_SeleccioneUnaFecha"
        Me.Lbl_SeleccioneUnaFecha.Size = New System.Drawing.Size(114, 13)
        Me.Lbl_SeleccioneUnaFecha.TabIndex = 11
        Me.Lbl_SeleccioneUnaFecha.Text = "Seleccione una Fecha"
        '
        'TxtB_IdReserva
        '
        Me.TxtB_IdReserva.Location = New System.Drawing.Point(111, 47)
        Me.TxtB_IdReserva.Name = "TxtB_IdReserva"
        Me.TxtB_IdReserva.Size = New System.Drawing.Size(100, 20)
        Me.TxtB_IdReserva.TabIndex = 10
        '
        'TxtB_NumeroDePasajeros
        '
        Me.TxtB_NumeroDePasajeros.Location = New System.Drawing.Point(485, 47)
        Me.TxtB_NumeroDePasajeros.Name = "TxtB_NumeroDePasajeros"
        Me.TxtB_NumeroDePasajeros.Size = New System.Drawing.Size(100, 20)
        Me.TxtB_NumeroDePasajeros.TabIndex = 16
        '
        'Divisor
        '
        Me.Divisor.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Divisor.Location = New System.Drawing.Point(485, 102)
        Me.Divisor.Name = "Divisor"
        Me.Divisor.Size = New System.Drawing.Size(10, 354)
        Me.Divisor.TabIndex = 17
        Me.Divisor.TabStop = False
        '
        'Lbl_Pasajero1
        '
        Me.Lbl_Pasajero1.AutoSize = True
        Me.Lbl_Pasajero1.Location = New System.Drawing.Point(331, 268)
        Me.Lbl_Pasajero1.Name = "Lbl_Pasajero1"
        Me.Lbl_Pasajero1.Size = New System.Drawing.Size(54, 13)
        Me.Lbl_Pasajero1.TabIndex = 18
        Me.Lbl_Pasajero1.Text = "Pasajero1"
        '
        'TxtB_Pasajero1
        '
        Me.TxtB_Pasajero1.Location = New System.Drawing.Point(359, 284)
        Me.TxtB_Pasajero1.Name = "TxtB_Pasajero1"
        Me.TxtB_Pasajero1.Size = New System.Drawing.Size(100, 20)
        Me.TxtB_Pasajero1.TabIndex = 19
        '
        'TxtB_Pasajero2
        '
        Me.TxtB_Pasajero2.Location = New System.Drawing.Point(359, 326)
        Me.TxtB_Pasajero2.Name = "TxtB_Pasajero2"
        Me.TxtB_Pasajero2.Size = New System.Drawing.Size(100, 20)
        Me.TxtB_Pasajero2.TabIndex = 21
        '
        'Lbl_Pasajero2
        '
        Me.Lbl_Pasajero2.AutoSize = True
        Me.Lbl_Pasajero2.Location = New System.Drawing.Point(331, 310)
        Me.Lbl_Pasajero2.Name = "Lbl_Pasajero2"
        Me.Lbl_Pasajero2.Size = New System.Drawing.Size(57, 13)
        Me.Lbl_Pasajero2.TabIndex = 20
        Me.Lbl_Pasajero2.Text = "Pasajero 2"
        '
        'TxtB_Pasajero3
        '
        Me.TxtB_Pasajero3.Location = New System.Drawing.Point(359, 370)
        Me.TxtB_Pasajero3.Name = "TxtB_Pasajero3"
        Me.TxtB_Pasajero3.Size = New System.Drawing.Size(100, 20)
        Me.TxtB_Pasajero3.TabIndex = 23
        '
        'Lbl_Pasajero3
        '
        Me.Lbl_Pasajero3.AutoSize = True
        Me.Lbl_Pasajero3.Location = New System.Drawing.Point(331, 354)
        Me.Lbl_Pasajero3.Name = "Lbl_Pasajero3"
        Me.Lbl_Pasajero3.Size = New System.Drawing.Size(57, 13)
        Me.Lbl_Pasajero3.TabIndex = 22
        Me.Lbl_Pasajero3.Text = "Pasajero 3"
        '
        'TxtB_Pasajero4
        '
        Me.TxtB_Pasajero4.Location = New System.Drawing.Point(359, 410)
        Me.TxtB_Pasajero4.Name = "TxtB_Pasajero4"
        Me.TxtB_Pasajero4.Size = New System.Drawing.Size(100, 20)
        Me.TxtB_Pasajero4.TabIndex = 25
        '
        'Lbl_Pasajero4
        '
        Me.Lbl_Pasajero4.AutoSize = True
        Me.Lbl_Pasajero4.Location = New System.Drawing.Point(331, 394)
        Me.Lbl_Pasajero4.Name = "Lbl_Pasajero4"
        Me.Lbl_Pasajero4.Size = New System.Drawing.Size(57, 13)
        Me.Lbl_Pasajero4.TabIndex = 24
        Me.Lbl_Pasajero4.Text = "Pasajero 4"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(315, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 444)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'ListB_TodosLosPasajeros
        '
        Me.ListB_TodosLosPasajeros.FormattingEnabled = True
        Me.ListB_TodosLosPasajeros.Location = New System.Drawing.Point(334, 102)
        Me.ListB_TodosLosPasajeros.Name = "ListB_TodosLosPasajeros"
        Me.ListB_TodosLosPasajeros.Size = New System.Drawing.Size(145, 147)
        Me.ListB_TodosLosPasajeros.TabIndex = 27
        '
        'Lbl_Pasajeros
        '
        Me.Lbl_Pasajeros.AutoSize = True
        Me.Lbl_Pasajeros.Location = New System.Drawing.Point(384, 80)
        Me.Lbl_Pasajeros.Name = "Lbl_Pasajeros"
        Me.Lbl_Pasajeros.Size = New System.Drawing.Size(53, 13)
        Me.Lbl_Pasajeros.TabIndex = 28
        Me.Lbl_Pasajeros.Text = "Pasajeros"
        '
        'Lbl_Drones
        '
        Me.Lbl_Drones.AutoSize = True
        Me.Lbl_Drones.Location = New System.Drawing.Point(542, 80)
        Me.Lbl_Drones.Name = "Lbl_Drones"
        Me.Lbl_Drones.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_Drones.TabIndex = 29
        Me.Lbl_Drones.Text = "Drones"
        '
        'HacerReservaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 468)
        Me.Controls.Add(Me.Lbl_Drones)
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
        Me.Controls.Add(Me.Divisor)
        Me.Controls.Add(Me.TxtB_NumeroDePasajeros)
        Me.Controls.Add(Me.Lbl_NumeroDePasajeros)
        Me.Controls.Add(Me.Lbl_SeleccioneUnaHora)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Lbl_FechaSeleccionada)
        Me.Controls.Add(Me.Lbl_SeleccioneUnaFecha)
        Me.Controls.Add(Lbl_IdReserva)
        Me.Controls.Add(Me.TxtB_IdReserva)
        Me.Name = "HacerReservaCliente"
        Me.Text = "HacerReservaCliente"
        CType(Me.Divisor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasajerosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Divisor As System.Windows.Forms.PictureBox
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
    Friend WithEvents Lbl_Drones As System.Windows.Forms.Label
    Friend WithEvents PasajerosBindingSource As System.Windows.Forms.BindingSource
End Class
