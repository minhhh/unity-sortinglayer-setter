using UnityEngine;

/// <summary>
/// Taken from https://github.com/anchan828/property-drawer-collection/blob/master/Popup/PopupAttribute.cs
/// </summary>
public class PopupAttribute : PropertyAttribute
{
    public object[] list;

    public PopupAttribute (params object[] list)
    {
        this.list = list;
    }
}
