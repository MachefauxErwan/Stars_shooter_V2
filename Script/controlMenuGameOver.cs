using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controlMenuGameOver : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
    }
    public void Recommencer()
    {
        Debug.Log("Recommencer appuyer");
        SceneManager.LoadScene("jeu");
       // Application.LoadLevel("jeu");
    }
    public void PressMenu()
    {
        Debug.Log("Menu appuyer");
        SceneManager.LoadScene("Menu");
       // Application.LoadLevel("Menu");
    }
}
