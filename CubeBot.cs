using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class CubeBot : MonoBehaviour
{

    int Health = 2;
    int Level = 3;
    float speed = 1.3f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health += Level;
      print(Health);   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z +=
         speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
