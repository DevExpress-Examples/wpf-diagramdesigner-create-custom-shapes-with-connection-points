Imports System
Imports System.Windows
Imports DevExpress.Diagram.Core
Imports DevExpress.Xpf.Core

Namespace DXDiagram.CreateCustomShapes

	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			InitCustomDiagramShapes()
		End Sub
		Private Sub InitCustomDiagramShapes()
			Dim customShapesDictionary As New ResourceDictionary() With {.Source = New Uri("CustomShapes.xaml", UriKind.Relative)}
			Dim stencil = DiagramStencil.Create("MyShapes", "Custom Shapes", customShapesDictionary, Function(shapeName) shapeName)
			DiagramToolboxRegistrator.RegisterStencil(stencil)
			diagramControl.SelectedStencils.Add("MyShapes")
		End Sub
	End Class
End Namespace
