using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody enemyrb;
    public float speed;
    public GameObject player;
    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyrb.AddForce(lookDirection*speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
