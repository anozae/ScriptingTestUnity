using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUI : MonoBehaviour
{

    public Healtj health;
    public CoinCounter coins;
    public TextMeshProUGUI CoinsCounter;
    public Slider HealthSlider;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HealthSlider.maxValue = health.maxHealth;
        HealthSlider.value = health.health;

        CoinsCounter.text = coins.coins.ToString();
    }
}
