using Unity.VectorGraphics;
using UnityEditor.SceneManagement;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

  public float seconds;
    public float minutes;
    public TextMeshProUGUI TimerUI;

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
        int roundSeconds = Mathf.RoundToInt(seconds);
        TimerUI.text = minutes + ":" + roundSeconds;

    }
}
