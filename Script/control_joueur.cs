using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control_joueur : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    public float Xmin = -150.0f;
    public float Zmin = -250.0f;
    public float Xmax = 750.0f;
    public float Zmax = 250.0f;
    public float rotationVaisseau = 10.0f;
    public Transform canonLaser;
    public Rigidbody laser;
    public Rigidbody lumiereLaser;
    public float vitesseTir;
    public float frequenceTir;
    float tirSuivant;
    public Canvas canvaGameOver;
    public Button boutonMenu;
    public Button boutonRecommencer;
    public Text textGameOver;
    public controlMenuGameOver gameOverScreen;
   

    void OnDestroy() 
    {
        gameOverScreen.Setup();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&Time.time>tirSuivant)
        {
            tirSuivant = Time.time + frequenceTir;
            Rigidbody munitionLaser;
            munitionLaser = Instantiate(laser, canonLaser.position, canonLaser.rotation) as Rigidbody;
            munitionLaser.AddForce(canonLaser.right * vitesseTir);
            Rigidbody malumiereParentee;
            malumiereParentee = Instantiate(lumiereLaser, canonLaser.position, canonLaser.rotation) as Rigidbody;
            malumiereParentee.AddForce(canonLaser.right * vitesseTir);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float deplacementHorizontal = Input.GetAxis("Horizontal")*speed;
        float deplacementVertical = Input.GetAxis("Vertical")*speed;
        Vector3 mouvement = new Vector3(deplacementHorizontal, 0, deplacementVertical);
        GetComponent<Rigidbody>().velocity = mouvement * speed;
        GetComponent<Rigidbody>().position = new Vector3(
        Mathf.Clamp(GetComponent<Rigidbody>().position.x, Xmin, Xmax),
        0,
        Mathf.Clamp(GetComponent<Rigidbody>().position.z, Zmin, Zmax));
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(GetComponent<Rigidbody>().velocity.x * -rotationVaisseau, 0f, 0f);

    }
}
