using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            // decrease time just once
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            // If the time is negative, we correct it to zero
            remainingTime = 0;
            // You can call a GameOver method or other behavior here
            // GameOver();
            timerText.color = Color.red;
        }

        // Calculates minutes and seconds
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        // Update timer text
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
