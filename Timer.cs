using Unity.VectorGraphics;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour
{

  public float seconds;
 public float minutes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if (seconds < 0)
        {
            minutes--;
            if (minutes >= 0)
            {
                seconds = 59;
            }
            else
            {
                EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().name);
            }
        }
    }
}
