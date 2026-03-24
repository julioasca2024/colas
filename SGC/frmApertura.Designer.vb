<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApertura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApertura))
        Me.dtgVentanillas = New System.Windows.Forms.DataGridView()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreEquipo = New System.Windows.Forms.TextBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCerrarVentanillas = New System.Windows.Forms.Button()
        Me.btnAbrirCola = New System.Windows.Forms.Button()
        Me.btnCambiaEstado = New System.Windows.Forms.Button()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_COD_AREA_ATENCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_AREA_ATENCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_COD_VENTANILLA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_VENTANILLA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_COD_ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgVentanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgVentanillas
        '
        Me.dtgVentanillas.AllowUserToAddRows = False
        Me.dtgVentanillas.AllowUserToDeleteRows = False
        Me.dtgVentanillas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgVentanillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgVentanillas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.COL_COD_AREA_ATENCION, Me.COL_AREA_ATENCION, Me.COL_COD_VENTANILLA, Me.COL_VENTANILLA, Me.COL_COD_ESTADO, Me.COL_ESTADO, Me.col_fecha, Me.col_equipo})
        Me.dtgVentanillas.Location = New System.Drawing.Point(12, 160)
        Me.dtgVentanillas.MultiSelect = False
        Me.dtgVentanillas.Name = "dtgVentanillas"
        Me.dtgVentanillas.ReadOnly = True
        Me.dtgVentanillas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgVentanillas.Size = New System.Drawing.Size(1041, 166)
        Me.dtgVentanillas.TabIndex = 0
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(12, 349)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(234, 28)
        Me.cboEstado.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ESTADO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 63)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "EQUIPO"
        '
        'txtNombreEquipo
        '
        Me.txtNombreEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEquipo.Location = New System.Drawing.Point(262, 43)
        Me.txtNombreEquipo.Name = "txtNombreEquipo"
        Me.txtNombreEquipo.ReadOnly = True
        Me.txtNombreEquipo.Size = New System.Drawing.Size(499, 68)
        Me.txtNombreEquipo.TabIndex = 5
        '
        'dtFecha
        '
        Me.dtFecha.Enabled = False
        Me.dtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(262, 351)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(123, 26)
        Me.dtFecha.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "FECHA"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.SGC.My.Resources.Resources.logo
        Me.PictureBox1.Image = Global.SGC.My.Resources.Resources.logo_ezgif_com_optipng
        Me.PictureBox1.Location = New System.Drawing.Point(886, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.SGC.My.Resources.Resources.exit_close
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(917, 332)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(136, 60)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCerrarVentanillas
        '
        Me.btnCerrarVentanillas.Image = Global.SGC.My.Resources.Resources.cerrarventana
        Me.btnCerrarVentanillas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarVentanillas.Location = New System.Drawing.Point(769, 333)
        Me.btnCerrarVentanillas.Name = "btnCerrarVentanillas"
        Me.btnCerrarVentanillas.Size = New System.Drawing.Size(142, 60)
        Me.btnCerrarVentanillas.TabIndex = 8
        Me.btnCerrarVentanillas.Text = "CERRAR VENTANILLAS"
        Me.btnCerrarVentanillas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrarVentanillas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCerrarVentanillas.UseVisualStyleBackColor = True
        '
        'btnAbrirCola
        '
        Me.btnAbrirCola.Enabled = False
        Me.btnAbrirCola.Image = Global.SGC.My.Resources.Resources.open_in_new
        Me.btnAbrirCola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbrirCola.Location = New System.Drawing.Point(515, 333)
        Me.btnAbrirCola.Name = "btnAbrirCola"
        Me.btnAbrirCola.Size = New System.Drawing.Size(121, 60)
        Me.btnAbrirCola.TabIndex = 7
        Me.btnAbrirCola.Text = "INICIAR ATENCIÓN"
        Me.btnAbrirCola.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbrirCola.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAbrirCola.UseVisualStyleBackColor = True
        '
        'btnCambiaEstado
        '
        Me.btnCambiaEstado.Image = Global.SGC.My.Resources.Resources.change_icon
        Me.btnCambiaEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCambiaEstado.Location = New System.Drawing.Point(397, 333)
        Me.btnCambiaEstado.Name = "btnCambiaEstado"
        Me.btnCambiaEstado.Size = New System.Drawing.Size(121, 60)
        Me.btnCambiaEstado.TabIndex = 1
        Me.btnCambiaEstado.Text = "CAMBIAR ESTADO"
        Me.btnCambiaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCambiaEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCambiaEstado.UseVisualStyleBackColor = True
        '
        'col_id
        '
        Me.col_id.DataPropertyName = "ID"
        Me.col_id.HeaderText = "ID"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'COL_COD_AREA_ATENCION
        '
        Me.COL_COD_AREA_ATENCION.DataPropertyName = "COD_AREA_ATENCION"
        Me.COL_COD_AREA_ATENCION.HeaderText = "COD_AREA_ATENCION"
        Me.COL_COD_AREA_ATENCION.Name = "COL_COD_AREA_ATENCION"
        Me.COL_COD_AREA_ATENCION.ReadOnly = True
        Me.COL_COD_AREA_ATENCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'COL_AREA_ATENCION
        '
        Me.COL_AREA_ATENCION.DataPropertyName = "AREA_ATENCION"
        Me.COL_AREA_ATENCION.HeaderText = "AREA_ATENCION"
        Me.COL_AREA_ATENCION.Name = "COL_AREA_ATENCION"
        Me.COL_AREA_ATENCION.ReadOnly = True
        Me.COL_AREA_ATENCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'COL_COD_VENTANILLA
        '
        Me.COL_COD_VENTANILLA.DataPropertyName = "COD_VENTANILLA"
        Me.COL_COD_VENTANILLA.HeaderText = "COD_VENTANILLA"
        Me.COL_COD_VENTANILLA.Name = "COL_COD_VENTANILLA"
        Me.COL_COD_VENTANILLA.ReadOnly = True
        Me.COL_COD_VENTANILLA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'COL_VENTANILLA
        '
        Me.COL_VENTANILLA.DataPropertyName = "VENTANILLA"
        Me.COL_VENTANILLA.HeaderText = "VENTANILLA"
        Me.COL_VENTANILLA.Name = "COL_VENTANILLA"
        Me.COL_VENTANILLA.ReadOnly = True
        Me.COL_VENTANILLA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'COL_COD_ESTADO
        '
        Me.COL_COD_ESTADO.DataPropertyName = "COD_ESTADO"
        Me.COL_COD_ESTADO.HeaderText = "COD_ESTADO"
        Me.COL_COD_ESTADO.Name = "COL_COD_ESTADO"
        Me.COL_COD_ESTADO.ReadOnly = True
        Me.COL_COD_ESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'COL_ESTADO
        '
        Me.COL_ESTADO.DataPropertyName = "ESTADO"
        Me.COL_ESTADO.HeaderText = "ESTADO"
        Me.COL_ESTADO.Name = "COL_ESTADO"
        Me.COL_ESTADO.ReadOnly = True
        Me.COL_ESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_fecha
        '
        Me.col_fecha.DataPropertyName = "fecha"
        Me.col_fecha.HeaderText = "FECHA"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.ReadOnly = True
        Me.col_fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col_fecha.Visible = False
        '
        'col_equipo
        '
        Me.col_equipo.DataPropertyName = "EQUIPO"
        Me.col_equipo.HeaderText = "EQUIPO"
        Me.col_equipo.Name = "col_equipo"
        Me.col_equipo.ReadOnly = True
        Me.col_equipo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_equipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmApertura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 402)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCerrarVentanillas)
        Me.Controls.Add(Me.btnAbrirCola)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.txtNombreEquipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.btnCambiaEstado)
        Me.Controls.Add(Me.dtgVentanillas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmApertura"
        Me.Text = "Operador"
        CType(Me.dtgVentanillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgVentanillas As DataGridView
    Friend WithEvents btnCambiaEstado As Button
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreEquipo As TextBox
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents btnAbrirCola As Button
    Friend WithEvents btnCerrarVentanillas As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents COL_COD_AREA_ATENCION As DataGridViewTextBoxColumn
    Friend WithEvents COL_AREA_ATENCION As DataGridViewTextBoxColumn
    Friend WithEvents COL_COD_VENTANILLA As DataGridViewTextBoxColumn
    Friend WithEvents COL_VENTANILLA As DataGridViewTextBoxColumn
    Friend WithEvents COL_COD_ESTADO As DataGridViewTextBoxColumn
    Friend WithEvents COL_ESTADO As DataGridViewTextBoxColumn
    Friend WithEvents col_fecha As DataGridViewTextBoxColumn
    Friend WithEvents col_equipo As DataGridViewTextBoxColumn
End Class
