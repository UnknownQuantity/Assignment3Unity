using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Text timerText;
     float timeLeft = 10F;

    public static Timer instance;

    void Start()
    {
        instance = this;
        
    }

    void Update()
    {
         timeLeft -= Time.deltaTime;

        string minutes = ((int)timeLeft / 60).ToString("00");
        string seconds = (timeLeft % 60).ToString("00");
        string milliseconds = ((int)(timeLeft * 100f) % 100).ToString("00");

        timerText.text = minutes + ":" + seconds + ":" + milliseconds;

        if (timeLeft <= 0)
        {
            timeLeft = 0;
            timerText.text = minutes + ":" + seconds;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }


    void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.name == "timeAdd")
        {
            Destroy(other.gameObject);

            timeLeft += 20F;
        }
    }

}