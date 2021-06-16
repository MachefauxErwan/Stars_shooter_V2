using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_ennemi : MonoBehaviour
{
    public float vitesseEnnemi;
    Rigidbody rigidbodyEnnemi;
    public Rigidbody munitionEnnemi;
    public Transform laserEnnemi;
    public Rigidbody lumierelaserEnnemi;
    public float cadenceTirEnnemi = 0.5f;
    float tirSuivant = 0.0f;
    public GameObject explosion;
    public GameObject explosionJoueur;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "ennemi")
        {
            return;
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "player")
        {
            Instantiate(explosionJoueur, transform.position, transform.rotation);
        }
    }
    void Start()
    {
        rigidbodyEnnemi = GetComponent<Rigidbody>();
        rigidbodyEnnemi.velocity = transform.right  * -1* vitesseEnnemi;
        transform.localRotation = Quaternion.Euler(transform.localRotation.x, -90, transform.localRotation.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>tirSuivant)
        {
            tirSuivant = Time.time + cadenceTirEnnemi;
            Rigidbody maLumiereparentee;
            Rigidbody laserInstance;
            laserInstance = Instantiate(munitionEnnemi, laserEnnemi.position, laserEnnemi.rotation) as Rigidbody;
            laserInstance.AddForce(laserEnnemi.right * 50000);

            maLumiereparentee = Instantiate(lumierelaserEnnemi, laserEnnemi.position, laserEnnemi.rotation) as Rigidbody;
            maLumiereparentee.AddForce(laserEnnemi.right * 50000);
        }
    }
}
