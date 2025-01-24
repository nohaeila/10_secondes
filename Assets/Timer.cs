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
            // Decrementa o tempo apenas uma vez
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            // Se o tempo for negativo, corrigimos para zero
            remainingTime = 0;
            // Você pode chamar um método de GameOver ou outro comportamento aqui
            // GameOver();
            timerText.color = Color.red;
        }

        // Calcula minutos e segundos
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        // Atualiza o texto do timer
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
