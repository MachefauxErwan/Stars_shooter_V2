using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_laser : MonoBehaviour
{
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
}
