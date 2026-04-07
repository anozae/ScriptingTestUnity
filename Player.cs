using JetBrains.Annotations;
using Unity.VectorGraphics;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    private int coins = 0;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public string sceneName;
    public AudioSource audioSource;
    public AudioClip damageSound;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока: " + health);



        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            EditorSceneManager.
            LoadScene(sceneName);
        }
    }

    public void CollectCoins()
    {
        coins++;
        print(coins);
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,
            attackPoint.
            position, attackPoint.
            rotation);
        }
    }

}