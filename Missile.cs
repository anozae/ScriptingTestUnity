using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed;
    void Start()
    {
        Destroy(gameObject, 3);
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.position +=
        transform.forward *
        speed * Time.deltaTime;
    }
}
