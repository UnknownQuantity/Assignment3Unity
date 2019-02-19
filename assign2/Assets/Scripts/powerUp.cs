using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerUp : MonoBehaviour
{

    public GameObject pickupEffect;


    public Text countText;

    private int count;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickUp(other);
        }
    }

    void PickUp(Collider Player)
    {
        Destroy(gameObject);


        //Add one to the current value of our count variable.
        count = count + 1;

        //Update the currently displayed count by calling the SetCountText function.
        SetCountText();

    }
    // Start is called before the first frame update
    void Start()
    {

        count = 0;

        SetCountText();

    }

    // Update is called once per frame
    void Update()
    {

    }


    void SetCountText()
    {
        //Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
        countText.text = "Count: " + count.ToString();


    }

}
