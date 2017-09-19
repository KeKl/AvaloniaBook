## Avalonia Properties
### AvaloniaProperty

```
public static readonly AvaloniaProperty<IEnumerable<IItem>> ItemsProperty = 
			AvaloniaProperty.Register<Menu, IEnumerable<IItem>>("Items");
```

```
public IEnumerable<IItem> Items 
{
	get 
	{ 
		return GetValue(ItemsProperty); 
	}
	set 
	{ 
		SetValue(ItemsProperty, value); 
	}
}
```

### DirectProperty
will be added soon.

### StyledProperty
will be added soon.

### AttachedProperty
will be added soon.