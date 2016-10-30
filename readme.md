# Unity Sorting Layer Setter

This component provides a way to set the sorting layer of any object using code or from the Editor.

## Problem
There are some `Renderer` components that don't expose sorting layer such as `MeshRenderer`. We want to easily set their sorting layer and order in layer just like `SpriteRenderer`

## Solution
You can simply add the `SortingLayerSetter` and it will show `Layer Name` and `Order in Layer` property just like `SpriteRenderer`. It also have a tick box for `Recursive` if you want to set all the children recursively as well.

![example 1](/images/example1.png)

The code for drawing popup attribute was taken from [https://github.com/anchan828/property-drawer-collection/tree/master/Popup](https://github.com/anchan828/property-drawer-collection/tree/master/Popup) with some modifications.

## License
MIT © Minh Ha
