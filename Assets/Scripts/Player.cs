using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    public float speed;

    [SerializeField]
    private Transform center;
    [SerializeField]
    private Transform leftMost;
    [SerializeField]
    private Transform rightMost;
    private Transform target;

    public void MoveToLeft()
    {
        if (target == rightMost)
        {
            target = center;
        }
        else
        {
            target = leftMost;
        }
    }

    public void MoveToRight()
    {
        if (target == leftMost)
        {
            target = center;
        }
        else
        {
            target = rightMost;
        }
    }

    private void Start()
    {
        target = center;
    }

    private void Update()
    {
        transform.position = target.position;
    }
}
