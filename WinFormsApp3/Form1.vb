Imports WinFormsApp3.Modelos
Imports System.Linq
Imports System.Data.Entity
Imports Microsoft.EntityFrameworkCore

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim productos As New List(Of Producto)
        Dim con As New CBaseDatos()
        productos = con.Productos.ToList()
        DataGridView1.DataSource = productos

    End Sub
End Class
