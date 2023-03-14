Imports DevExpress.Diagram.Core
Imports System
Imports System.Windows
Imports System.Windows.Controls

Namespace WpfApplication293

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            InitCustomDiagramShapes()
        End Sub

        Private Sub InitCustomDiagramShapes()
            Dim customShapesDictionary As ResourceDictionary = New ResourceDictionary() With {.Source = New Uri("CustomShapes.xaml", UriKind.Relative)}
            DiagramToolboxRegistrator.RegisterShapes("MyShapes", Function() "Custom Shapes", customShapesDictionary, Function(shapeName) shapeName)
            Me.diagramControl.DefaultStencils.Add("MyShapes")
        End Sub
    End Class
End Namespace
