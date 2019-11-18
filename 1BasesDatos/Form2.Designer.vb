<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sss = New System.Windows.Forms.Label()
        Me.txtTotalSaldo = New System.Windows.Forms.Label()
        Me.txtNCuenta = New System.Windows.Forms.Label()
        Me.btnReintegro = New System.Windows.Forms.Button()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lv2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasta"
        '
        'sss
        '
        Me.sss.AutoSize = True
        Me.sss.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sss.Location = New System.Drawing.Point(37, 405)
        Me.sss.Name = "sss"
        Me.sss.Size = New System.Drawing.Size(58, 24)
        Me.sss.TabIndex = 3
        Me.sss.Text = "Saldo"
        '
        'txtTotalSaldo
        '
        Me.txtTotalSaldo.AutoSize = True
        Me.txtTotalSaldo.Location = New System.Drawing.Point(179, 404)
        Me.txtTotalSaldo.Name = "txtTotalSaldo"
        Me.txtTotalSaldo.Size = New System.Drawing.Size(0, 13)
        Me.txtTotalSaldo.TabIndex = 4
        '
        'txtNCuenta
        '
        Me.txtNCuenta.AutoSize = True
        Me.txtNCuenta.Location = New System.Drawing.Point(137, 20)
        Me.txtNCuenta.Name = "txtNCuenta"
        Me.txtNCuenta.Size = New System.Drawing.Size(0, 13)
        Me.txtNCuenta.TabIndex = 5
        '
        'btnReintegro
        '
        Me.btnReintegro.Location = New System.Drawing.Point(36, 69)
        Me.btnReintegro.Name = "btnReintegro"
        Me.btnReintegro.Size = New System.Drawing.Size(75, 23)
        Me.btnReintegro.TabIndex = 6
        Me.btnReintegro.Text = "Reintegro"
        Me.btnReintegro.UseVisualStyleBackColor = True
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(156, 73)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 7
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(24, 155)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtDesde.TabIndex = 8
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(207, 158)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtHasta.TabIndex = 9
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(29, 226)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 10
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(146, 225)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 11
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lv2
        '
        Me.lv2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv2.HideSelection = False
        Me.lv2.Location = New System.Drawing.Point(12, 255)
        Me.lv2.Name = "lv2"
        Me.lv2.Size = New System.Drawing.Size(419, 130)
        Me.lv2.TabIndex = 12
        Me.lv2.UseCompatibleStateImageBehavior = False
        Me.lv2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Movimiento"
        Me.ColumnHeader1.Width = 82
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Importe"
        Me.ColumnHeader2.Width = 77
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Concepto"
        Me.ColumnHeader3.Width = 172
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Fecha"
        Me.ColumnHeader4.Width = 74
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 446)
        Me.Controls.Add(Me.lv2)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.btnReintegro)
        Me.Controls.Add(Me.txtNCuenta)
        Me.Controls.Add(Me.txtTotalSaldo)
        Me.Controls.Add(Me.sss)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sss As Label
    Friend WithEvents txtTotalSaldo As Label
    Friend WithEvents txtNCuenta As Label
    Friend WithEvents btnReintegro As Button
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents txtDesde As TextBox
    Friend WithEvents txtHasta As TextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents lv2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
