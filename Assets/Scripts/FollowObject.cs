using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public GameObject target;

    private void Update()
    {
        if (target != null)
        {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        }
    }
}
