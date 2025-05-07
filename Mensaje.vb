Imports AppSegurosWS.WS
Public Class Mensaje
    Private seguros As New Dictionary(Of String, Integer) ' Diccionario para almacenar nombre e id
    Private _idSeleccionado As Integer ' Campo privado para la propiedad
    Public Property IdSeleccionado As Integer
        Get
            Return _idSeleccionado
        End Get
        Set(value As Integer)
            _idSeleccionado = value
            Console.WriteLine($"IdSeleccionado actualizado a: {_idSeleccionado}")
        End Set
    End Property

    Private Sub Mensaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim WS As New WS.WebService1SoapClient
        Dim ds As db.TSegurosDataTable = WS.MostrarSeguros()
        ComboBox1.Items.Clear()
        seguros.Clear()
        For Each row As db.TSegurosRow In ds.Rows
            ComboBox1.Items.Add(row.nombre)
            seguros(row.nombre) = row.SegurosID ' Guardar el id asociado al nombre
        Next
        Console.WriteLine(IdSeleccionado)
    End Sub

    Public Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim seleccionado As String = ComboBox1.SelectedItem.ToString()
        If seguros.ContainsKey(seleccionado) Then
            IdSeleccionado = seguros(seleccionado) ' Actualizar la propiedad con el id asociado al nombre
        End If
        ComboBox1.Items.Clear()
        Me.Close()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        _idSeleccionado = 0
        ComboBox1.Items.Clear()
        Me.Close()

    End Sub
End Class