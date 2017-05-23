using UnityEditor;
using System;
using UnityEditorInternal;
using System.Reflection;

[CustomPropertyDrawer (typeof(SortingLayerAttribute))]
public class SortingLayerDrawer : PopupDrawer
{
    public override string[] list {
        get {
            if (_list == null) {
                _list = GetSortingLayerNames ();
            }

            return _list;
        }
    }

    public string[] GetSortingLayerNames ()
    {
        Type internalEditorUtilityType = typeof(InternalEditorUtility);
        PropertyInfo sortingLayersProperty = internalEditorUtilityType.GetProperty ("sortingLayerNames", BindingFlags.Static | BindingFlags.NonPublic);
        var sortingLayers = (string[])sortingLayersProperty.GetValue (null, new object[0]);
        return sortingLayers;
    }
}
