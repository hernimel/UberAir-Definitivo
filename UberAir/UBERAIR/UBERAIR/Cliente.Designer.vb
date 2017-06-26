<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Me.Btn_AdministrarPasajeros = New System.Windows.Forms.Button()
        Me.BDUberAirDataSet = New UBERAIR.BDUberAirDataSet()
        Me.ReservasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservasTableAdapter = New UBERAIR.BDUberAirDataSetTableAdapters.ReservasTableAdapter()
        Me.TableAdapterManager = New UBERAIR.BDUberAirDataSetTableAdapters.TableAdapterManager()
        Me.Btn_HacerReserva = New System.Windows.Forms.Button()
        CType(Me.BDUberAirDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_AdministrarPasajeros
        '
        Me.Btn_AdministrarPasajeros.Location = New System.Drawing.Point(362, 48)
        Me.Btn_AdministrarPasajeros.Name = "Btn_AdministrarPasajeros"
        Me.Btn_AdministrarPasajeros.Size = New System.Drawing.Size(237, 465)
        Me.Btn_AdministrarPasajeros.TabIndex = 1
        Me.Btn_AdministrarPasajeros.Text = "Administrar Pasajeros"
        Me.Btn_AdministrarPasajeros.UseVisualStyleBackColor = True
        '
        'BDUberAirDataSet
        '
        Me.BDUberAirDataSet.DataSetName = "BDUberAirDataSet"
        Me.BDUberAirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservasBindingSource
        '
        Me.ReservasBindingSource.DataMember = "Reservas"
        Me.ReservasBindingSource.DataSource = Me.BDUberAirDataSet
        '
        'ReservasTableAdapter
        '
        Me.ReservasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BasesTableAdapter = Nothing
        Me.TableAdapterManager.DronesTableAdapter = Nothing
        Me.TableAdapterManager.Hoja_de_RutaTableAdapter = Nothing
        Me.TableAdapterManager.PasajerosTableAdapter = Nothing
        Me.TableAdapterManager.ReservasTableAdapter = Me.ReservasTableAdapter
        Me.TableAdapterManager.UpdateOrder = UBERAIR.BDUberAirDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Btn_HacerReserva
        '
        Me.Btn_HacerReserva.Location = New System.Drawing.Point(61, 48)
        Me.Btn_HacerReserva.Name = "Btn_HacerReserva"
        Me.Btn_HacerReserva.Size = New System.Drawing.Size(237, 465)
        Me.Btn_HacerReserva.TabIndex = 2
        Me.Btn_HacerReserva.Text = "Hacer Reserva"
        Me.Btn_HacerReserva.UseVisualStyleBackColor = True
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 540)
        Me.Controls.Add(Me.Btn_HacerReserva)
        Me.Controls.Add(Me.Btn_AdministrarPasajeros)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        CType(Me.BDUberAirDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_AdministrarPasajeros As System.Windows.Forms.Button
    Friend WithEvents BDUberAirDataSet As UBERAIR.BDUberAirDataSet
    Friend WithEvents ReservasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservasTableAdapter As UBERAIR.BDUberAirDataSetTableAdapters.ReservasTableAdapter
    Friend WithEvents TableAdapterManager As UBERAIR.BDUberAirDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Btn_HacerReserva As System.Windows.Forms.Button
End Class
