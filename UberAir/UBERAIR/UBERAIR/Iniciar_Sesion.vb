Public Class Iniciar_Sesion

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDUberAirDataSet)

    End Sub

    Private Sub Iniciar_Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDUberAirDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.BDUberAirDataSet.Usuarios)
        Txtb_Usuario.Text = ""
        Txtb_Contraseña.Text = ""

    End Sub
    Private Sub Btn_Aceptar_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click
        Dim Usuario As String
        Dim Contraseña As String
        Dim i, n As Integer
        Dim fila As System.Data.DataRowView

        n = Me.UsuariosBindingSource.Count

        Usuario = Txtb_Usuario.Text
        Contraseña = Txtb_Contraseña.Text

        Me.UsuariosBindingSource.MoveFirst()

        For i = 1 To n
            fila = Me.UsuariosBindingSource.Current
            If Usuario = fila.Item("id_empresa") And Contraseña = fila.Item("contraseña") Then
                Me.Hide()
                If Usuario = "UberAir" Then
                    Administrador.Show()

                    Exit For
                Else
                    Cliente.Show()
                End If
            Else
                MessageBox.Show("Verifique los datos ingresados")
                Me.Show()
                Txtb_Usuario.Text = ""
                Txtb_Contraseña.Text = ""
                Exit For
            End If
            Me.UsuariosBindingSource.MoveNext()
        Next
    End Sub
End Class