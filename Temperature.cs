using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Healtj health;
    public int playerDamage = 2;
    public float temperatureCurrent = 36.6f;
    public float temperatureNormal = 36.6f;
    public float temperatureCritical = 34f;
    public float freezeSpeed = 0.05f;
    public float freezeDamageTimer = 1;
    public float freezeDamageDelay = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temperatureCurrent -= freezeSpeed * Time.deltaTime;
        if (temperatureCurrent <= temperatureCritical)
        {
            if (freezeDamageTimer <= 0)
            {
                health.TakeDamage(playerDamage);
                freezeDamageTimer += freezeDamageDelay;
            }
            else
            {
                freezeDamageTimer -= Time.deltaTime;
            }
        }


    }
}
