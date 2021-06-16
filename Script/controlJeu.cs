using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlJeu : MonoBehaviour
{
    public GameObject[] obstacle;
    public Vector3 positionVague;
    public int nbObstacle;
    public float attenteVague;
    public float debutAttente;
    public float intervaleVague;
    
    // Start is called before the first frame update


    void Start()
    {
        StartCoroutine( ApparitionVague());
    }

    // Update is called once per frame
    IEnumerator ApparitionVague()
    {
        yield return new WaitForSeconds(debutAttente);
        while(true)
        {
            for (int i = 0; i < nbObstacle; i++)
            {
                Vector3 maVague = new Vector3(positionVague.x, positionVague.y, Random.Range(-positionVague.z, positionVague.z));
                Quaternion rotationVague = Quaternion.identity;
                Instantiate(obstacle[Random.Range(0,9)], maVague, rotationVague);
                yield return new WaitForSeconds(attenteVague);
            }
            yield return new WaitForSeconds(intervaleVague);
        }
        
        
    }
}
