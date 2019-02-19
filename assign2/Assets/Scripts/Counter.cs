using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
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
            countText.rectTransform.DOShakeAnchorPos(3f, 20f, 5, 45, false, true);
            }
        }
    

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

}