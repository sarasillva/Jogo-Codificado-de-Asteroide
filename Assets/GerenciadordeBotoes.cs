using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadordeBotoes : MonoBehaviour
{
    public void ApertouIniciar()
    {
        SceneManager.LoadScene("SampleScene");

    }

    public void ApertouSair()
    {
        Application.Quit();
    }
    public void ApertouVoltarMenu()
    {
        SceneManager.LoadScene("Menu principal");
    }
}


