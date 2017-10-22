using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour, IMoveHandler
{
    [SerializeField]
    private Player player;

    public void OnMove(AxisEventData eventData)
    {
        switch (eventData.moveDir)
        {
            case MoveDirection.Left:
                player.MoveToLeft();
                break;
            case MoveDirection.Right:
                player.MoveToRight();
                break;
        }
    }
}
