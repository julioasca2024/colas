Imports System.Collections.Generic


Public Class frmCola
    ' Cola de turnos (Queue)
    Private colaTurnos As New Queue(Of String)()
    Private turnoActual As Integer = 0
    Private con As New Clase_Conexion


    Private Sub FormTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración de la pantalla (ej. maximizado)
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.DarkBlue



        ' Etiqueta grande para el turno
        lblTurno.Text = "Esperando..."
        lblTurno.Font = New Font("Arial", 60, FontStyle.Bold)
        lblTurno.ForeColor = Color.White
        lblTurno.Dock = DockStyle.Fill
        lblTurno.TextAlign = ContentAlignment.MiddleCenter

        ' Iniciar temporizador para simular llamada de clientes
        TimerTurnos.Interval = 5000 ' 5 segundos
        TimerTurnos.Start()
    End Sub

    ' Acción para llamar al siguiente turno
    Private Sub TimerTurnos_Tick(sender As Object, e As EventArgs) Handles TimerTurnos.Tick
        If colaTurnos.Count > 0 Then
            ' Saca el siguiente turno de la cola
            Dim siguiente As String = colaTurnos.Dequeue()
            lblTurno.Text = "Turno: " & siguiente
            ' Aquí se podría agregar código para sonido (ej. My.Computer.Audio.Play)
        Else
            lblTurno.Text = "Esperando..."
        End If
    End Sub

    ' Método para añadir un nuevo turno a la cola
    Public Sub AgregarTurno()
        Dim dt As New DataTable
        con.Conectar()

        dt = con.fObtieneDataTable("usp_sgc_listaespera", dtpFecha.Value.Date)

        For i As Integer = 0 To dt.Rows.Count - 1
            turnoActual += 1
            Dim nuevoTurno As String = "A-" & turnoActual.ToString("000") & " - " & dt.Rows(i).Item(1).ToString
            colaTurnos.Enqueue(nuevoTurno)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarTurno()
    End Sub
End Class
