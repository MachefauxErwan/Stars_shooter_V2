using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controleMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void jouer()
    {
        Application.LoadLevel("jeu");
    }

    // Update is called once per frame
    public void quitter()
    {
        Application.Quit();
    }
}
