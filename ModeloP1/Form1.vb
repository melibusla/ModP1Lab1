Public Class Form1
    'Datos del problema
    'Costo de los insumos:
    'Cartucho Negro = 250
    'Cartucho Color = 320
    'Repuesto Toner = 400
    'Resma A4 = 220
    'Resma Oficio = 280

    'Servicios Opcionales:
    'Entrega a Domicilio = 50
    'Garantìa Extendida = 100

    'Forma de Pago:
    'Contado = 10% de Descuento
    'Debito = sin cambios
    'Crèdito = 5% de Recargo

    'Calcular el Importe Total de la Venta


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmbInsumo.SelectedIndex = 0
        cmbFormaPago.SelectedIndex = 0
        chkEntrega.Checked = False
        chkGarantia.Checked = False
        cmdVender.Enabled = False
    End Sub

    Private Sub txtNombreCliente_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombreCliente.TextChanged
        If txtNombreCliente.Text <> "" And txtCantidad.Text <> "" Then
            cmdVender.Enabled = True
        Else
            cmdVender.Enabled = False
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCantidad.TextChanged
        If txtNombreCliente.Text <> "" And txtCantidad.Text <> "" Then
            cmdVender.Enabled = True
        Else
            cmdVender.Enabled = False
        End If
    End Sub

    Private Sub cmdVender_Click(sender As System.Object, e As System.EventArgs) Handles cmdVender.Click
        Dim Cantidad As Integer
        Dim Total As Decimal
        Dim Insumo As Integer
        'toma el formato de text a integer
        Cantidad = Val(txtCantidad.Text)
        Insumo = cmbInsumo.SelectedIndex

        Select Case Insumo
            Case 0
                Total = 250
            Case 1
                Total = 320
            Case 2
                Total = 400
            Case 3
                Total = 220
            Case 4
                Total = 280
        End Select
        Total = Total * Cantidad

        If chkEntrega.Checked Then
            Total = Total + 50
        End If
        If chkGarantia.Checked Then
            Total = Total + 100
        End If

        If cmbFormaPago.SelectedIndex = 0 Then
            Total = Total - (Total * 10 / 100)
        Else
            If cmbFormaPago.SelectedIndex = 2 Then
                Total = Total + (Total * 5 / 100)
            End If
        End If

        txtImporte.Text = Val(Total)

    End Sub

    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        txtNombreCliente.Text = ""
        txtCantidad.Text = ""
        txtImporte.Text = ""
        cmbInsumo.SelectedIndex = 0
        cmbFormaPago.SelectedIndex = 0
        chkEntrega.Checked = False
        chkGarantia.Checked = False
        cmdVender.Enabled = False

    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class
