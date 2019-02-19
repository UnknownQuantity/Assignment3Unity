using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour
{
    public AudioSource soundeffect;
    public Text countText;

    private int count;



  

    void Start()
    {
        soundeffect = GetComponent<AudioSource>();
        count = 0;
        SetCountText();




    }

    void OnTriggerEnter(Collider other)
    
     {
            if (other.gameObject.CompareTag("PickUp"))
            {
                soundeffect.Play();
                Destroy(other.gameObject);
                count = count + 1;
                SetCountText();
            }
        }
    
    /*void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            soundeffect.Play();
            Destroy(other.gameObject);
            count = count + 1;
            SetCountText();
        }
    }*/


    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }



}