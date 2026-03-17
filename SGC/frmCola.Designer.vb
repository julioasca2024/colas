<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCola
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TimerTurnos = New System.Windows.Forms.Timer(Me.components)
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Location = New System.Drawing.Point(49, 37)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(39, 13)
        Me.lblTurno.TabIndex = 0
        Me.lblTurno.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(692, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 58)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TimerTurnos
        '
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(480, 418)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(126, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTurno)
        Me.Name = "Form1"
        Me.Text = "FormTV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTurno As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TimerTurnos As Timer
    Friend WithEvents dtpFecha As DateTimePicker
End Class
