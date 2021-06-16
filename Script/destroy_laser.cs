using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_laser : MonoBehaviour
{
    public float dureeDestruction;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, dureeDestruction);
    }
}
