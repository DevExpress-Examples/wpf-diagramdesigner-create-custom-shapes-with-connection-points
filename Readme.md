<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585231/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T320892)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[CustomShapes.xaml](./CS/DXDiagram.CreateCustomShapes/CustomShapes.xaml) (VB: [CustomShapes.xaml](./VB/DXDiagram.CreateCustomShapes/CustomShapes.xaml))**
* [MainWindow.xaml](./CS/DXDiagram.CreateCustomShapes/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXDiagram.CreateCustomShapes/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXDiagram.CreateCustomShapes/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXDiagram.CreateCustomShapes/MainWindow.xaml.vb))
<!-- default file list end -->
# How to create custom shapes with custom connection points for DiagramDesignerControl


<p>The Diagram control supports a special language for defining shapes. The main element that contains shape description is <em>ShapeTemplate</em>. This element describes a shape contour and may contain several segments

* <em>Start</em>. Specifies the start point
* <em>Line</em>. Defines a line with start and end points
* <em>Arc</em>. Defines an arc with start and end points<br><br>To specify connection points, use the <em>ShapeTemplate.ConnectionPoints</em> property.<br>To register custom shapes, create a stencil with the <em>DiagramStencil.Create</em> method and pass it to the <em>DiagramToolboxRegistrator.RegisterStencil</em> method.</p>

<br/>
To create a shape programmatically, get an instance of your custom stencil, call the DiagramStencil.GetShape method to access the ShapeDescription object, and assign it to the DiagramShape.Shape property:

```cs
new DiagramShape() { Shape = customStencil.GetShape("Shape1")}
```

<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-diagramdesigner-create-custom-shapes-with-connection-points&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-diagramdesigner-create-custom-shapes-with-connection-points&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
