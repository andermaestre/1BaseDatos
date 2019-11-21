Imports System.Data.SqlClient

Public Class Form3
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txNc.Text = CuentaActual
        txtSaldoAct.Text = SaldoAct
        consulta.CommandText = "Select * From BaseDatos.Muvimientos Where NCuenta=@nc And Fecha Between @fechaIni and @fechaFin"
        consulta.Parameters.AddWithValue("@fechaIni", desde)
        consulta.Parameters.AddWithValue("@fechaFin", hasta)
        consulta.Parameters.AddWithValue("@nc", CuentaActual)
        cn.Open()


        dr = consulta.ExecuteReader

        If (dr.Read) Then
            If Not IsDBNull(dr("NMovimiento")) Then
                LLenarLista(dr)
            End If
        End If
        cn.Close()
    End Sub


    Private Sub LLenarLista(dr As SqlDataReader)
        lv3.Items.Clear()
        Dim it As ListViewItem
        Do
            it = lv3.Items.Add(dr("NMovimiento").ToString)
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