using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FloorManager : MonoBehaviour
{
    [SerializeField]
    private GameObject floorPrefab;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject mainCamera;

    [SerializeField]
    private float moveSpeed;

    private List<GameObject> floors = new List<GameObject>(10);

    private void Start()
    {
        SetupFloors();
    }

    private void SetupFloors()
    {
        var floorSize = floorPrefab.GetComponent<MeshRenderer>().bounds.size;
        for (var i = 0; i < floors.Capacity; i++)
        {
            var floor = Instantiate(floorPrefab);
            floor.transform.position = Vector3.Scale(Vector3.forward, floorSize) * i;
            floors.Add(floor);
        }
    }

    //private void Update()
    //{

    //}

    //private void SpawnNextFloor()
    //{
    //    // TODO: Implement
    //}
}
