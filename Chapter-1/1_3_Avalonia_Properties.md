## Avalonia Properties

If you are creating a control, you will want to define properties on your control. 
The process in Avalonia is broadly similar to other XAML languages, like WPF.
The Avalonia equivalent of `DependencyProperty` is `StyledProperty`, 
however Avalonia has a richer property system than WPF, and includes `DirectProperty` 
for turning standard CLR properties into Avalonia properties. 
The common base class of StyledProperty and `DirectProperty` is AvaloniaProperty`.

> 

### Styled Property


#### Registering Styled Properties

```
public static readonly StyledProperty<string> MyStringProperty = 
			AvaloniaProperty.Register<Menu, IEnumerable<IItem>>(nameof(MyString));
```

```
public string MyString 
{
	get 
	{ 
		return GetValue(MyStringProperty); 
	}
	set 
	{ 
		SetValue(MyStringProperty, value); 
	}
}
```

### DirectProperty
will be added soon.

### StyledProperty
will be added soon.

### AttachedProperty
will be added soon.