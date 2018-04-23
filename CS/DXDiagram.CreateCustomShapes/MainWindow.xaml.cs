using System;
using System.Windows;
using DevExpress.Diagram.Core;
using DevExpress.Xpf.Core;

namespace DXDiagram.CreateCustomShapes {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            InitCustomDiagramShapes();
        }
        void InitCustomDiagramShapes() {
            ResourceDictionary customShapesDictionary = new ResourceDictionary() { Source = new Uri("CustomShapes.xaml", UriKind.Relative) };
            var stencil = DiagramStencil.Create("MyShapes", "Custom Shapes", customShapesDictionary, shapeName => shapeName);
            DiagramToolboxRegistrator.RegisterStencil(stencil);
            diagramControl.SelectedStencils.Add("MyShapes");
        }
    }
}
