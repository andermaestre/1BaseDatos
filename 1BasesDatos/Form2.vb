Imports System.Data.SqlClient

Public Class Form2
    Dim Saldo As Double
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNCuenta.Text = CuentaActual

        consulta.CommandText = String.Format("SELECT SaldoActual FROM BaseDatos.Cuentas WHERE NCuenta='{0}' ", CuentaActual)
        consulta.CommandType = CommandType.Text
        cn.Open()

        consulta.Connection = cn

        dr = consulta.ExecuteReader()
        If dr.Read Then
            Saldo = dr("SaldoActual")
        End If
        txtTotalSaldo.Text = Saldo
        dr.Close()

        consulta.CommandText = String.Format("SELECT NMovimiento, Importe, Concepto, Fecha FROM BaseDatos.Muvimientos WHERE NCuenta='{0}' ", txtNCuenta.Text)
        dr = consulta.ExecuteReader()

        If dr.Read Then

            If Not IsDBNull(dr("NMovimiento")) Then
                LLenarLista(dr)
            End If
        Else
            MsgBox("Nombre de usuario y contraseña incorrectos")
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub LLenarLista(dr As SqlDataReader)
        lv2.Items.Clear()
        Dim it As ListViewItem
        Do
            it = lv2.Items.Add(dr("NMovimiento").ToString)
            If Not IsDBNull(dr("Importe")) Then
                it.SubItems.Add(dr("Importe"))
            Else
                it.SubItems.Add("null")
            End If
            If Not IsDBNull(dr("Concepto")) Then
                it.SubItems.Add(dr("Concepto"))
            Else
                it.SubItems.Add("null")
            End If
            If Not IsDBNull(dr("Fecha")) Then
                it.SubItems.Add(dr("Fecha"))
            Else
                it.SubItems.Add("null")
            End If

        Loop While dr.Read
    End Sub
End Class