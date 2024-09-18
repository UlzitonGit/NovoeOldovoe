
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Image image;
    
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    public void StartTimer(float duration)
    {
        StartCoroutine(Delaying(duration));
    }
    private IEnumerator Delaying(float delay)
    {
        float currentDelay = delay;
        image.fillAmount = 1;
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(delay / 10);
            currentDelay = currentDelay - delay / 10;
            image.fillAmount = currentDelay / delay;
        }

    }
}
