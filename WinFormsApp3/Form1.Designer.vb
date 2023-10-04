<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Nombre = New DataGridViewTextBoxColumn()
        IdCategoriaNavigation = New DataGridViewTextBoxColumn()
        Id = New DataGridViewTextBoxColumn()
        Precio = New DataGridViewTextBoxColumn()
        Cantidad = New DataGridViewTextBoxColumn()
        IdCategoria = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Nombre, IdCategoriaNavigation, Id, Precio, Cantidad, IdCategoria})
        DataGridView1.Location = New Point(25, 119)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(763, 240)
        DataGridView1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(28, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Nombre
        ' 
        Nombre.DataPropertyName = "Nombre"
        Nombre.HeaderText = "Nombre"
        Nombre.MinimumWidth = 6
        Nombre.Name = "Nombre"
        Nombre.Width = 125
        ' 
        ' IdCategoriaNavigation
        ' 
        IdCategoriaNavigation.DataPropertyName = "IdCategoriaNavigation"
        IdCategoriaNavigation.HeaderText = "IdCategoriaNavigation"
        IdCategoriaNavigation.MinimumWidth = 6
        IdCategoriaNavigation.Name = "IdCategoriaNavigation"
        IdCategoriaNavigation.Width = 125
        ' 
        ' Id
        ' 
        Id.DataPropertyName = "Id"
        Id.HeaderText = "Id"
        Id.MinimumWidth = 6
        Id.Name = "Id"
        Id.Visible = False
        Id.Width = 125
        ' 
        ' Precio
        ' 
        Precio.DataPropertyName = "Precio"
        Precio.HeaderText = "Precio"
        Precio.MinimumWidth = 6
        Precio.Name = "Precio"
        Precio.Width = 125
        ' 
        ' Cantidad
        ' 
        Cantidad.DataPropertyName = "Cantidad"
        Cantidad.HeaderText = "Cantidad"
        Cantidad.MinimumWidth = 6
        Cantidad.Name = "Cantidad"
        Cantidad.Width = 125
        ' 
        ' IdCategoria
        ' 
        IdCategoria.DataPropertyName = "IdCategoria"
        IdCategoria.HeaderText = "IdCategoria"
        IdCategoria.MinimumWidth = 6
        IdCategoria.Name = "IdCategoria"
        IdCategoria.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoriaNavigation As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoria As DataGridViewTextBoxColumn
End Class
