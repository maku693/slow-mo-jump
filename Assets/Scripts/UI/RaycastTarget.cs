using UnityEngine;
using UnityEngine.UI;

public class RaycastTarget : Graphic
{
    public override void Rebuild(CanvasUpdate update)
    {
        color = Color.clear;
    }
}
