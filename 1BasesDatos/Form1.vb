Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        consulta.CommandText = String.Format("SELECT NCuenta, Tipo, SaldoActual FROM BaseDatos.Usuarios LEFT JOIN BaseDatos.Cuentas On BaseDatos.Cuentas.Titular=BaseDatos.Usuarios.Username WHERE BaseDatos.Usuarios.Password='{0}' AND BaseDatos.Usuarios.UserName='{1}'", txtPassword.Text, txtUsername.Text)
        consulta.CommandType = CommandType.Text
        cn.Open()

        consulta.Connection = cn

        dr = consulta.ExecuteReader()

        If dr.Read Then

            If Not IsDBNull(dr("NCuenta")) Then
                LLenarLista(dr)
            End If
        Else
            MsgBox("Nombre de usuario y contraseña incorrectos")
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub LLenarLista(dr As SqlDataReader)
        lv1.Items.Clear()
        Dim it As ListViewItem
        Do
            it = lv1.Items.Add(dr("NCuenta").ToString)
            If Not IsDBNull(dr("Tipo")) Then
                it.SubItems.Add(dr("Tipo"))
            Else
                it.SubItems.Add("null")
            End If
            it.SubItems.Add(dr("SaldoActual").ToString)
        Loop While dr.Read
    End Sub

    Private Sub Lv1_DoubleClick(sender As Object, e As EventArgs) Handles lv1.DoubleClick
        CuentaActual = lv1.SelectedItems(0).Text

        Dim f As New Form2
        f.Show()

    End Sub
End Class
