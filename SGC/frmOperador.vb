Imports System.ComponentModel
Imports LAYER_DATA
Imports OSSql
Public Class frmOperador

    Private con As New Clase_Conexion
    Private conCola As New Clase_Conexion
    Dim dtColores As DataTable
    Private Sub btnRefresca_Click(sender As Object, e As EventArgs) Handles btnRefresca.Click
        Timer1.Enabled = False
        pCargaGrid()
        Timer1.Enabled = True
    End Sub

    Private Sub pCargaGrid()

        Dim dt As New DataTable
        Dim vaFecha As Date

        dtgEspera.DataSource = Nothing

        con.Conectar()
        vaFecha = dtFecha.Value.ToShortDateString
        dt = con.fObtieneDataTable("usp_sgc_listaespera", vaFecha)
        dtgEspera.DataSource = dt
        dtgEspera.AutoGenerateColumns = False
        dtgEspera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        con.Desconectar()

    End Sub

    Private Sub pCargaGridColaAsignada()
        Dim dt As New DataTable
        Dim vaFecha As Date
        Dim vaIdVentanilla As String

        dtgCola.DataSource = Nothing

        conCola.ConectarColas()

        vaIdVentanilla = txtIdVentanilla.Text
        vaFecha = dtFecha.Value.ToShortDateString
        dt = conCola.fObtieneDataTable("usp_sgc_listacolaasignada", vaFecha, vaIdVentanilla)
        conCola.Desconectar()
        dtgCola.DataSource = dt

        dtgCola.AutoGenerateColumns = False
        dtgCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Dim fila As Integer = 0
        Dim columna As Integer = 1
        Dim args As New DataGridViewCellEventArgs(columna, fila)
        dtgCola_CellContentClick(dtgCola, args)

    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Dim vaIdEstado As String
        Dim vaColaAsignada As Integer
        Dim vaNumSolicitud As String
        Dim vaCliente As String
        Dim vaFecha As Date
        Dim vaColaSistema As Integer
        Dim vaIdEquipo As String
        Dim vaIDVentanilla As String
        Dim dt As New DataTable

        vaIdEquipo = txtNombreEquipo.Text
        vaFecha = dtFecha.Value.ToShortDateString

        conCola.ConectarColas()
        dt = conCola.fObtieneDataTable("usp_sgc_valida_asignacioncola", vaIdEquipo, vaFecha)
        conCola.Desconectar()

        If dt.Rows.Count > 0 Then

            MsgBox("TIENE AL USUARIO '" & dt.Rows(0).Item("CLIENTE").ToString & "' EN ESTADO '" _
                        & dt.Rows(0).Item("estado").ToString & "'", vbExclamation)
            Exit Sub
        End If


        If dtgEspera.Rows.Count > 0 Then

            For i As Integer = 0 To dtgEspera.Rows.Count - 1

                vaIdEstado = dtgEspera.Rows(i).Cells("col_id_estado").Value.ToString.Trim
                If vaIdEstado = "E" Then
                    vaColaAsignada = dtgEspera.Rows(i).Cells("col_cola").Value
                    vaNumSolicitud = dtgEspera.Rows(i).Cells("col_solicitud").Value
                    vaCliente = dtgEspera.Rows(i).Cells("col_paciente").Value

                    vaColaSistema = dtgEspera.Rows(i).Cells("col_ticket_cola").Value
                    vaIDVentanilla = txtIdVentanilla.Text

                    vaIdEstado = "LL"  ' en llamado

                    conCola.ConectarColas()
                    conCola.pEjecutaSP("usp_sgc_asignaturno", vaColaAsignada, vaNumSolicitud, vaCliente, vaFecha, vaColaSistema,
                                       vaIDVentanilla, vaIdEquipo, vaIdEstado)
                    conCola.Desconectar()
                    pCargaGrid()
                    pCargaGridColaAsignada()
                    Exit For
                End If
            Next

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pCargaGrid()
    End Sub

    Private Sub btnAtender_Click(sender As Object, e As EventArgs) Handles btnAtender.Click
        Dim vaFecha As String
        Dim vaEquipo As String
        Dim vaId As Integer
        Dim vaEstadoOld As String
        Dim vaEstadoNew As String
        Dim result As Integer = 0

        Timer1.Enabled = False

        If dtgCola.Rows.Count > 0 Then

            If MsgBox("¿PROCEDERÁ A ATENDER A UN USUARIO, DESEA CONTINUAR?", vbQuestion + vbYesNo) = vbYes Then
                vaFecha = dtFecha.Value
                vaEquipo = txtNombreEquipo.Text
                vaId = dtgCola.CurrentRow.Cells("col_id_cola").Value
                vaEstadoOld = dtgCola.CurrentRow.Cells("col_id_estado_cola_asignada").Value '"LL"  'se estuvo llamando

                vaEstadoNew = "AT"  'en atencion

                conCola.ConectarColas()
                result = conCola.pEjecutaSP("usp_sgc_CambiaEstadodeAtencionCola", vaId, vaEstadoOld, vaEstadoNew, vaEquipo, vaFecha)
                conCola.Desconectar()

                If result > 0 Then
                    MsgBox("AHORA PUEDE ATENDER", vbInformation)
                    pCargaGridColaAsignada()
                    btnAtender.Enabled = False
                Else
                    MsgBox("NO SE PUDO CAMBIAR A ESTADO 'EN ATENCION'", vbExclamation)
                End If
            End If


        End If

        Timer1.Enabled = True
    End Sub

    Private Sub dtgCola_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCola.CellContentClick

        If dtgCola.Rows.Count > 0 And e.RowIndex > -1 Then
            Select Case dtgCola.Rows(e.RowIndex).Cells("col_id_estado_cola_asignada").Value.ToString.Trim
                Case "LL"  ''en llamado
                    btnAtender.Enabled = True
                    pColores("BOTONES_BACKCOLOR_ACTIVO_OPERADOR", btnAtender)
                    btnAtendido.Enabled = False
                    pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnAtendido)
                    btnNoAtendido.Enabled = True
                    pColores("BOTONES_BACKCOLOR_ACTIVO_OPERADOR", btnNoAtendido)
                    btnRellamado.Enabled = False
                    pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnRellamado)
                Case "AT" 'en atencion
                    btnAtender.Enabled = False
                    pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnAtender)
                    btnAtendido.Enabled = True
                    pColores("BOTONES_BACKCOLOR_ACTIVO_OPERADOR", btnAtendido)
                    btnNoAtendido.Enabled = False
                    pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnNoAtendido)
                    btnRellamado.Enabled = False
                    pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnRellamado)
                Case "A" ' atendido
                    btnAtender.Enabled = False
                    pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnAtender)
                    btnAtendido.Enabled = False
                    pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnAtendido)
                    btnNoAtendido.Enabled = False
                    pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnNoAtendido)
                    btnRellamado.Enabled = False
                    pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnRellamado)
                Case "NT" ' no atendido
                    btnAtender.Enabled = False
                    pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnAtender)
                    btnAtendido.Enabled = False
                    pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnAtendido)
                    btnNoAtendido.Enabled = False
                    pColores("BOTONES_BACKCOLOR_INACTIVO_OPERADOR", btnNoAtendido)
                    btnRellamado.Enabled = True
                    pColores("BOTONES_BACKCOLOR_ACTIVO_OPERADOR", btnRellamado)
            End Select
        End If

    End Sub

    Private Sub btnAtendido_Click(sender As Object, e As EventArgs) Handles btnAtendido.Click
        Dim vaFecha As String
        Dim vaEquipo As String
        Dim vaId As Integer
        Dim vaEstadoOld As String
        Dim vaEstadoNew As String
        Dim result As Integer = 0

        Timer1.Enabled = False

        If dtgCola.Rows.Count > 0 Then

            If MsgBox("¿PROCEDERÁ A CERRAR LA ATENCIÓN, DESEA CONTINUAR?", vbQuestion + vbYesNo) = vbYes Then
                vaFecha = dtFecha.Value
                vaEquipo = txtNombreEquipo.Text
                vaId = dtgCola.CurrentRow.Cells("col_id_cola").Value
                vaEstadoNew = "A"  'atendido
                vaEstadoOld = "AT"  'estuvo en atencion
                conCola.ConectarColas()
                result = conCola.pEjecutaSP("usp_sgc_CambiaEstadodeAtencionCola", vaId, vaEstadoOld, vaEstadoNew, vaEquipo, vaFecha)
                conCola.Desconectar()

                If result > 0 Then
                    MsgBox("USUARIO ATENDIDO", vbInformation)
                    pCargaGridColaAsignada()
                    btnAtendido.Enabled = False
                Else
                    MsgBox("NO SE PUDO CAMBIAR A ESTADO 'ATENDIDO'", vbExclamation)
                End If
            End If

        End If

        Timer1.Enabled = True

    End Sub

    Private Sub btnNoAtendido_Click(sender As Object, e As EventArgs) Handles btnNoAtendido.Click
        Dim vaFecha As String
        Dim vaEquipo As String
        Dim vaId As Integer
        Dim vaEstadoOld As String
        Dim vaEstadoNew As String
        Dim result As Integer = 0

        Timer1.Enabled = False

        If dtgCola.Rows.Count > 0 Then

            If MsgBox("¿PROCEDERÁ A CAMBIAR A 'NO ATENDIDO' AL USUARIO, DESEA CONTINUAR?", vbQuestion + vbYesNo) = vbYes Then
                vaFecha = dtFecha.Value
                vaEquipo = txtNombreEquipo.Text
                vaId = dtgCola.CurrentRow.Cells("col_id_cola").Value
                vaEstadoOld = dtgCola.CurrentRow.Cells("col_id_estado_cola_asignada").Value ' LL en llamado

                vaEstadoNew = "NT"  'no atendido
                ''vaEstadoOld = "AT"  'estuvo en atencion

                conCola.ConectarColas()
                result = conCola.pEjecutaSP("usp_sgc_CambiaEstadodeAtencionCola", vaId, vaEstadoOld, vaEstadoNew, vaEquipo, vaFecha)
                conCola.Desconectar()

                If result > 0 Then
                    MsgBox("USUARIO NO ATENDIDO", vbInformation)
                    pCargaGridColaAsignada()
                    btnAtendido.Enabled = False
                Else
                    MsgBox("NO SE PUDO CAMBIAR A ESTADO A 'NO ATENDIDO'", vbExclamation)
                End If
            End If

        End If

        Timer1.Enabled = True

    End Sub

    Private Sub frmOperador_Load(sender As Object, e As EventArgs) Handles Me.Load

        Timer1.Enabled = False
        dtgCola.DataSource = Nothing
        dtgEspera.DataSource = Nothing
        pColores("FORM_BACKCOLOR_OPERADOR")
        pCargaGrid()
        pCargaGridColaAsignada()
        Timer1.Enabled = True
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

    Private Sub frmOperador_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Timer1.Enabled = True
            Me.Hide() ' Oculta el formulario
            NotifyIcon1.Visible = True ' Asegura que el icono sea visible
        End If
    End Sub
    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        Timer1.Enabled = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmOperador_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not Me.WindowState = FormWindowState.Minimized Then
            Timer1.Enabled = False
            frmApertura.Show()
        End If
    End Sub

    Private Sub dtgCola_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dtgCola.DataBindingComplete
        For Each row As DataGridViewRow In dtgCola.Rows
            ' Asegurarse de que no es una fila nueva y verificar valor
            If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("col_color").Value) Then
                'Dim valor As String = row.Cells("NombreColumnaEstado").Value.ToString()

                row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(row.Cells("col_color").Value.ToString.Trim)
            End If
        Next
    End Sub

    Private Sub btnRellamar_Click(sender As Object, e As EventArgs) Handles btnRellamado.Click
        Dim vaFecha As String
        Dim vaEquipo As String
        Dim vaId As Integer
        Dim vaEstadoOld As String
        Dim vaEstadoNew As String
        Dim result As Integer = 0

        Timer1.Enabled = False

        If dtgCola.Rows.Count > 0 Then

            If MsgBox("¿PROCEDERÁ A ATENDER A UN USUARIO, DESEA CONTINUAR?", vbQuestion + vbYesNo) = vbYes Then
                vaFecha = dtFecha.Value
                vaEquipo = txtNombreEquipo.Text
                vaId = dtgCola.CurrentRow.Cells("col_id_cola").Value
                vaEstadoOld = "NT"

                vaEstadoNew = "LL"  'en atencion

                conCola.ConectarColas()
                result = conCola.pEjecutaSP("usp_sgc_CambiaEstadodeAtencionCola", vaId, vaEstadoOld, vaEstadoNew, vaEquipo, vaFecha)
                conCola.Desconectar()

                If result > 0 Then
                    MsgBox("SE ESTA VOLVIENDO A LLAMAR", vbInformation)
                    pCargaGridColaAsignada()
                    btnAtender.Enabled = False
                Else
                    MsgBox("NO SE PUDO CAMBIAR A ESTADO 'EN LLAMADO'", vbExclamation)
                End If
            End If


        End If

        Timer1.Enabled = True
    End Sub

    Private Sub btnAnalisis_Click(sender As Object, e As EventArgs) Handles btnAnalisis.Click
        Dim frm As New frmAnalisis

        frm.pFecha = dtFecha.Value.ToShortDateString
        frm.pEquipo = txtNombreEquipo.Text.Trim
        frm.ShowDialog()
        Timer1.Enabled = False

    End Sub
End Class