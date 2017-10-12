using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private string floorLayerName;

    private bool collidingToFloor = false;
    private Animator animator;

    private void OnEnable()
    {
        animator = GetComponent<Animator>();
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
            animator.SetTrigger("Jump");
        }
    }
}
