using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private Vector3 moveAxis;

    private void Update()
    {
        var movement = moveAxis * moveSpeed * Time.deltaTime;
        transform.position += movement;
    }

    public void MoveToLeft()
    {
        moveAxis = Vector3.left;
    }

    public void MoveToRight()
    {
        moveAxis = Vector3.right;
    }
}
