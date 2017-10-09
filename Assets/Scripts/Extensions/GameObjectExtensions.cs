using UnityEngine;

static class GameObjectExtensions
{
    public static bool IsInLayerByName(this GameObject gameObject, string layerName)
    {
        return (gameObject.layer & LayerMask.NameToLayer(layerName)) != 0;
    }
}
