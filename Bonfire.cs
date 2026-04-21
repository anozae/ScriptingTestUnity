using UnityEngine;

public class Bonfire : MonoBehaviour
{

    public float lifeTime = 15;
    public float heatPower = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            gameObject.SetActive(false);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Temperature>() != null)
        {
            Temperature temperature = other.GetComponent<Temperature>();
            if (temperature.temperatureCurrent < temperature.temperatureNormal)
            {
                temperature.temperatureCurrent += heatPower * Time.deltaTime;
            }
        }
    }



}



