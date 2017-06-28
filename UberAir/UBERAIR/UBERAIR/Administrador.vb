Public Class Administrador
    Private Sub DronesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_AgregarDrone.Click
        Dim DroneInput As String = ""
        Dim Modelo As String = ""
        Dim Capacidad As Integer = 0
        Dim Autonomia As Integer = 30
        Dim Estado As Boolean = False
        Dim Creditos As Integer = 0
        Dim n, i As Integer
        Dim fila As System.Data.DataRowView

        DroneInput = InputBox("Ingrese Id_DInputBoxrone para agregar: ")

        If DroneInput = "" Then
            MessageBox.Show("No se ingresó ningún DRONE")
            Exit Sub
        End If

        n = Me.DronesBindingSource.Count 'Cuenta la cantidad de registros
        Me.DronesBindingSource.MoveFirst()

        For i = 1 To n
            fila = Me.DronesBindingSource.Current
            If DroneInput = fila.Item("id_Drone") Then
                MessageBox.Show("El id del Drone ya existe, por favor ingrese otro")
                Exit Sub
            End If
            Me.DronesBindingSource.MoveNext()
        Next

        If Microsoft.VisualBasic.Left(DroneInput, 1) = "A" Then
            Modelo = Microsoft.VisualBasic.Left(DroneInput, 1)
            Capacidad = 1
            Estado = False
            Creditos = 2
        ElseIf Microsoft.VisualBasic.Left(DroneInput, 1) = "B" Then
            Modelo = Microsoft.VisualBasic.Left(DroneInput, 1)
            Capacidad = 2
            Estado = False
            Creditos = "4"
        ElseIf Microsoft.VisualBasic.Left(DroneInput, 1) = "C" Then
            Modelo = Microsoft.VisualBasic.Left(DroneInput, 1)
            Capacidad = "4"
            Estado = False
            Creditos = "6"
        End If


        Me.DronesTableAdapter.InsertDroneQuery(DroneInput, Modelo, Capacidad, Autonomia, Estado, Creditos)
        Me.DronesTableAdapter.Fill(Me.BDUberAirDataSet.Drones)
    End Sub
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDUberAirDataSet.Bases' Puede moverla o quitarla según sea necesario.
        Me.BasesTableAdapter.Fill(Me.BDUberAirDataSet.Bases)
        'TODO: esta línea de código carga datos en la tabla 'BDUberAirDataSet.Reservas' Puede moverla o quitarla según sea necesario.
        Me.ReservasTableAdapter.Fill(Me.BDUberAirDataSet.Reservas)
        'TODO: esta línea de código carga datos en la tabla 'BDUberAirDataSet.Pasajeros' Puede moverla o quitarla según sea necesario.
        Me.PasajerosTableAdapter.Fill(Me.BDUberAirDataSet.Pasajeros)
        'TODO: esta línea de código carga datos en la tabla 'BDUberAirDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.BDUberAirDataSet.Usuarios)
        Me.DronesTableAdapter.Fill(Me.BDUberAirDataSet.Drones)
    End Sub

    Private Sub Btn_BorrarDrone_Click(sender As Object, e As EventArgs) Handles Btn_BorrarDrone.Click
        Dim DronInput As String
        DronInput = InputBox("Ingrese Id_Drone para borrar: ")
        Me.DronesTableAdapter.DeleteDroneQuery(DronInput)
        Me.DronesTableAdapter.Fill(Me.BDUberAirDataSet.Drones)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_AgregarUsuarios.Click
        Dim n, i As Integer
        Dim EmpresaIngresada As String
        Dim Contraseña As String
        Dim Rol As String
        Dim Creditos_Mensuales As Integer
        Dim fila As System.Data.DataRowView

       

        EmpresaIngresada = InputBox("Ingrese Id_Empresa")
        If EmpresaIngresada = "" Then
            MessageBox.Show("No se ingresó ningún Id_Empresa")
            Exit Sub
        End If

        n = Me.UsuariosBindingSource.Count 'Cuenta la cantidad de registros
        Me.UsuariosBindingSource.MoveFirst()

        For i = 1 To n
            fila = Me.UsuariosBindingSource.Current
            If EmpresaIngresada = fila.Item("Id_empresa") Then
                MessageBox.Show("La empresa ingresada ya existe, por favor ingrese otra")
                Exit Sub
            End If
            Me.UsuariosBindingSource.MoveNext()
        Next

        Contraseña = InputBox("Ingrese Contraseña")
        If Contraseña = "" Then
            MessageBox.Show("No se ingresó ninguna Contraseña")
            Exit Sub
        End If
        Rol = InputBox("Ingrese Rol")
        If Rol = "" Then
            MessageBox.Show("No se ingresó ningún Rol")
            Exit Sub
        ElseIf Rol <> ("Cliente") Or Rol <> ("Admin") Then
            MessageBox.Show("Error en el Rol de Usuario, recuerde que las categorías son: Cliente o Admin ")
            Exit Sub
        End If
        Creditos_Mensuales = InputBox("Ingrese Créditos Mensuales")
        If Creditos_Mensuales = "0" Then
            MessageBox.Show("No se ingresaron Créditos Mensuales")
            Exit Sub
        End If

        

        Me.UsuariosTableAdapter.InsertUsuariosQuery(EmpresaIngresada, Contraseña, Rol, Creditos_Mensuales)
        Me.UsuariosTableAdapter.Fill(Me.BDUberAirDataSet.Usuarios)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_ModificarUsuarios.Click
        Me.UsuariosTableAdapter.UpdateUsuarioActualizado(ContraseñaTextBoxUsuarios.Text, RolTextBoxUsuarios.Text, Creditos_MensualesTextBoxUsuarios.Text, Id_empresaTextBoxUsuarios.Text)
        Me.UsuariosTableAdapter.Fill(Me.BDUberAirDataSet.Usuarios)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_BorrarUsuarios.Click
        Me.UsuariosTableAdapter.DeleteUsuariosQuery(Id_empresaTextBoxUsuarios.Text)
        Me.UsuariosTableAdapter.Fill(Me.BDUberAirDataSet.Usuarios)
    End Sub

    Private Sub Btn_AgregarPasajeros_Click(sender As Object, e As EventArgs) Handles Btn_AgregarPasajeros.Click
        Dim n, i, a, b, c As Integer
        Dim Empresa As String
        Dim Nombre As String
        Dim Apellido As String
        Dim DNI As Integer
        Dim Celular As Integer
        Dim fila As System.Data.DataRowView

        a = 0
        b = 0
        c = 0
        n = 0
        i = 0

        n = Me.PasajerosBindingSource.Count

        Empresa = InputBox("Ingrese la Empresa de el/la nuevo/a Pasajero/a")

        If Empresa = "" Then
            MessageBox.Show("No se ingresó ningúna Empresa")
            Exit Sub
        End If


        Nombre = InputBox("Ingrese el Nombre del nuevo/a Pasajero/a")

        If Nombre = "" Then
            MessageBox.Show("No se ingresó ningún Nombre")
            Exit Sub
        End If

        Apellido = InputBox("Ingrese el Apellido de el/la nuevo/a Pasajero/a")


        If Apellido = "" Then
            MessageBox.Show("No se ingresó ningún Apellido")
            Exit Sub
        End If

        DNI = InputBox("Ingrese el DNI del nuevo/a Pasajero/a")

        If DNI = "0" Then
            MessageBox.Show("No se ingresó ningún Apellido")
            Exit Sub
        End If


        Me.PasajerosBindingSource.MoveFirst()

        For b = 1 To n
            fila = Me.PasajerosBindingSource.Current
            If DNI = fila.Item("DNI") Then
                MessageBox.Show("El DNI ingresado ya existe, por favor ingrese otro")
                Exit Sub
            End If
            Me.PasajerosBindingSource.MoveNext()
        Next

        Celular = InputBox("Ingrese el Celular del nuevo/a Pasajero/a")

        If Celular = "0" Then
            MessageBox.Show("No se ingresó ningún Celular")
            Exit Sub
        End If





        Me.PasajerosTableAdapter.InsertPasajerosQuery(Empresa, Nombre, Apellido, DNI, Celular)
        Me.PasajerosTableAdapter.Fill(Me.BDUberAirDataSet.Pasajeros)
    End Sub

    Private Sub Btn_ModificarPasajeros_Click(sender As Object, e As EventArgs) Handles Btn_ModificarPasajeros.Click

        Me.PasajerosTableAdapter.UpdatePasajeroQueryNueva(Id_EmpresaTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, DNITextBox.Text, CelularTextBox.Text)
        Me.PasajerosTableAdapter.Fill(Me.BDUberAirDataSet.Pasajeros)
    End Sub

    Private Sub Btn_EliminarPasajeros_Click(sender As Object, e As EventArgs) Handles Btn_EliminarPasajeros.Click
        Me.PasajerosTableAdapter.DeletePasajerosQuery(DNITextBox.Text)
        Me.PasajerosTableAdapter.Fill(Me.BDUberAirDataSet.Pasajeros)
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ToolStripStatusLabel1.Text = Date.Now
    End Sub

    Private Sub Btn_InsertarBases_Click(sender As Object, e As EventArgs) Handles Btn_InsertarBases.Click

        Dim nomBase As String
        Dim n, i As Integer
        Dim fila As System.Data.DataRowView

        nomBase = InputBox("Ingrese la nueva Base")

        n = Me.BasesBindingSource.Count 'Cuenta la cantidad de registros
        Me.BasesBindingSource.MoveFirst()

        For i = 1 To n
            fila = Me.BasesBindingSource.Current
            If nomBase = fila.Item("Nombre") Then
                MessageBox.Show("La base ya existe, por favor ingrese otra")
                Exit Sub
            End If
            Me.BasesBindingSource.MoveNext()
        Next

        Me.BasesTableAdapter.InsertBasesQuery(nomBase)
        Me.BasesTableAdapter.Fill(Me.BDUberAirDataSet.Bases)


    End Sub

    Private Sub Btn_EliminarBases_Click(sender As Object, e As EventArgs) Handles Btn_EliminarBases.Click
        Me.BasesTableAdapter.DeleteBasesQuery(NombreTextBox1.Text)
        Me.BasesTableAdapter.Fill(Me.BDUberAirDataSet.Bases)
    End Sub

End Class