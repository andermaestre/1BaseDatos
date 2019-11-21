<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lv3 = New System.Windows.Forms.ListView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.NMovimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txNc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldoAct = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lv3
        '
        Me.lv3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NMovimiento, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lv3.Location = New System.Drawing.Point(12, 46)
        Me.lv3.Name = "lv3"
        Me.lv3.Size = New System.Drawing.Size(314, 254)
        Me.lv3.TabIndex = 0
        Me.lv3.UseCompatibleStateImageBehavior = False
        Me.lv3.View = System.Windows.Forms.View.Details
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(13, 341)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(313, 36)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'NMovimiento
        '
        Me.NMovimiento.Text = "Nº Movimiento"
        Me.NMovimiento.Width = 82
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Importe"
        Me.ColumnHeader1.Width = 64
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Concepto"
        Me.ColumnHeader2.Width = 117
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nº de Cuenta"
        '
        'txNc
        '
        Me.txNc.AutoSize = True
        Me.txNc.Location = New System.Drawing.Point(166, 19)
        Me.txNc.Name = "txNc"
        Me.txNc.Size = New System.Drawing.Size(0, 13)
        Me.txNc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Saldo"
        '
        'txtSaldoAct
        '
        Me.txtSaldoAct.AutoSize = True
        Me.txtSaldoAct.Location = New System.Drawing.Point(145, 319)
        Me.txtSaldoAct.Name = "txtSaldoAct"
        Me.txtSaldoAct.Size = New System.Drawing.Size(0, 13)
        Me.txtSaldoAct.TabIndex = 5
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 389)
        Me.Controls.Add(Me.txtSaldoAct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txNc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lv3)
        Me.Name = "Form3"
        Me.Text = "list"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lv3 As ListView
    Friend WithEvents btnSalir As Button
    Friend WithEvents NMovimiento As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents txNc As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaldoAct As Label
End Class
