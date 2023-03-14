Imports System
Imports System.Windows
Imports DevExpress.Diagram.Core

Namespace DXDiagram.CreateCustomShapes

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            InitCustomDiagramShapes()
        End Sub

        Private Sub InitCustomDiagramShapes()
            Dim customShapesDictionary As ResourceDictionary = New ResourceDictionary() With {.Source = New Uri("CustomShapes.xaml", UriKind.Relative)}
            Dim stencil = DiagramStencil.Create("MyShapes", "Custom Shapes", customShapesDictionary, Function(shapeName) shapeName)
            DiagramToolboxRegistrator.RegisterStencil(stencil)
            Me.diagramControl.SelectedStencils.Add("MyShapes")
        End Sub
    End Class
End Namespace
