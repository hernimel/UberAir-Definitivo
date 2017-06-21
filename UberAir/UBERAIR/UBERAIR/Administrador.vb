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
        Dim n As Integer
        Dim fila As System.Data.DataRowView

        DroneInput = InputBox("Ingrese Id_Drone para agregar: ")

        If DroneInput = "" Then
            MessageBox.Show("Por favor llene el campo")
            Exit Sub
        End If

        n = Me.DronesBindingSource.Count
        Me.DronesBindingSource.MoveFirst()

        For i = 1 To n
            fila = Me.DronesBindingSource.Current
            If DroneInput = fila.Item("id_Drone") Then
                MessageBox.Show("El id del Drone ya existe, por favor ingrese otro")
                Exit Sub
            End If
            Me.DronesBindingSource.MoveNext()
        Next

        Select Case DroneInput
            Case Microsoft.VisualBasic.Left(DroneInput, 1) = "A"
                Modelo = Microsoft.VisualBasic.Left(DroneInput, 1)
                Capacidad = 1
                Estado = False
                Creditos = 2
            Case Microsoft.VisualBasic.Left(DroneInput, 1) = "B"
                Modelo = Microsoft.VisualBasic.Left(DroneInput, 1)
                Capacidad = 2
                Estado = False
                Creditos = "4"
            Case Microsoft.VisualBasic.Left(DroneInput, 1) = "C"
                Modelo = Microsoft.VisualBasic.Left(DroneInput, 1)
                Capacidad = "4"
                Estado = False
                Creditos = "6"
        End Select

        Me.DronesTableAdapter.InsertDroneQuery(DroneInput, Modelo, Capacidad, Autonomia, Estado, Creditos)
        Me.DronesTableAdapter.Fill(Me.BDUberAirDataSet.Drones)
    End Sub

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.UsuariosTableAdapter.InsertUsuariosQuery(Id_empresaTextBoxUsuarios.Text, ContraseñaTextBoxUsuarios.Text, RolTextBoxUsuarios.Text, Creditos_MensualesTextBoxUsuarios.Text)
        Me.UsuariosTableAdapter.Fill(Me.BDUberAirDataSet.Usuarios)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_ModificarUsuarios.Click
        Me.UsuariosTableAdapter.UpdateUsuariosQuery(Id_empresaTextBoxUsuarios.Text, ContraseñaTextBoxUsuarios.Text, RolTextBoxUsuarios.Text, Creditos_MensualesTextBoxUsuarios.Text)
        Me.UsuariosTableAdapter.Fill(Me.BDUberAirDataSet.Usuarios)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_BorrarUsuarios.Click
        Me.UsuariosTableAdapter.DeleteUsuariosQuery(Id_empresaTextBoxUsuarios.Text)
        Me.UsuariosTableAdapter.Fill(Me.BDUberAirDataSet.Usuarios)
    End Sub

    Private Sub Btn_AgregarPasajeros_Click(sender As Object, e As EventArgs) Handles Btn_AgregarPasajeros.Click
        Me.PasajerosTableAdapter.InsertPasajerosQuery(Id_EmpresaTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, DNITextBox.Text, CelularTextBox.Text)
        Me.PasajerosTableAdapter.Fill(Me.BDUberAirDataSet.Pasajeros)
    End Sub

    Private Sub Btn_ModificarPasajeros_Click(sender As Object, e As EventArgs) Handles Btn_ModificarPasajeros.Click
        Me.PasajerosTableAdapter.UpdatePasajerosQuery(Id_EmpresaTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, DNITextBox.Text, CelularTextBox.Text)
        Me.PasajerosTableAdapter.Fill(Me.BDUberAirDataSet.Pasajeros)
    End Sub

    Private Sub Btn_EliminarPasajeros_Click(sender As Object, e As EventArgs) Handles Btn_EliminarPasajeros.Click
        Me.PasajerosTableAdapter.DeletePasajerosQuery(DNITextBox.Text)
        Me.PasajerosTableAdapter.Fill(Me.BDUberAirDataSet.Pasajeros)
    End Sub

    
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ToolStripStatusLabel1.Text = Date.Now
    End Sub

    Private Sub Btn_ConfirmarReserva_Click(sender As Object, e As EventArgs) Handles Btn_ConfirmarReserva.Click

    End Sub
End Class