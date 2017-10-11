using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    public string floorLayerName;

    private Rigidbody rb;
    private bool collidingToFloor = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
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
            rb.AddForce(0.0f, rb.mass * 1000.0f, 0.0f);
        }
    }
}
