using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpFactor = 10f;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 10;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 2f;
    }



}
