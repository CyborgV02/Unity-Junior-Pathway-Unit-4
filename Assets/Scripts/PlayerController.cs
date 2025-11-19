using System.Numerics;
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    public float powerUpstrength=15.0f;

    public bool hasPowerup = false;

    private GameObject focalPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        rb.AddForce(focalPoint.transform.forward * forwardInput*speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            Destroy(other.gameObject);
            hasPowerup=true;
            StartCoroutine(PowerUpCountdownRoutine());
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")&& hasPowerup)
        {
            Rigidbody enemyrigidbody=collision.gameObject.GetComponent<Rigidbody>();
            UnityEngine.Vector3 awayFromPlayer=(collision.gameObject.transform.position - transform.position);
            enemyrigidbody.AddForce( awayFromPlayer * powerUpstrength, ForceMode.Impulse );
        }


    }

    IEnumerator PowerUpCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup=false;
    }



}