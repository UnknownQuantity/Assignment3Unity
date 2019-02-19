using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinMover : MonoBehaviour
{


    public float speed;
    public float lerpValue;
    float delay = 2f;
    float posX;
    float posY;
    float posZ;
    float targetX;
    Vector3 startPosition;
    Vector3 endPosition;
    Transform c;

    // Start is called before the first frame update
    void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;

        startPosition = transform.position;
        endPosition = new Vector3(10, 0, 0);
        targetX = posX + 50f;


        Invoke("Move", 1f);
        StartCoroutine("Move");
        
    }

    

    private void Moverss()
    {
        throw new NotImplementedException();
    }


    // Update is called once per frame
    void Update()
    {

    }




    IEnumerator Moverss(Transform c, Vector3 startPos, Vector3 endPos, float speed)
    {
        float move = (speed / (startPos - endPos).magnitude) * Time.deltaTime;

        float t = 0;
        while (t <= 1.0f)
        {
            t += move; // Goes from 0 to 1, incrementing by step each time
            c.position = Vector3.Lerp(startPos, endPos, t); // Move objectToMove closer to b
            yield return new WaitForSeconds(3f);      // Leave the routine and return here in the next frame
        }
        c.position = endPos;

    }



    IEnumerator MoveFromTo(Transform objectToMove, Vector3 a, Vector3 b, float speed)
    {
        float step = (speed / (a - b).magnitude) * Time.fixedDeltaTime;
        float t = 0;
        while (t <= 1.0f)
        {
            t += step; // Goes from 0 to 1, incrementing by step each time
            objectToMove.position = Vector3.Lerp(a, b, t); // Move objectToMove closer to b
            yield return new WaitForFixedUpdate();         // Leave the routine and return here in the next frame
        }
        objectToMove.position = b;
    }


 
}
