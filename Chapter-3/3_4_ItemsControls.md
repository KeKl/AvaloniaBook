## Items Controls
In the last chapter we have seen the content control. The items controls differ in that way that they contains a collection of items rather than just a single
piece of content.
ItemsControls store their content in an property named ***Items*** which is an IEnumerable. Each item gets rendered as it would in a content control. Visual items get rendered as expected. Arbitrary items get rendered as a TextBlock containing the string of the ToString() method.

The ***ItemsPanel*** property can be used to define which layout panel should be used to arrange the items in the items property. Every control can be used that implement the IPanel interface (see Chapter 2.2 Layout).

```xml
<ListBox>
	<ListBox.ItemsPanel>
		<ItemsPanelTemplate>
			<WrapPanel/>
		</ItemsPanelTemplate>
	</ListBox.ItemsPanel>
…
</ListBox>
```


***ItemTemplate*** can be used to set the DataTemplate for the items.

***MemberSelector***

### TreeView
TreeView is a ItemsControl to display hierarchical data with nodes that can be
expanded and collapsed. It can contain any items, and it stacks them
vertically. It has two additional properties added to ItemsControl:
SelectedItemProperty and AutoScrollToSelectedItemProperty. As the name suggests  the first property contains the current selected item and is of type Object. The second property is a Boolean and set to True let you automatically scroll to the selected item, this is nice if you set the selected item programmatically.

Normally you fill the TreeView with TreeViewItems. TreeViewItem is a headered items control. TreeViewItem’s Header property contains the current item, and its Items collection contains sub items. It adds additional properties to the headered items control: IsExpandedProperty and IsSelectedProperty.

```xml
<TreeView>
	<TreeViewItem Header="Fruits">
		<TreeViewItem Header="Apple" />
	</TreeViewItem>
</TreeView>
```
