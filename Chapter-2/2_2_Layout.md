## Layout with Panels
Avalonia contains five main built-in panels, in increasing order of complexity:

+ Canvas
+ StackPanel
+ WrapPanel
+ DockPanel
+ Grid

### Canvas
Canvas is a basic panel. It supports positioning elements with explicit coordinates by using its attached properties: Left, Top, Right and Bottom. By setting a value for Left or Right, you are stating that the edge of the element should remain this fixed distance from the edge. The attached property values serve as margins. If an element doesn't use any of these attached properties, it is placed in the topleft corner of the Canvas.

> **Warning:** Elements can't use more than two of the Canvas attached properties!

```xml
	<Window x:Class="AvaloniaSamples.MainWindow"
	        xmlns="https://github.com/avaloniaui"
	        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	        Title="Main Window" Width="1024" Height="800">
	
		<Canvas>
			<Button Background="Red">Left=0, Top=0</Button>		
			<Button Canvas.Left="18" Canvas.Top="18"
					Background="Orange">Left=18, Top=18</Button>		
			<Button Canvas.Right="18" Canvas.Bottom="18"
					Background="Yellow">Right=18, Bottom=18</Button>		
			<Button Canvas.Right="0" Canvas.Bottom="0"
					Background="Lime">Right=0, Bottom=0</Button>		
			<Button Canvas.Right="0" Canvas.Top="0"
					Background="Aqua">Right=0, Top=0</Button>
			<Button Canvas.Left="0" Canvas.Bottom="0"
					Background="Magenta">Left=0, Bottom=0</Button>
		</Canvas>
	    
	</Window>
```

### StackPanel
StackPanel is a useful panel. It simply stacks its children sequentially according to the Orientation property. The Orientation property can be set to Horizontal or Vertical (default). There is also a Gap property which can be set to place a gap between the childrens.

| Property      | Description                                                   | Default
| -----------   | ------------------                                            | ---------- 
| Orientation   | The orientation in which child controls will be layed out.    | Vertical
| Gap           | The size of the gap to place between child controls.          | 0


```xml
	<Window x:Class="AvaloniaSamples.MainWindow"
	        xmlns="https://github.com/avaloniaui"
	        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	        Title="Main Window" Width="1024" Height="800">
		
		<StackPanel Orientation="Horizontal" Gap="5">
			<Button Background="Red">1</Button>		
			<Button Background="Orange">2</Button>		
			<Button Background="Yellow">3</Button>		
			<Button Background="Lime">4</Button>		
			<Button Background="Aqua">5</Button>
			<Button Background="Magenta">6</Button>
		</StackPanel>

	</Window>
```

### WrapPanel
WrapPanel is similar to the StackPanel. But in addition to stacking its child elements, it wraps them to additional rows or columns when there’s not enough space.

| Property      | Description                                                   | Default
| -----------   | ------------------                                            | ---------- 
| Orientation   | The orientation in which child controls will be layed out.    | Horizontal

### DockPanel
DockPanel enables easy docking of elements to a side of the panel, stretching it to fill the entire width or height. DockPanel also enables an element to fill all the remaining space unused by the docked elements.

| Property      | Description                                                   | Default
| -----------   | ------------------                                            | ---------- 
| Dock          | The side to which the children will be docked.                | Left
| LastChildFill | Indicates whether the last child of the DockPanel fills the remaining space in the panel. | True

```xml
	<Window x:Class="AvaloniaSamples.MainWindow"
	        xmlns="https://github.com/avaloniaui"
	        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	        Title="Main Window" Width="1024" Height="800">
		
		<DockPanel LastChildFill="True">
			<Button DockPanel.Dock="Top" Background="Red">1 (Top)</Button>
			<Button DockPanel.Dock="Left" Background="Orange">2 (Left)</Button>
			<Button DockPanel.Dock="Right" Background="Yellow">3 (Right)</Button>
			<Button DockPanel.Dock="Bottom" Background="Lime">4 (Bottom)</Button>
			<Button Background="Aqua">5</Button>
		</DockPanel>

	</Window>
```

### Grid
will be added soon.

### Primitive Panels
will be added soon.