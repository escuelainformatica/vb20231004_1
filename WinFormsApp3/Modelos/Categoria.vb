Imports System
Imports System.Collections.Generic

Namespace Modelos
    Partial Public Class Categoria
        Public Property Id As Integer

        Public Property Nombre As String

        Public Overridable ReadOnly Property Productos As ICollection(Of Producto) = New List(Of Producto)()

        Public Overrides Function ToString() As String
            Return Nombre
        End Function
    End Class
End Namespace
