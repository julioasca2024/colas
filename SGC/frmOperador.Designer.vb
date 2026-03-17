<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperador
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperador))
        Me.dtgEspera = New System.Windows.Forms.DataGridView()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cola = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Solicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ticket_cola = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_ventanilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ventanilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtgCola = New System.Windows.Forms.DataGridView()
        Me.txtNombreEquipo = New System.Windows.Forms.TextBox()
        Me.txtVentanilla = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdVentanilla = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRellamado = New System.Windows.Forms.Button()
        Me.btnAtendido = New System.Windows.Forms.Button()
        Me.btnAtender = New System.Windows.Forms.Button()
        Me.btnNoAtendido = New System.Windows.Forms.Button()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.btnRefresca = New System.Windows.Forms.Button()
        Me.col_id_cola = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cola_asiganada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_ventanilla_asignada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_estado_cola_asignada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado_asignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha_asignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgCola, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgEspera
        '
        Me.dtgEspera.AllowUserToAddRows = False
        Me.dtgEspera.AllowUserToDeleteRows = False
        Me.dtgEspera.AllowUserToResizeRows = False
        Me.dtgEspera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEspera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_cola, Me.col_Solicitud, Me.col_paciente, Me.col_ticket_cola, Me.col_fecha, Me.col_id_estado, Me.COL_ESTADO, Me.col_equipo, Me.col_id_ventanilla, Me.col_ventanilla})
        Me.dtgEspera.Location = New System.Drawing.Point(12, 144)
        Me.dtgEspera.MultiSelect = False
        Me.dtgEspera.Name = "dtgEspera"
        Me.dtgEspera.ReadOnly = True
        Me.dtgEspera.RowHeadersVisible = False
        Me.dtgEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgEspera.Size = New System.Drawing.Size(844, 476)
        Me.dtgEspera.TabIndex = 0
        '
        'col_id
        '
        Me.col_id.DataPropertyName = "ID"
        Me.col_id.HeaderText = "ID"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_cola
        '
        Me.col_cola.DataPropertyName = "COLA"
        Me.col_cola.HeaderText = "COLA"
        Me.col_cola.Name = "col_cola"
        Me.col_cola.ReadOnly = True
        Me.col_cola.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_Solicitud
        '
        Me.col_Solicitud.DataPropertyName = "SOLICITUD"
        Me.col_Solicitud.HeaderText = "SOLICITUD"
        Me.col_Solicitud.Name = "col_Solicitud"
        Me.col_Solicitud.ReadOnly = True
        Me.col_Solicitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_paciente
        '
        Me.col_paciente.DataPropertyName = "PACIENTE"
        Me.col_paciente.HeaderText = "PACIENTE"
        Me.col_paciente.Name = "col_paciente"
        Me.col_paciente.ReadOnly = True
        Me.col_paciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_ticket_cola
        '
        Me.col_ticket_cola.DataPropertyName = "TICKET_COLA"
        Me.col_ticket_cola.HeaderText = "TICKET COLA"
        Me.col_ticket_cola.Name = "col_ticket_cola"
        Me.col_ticket_cola.ReadOnly = True
        Me.col_ticket_cola.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col_ticket_cola.Visible = False
        '
        'col_fecha
        '
        Me.col_fecha.DataPropertyName = "FECHA"
        Me.col_fecha.HeaderText = "FECHA"
        Me.col_fecha.Name = "col_fecha"
        Me.col_fecha.ReadOnly = True
        Me.col_fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'COL_ESTADO
        '
        Me.COL_ESTADO.DataPropertyName = "ESTADO"
        Me.COL_ESTADO.HeaderText = "ESTADO"
        Me.COL_ESTADO.Name = "COL_ESTADO"
        Me.COL_ESTADO.ReadOnly = True
        Me.COL_ESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_equipo
        '
        Me.col_equipo.DataPropertyName = "EQUIPO"
        Me.col_equipo.HeaderText = "EQUIPO"
        Me.col_equipo.Name = "col_equipo"
        Me.col_equipo.ReadOnly = True
        Me.col_equipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_id_ventanilla
        '
        Me.col_id_ventanilla.DataPropertyName = "ID_VENTANILLA"
        Me.col_id_ventanilla.HeaderText = "ID_VENTANILLA"
        Me.col_id_ventanilla.Name = "col_id_ventanilla"
        Me.col_id_ventanilla.ReadOnly = True
        Me.col_id_ventanilla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_ventanilla
        '
        Me.col_ventanilla.DataPropertyName = "VENTANILLA"
        Me.col_ventanilla.HeaderText = "VENTANILLA"
        Me.col_ventanilla.Name = "col_ventanilla"
        Me.col_ventanilla.ReadOnly = True
        Me.col_ventanilla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col_ventanilla.Visible = False
        '
        'dtFecha
        '
        Me.dtFecha.Enabled = False
        Me.dtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Location = New System.Drawing.Point(197, 12)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(511, 38)
        Me.dtFecha.TabIndex = 2
        '
        'dtgCola
        '
        Me.dtgCola.AllowUserToAddRows = False
        Me.dtgCola.AllowUserToDeleteRows = False
        Me.dtgCola.AllowUserToResizeRows = False
        Me.dtgCola.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCola.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id_cola, Me.col_cola_asiganada, Me.col_id_ventanilla_asignada, Me.col_id_estado_cola_asignada, Me.col_estado_asignado, Me.col_fecha_asignado, Me.col_color})
        Me.dtgCola.Location = New System.Drawing.Point(969, 144)
        Me.dtgCola.MultiSelect = False
        Me.dtgCola.Name = "dtgCola"
        Me.dtgCola.ReadOnly = True
        Me.dtgCola.RowHeadersVisible = False
        Me.dtgCola.Size = New System.Drawing.Size(407, 476)
        Me.dtgCola.TabIndex = 3
        '
        'txtNombreEquipo
        '
        Me.txtNombreEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEquipo.Location = New System.Drawing.Point(197, 55)
        Me.txtNombreEquipo.Name = "txtNombreEquipo"
        Me.txtNombreEquipo.ReadOnly = True
        Me.txtNombreEquipo.Size = New System.Drawing.Size(511, 38)
        Me.txtNombreEquipo.TabIndex = 6
        '
        'txtVentanilla
        '
        Me.txtVentanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVentanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentanilla.Location = New System.Drawing.Point(323, 99)
        Me.txtVentanilla.Name = "txtVentanilla"
        Me.txtVentanilla.ReadOnly = True
        Me.txtVentanilla.Size = New System.Drawing.Size(385, 38)
        Me.txtVentanilla.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "FECHA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "TERMINAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 31)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "VENTANILLA"
        '
        'txtIdVentanilla
        '
        Me.txtIdVentanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdVentanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdVentanilla.Location = New System.Drawing.Point(197, 99)
        Me.txtIdVentanilla.Name = "txtIdVentanilla"
        Me.txtIdVentanilla.ReadOnly = True
        Me.txtIdVentanilla.Size = New System.Drawing.Size(120, 38)
        Me.txtIdVentanilla.TabIndex = 11
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Operador"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(124, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripMenuItem1.Text = "Salir"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(123, 22)
        Me.ToolStripMenuItem2.Text = "Restaurar"
        '
        'btnRellamado
        '
        Me.btnRellamado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRellamado.Enabled = False
        Me.btnRellamado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRellamado.Image = Global.SGC.My.Resources.Resources.rellamada
        Me.btnRellamado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRellamado.Location = New System.Drawing.Point(1382, 450)
        Me.btnRellamado.Name = "btnRellamado"
        Me.btnRellamado.Size = New System.Drawing.Size(110, 94)
        Me.btnRellamado.TabIndex = 15
        Me.btnRellamado.Text = "VOLVER A LLMAR"
        Me.btnRellamado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRellamado.UseVisualStyleBackColor = True
        '
        'btnAtendido
        '
        Me.btnAtendido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtendido.Enabled = False
        Me.btnAtendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtendido.Image = Global.SGC.My.Resources.Resources.call_received
        Me.btnAtendido.Location = New System.Drawing.Point(1382, 247)
        Me.btnAtendido.Name = "btnAtendido"
        Me.btnAtendido.Size = New System.Drawing.Size(110, 97)
        Me.btnAtendido.TabIndex = 14
        Me.btnAtendido.Text = "ATENDIDO"
        Me.btnAtendido.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAtendido.UseVisualStyleBackColor = True
        '
        'btnAtender
        '
        Me.btnAtender.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtender.Enabled = False
        Me.btnAtender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtender.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAtender.Image = Global.SGC.My.Resources.Resources.phone_2
        Me.btnAtender.Location = New System.Drawing.Point(1382, 144)
        Me.btnAtender.Name = "btnAtender"
        Me.btnAtender.Size = New System.Drawing.Size(110, 97)
        Me.btnAtender.TabIndex = 13
        Me.btnAtender.Text = "ATENDER"
        Me.btnAtender.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAtender.UseVisualStyleBackColor = True
        '
        'btnNoAtendido
        '
        Me.btnNoAtendido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNoAtendido.Enabled = False
        Me.btnNoAtendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoAtendido.Image = Global.SGC.My.Resources.Resources.call_received_icon
        Me.btnNoAtendido.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNoAtendido.Location = New System.Drawing.Point(1382, 350)
        Me.btnNoAtendido.Name = "btnNoAtendido"
        Me.btnNoAtendido.Size = New System.Drawing.Size(110, 94)
        Me.btnNoAtendido.TabIndex = 12
        Me.btnNoAtendido.Text = "NO ATENDIDO"
        Me.btnNoAtendido.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNoAtendido.UseVisualStyleBackColor = True
        '
        'btnAsignar
        '
        Me.btnAsignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignar.Image = Global.SGC.My.Resources.Resources.Next_arrow_64
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAsignar.Location = New System.Drawing.Point(862, 247)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(101, 94)
        Me.btnAsignar.TabIndex = 4
        Me.btnAsignar.Text = "ASIGNAR"
        Me.btnAsignar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'btnRefresca
        '
        Me.btnRefresca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresca.Image = Global.SGC.My.Resources.Resources.REFRESH
        Me.btnRefresca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresca.Location = New System.Drawing.Point(862, 144)
        Me.btnRefresca.Name = "btnRefresca"
        Me.btnRefresca.Size = New System.Drawing.Size(101, 97)
        Me.btnRefresca.TabIndex = 1
        Me.btnRefresca.Text = "REFRESCA"
        Me.btnRefresca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresca.UseVisualStyleBackColor = True
        '
        'col_id_cola
        '
        Me.col_id_cola.DataPropertyName = "id"
        Me.col_id_cola.HeaderText = "ID"
        Me.col_id_cola.Name = "col_id_cola"
        Me.col_id_cola.ReadOnly = True
        Me.col_id_cola.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col_id_cola.Visible = False
        '
        'col_cola_asiganada
        '
        Me.col_cola_asiganada.DataPropertyName = "COLA"
        Me.col_cola_asiganada.HeaderText = "COLA"
        Me.col_cola_asiganada.Name = "col_cola_asiganada"
        Me.col_cola_asiganada.ReadOnly = True
        Me.col_cola_asiganada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_id_ventanilla_asignada
        '
        Me.col_id_ventanilla_asignada.DataPropertyName = "VENTANILLA"
        Me.col_id_ventanilla_asignada.HeaderText = "VENTANILLA"
        Me.col_id_ventanilla_asignada.Name = "col_id_ventanilla_asignada"
        Me.col_id_ventanilla_asignada.ReadOnly = True
        Me.col_id_ventanilla_asignada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_id_estado_cola_asignada
        '
        Me.col_id_estado_cola_asignada.DataPropertyName = "ID_ESTADO"
        Me.col_id_estado_cola_asignada.HeaderText = "ID_ESTADO"
        Me.col_id_estado_cola_asignada.Name = "col_id_estado_cola_asignada"
        Me.col_id_estado_cola_asignada.ReadOnly = True
        Me.col_id_estado_cola_asignada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col_id_estado_cola_asignada.Visible = False
        '
        'col_estado_asignado
        '
        Me.col_estado_asignado.DataPropertyName = "ESTADO"
        Me.col_estado_asignado.HeaderText = "ESTADO"
        Me.col_estado_asignado.Name = "col_estado_asignado"
        Me.col_estado_asignado.ReadOnly = True
        Me.col_estado_asignado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_fecha_asignado
        '
        Me.col_fecha_asignado.DataPropertyName = "FECHA"
        Me.col_fecha_asignado.HeaderText = "FECHA"
        Me.col_fecha_asignado.Name = "col_fecha_asignado"
        Me.col_fecha_asignado.ReadOnly = True
        Me.col_fecha_asignado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'col_color
        '
        Me.col_color.DataPropertyName = "color"
        Me.col_color.HeaderText = "COLOR"
        Me.col_color.Name = "col_color"
        Me.col_color.ReadOnly = True
        Me.col_color.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.col_color.Visible = False
        '
        'frmOperador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1504, 632)
        Me.Controls.Add(Me.btnRellamado)
        Me.Controls.Add(Me.btnAtendido)
        Me.Controls.Add(Me.btnAtender)
        Me.Controls.Add(Me.btnNoAtendido)
        Me.Controls.Add(Me.txtIdVentanilla)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVentanilla)
        Me.Controls.Add(Me.txtNombreEquipo)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.dtgCola)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.btnRefresca)
        Me.Controls.Add(Me.dtgEspera)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOperador"
        Me.Text = "ATENCIÓN DE COLA"
        CType(Me.dtgEspera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgCola, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgEspera As DataGridView
    Friend WithEvents btnRefresca As Button
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents dtgCola As DataGridView
    Friend WithEvents btnAsignar As Button
    Friend WithEvents txtNombreEquipo As TextBox
    Friend WithEvents txtVentanilla As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdVentanilla As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents col_cola As DataGridViewTextBoxColumn
    Friend WithEvents col_Solicitud As DataGridViewTextBoxColumn
    Friend WithEvents col_paciente As DataGridViewTextBoxColumn
    Friend WithEvents col_ticket_cola As DataGridViewTextBoxColumn
    Friend WithEvents col_fecha As DataGridViewTextBoxColumn
    Friend WithEvents col_id_estado As DataGridViewTextBoxColumn
    Friend WithEvents COL_ESTADO As DataGridViewTextBoxColumn
    Friend WithEvents col_equipo As DataGridViewTextBoxColumn
    Friend WithEvents col_id_ventanilla As DataGridViewTextBoxColumn
    Friend WithEvents col_ventanilla As DataGridViewTextBoxColumn
    Friend WithEvents btnNoAtendido As Button
    Friend WithEvents btnAtender As Button
    Friend WithEvents btnAtendido As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents btnRellamado As Button
    Friend WithEvents col_id_cola As DataGridViewTextBoxColumn
    Friend WithEvents col_cola_asiganada As DataGridViewTextBoxColumn
    Friend WithEvents col_id_ventanilla_asignada As DataGridViewTextBoxColumn
    Friend WithEvents col_id_estado_cola_asignada As DataGridViewTextBoxColumn
    Friend WithEvents col_estado_asignado As DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_asignado As DataGridViewTextBoxColumn
    Friend WithEvents col_color As DataGridViewTextBoxColumn
End Class
