using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    public float position;
    public float velocity;

    [SerializeField]
    private Transform leftMost;
    [SerializeField]
    private Transform rightMost;

    private void Update()
    {
        transform.position = Vector3.Lerp(leftMost.position, rightMost.position, (position + 1.0f) * 0.5f);
        Debug.Log(transform.position);
    }
}
