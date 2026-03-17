Imports System.Net
Public Class frmApertura
    Dim ConCola As New Clase_Conexion
    Dim cargando As Boolean = True
    Dim dtColores As DataTable

    Private Sub frmOperador_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtNombreEquipo.Text = Dns.GetHostName().ToUpper.ToString
        pCargaGrid()
        pColores("FORM_BACKCOLOR_OPERADOR")

    End Sub

    Private Sub pColores(ByVal propiedad As String, Optional ByVal boton As Button = Nothing)

        Dim vaBackColor As String = ""
        Dim foundRows() As DataRow

        conCola.ConectarColas()
        dtColores = conCola.fObtieneDataTableSQL("usp_sgc_listacolores")

        Select Case propiedad
            Case "FORM_BACKCOLOR_OPERADOR"

                foundRows = dtColores.Select("propiedad='FORM_BACKCOLOR_OPERADOR'")
                vaBackColor = foundRows.ElementAt(0).ItemArray(1)
                Me.BackColor = System.Drawing.ColorTranslator.FromHtml(vaBackColor)

            Case "BOTONES_BACKCOLOR_INACTIVO_OPERADOR"
                foundRows = dtColores.Select("propiedad='BOTONES_BACKCOLOR_INACTIVO_OPERADOR'")

                'fondo de boton
                vaBackColor = foundRows.ElementAt(0).ItemArray(1)
                boton.BackColor = System.Drawing.ColorTranslator.FromHtml(vaBackColor)

                vaBackColor = foundRows.ElementAt(0).ItemArray(2)
                'color de texto
                boton.ForeColor = System.Drawing.ColorTranslator.FromHtml(vaBackColor)

            Case "BOTONES_BACKCOLOR_ACTIVO_OPERADOR"
                foundRows = dtColores.Select("propiedad='BOTONES_BACKCOLOR_ACTIVO_OPERADOR'")

                'fondo de boton
                vaBackColor = foundRows.ElementAt(0).ItemArray(1)
                boton.BackColor = System.Drawing.ColorTranslator.FromHtml(vaBackColor)

                vaBackColor = foundRows.ElementAt(0).ItemArray(2)
                'color de texto
                boton.ForeColor = System.Drawing.ColorTranslator.FromHtml(vaBackColor)

        End Select

        conCola.Desconectar()

    End Sub

    Private Sub pCargaGrid()
        Dim dt As New DataTable
        Dim ID As String

        ConCola.ConectarColas()
        If dtgVentanillas.Rows.Count > 0 Then
            ID = dtgVentanillas.CurrentRow.Cells("col_ID").Value
        Else
            ID = 0
        End If

        dt = ConCola.fObtieneDataTableSQL("usp_sgc_listaventanillas")
        ConCola.Desconectar()
        dtgVentanillas.DataSource = dt
        dtgVentanillas.Refresh()
        dtgVentanillas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        pCargaCombo("VENTANILLA")
        cboEstado.SelectedValue = dtgVentanillas.CurrentRow.Cells("col_cod_estado").Value

        If dtgVentanillas.Rows.Count > 0 Then

            For Each row As DataGridViewRow In dtgVentanillas.Rows
                If row.Cells("col_ID").Value.ToString() = ID Then
                    dtgVentanillas.ClearSelection()
                    row.Selected = True
                    dtgVentanillas.CurrentCell = row.Cells("col_ID")
                    Exit For ' Fila encontrada, salir del ciclo
                End If
            Next
        End If


    End Sub

    Private Sub pCargaCombo(stModulo As String)
        Dim dtcombo As New DataTable

        ConCola.ConectarColas()
        dtcombo = ConCola.fObtieneDataTable("usp_sgc_listaestados", stModulo)

        cboEstado.DataSource = dtcombo
        cboEstado.ValueMember = "id"
        cboEstado.DisplayMember = "descripcion"

        cargando = False
        ConCola.Desconectar()

    End Sub
    Private Sub dtgVentanillas_SelectionChanged(sender As Object, e As EventArgs) Handles dtgVentanillas.SelectionChanged

        Dim vaEstado As String
        Dim vaEquipo As String

        cboEstado.SelectedValue = dtgVentanillas.CurrentRow.Cells("col_cod_estado").Value
        vaEquipo = dtgVentanillas.CurrentRow.Cells("COL_EQUIPO").Value.ToString.ToUpper.Trim
        vaEstado = dtgVentanillas.CurrentRow.Cells("COL_COD_ESTADO").Value

        If vaEstado = "AP" And vaEquipo = Dns.GetHostName().ToUpper.ToString.Trim Then
            btnAbrirCola.Enabled = True
            pColores("BOTONES_BACKCOLOR_ACTIVO_OPERADOR", btnAbrirCola)
        Else
            btnAbrirCola.Enabled = False
            pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnAbrirCola)
        End If

    End Sub

    Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado.SelectedIndexChanged

        If dtgVentanillas.CurrentRow.Cells("col_cod_estado").Value = cboEstado.SelectedValue.ToString Then

            btnCambiaEstado.Enabled = False
            pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnCambiaEstado)
        Else
            btnCambiaEstado.Enabled = True
            pColores("BOTONES_BACKCOLOR_ACTIVO_OPERADOR", btnCambiaEstado)
        End If

    End Sub

    Private Sub btnCambiaEstado_Click(sender As Object, e As EventArgs) Handles btnCambiaEstado.Click
        Dim vaEstado As String
        Dim vaId As Integer
        Dim vaEquipo As String
        Dim resul As Integer
        Dim vaFecha As Date
        Dim dt As New DataTable

        vaEstado = cboEstado.SelectedValue.ToString
        vaId = dtgVentanillas.CurrentRow.Cells("col_id").Value.ToString
        vaEquipo = txtNombreEquipo.Text
        vaFecha = dtFecha.Value

        'valida si un equipo esta conectado en otra ventanilla
        dt = ConCola.fObtieneDataTable("usp_sgc_ValidaVentanilla", vaId, vaEquipo)

        If dt.Rows.Count > 0 Then
            MsgBox("EL EQUIPO " & vaEquipo & " YA SE ENCUENTRA CONECTADO A LA VENTANILLA " &
                   dt.Rows(0).Item("VENTANILLA").ToString.Trim & ". TIENE QUE CAMBIAR DE ESTADO A NO APERTURA")
            Exit Sub
        End If
        resul = ConCola.pEjecutaSP("usp_sgc_CambiaEstadoVentanilla", vaId, vaEstado, vaEquipo, vaFecha)

        If resul > 0 Then
            If vaEstado = "AP" Then  'cuando pasa a estado "Aperturada"
                MsgBox("SE CAMBIO DE ESTADO '" & cboEstado.Text &
                        "' Y YA PUEDE COMENZAR A ATENDER", vbInformation)

                frmOperador.dtFecha.Value = dtFecha.Value
                frmOperador.txtNombreEquipo.Text = txtNombreEquipo.Text
                frmOperador.txtIdVentanilla.Text = dtgVentanillas.CurrentRow.Cells("col_cod_ventanilla").Value
                frmOperador.txtVentanilla.Text = dtgVentanillas.CurrentRow.Cells("col_ventanilla").Value
                pCargaGrid()
                Me.Hide()
                frmOperador.ShowDialog()

            Else
                MsgBox("SE CAMBIO DE ESTADO " & cboEstado.SelectedItem.ToString &
                       " Y YA PUEDE COMENZAR A ATENDER", vbInformation)
            End If

        Else
            MsgBox("NO SE ACTUALIZÓ NINGUNA VENTANILLA", vbExclamation)
        End If

        pCargaGrid()

    End Sub

    Private Sub btnAbrirCola_Click(sender As Object, e As EventArgs) Handles btnAbrirCola.Click
        Dim formularioAbierto As Form = Application.OpenForms.OfType(Of frmOperador)().FirstOrDefault()

        If formularioAbierto IsNot Nothing Then
            ' Si ya existe, activarlo
            formularioAbierto.Activate()
            formularioAbierto.BringToFront()
        Else
            ' Si no existe, crear uno nuevo
            Dim form As New frmOperador
            If dtgVentanillas.Rows.Count > 0 Then
                Me.Hide()
                form.dtFecha.Value = dtFecha.Value
                form.txtIdVentanilla.Text = dtgVentanillas.CurrentRow.Cells("col_cod_ventanilla").Value
                form.txtVentanilla.Text = dtgVentanillas.CurrentRow.Cells("col_ventanilla").Value
                form.txtNombreEquipo.Text = txtNombreEquipo.Text
                form.Show()
                'Me.Show()
            End If
        End If

    End Sub

    Private Sub btnCerrarVentanillas_Click(sender As Object, e As EventArgs) Handles btnCerrarVentanillas.Click

        If MsgBox("¿SEGURO QUE DESEA CERRAR TODAS LAS VENTANAS DE ATENCIÓN?", vbYesNo + vbQuestion) = vbYes Then
            ConCola.ConectarColas()
            ConCola.pEjecutaSP("usp_sgc_cierraventanillas")
            MsgBox("TODAS LAS VENTANILLAS PASARON A ESTADO 'NO APERTURADO'", vbInformation)
            pCargaGrid()
        End If

    End Sub

    Private Sub dtgVentanillas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVentanillas.CellContentClick
        Dim vaEstado As String
        Dim vaEquipo As String

        vaEquipo = dtgVentanillas.Rows(e.RowIndex).Cells("COL_EQUIPO").Value.ToString.ToUpper.Trim
        vaEstado = dtgVentanillas.Rows(e.RowIndex).Cells("COL_COD_ESTADO").Value

        If vaEstado = "AP" And vaEquipo = Dns.GetHostName().ToUpper.ToString.Trim Then
            btnAbrirCola.Enabled = True
            pColores("BOTONES_BACKCOLOR_ACTIVO_OPERADOR", btnAbrirCola)
        Else
            btnAbrirCola.Enabled = False
            pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnAbrirCola)
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class