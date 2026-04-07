using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedfactor = 2.5f;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedfactor;
    }
    private void OnTriggerExit(Collider other) 
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedfactor;
    }

}
