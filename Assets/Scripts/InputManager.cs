using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private Player player;
    [SerializeField]
    private string axisName;

    public void Update()
    {
        player.position = Input.GetAxis(axisName);
    }
}
