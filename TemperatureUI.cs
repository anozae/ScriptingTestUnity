using TMPro;
using UnityEngine;

public class TemperatureUI : MonoBehaviour
{
    public Temperature player;
    public TextMeshProUGUI degress;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float number = Mathf.Round(player.temperatureCurrent * 10.0f) * 0.1f;
                degress.text = number.ToString();
    }
}
