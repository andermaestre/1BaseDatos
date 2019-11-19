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

    Private Sub BtnReintegro_Click(sender As Object, e As EventArgs) Handles btnReintegro.Click


        If txtImporte.Text.CompareTo("") <> 0 Then

            cn.Open()

            Dim maxNMovimiento As Integer
            Dim Importe As Double
            Dim Concepto As String
            Dim Fecha As Date
            Dim ncuenta As Integer
            ncuenta = Integer.Parse(CuentaActual)
            Importe = Double.Parse(txtImporte.Text)
            Fecha = Date.Today
            Concepto = "REINTEGRO CAJERO"
            consulta.CommandText = String.Format("SELECT MAX(NMovimiento) FROM BaseDatos.Muvimientos")
            maxNMovimiento = consulta.ExecuteScalar() + 1

            consulta.CommandText = "Insert Into BaseDatos.Muvimientos (NMovimiento, Importe, Concepto, Fecha, NCuenta) Values(@nm,@imp,@con,@fec,@nc)"

            consulta.Parameters.AddWithValue("@nm", maxNMovimiento)
            consulta.Parameters.AddWithValue("@imp", Importe)
            consulta.Parameters.AddWithValue("@con", Concepto)
            consulta.Parameters.AddWithValue("@fec", Fecha)
            consulta.Parameters.AddWithValue("@nc", ncuenta)



            consulta.ExecuteNonQuery()
            cn.Close()
            cn.Open()


            consulta.CommandText = String.Format("SELECT NMovimiento, Importe, Concepto, Fecha FROM BaseDatos.Muvimientos WHERE NCuenta='{0}' ", txtNCuenta.Text)
            dr = consulta.ExecuteReader()

            If dr.Read Then

                If Not IsDBNull(dr("NMovimiento")) Then
                    LLenarLista(dr)
                End If

            End If
            cn.Close()
            cn.Open()
            txtTotalSaldo.Text = Double.Parse(txtTotalSaldo.Text) + Double.Parse(txtImporte.Text)
            Dim updSaldo As Double
            updSaldo = Double.Parse(txtTotalSaldo.Text)

            consulta.CommandText = "Insert Into BaseDatos.Cuentas (SaldoActual) Values(@sal)"

            consulta.Parameters.AddWithValue("@sal", updSaldo)
        Else
            MsgBox("Caca pa ti")
        End If

        cn.Close()
    End Sub
End Class