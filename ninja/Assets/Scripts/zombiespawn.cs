using UnityEngine;

public class zombiespawn : MonoBehaviour {
    public GameObject target;
    void Start()
    {
        InvokeRepeating("LaunchZombieSpawn", 1f, 2f);
    }
    void LaunchZombieSpawn()
    {
        GameObject zombie = Instantiate(target, transform.position, Quaternion.identity);
        Destroy(zombie, 5);
    }
}
