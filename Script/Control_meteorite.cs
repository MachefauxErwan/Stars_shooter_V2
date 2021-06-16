using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_meteorite : MonoBehaviour
{
    Rigidbody rigidbodyMeteorite;
    public float vitesseMeteorite;
    public Vector3 eulerAngleVelocity;
    public GameObject explosionJoueur;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyMeteorite = GetComponent<Rigidbody>();
        rigidbodyMeteorite.velocity = transform.right * -vitesseMeteorite;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
        if(other.tag == "Player")
        {
            Instantiate(explosionJoueur, transform.position, transform.rotation);
        }
        else 
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
        rigidbodyMeteorite.MoveRotation(rigidbodyMeteorite.rotation * deltaRotation);


    }
}
