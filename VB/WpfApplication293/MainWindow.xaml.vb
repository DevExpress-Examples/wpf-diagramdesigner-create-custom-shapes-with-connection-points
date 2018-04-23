Imports DevExpress.Diagram.Core
Imports DevExpress.Xpf.Diagram
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace WpfApplication293
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            InitCustomDiagramShapes()
        End Sub

        Private Sub InitCustomDiagramShapes()
            Dim customShapesDictionary As New ResourceDictionary() With {.Source = New Uri("CustomShapes.xaml", UriKind.Relative)}
            DiagramToolboxRegistrator.RegisterShapes("MyShapes", Function() "Custom Shapes", customShapesDictionary, Function(shapeName) shapeName)
            diagramControl.DefaultStencils.Add("MyShapes")
        End Sub
    End Class
End Namespace
