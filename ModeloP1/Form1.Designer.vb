<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbInsumo = New System.Windows.Forms.ComboBox()
        Me.grpCambiar = New System.Windows.Forms.GroupBox()
        Me.chkGarantia = New System.Windows.Forms.CheckBox()
        Me.chkEntrega = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.cmdVender = New System.Windows.Forms.Button()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.grpCambiar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Cliente"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(120, 20)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(178, 20)
        Me.txtNombreCliente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de Insumo"
        '
        'cmbInsumo
        '
        Me.cmbInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInsumo.FormattingEnabled = True
        Me.cmbInsumo.Items.AddRange(New Object() {"Cartucho Tinta Negra", "Cartucho Tinta Color", "Repuesto Toner", "Resma A4", "Resma Oficio"})
        Me.cmbInsumo.Location = New System.Drawing.Point(120, 52)
        Me.cmbInsumo.Name = "cmbInsumo"
        Me.cmbInsumo.Size = New System.Drawing.Size(178, 21)
        Me.cmbInsumo.TabIndex = 3
        '
        'grpCambiar
        '
        Me.grpCambiar.Controls.Add(Me.chkGarantia)
        Me.grpCambiar.Controls.Add(Me.chkEntrega)
        Me.grpCambiar.Location = New System.Drawing.Point(24, 130)
        Me.grpCambiar.Name = "grpCambiar"
        Me.grpCambiar.Size = New System.Drawing.Size(273, 102)
        Me.grpCambiar.TabIndex = 4
        Me.grpCambiar.TabStop = False
        Me.grpCambiar.Text = "Servicios Opcionales"
        '
        'chkGarantia
        '
        Me.chkGarantia.AutoSize = True
        Me.chkGarantia.Location = New System.Drawing.Point(14, 64)
        Me.chkGarantia.Name = "chkGarantia"
        Me.chkGarantia.Size = New System.Drawing.Size(118, 17)
        Me.chkGarantia.TabIndex = 1
        Me.chkGarantia.Text = "Garantía Extendida"
        Me.chkGarantia.UseVisualStyleBackColor = True
        '
        'chkEntrega
        '
        Me.chkEntrega.AutoSize = True
        Me.chkEntrega.Location = New System.Drawing.Point(15, 35)
        Me.chkEntrega.Name = "chkEntrega"
        Me.chkEntrega.Size = New System.Drawing.Size(117, 17)
        Me.chkEntrega.TabIndex = 0
        Me.chkEntrega.Text = "Entrega a Domicilio"
        Me.chkEntrega.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Forma de Pago"
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Items.AddRange(New Object() {"Contado", "Debito", "Credito"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(120, 254)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(178, 21)
        Me.cmbFormaPago.TabIndex = 7
        '
        'cmdVender
        '
        Me.cmdVender.Enabled = False
        Me.cmdVender.Location = New System.Drawing.Point(334, 18)
        Me.cmdVender.Name = "cmdVender"
        Me.cmdVender.Size = New System.Drawing.Size(75, 23)
        Me.cmdVender.TabIndex = 8
        Me.cmdVender.Text = "&Vender"
        Me.cmdVender.UseVisualStyleBackColor = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(334, 104)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCerrar.TabIndex = 10
        Me.cmdCerrar.Text = "&Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 298)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Importe Total"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(220, 296)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(2)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.ReadOnly = True
        Me.txtImporte.Size = New System.Drawing.Size(76, 20)
        Me.txtImporte.TabIndex = 12
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(334, 61)
        Me.cmdLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdLimpiar.TabIndex = 13
        Me.cmdLimpiar.Text = "&Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 91)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(120, 91)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(76, 20)
        Me.txtCantidad.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 349)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdVender)
        Me.Controls.Add(Me.cmbFormaPago)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpCambiar)
        Me.Controls.Add(Me.cmbInsumo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta de Insumos"
        Me.grpCambiar.ResumeLayout(False)
        Me.grpCambiar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbInsumo As System.Windows.Forms.ComboBox
    Friend WithEvents grpCambiar As System.Windows.Forms.GroupBox
    Friend WithEvents chkGarantia As System.Windows.Forms.CheckBox
    Friend WithEvents chkEntrega As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents cmdVender As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox

End Class
