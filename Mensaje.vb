Imports AppSegurosWS.WS
Public Class Mensaje
    Private Sub Mensaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim WS As New WS.WebService1SoapClient
        Dim ds As db.TSegurosDataTable = WS.MostrarSeguros()
        ComboBox1.Items.Clear()
        For Each row As db.TSegurosRow In ds.Rows
            ComboBox1.Items.Add(row.nombre)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim comparativa As String = ComboBox1.SelectedItem.ToString()
        If comparativa Then
            Dim seleccionado As String = ComboBox1.SelectedItem.ToString()
    End Sub
End Class