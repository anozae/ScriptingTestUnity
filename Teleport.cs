using UnityEngine;


public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform teleportPoint;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportPoint.position;
    }

}