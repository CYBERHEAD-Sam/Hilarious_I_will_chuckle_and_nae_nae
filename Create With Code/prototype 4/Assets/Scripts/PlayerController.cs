using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool hasPowerup;
    private Rigidbody playerRb;
    private float powerupStrength = 15.0f;
    private GameObject focalPoint;

    

    IEnumerator PowerupCountdownRoutine() 
    {
        yield return new WaitForSeconds(7);
    }
 
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }

    private void onTriggerEnter(Collider other) {
        if (other.CompareTag("Powerup")) {
            hasPowerup = true;
            Destroy(other.gameObject); 
            StartCoroutine(PowerupCountdownRoutine());
        }
    }
    private void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup) {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);

            Debug.Log("Player collided with " + collision.gameObject + " with powerup set to " + hasPowerup);
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }
 
}
