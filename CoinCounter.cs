using UnityEngine;



public class CoinCounter : MonoBehaviour
{
    public int coins = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CollectCoins()
    {
        coins++;
        print(coins);
    }
}
