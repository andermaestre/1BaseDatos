Imports System.Data.SqlClient

Module Modúlo
    Public cadena As String = "Data Source=SEGUNDO150;Initial Catalog=DAM_Andermaestre_DEV;Integrated Security=True"
    Public CuentaActual As String
    Public cn As SqlConnection = New SqlConnection(cadena)
    Public consulta As New SqlCommand
    Public dr As SqlDataReader

    Public desde As Date
    Public hasta As Date

    Public SaldoAct As Double
End Module
