Imports OSSql

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("orden", 30)
        ListView1.Columns.Add("solicitud", 150)
        ListView1.Columns.Add("ventanilla", 100)
    End Sub



    Private Sub CargarDatos()
        Dim con As New Clase_Conexion
        Dim dt As New DataTable()

        con.ConectarColas()

        dt = con.fObtieneDataTable("usp_sgc_listacolas", "19/02/2026")

        Try
            ListView1.Items.Clear() ' Limpiar antes de recargar [7]
            ListView1.GridLines = True
            ListView1.View = View.Details

            For Each fila As DataRow In dt.Rows
                ' Crear elemento principal (primera columna)
                Dim item As New ListViewItem(fila("orden").ToString())
                ' Agregar subelementos (columnas siguientes) [3]
                item.SubItems.Add(fila("solicitud").ToString())
                item.SubItems.Add(fila("ventanilla").ToString())
                ListView1.Items.Add(item)
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Desconectar()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CargarDatos()
    End Sub
End Class