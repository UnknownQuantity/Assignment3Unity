using UnityEngine;
using System.Collections;


public class CoinMoverWorking : MonoBehaviour
{
    public Vector3 endPos;

    IEnumerator Start()
    {
        var startPos = transform.position;
        while (true)
        {
            yield return StartCoroutine(Coin(transform, startPos, endPos, 7.0f));
            yield return StartCoroutine(Coin(transform, endPos, startPos, 7.0f));
        }
    }

    IEnumerator Coin(Transform c, Vector3 startPos, Vector3 endPos, float time)
    {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            c.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
        yield return new WaitForSeconds(3f);
    }
}
