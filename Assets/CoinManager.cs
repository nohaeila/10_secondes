using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;

    private int coins;
    [SerializeField] private TMP_Text coinsDisplay;
    [SerializeField] private Timer timer;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    public void ChangeCoins(int amount)
    {
        // Atualiza o valor das moedas
        coins += amount;

        // Atualiza o texto na UI
        UpdateUI();
    }

    private void UpdateUI()
    {
        // Atualiza a exibição do número de moedas
        coinsDisplay.text = coins.ToString();
    }
}
