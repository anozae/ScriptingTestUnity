using Unity.VectorGraphics;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Audio;

public class Healtj : MonoBehaviour
{

    public int health = 10;
    public int maxHealth = 10;
    public string sceneName;
    public AudioSource audioSource;
    public AudioClip damageSound;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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


}
