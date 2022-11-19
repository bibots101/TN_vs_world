using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatSpawn : MonoBehaviour {
    public GameObject BatSpawner;
    void Start()
    {
        InvokeRepeating("LaunchZombieSpawn", 2f, 3f);
    }
    void LaunchZombieSpawn()
    {
        GameObject bat = Instantiate(BatSpawner, transform.position, Quaternion.identity);
        Destroy(bat, 5);
    }
}
