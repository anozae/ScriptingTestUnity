using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    private int playerDamage = 2;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(playerDamage);

    }

}
