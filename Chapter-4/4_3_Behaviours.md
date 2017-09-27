## Behaviours

The examples assume that the following XML Namespaces have been imported 
into your XAML document somewhere. 

For example:

```XML
    <Window...
        xmlns:i="clr-namespace:Avalonia.Xaml.Interactivity;assembly=Avalonia.Xaml.Interactivity" 
        xmlns:ia="clr-namespace:Avalonia.Xaml.Interactions.Core;assembly=Avalonia.Xaml.Interactions" 
    >    
```

### CallMethodAction

`CallMethodAction` represents an action which when triggered, calls a method on a specified object.
Using this Behavior allows the specified `MethodName` to be called on `TargetObject`.

#### Sample Code

The following 

##### XAML

```XML
    <Button x:Name="incrementButton">
        <i:Interaction.Behaviors>
            <i:EventTriggerBehavior EventName="Click" SourceObject="{Binding #incrementButton}">
                <ia:CallMethodAction TargetObject="{Binding}" MethodName="IncrementCount"/>
            </i:EventTriggerBehavior>
        </i:Interaction.Behaviors>
    </Button>
```

##### C#

```C#
    public event PropertyChangedEventHandler PropertyChanged;

    public int Count { get; set; }

    public void IncrementCount()
    {
        Count++;
        OnPropertyChanged(nameof(Count));
    }

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
```

### EventTriggerBehavior

`EventTriggerBehavior` listens for a specific event on its source and executes an action when the event is fired.

This Behavior has two configurable properties:

This Behavior listens for the specified `EventName` to happen on `SourceObject` in order to execute. 
- `EventName` - The name of the event to listen for.  This event must exist on the `SourceObject`
- `SourceObject` - The object on which the behavior should listen for the event `EventName` on.  If not provided, this will default to the element the behavior is attached to.

#### Sample Code

Attaching the behavior to an element.

```XML
    <Button x:Name="button1" Margin="5" Content="I am a Button!" Command="{Binding ClickCommand}" CommandParameter="{Binding}">
        <i:Interaction.Behaviors>
            <ia:EventTriggerBehavior EventName="Click" SourceObject="{Binding #button1}">
                <ia:InvokeCommandAction Command="{Binding ButtonClickEventCommand}"/>
            </ia:EventTriggerBehavior>
        </i:Interaction.Behaviors>
    </Button>
```

Explicitly specifying the  SourceObject  of the behavior. 
Note that in this case it's being set to the containing element, 
but the source object can be set to any object.