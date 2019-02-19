using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Movement : MonoBehaviour
{
    
    public float speed;
    public float lerpValue;
    float delay = 2f;
    float posX;
    float posY;
    float posZ;
    float targetX =10;
    Vector3 startPosition;
    Vector3 endPosition;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("CoroutineDemo", 1f);

        //StartCoroutine("CoroutineDemo");

        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;

        startPosition = transform.position;
        endPosition = new Vector3(10, 0, 0);

        CoroutineDemo();
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    
    bool Timer()
    {
         delay -= Time.deltaTime;
        if (delay <= 0)
            return true;
        return false;
    }


    void FindGameObject()
    {

        GameObject.Find("Sphere").GetComponent<Rigidbody>().useGravity = false;
    }

    void MoveDoTween()
    {
        transform.DOMoveX(10, 1);
    }


    void moveLerp()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, lerpValue);
        lerpValue += 0.01f;
    }

    void MoveBasicTweening()
    {
        posX += (targetX - posX) * 0.1f;
        transform.position = new Vector3(posX, posY, posZ);
    }

    void MoveBasic()
    {
        if (transform.position.x <= 10)
            transform.position = new Vector3(transform.position.x + 0.01f * Time.deltaTime * speed, transform.position.y, transform.position.z);


    }


    IEnumerator CoroutineDemo()
    {
        yield return new WaitForSeconds(1f);
        print("Hello");
        yield return new WaitForSeconds(1f);
        print("Byeee");
        yield return null;
    }
}
