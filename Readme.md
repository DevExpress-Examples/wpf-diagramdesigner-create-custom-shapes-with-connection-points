<!-- default file list -->
*Files to look at*:

* [CustomShapes.xaml](./CS/WpfApplication293/CustomShapes.xaml) (VB: [CustomShapes.xaml](./VB/WpfApplication293/CustomShapes.xaml))
* [MainWindow.xaml](./CS/WpfApplication293/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication293/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication293/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication293/MainWindow.xaml.vb))
<!-- default file list end -->
# How to create custom shapes with custom connection points for DiagramDesignerControl


<p>The Diagram control supports a special language for defining shapes. The main element that contains shape description is <em>ShapeTemplate</em>. This element describes a shape contour and may contain several segments

* <em>Start</em>. Specifies the start point
* <em>Line</em>. Defines a line with start and end points
* <em>Arc</em>. Defines an arc with start and end points<br><br>To specify connection points, use the <em>ShapeTemplate.ConnectionPoints</em> property.<br>To register custom shapes, create a stencil with the <em>DiagramStencil.Create</em> method and pass it to the <em>DiagramToolboxRegistrator.RegisterStencil</em> method.</p>

<br/>


