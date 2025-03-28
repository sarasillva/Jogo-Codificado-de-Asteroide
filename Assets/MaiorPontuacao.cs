using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class MaiorPontuacao : MonoBehaviour
{
    public TextMeshProUGUI TextoHighScore;
    public TextMeshProUGUI TextoMaiorPontos;
    public TextMeshProUGUI TextoPontuacaoAnterior;
    // Start is called before the first frame update
    void Start()
    {
        int pontuacaoAnterior = PlayerPrefs.GetInt("PontosPrefs");
        int maiorPontuacao = PlayerPrefs.GetInt("MaiorPontuacao");

        TextoHighScore.text = "Pontuacao anterior" + PlayerPrefs.GetInt("PontosPrefs");
        PlayerPrefs.GetInt("MaiorPontuacao");
        TextoMaiorPontos.text = " Maior Pontuação: " + PlayerPrefs.GetInt("MaiorPontuacao");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
