Imports System.Windows.Forms.DataVisualization.Charting
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Text
Imports System.Net

Public Class frmAnalisis

    Public pFecha As Date

    Public Async Sub GenerarReporteInteligente(dt As DataTable)


        ' --- PARTE 1: GRÁFICA ---
        Chart1.Series.Clear()
        'Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.ChartAreas(0).AxisX.IsLabelAutoFit = False
        Chart1.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Segoe UI", 8)

        Dim serieA As New Series("id") With {.ChartType = SeriesChartType.SplineArea, .BorderWidth = 3}


        ' Llenar series filtrando el DataTable
        For Each row As DataRow In dt.Rows
            Dim usuario As String = row("id").ToString().Trim()
            Dim valor As Double = Convert.ToDouble(row("diferencia"))

            'If estado = "LL" Then serieLL.Points.AddY(valor)
            'If estado = "AT" Then serieAT.Points.AddY(valor)
            If usuario > 0 Then serieA.Points.AddY(valor)

            Dim punto As Integer = serieA.Points.AddXY(usuario, valor)
            serieA.Points(punto).AxisLabel = usuario

        Next

        'Chart1.Series.Add(serieLL)
        'Chart1.Series.Add(serieAT)
        Chart1.Series.Add(serieA)

        ' --- PARTE 2: ANÁLISIS IA ---
        ' Calculamos promedios para que la IA no reciba miles de filas, sino datos clave
        Dim resumen = From r In dt.AsEnumerable()
                      Group r By est = r("id_estado") Into G = Group
                      Select New With {
                     .Estado = est,
                     .Promedio = G.Average(Function(x) Convert.ToDouble(x("diferencia"))),
                     .Maximo = G.Max(Function(x) Convert.ToDouble(x("diferencia")))
                 }

        Dim interpretacion As String = Await ObtenerInterpretacionIA(JsonConvert.SerializeObject(resumen))

        ' Mostrar la interpretación en un Label o TextBox
        interpretacion = LimpiarMarkdown(interpretacion)

        RichTextBox1.Text = interpretacion
    End Sub

    Private Async Function ObtenerInterpretacionIA(jsonResumen As String) As Task(Of String)
        ' Prompt diseñado para tus datos de ID_ESTADO y DIFERENCIA
        Dim prompt As String = $"Analiza estos tiempos de espera: {jsonResumen}. " &
                     "Explica qué estado es más crítico y qué significa la tendencia descendente observada."

        ' (Aquí usarías la función HttpClient mostrada en el paso anterior para llamar a OpenAI/Azure)
        ' La IA devolverá algo como: 
        ' "El estado AT es crítico con un máximo de 70. Los descensos en LL sugieren una estabilización..."
        Return Await LlamarApiIA(prompt)
    End Function

    Private Async Function LlamarApiIA(ByVal prompt As String) As Task(Of String)



    End Function

    Private Function LimpiarMarkdown(texto As String) As String
        ' Negrita y cursiva
        texto = System.Text.RegularExpressions.Regex.Replace(texto, "\*\*(.+?)\*\*", "$1")
        texto = System.Text.RegularExpressions.Regex.Replace(texto, "\*(.+?)\*", "$1")
        ' Bullets * y -
        texto = System.Text.RegularExpressions.Regex.Replace(texto, "(?m)^\s*[\*\-]\s+", "• ")
        ' Numeración 1. 2. etc (dejarla como está, ya es legible)
        ' Headers # ## ###
        texto = System.Text.RegularExpressions.Regex.Replace(texto, "(?m)^#{1,6}\s+", "")
        ' Backticks de código
        texto = texto.Replace("`", "")
        Return texto.Trim()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim dt As New DataTable
        Dim conCola As New Clase_Conexion

        conCola.ConectarColas()
        dt = conCola.fObtieneDataTable("usp_sgc_datosanalisis", pFecha)
        GenerarReporteInteligente(dt)
        conCola.Desconectar()
    End Sub
End Class