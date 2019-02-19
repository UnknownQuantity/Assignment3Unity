using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer:MonoBehaviour
{
    public GameObject Explosion;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cylinder")
        {
            
            Destroy(col.gameObject);
            Instantiate(Explosion, transform.position, transform.rotation);

        }
    }
}