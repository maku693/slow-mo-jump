using UnityEngine;

public class SpawnNextFloor : MonoBehaviour
{
    public Collider player;
    public FloorManager manager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == player)
        {
            manager.SpawnNextFloor();
        }
    }
}
