<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Iniciar_Sesion
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
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDUberAirDataSet = New UBERAIR.BDUberAirDataSet()
        Me.Btn_Aceptar = New System.Windows.Forms.Button()
        Me.UsuariosTableAdapter = New UBERAIR.BDUberAirDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New UBERAIR.BDUberAirDataSetTableAdapters.TableAdapterManager()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Id_empresaLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDUberAirDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_empresaLabel
        '
        Id_empresaLabel.AutoSize = True
        Id_empresaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_empresaLabel.Location = New System.Drawing.Point(40, 71)
        Id_empresaLabel.Name = "Id_empresaLabel"
        Id_empresaLabel.Size = New System.Drawing.Size(76, 20)
        Id_empresaLabel.TabIndex = 1
        Id_empresaLabel.Text = "Usuario:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContraseñaLabel.Location = New System.Drawing.Point(40, 98)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(107, 20)
        ContraseñaLabel.TabIndex = 3
        ContraseñaLabel.Text = "Contraseña:"
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.BDUberAirDataSet
        '
        'BDUberAirDataSet
        '
        Me.BDUberAirDataSet.DataSetName = "BDUberAirDataSet"
        Me.BDUberAirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Aceptar.Location = New System.Drawing.Point(140, 145)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(100, 32)
        Me.Btn_Aceptar.TabIndex = 5
        Me.Btn_Aceptar.Text = "Aceptar"
        Me.Btn_Aceptar.UseVisualStyleBackColor = True
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BasesTableAdapter = Nothing
        Me.TableAdapterManager.DronesTableAdapter = Nothing
        Me.TableAdapterManager.Hoja_de_RutaTableAdapter = Nothing
        Me.TableAdapterManager.PasajerosTableAdapter = Nothing
        Me.TableAdapterManager.ReservasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UBERAIR.BDUberAirDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(154, 71)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 6
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Location = New System.Drawing.Point(154, 98)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenia.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasenia.TabIndex = 7
        '
        'Iniciar_Sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 258)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Btn_Aceptar)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Id_empresaLabel)
        Me.Name = "Iniciar_Sesion"
        Me.Text = "Iniciar_Sesion"
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDUberAirDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BDUberAirDataSet As UBERAIR.BDUberAirDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As UBERAIR.BDUberAirDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As UBERAIR.BDUberAirDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasenia As System.Windows.Forms.TextBox
End Class
