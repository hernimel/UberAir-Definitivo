Public Class HacerReservaCliente
    Public usuarioLogeadoHR As String
    Private Sub HacerReservaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReservasTableAdapter.Fill(Me.BdUberAirDataSet.Reservas)
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Lbl_FechaSeleccionada.Text = MonthCalendar1.SelectionStart
    End Sub
    Private Sub ListB_TodosLosPasajeros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListB_TodosLosPasajeros.Click

    End Sub

    Private Sub TxtB_IdReserva_TextChanged(sender As Object, e As EventArgs) Handles TxtB_IdReserva.TextChanged

    End Sub

    Private Sub Btn_ConfirmarPasajeros_Click(sender As Object, e As EventArgs) Handles Btn_ConfirmarPasajeros.Click
        Dim n As Integer, k As Integer
        Dim fila As System.Data.DataRowView

        ListB_TodosLosPasajeros.Items.Clear()
        n = Me.PasajerosBindingSource.Count
        Me.PasajerosBindingSource.MoveFirst()
        ListB_TodosLosPasajeros.Items.Add("NOMBRE" & vbTab & "APELLIDO" & vbTab & "DNI")
        For k = 0 To n - 1
            fila = Me.PasajerosBindingSource.Current
            If fila.Item("Id_Empresa") = usuarioLogeadoHR Then
                ListB_TodosLosPasajeros.Items.Add(fila.Item("Nombre") & vbTab & fila.Item("Apellido") & ", " & fila.Item("DNI"))
            End If
            Me.PasajerosBindingSource.MoveNext()
        Next


        Dim numPas As Integer

        numPas = TxtB_NumeroDePasajeros.Text

        If numPas = 1 Then
            Lbl_Pasajero1.Show()
            TxtB_Pasajero1.Show()
        ElseIf numPas = 2 Then
            Lbl_Pasajero1.Show()
            TxtB_Pasajero1.Show()
            Lbl_Pasajero2.Show()
            TxtB_Pasajero2.Show()
        ElseIf numPas = 3 Then
            Lbl_Pasajero1.Show()
            TxtB_Pasajero1.Show()
            Lbl_Pasajero2.Show()
            TxtB_Pasajero2.Show()
            Lbl_Pasajero3.Show()
            TxtB_Pasajero3.Show()
        ElseIf numPas = 4 Then
            Lbl_Pasajero1.Show()
            TxtB_Pasajero1.Show()
            Lbl_Pasajero2.Show()
            TxtB_Pasajero2.Show()
            Lbl_Pasajero3.Show()
            TxtB_Pasajero3.Show()
            Lbl_Pasajero4.Show()
            TxtB_Pasajero4.Show()
        End If
    End Sub

    Private Sub Lbl_NumeroDePasajeros_Click(sender As Object, e As EventArgs) Handles Lbl_NumeroDePasajeros.Click

    End Sub

    Private Sub TxtB_NumeroDePasajeros_TextChanged(sender As Object, e As EventArgs) Handles TxtB_NumeroDePasajeros.TextChanged

    End Sub

    Private Sub Btn_VerReservas_Click(sender As Object, e As EventArgs) Handles Btn_VerReservas.Click
        VerReservas.Show()

    End Sub

    Private Sub ConfirmarReservas_Click(sender As Object, e As EventArgs) Handles ConfirmarReserva.Click
        Dim idReserva As String
        idReserva = Left(usuarioLogeadoHR, 1)
        Me.ReservasTableAdapter.ConfirmarReservaInsertQuery(Id_Reserva:=, Id_Drone:=, Fecha_y_hora:=, Lugar:=, Estado:=, Dni_Pasajero1:=, Dni_Pasajero2:=, Dni_Pasajero3:=
                                                            , Dni_Pasajero4:=)
        Me.ReservasTableAdapter.Fill(Me.BdUberAirDataSet.Reservas)
    End Sub
End Class