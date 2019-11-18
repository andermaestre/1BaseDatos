<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lv1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.NCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'lv1
        '
        Me.lv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NCuenta, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lv1.HideSelection = False
        Me.lv1.Location = New System.Drawing.Point(12, 235)
        Me.lv1.Name = "lv1"
        Me.lv1.Size = New System.Drawing.Size(355, 203)
        Me.lv1.TabIndex = 2
        Me.lv1.UseCompatibleStateImageBehavior = False
        Me.lv1.View = System.Windows.Forms.View.Details
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(206, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 47)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Continuar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 71)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(12, 136)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 5
        '
        'NCuenta
        '
        Me.NCuenta.Text = "Numero de cuenta"
        Me.NCuenta.Width = 162
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Tipo de Cuenta"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Saldo Actual"
        Me.ColumnHeader2.Width = 88
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 470)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lv1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lv1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents NCuenta As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
