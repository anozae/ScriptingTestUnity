using Unity.VectorGraphics;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public string sceneName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.
       LoadScene(sceneName);

    }
    // Update is called once per frame

}
