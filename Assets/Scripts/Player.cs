using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private string floorLayerName;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpPower;

    private bool collidingToFloor = false;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var movement = Vector3.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(transform.position + movement);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.IsInLayerByName(floorLayerName))
        {
            collidingToFloor = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        collidingToFloor = false;
    }

    public void Jump()
    {
        if (collidingToFloor)
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}
