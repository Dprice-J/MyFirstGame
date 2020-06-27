using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            GameObject newBullet = Instantiate(
                bulletPrefab,
                transform.position + transform.forward * bulletPrefab.transform.position.z,
                transform.rotation * bulletPrefab.transform.rotation
            );
        }
    }
}
