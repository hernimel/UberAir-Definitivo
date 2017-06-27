Public Class HacerReservaCliente

    Private Sub HacerReservaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Lbl_FechaSeleccionada.Text = MonthCalendar1.SelectionStart
    End Sub
    Private Sub ListB_TodosLosPasajeros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListB_TodosLosPasajeros.Click
        Dim n As Integer, k As Integer
        Dim fila As System.Data.DataRowView
        ListB_TodosLosPasajeros.Items.Clear()
        n = Me.PasajerosBindingSource.Count  'devuelve la cantidad de registros de la tabla
        Me.PasajerosBindingSource.MoveFirst()  'se posiciona en primer registro
        ListB_TodosLosPasajeros.Items.Add("paciente" & vbTab & "apellido y nombre" & vbTab & "fecha nacimiento")
        For k = 0 To n - 1
            fila = Me.PasajerosBindingSource.Current 'trae a la variable fila el registro actual
            If Me.PasajerosBindingSource.Current("Id_Empresa") = "Microsoft" Then
                ListB_TodosLosPasajeros.Items.Add(fila.Item("nombre") & vbTab & fila.Item("apellido") & ", " & fila.Item("dni"))
            End If
            Me.PasajerosBindingSource.MoveNext()  'mueve el puntero al proximo registro
        Next
    End Sub

    Private Sub TxtB_IdReserva_TextChanged(sender As Object, e As EventArgs) Handles TxtB_IdReserva.TextChanged

    End Sub

End Class