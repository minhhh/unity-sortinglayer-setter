using UnityEngine;
using System.Collections;

public class SortingLayerSetter : MonoBehaviour
{
    [SerializeField, SortingLayer] private string _layerName = "Default";
    [SerializeField, Range (-10000, 10000)] private int _orderInLayer = 0;
    public bool recursive = false;

    // wait for renderer to be created
    public bool waitForRenderer = false;

    protected virtual void Awake ()
    {
        Renderer renderer = transform.GetComponent <Renderer> ();
        if (renderer != null) {
            _layerName = renderer.sortingLayerName;
        }
        _SetLayer (LayerName, OrderInLayer);
    }

    void Update ()
    {
        if (waitForRenderer) {
            var renderer = GetComponent <Renderer> ();
            if (renderer != null) {
                _SetLayer (LayerName, OrderInLayer);
                this.enabled = false;
            }
        }
    }

    protected virtual void OnValidate ()
    {
        _SetLayer (LayerName, OrderInLayer);
    }

    private void _SetLayer (string layerName, int orderInLayer)
    {
        Renderer[] renderers;
        if (recursive) {
            renderers = transform.GetComponentsInChildren <Renderer> (true);
        } else {
            renderers = transform.GetComponents <Renderer> ();
        }
        foreach (Renderer renderer in renderers) {
            renderer.sortingLayerName = layerName;
            renderer.sortingOrder = orderInLayer;
        }
    }

    public virtual string LayerName {
        get {
            return _layerName;
        }
        set {
            _layerName = value;
            _SetLayer (LayerName, OrderInLayer);
        }
    }

    public virtual int OrderInLayer {
        get {
            return _orderInLayer;
        }
        set {
            _orderInLayer = value;
            _SetLayer (LayerName, OrderInLayer);
        }
    }
}
