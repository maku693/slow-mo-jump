using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private Player player;
    [SerializeField]
    private string axisName;

    public void Update()
    {
        if (Input.GetAxis(axisName) < 0)
        {
            player.MoveToLeft();
        }
        else if (Input.GetAxis(axisName) > 0)
        {
            player.MoveToRight();
        }
    }
}
