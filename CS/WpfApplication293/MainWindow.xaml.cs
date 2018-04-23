using DevExpress.Diagram.Core;
using DevExpress.Xpf.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication293
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitCustomDiagramShapes();
        }

        void InitCustomDiagramShapes()
        {
            ResourceDictionary customShapesDictionary = new ResourceDictionary() { Source = new Uri("CustomShapes.xaml", UriKind.Relative) };
            DiagramToolboxRegistrator.RegisterShapes("MyShapes", () => "Custom Shapes", customShapesDictionary, shapeName => shapeName);
            diagramControl.DefaultStencils.Add("MyShapes");
        }
    }
}
