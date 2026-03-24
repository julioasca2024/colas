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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCola))
        Me.TimerTurnos = New System.Windows.Forms.Timer(Me.components)
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtgCola = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ventanilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimerLlamada = New System.Windows.Forms.Timer(Me.components)
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.txtOrdenllamada = New System.Windows.Forms.TextBox()
        CType(Me.dtgCola, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerTurnos
        '
        Me.TimerTurnos.Enabled = True
        Me.TimerTurnos.Interval = 6000
        '
        'dtFecha
        '
        Me.dtFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(0, 0)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(1457, 20)
        Me.dtFecha.TabIndex = 2
        '
        'dtgCola
        '
        Me.dtgCola.AllowUserToAddRows = False
        Me.dtgCola.AllowUserToDeleteRows = False
        Me.dtgCola.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dtgCola.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgCola.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCola.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.USUARIO, Me.col_orden, Me.col_ventanilla, Me.col_Estado, Me.col_id_estado})
        Me.dtgCola.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtgCola.Location = New System.Drawing.Point(0, 431)
        Me.dtgCola.Name = "dtgCola"
        Me.dtgCola.ReadOnly = True
        Me.dtgCola.RowHeadersVisible = False
        Me.dtgCola.RowHeadersWidth = 20
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCola.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgCola.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCola.Size = New System.Drawing.Size(1457, 218)
        Me.dtgCola.TabIndex = 3
        '
        'col_id
        '
        Me.col_id.DataPropertyName = "ID"
        Me.col_id.HeaderText = "ID"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col_id.Visible = False
        '
        'USUARIO
        '
        Me.USUARIO.DataPropertyName = "USUARIO"
        Me.USUARIO.HeaderText = "USUARIO"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.ReadOnly = True
        Me.USUARIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.USUARIO.Width = 279
        '
        'col_orden
        '
        Me.col_orden.DataPropertyName = "ORDEN"
        Me.col_orden.HeaderText = "TURNO"
        Me.col_orden.Name = "col_orden"
        Me.col_orden.ReadOnly = True
        Me.col_orden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col_orden.Width = 225
        '
        'col_ventanilla
        '
        Me.col_ventanilla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_ventanilla.DataPropertyName = "VENTANILLA"
        Me.col_ventanilla.HeaderText = "PUERTA"
        Me.col_ventanilla.Name = "col_ventanilla"
        Me.col_ventanilla.ReadOnly = True
        Me.col_ventanilla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col_ventanilla.Width = 320
        '
        'col_Estado
        '
        Me.col_Estado.DataPropertyName = "ESTADO"
        Me.col_Estado.HeaderText = "ESTADO"
        Me.col_Estado.Name = "col_Estado"
        Me.col_Estado.ReadOnly = True
        Me.col_Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_id_estado
        '
        Me.col_id_estado.DataPropertyName = "ID_ESTADO"
        Me.col_id_estado.HeaderText = "ID_ESTADO"
        Me.col_id_estado.Name = "col_id_estado"
        Me.col_id_estado.ReadOnly = True
        Me.col_id_estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col_id_estado.Visible = False
        '
        'TimerLlamada
        '
        Me.TimerLlamada.Enabled = True
        Me.TimerLlamada.Interval = 5000
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(1457, 181)
        Me.AxWindowsMediaPlayer1.TabIndex = 4
        '
        'txtOrdenllamada
        '
        Me.txtOrdenllamada.Location = New System.Drawing.Point(1304, 362)
        Me.txtOrdenllamada.Name = "txtOrdenllamada"
        Me.txtOrdenllamada.Size = New System.Drawing.Size(100, 20)
        Me.txtOrdenllamada.TabIndex = 5
        Me.txtOrdenllamada.Text = "0"
        '
        'frmCola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1457, 649)
        Me.Controls.Add(Me.txtOrdenllamada)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.dtgCola)
        Me.Controls.Add(Me.dtFecha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCola"
        Me.Text = "ESTADO DE ATENCIÓN"
        CType(Me.dtgCola, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerTurnos As Timer
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents dtgCola As DataGridView
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TimerLlamada As Timer
    Friend WithEvents txtOrdenllamada As TextBox
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents USUARIO As DataGridViewTextBoxColumn
    Friend WithEvents col_orden As DataGridViewTextBoxColumn
    Friend WithEvents col_ventanilla As DataGridViewTextBoxColumn
    Friend WithEvents col_Estado As DataGridViewTextBoxColumn
    Friend WithEvents col_id_estado As DataGridViewTextBoxColumn
End Class
