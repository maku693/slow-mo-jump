using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
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

    private void FixedUpdate()
    {
        if (Input.anyKeyDown)
        {
            if (collidingToFloor)
            {
                rb.AddForce(0.0f, rb.mass * 1000.0f, 0.0f);
            }
        }
    }
}
