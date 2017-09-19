## Sizing and Positioning
Sizing and Positioning is a fundamental part of designing a Gui. Most properties are shown in figure 2.1. Size-related properties are shown in blue, position-related properties are shown in red.

![alt text](./images/LayoutProps.png "Figure 2.1 - Main layout properties")
<center>Figure 2.1 - Main layout properties</center>

### Sizing
Every time the size of the Gui is changed, the child controls tell their parent about their desired size.
You can affect the size with some simple properties described in this chapter.

#### Height and Width
All Layoutable controls have the Height and Width properties. There exists also MinWidth, MaxWidth and MinHeight, MaxHeight to set a range of sufficient values. These values are of type Double.

```
<Button Width="120" Height="30" Content="Fixed Size" />
```


> **Warning:** Don´t set explicit sizes!

#### Margin and Padding
Margin and Padding relate to an control´s size.
Margin controls how much extra space gets placed around the outside edges of the control, all Layoutable controls have the margin property. Padding controls how much extra space gets places around the inside edges of the control, all Templated controls have the padding property.

```
<!-- Padding -->
<!-- One value for all sides -->
<TextBlock Padding="10" Text="10" />

<!-- Two values: Left/Right first value; Top/Bottom second value -->
<TextBlock Padding="10, 20" Text="10, 20" />

<!-- Four values: Left, Top, Right, Bottom -->
<TextBlock Padding="10, 20, 30, 40" Text="10, 20, 30, 40" />

<!-- Margin -->
<!-- One value for all sides -->
<TextBlock Margin="10" Text="10" />

<!-- Two values: Left/Right first value; Top/Bottom second value -->
<TextBlock Margin="10, 20" Text="10, 20" />

<!-- Four values: Left, Top, Right, Bottom -->
<TextBlock Margin="10, 20, 30, 40" Text="10, 20, 30, 40" />
```

### Positioning

#### Alignment