Imports System.Collections.Generic
Imports OSSql
Imports System.Data.SqlClient
Imports System.Speech.Synthesis

Public Class frmCola
    ' Cola de turnos (Queue)
    Private colaTurnos As New Queue(Of String)()
    Private turnoActual As Integer = 0
    Private con As New Clase_Conexion
    Private conColas As New Clase_Conexion
    Dim vaOrden As String = 0
    Dim dtColores As DataTable

    Private Sub FormTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vaBackColor As String = "#"

        conColas.ConectarColas()
        dtColores = conColas.fObtieneDataTableSQL("usp_sgc_listacolores")
        Dim foundRows() As DataRow
        foundRows = dtColores.Select("propiedad='FORM_BACKCOLOR_COLA'")

        vaBackColor = foundRows.ElementAt(0).ItemArray(1)

        conColas.Desconectar()

        ' Configuración de la pantalla (ej. maximizado)
        Me.WindowState = FormWindowState.Maximized

        Me.BackColor = System.Drawing.ColorTranslator.FromHtml(vaBackColor)

        pCargaColaAtencion()
        AxWindowsMediaPlayer1.settings.volume = 0


    End Sub

    ' Acción para llamar al siguiente turno
    Private Sub TimerTurnos_Tick(sender As Object, e As EventArgs) Handles TimerTurnos.Tick

        pCargaColaAtencion()

    End Sub

    ' Método para añadir un nuevo turno a la cola
    Public Sub AgregarTurno()
        Dim dt As New DataTable
        con.Conectar()

        dt = con.fObtieneDataTable("usp_sgc_listaespera", dtFecha.Value.Date)

        For i As Integer = 0 To dt.Rows.Count - 1
            turnoActual += 1
            Dim nuevoTurno As String = "A-" & turnoActual.ToString("000") & " - " & dt.Rows(i).Item(1).ToString
            colaTurnos.Enqueue(nuevoTurno)
        Next

    End Sub

    Private Sub pCargaColaAtencion()
        Dim dt As New DataTable

        TimerLlamada.Enabled = False
        conColas.ConectarColas()

        dt = conColas.fObtieneDataTable("usp_sgc_listacolas", dtFecha.Value.ToShortDateString)

        dtgCola.AutoGenerateColumns = False
        dtgCola.EnableHeadersVisualStyles = False
        dtgCola.ColumnHeadersDefaultCellStyle.BackColor = Me.BackColor
        dtgCola.RowsDefaultCellStyle.BackColor = Me.BackColor
        dtgCola.RowsDefaultCellStyle.ForeColor = Color.White
        dtgCola.DefaultCellStyle.SelectionBackColor = Me.BackColor
        dtgCola.ColumnHeadersDefaultCellStyle.SelectionBackColor = Me.BackColor

        dtgCola.AllowUserToResizeColumns = True
        dtgCola.DataSource = dt
        dtgCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dtgCola.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells)
        dtgCola.BackgroundColor = Me.BackColor
        TimerLlamada.Enabled = True

    End Sub

    Private Sub TimerLlamada_Tick(sender As Object, e As EventArgs) Handles TimerLlamada.Tick
        Dim vaIdEstado As String

        If dtgCola.Rows.Count > 0 Then

            'limpia los colores de las filas 
            For Each row As DataGridViewRow In dtgCola.Rows
                vaIdEstado = row.Cells("col_id_estado").Value.ToString.Trim
                If vaIdEstado = "LL" Then

                    If row.DefaultCellStyle.BackColor = Color.GreenYellow Then
                        row.DefaultCellStyle.BackColor = Me.BackColor
                    Else
                        row.DefaultCellStyle.BackColor = Color.GreenYellow
                    End If

                    txtOrdenllamada.Text = row.Cells("col_ID").Value

                    If txtOrdenllamada.Text > vaOrden Then 'llama por orden segun el Id asignado
                        Dim sintetizador As New SpeechSynthesizer()
                        sintetizador.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen, 0)
                        sintetizador.Rate = -3
                        sintetizador.SpeakAsyncCancelAll()
                        sintetizador.SpeakAsync(row.Cells("USUARIO").Value.ToString)
                        vaOrden = row.Cells("col_id").Value
                        Exit For
                    End If
                End If

                If dtgCola.Rows.Count = row.Index + 1 Then 'si se recorren todos las filas
                    txtOrdenllamada.Text = 0    ' se resetean el numero de orden
                    vaOrden = 0
                End If
            Next

            dtgCola.ClearSelection()
            dtgCola.Refresh()

        End If
    End Sub

    Private Sub frmCola_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged

        If Me.WindowState = FormWindowState.Maximized Then

            dtgCola.Width = Me.Width
            dtgCola.Height = (Me.Height / 2) - 50
            AxWindowsMediaPlayer1.Width = Me.Width
            AxWindowsMediaPlayer1.Height = (Me.Height / 2) - 10

        End If
    End Sub

End Class
