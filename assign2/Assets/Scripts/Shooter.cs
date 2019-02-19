using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public Transform gunPoint;

    public float despawnTimer = 3.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Shoot();
        }
    }


    void Shoot()
    {
        var bull = Instantiate(bullet, gunPoint.position, gunPoint.rotation);
        bull.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 30);

        Destroy(bull, despawnTimer);
    }
}
