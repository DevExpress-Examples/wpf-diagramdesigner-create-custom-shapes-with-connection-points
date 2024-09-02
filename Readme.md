<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585231/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T320892)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF DiagramControl - Create Custom Shapes with Connection Points

This example demonstrates how to define custom shapes for the [Diagram Designer Control](https://docs.devexpress.com/WPF/115125/controls-and-libraries/diagram-control/diagram-designer-control/diagram-designer-control) in the XAML markup.

![image](https://user-images.githubusercontent.com/65009440/225007759-4854c42d-d54a-40a8-8885-1939961157f2.png)

The `ShapeTemplate` class describes a [diagram shape](https://docs.devexpress.com/WPF/116099/controls-and-libraries/diagram-control/diagram-items/shapes) and contains the following segments:

* [Start](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.Shapes.Start) - Specifies the start point of the geometry and includes customization properties. A shape can consist of multiple geometries.
* [Line](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.Shapes.Line) - Defines a line with start and end points.
* [Arc](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.Shapes.Arc) - Defines an arc with size and direction.
* `ShapePoint` - Defines a [connection point](https://docs.devexpress.com/WPF/116648/controls-and-libraries/diagram-control/diagram-items/connectors). To specify connection points, use the `ShapeTemplate.ConnectionPoints` property.
* [Parameter](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.Shapes.Parameter) - Defines a parameter that allows users to transform the shape. To specify parameters, use the `ShapeTemplate.Parameters` property.

Refer to the following help topic for more information about supported segments: [Creating Shapes and Containers Using Shape Templates](https://docs.devexpress.com/WPF/117037/controls-and-libraries/diagram-control/diagram-items/creating-shapes-and-containers-using-shape-templates).

To register custom shapes, create a stencil with the [DiagramStencil.Create](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.DiagramStencil.Create.overloads) method and pass it to the [DiagramToolboxRegistrator.RegisterStencil](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.DiagramToolboxRegistrator.RegisterStencil(DevExpress.Diagram.Core.DiagramStencil)) method.

To create a shape in code, get an instance of your custom stencil, call the [DiagramStencil.GetShape](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.DiagramStencil.GetShape(System.String)) method to access the [ShapeDescription](https://docs.devexpress.com/CoreLibraries/DevExpress.Diagram.Core.ShapeDescription) object, and assign it to the [DiagramShape.Shape](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramShape.Shape) property:

```cs
new DiagramShape() { Shape = customStencil.GetShape("Shape1")}
```

## Files to Review

* [CustomShapes.xaml](./CS/DXDiagram.CreateCustomShapes/CustomShapes.xaml) (VB: [CustomShapes.xaml](./VB/DXDiagram.CreateCustomShapes/CustomShapes.xaml))
* [MainWindow.xaml](./CS/DXDiagram.CreateCustomShapes/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXDiagram.CreateCustomShapes/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXDiagram.CreateCustomShapes/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXDiagram.CreateCustomShapes/MainWindow.xaml.vb))

## Documentation

* [Creating Shapes and Containers Using Shape Templates](https://docs.devexpress.com/WPF/117037/controls-and-libraries/diagram-control/diagram-items/creating-shapes-and-containers-using-shape-templates)
* [Diagram Designer Control](https://docs.devexpress.com/WPF/115125/controls-and-libraries/diagram-control/diagram-designer-control/diagram-designer-control)
* [Shapes](https://docs.devexpress.com/WPF/116099/controls-and-libraries/diagram-control/diagram-items/shapes)

## More Examples

* [Create Items with Custom Content in DiagramControl](https://github.com/DevExpress-Examples/how-to-create-items-with-custom-content-in-diagramcontrol-t395119)
* [Create Custom Diagram Containers and Register Them in the Toolbox and Ribbon Gallery](https://github.com/DevExpress-Examples/how-to-create-custom-diagram-containers-and-register-them-in-the-toolbox-and-ribbon-gallery-t466430)
* [Create a DiagramShape Descendant with Editable and Serializable Properties](https://github.com/DevExpress-Examples/how-to-create-a-diagramshape-descendant-with-editable-and-serializable-properties-t395040)
* [DiagramControl for WPF - Change a Shape's Connection Points at Runtime](https://github.com/DevExpress-Examples/wpf-diagram-change-connection-points)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-diagramdesigner-create-custom-shapes-with-connection-points&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-diagramdesigner-create-custom-shapes-with-connection-points&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
