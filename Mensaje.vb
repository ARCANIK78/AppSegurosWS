Imports AppSegurosWS.WS

Public Class Mensaje
    Private ReadOnly seguros As New Dictionary(Of String, Integer)
    Public Property IdSeleccionado As Integer

    Private Sub Mensaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim WS As New WS.WebService1SoapClient
            Dim ds As db.TSegurosDataTable = WS.MostrarSeguros()

            ComboBox1.Items.Clear()
            seguros.Clear()

            For Each row As db.TSegurosRow In ds.Rows
                ComboBox1.Items.Add(row.nombre)
                seguros(row.nombre) = row.SegurosID
            Next

            If ComboBox1.Items.Count > 0 Then
                ComboBox1.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar los seguros: " & ex.Message)
        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If ComboBox1.SelectedItem IsNot Nothing AndAlso seguros.TryGetValue(ComboBox1.SelectedItem.ToString(), IdSeleccionado) Then
            ' IdSeleccionado se actualiza directamente desde TryGetValue
        Else
            IdSeleccionado = 0
        End If

        Me.Close()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        IdSeleccionado = 0
        Me.Close()
    End Sub
End Class
