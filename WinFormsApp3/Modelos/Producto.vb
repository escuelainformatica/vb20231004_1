Imports System
Imports System.Collections.Generic

Namespace Modelos
    Partial Public Class Producto
        Public Property Id As Integer

        Public Property Nombre As String

        Public Property Precio As Integer?

        Public Property Cantidad As Integer?

        Public Property IdCategoria As Integer?

        Public Overridable Property IdCategoriaNavigation As Categoria
    End Class
End Namespace
