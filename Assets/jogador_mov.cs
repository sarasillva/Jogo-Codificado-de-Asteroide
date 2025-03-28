using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class jogador_mov : MonoBehaviour
{
    public float vel;
    public int vida;
    public int pontos;
    public TextMeshProUGUI TextoHighScore;
    public TextMeshProUGUI TextoPontos;
    public TextMeshProUGUI TextoVidas;
    public Rigidbody2D rb2d;
    public float largura = 10f, altura = 5f; 

    // Start is called before the first frame update
    void Start()
    {
        // Carregar a maior pontuação e a pontuação anterior
        int maiorPontuacao = PlayerPrefs.GetInt("MaiorPontuacao", 0);
        int pontuacaoAnterior = PlayerPrefs.GetInt("PontuacaoAnterior", 0);

        TextoHighScore.text = $"High Score: {maiorPontuacao} (Anterior: {pontuacaoAnterior})";

        TextoVidas.text = "Vidas: " + vida;
        TextoPontos.text = "Pontos:" + pontos;
        pontos = 0;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(vel * Input.GetAxisRaw("Horizontal"), vel * Input.GetAxisRaw("Vertical"));
       
            Vector3 pos = transform.position;

            if (pos.x > largura) pos.x = -largura;
            else if (pos.x < -largura) pos.x = largura;

            if (pos.y > altura) pos.y = -altura;
            else if (pos.y < -altura) pos.y = altura;

            transform.position = pos;
    }

    public void AtualizaPontos()
    {
        pontos = pontos + 10;
        TextoPontos.text = "pontos: " + pontos;

        // Verificar e atualizar maior pontuação
        int maiorPontuacao = PlayerPrefs.GetInt("MaiorPontuacao", 0);
        if (pontos > maiorPontuacao)
        {
            PlayerPrefs.SetInt("MaiorPontuacao", pontos);
            TextoHighScore.text = "High Score: " + pontos + $" (Anterior: {PlayerPrefs.GetInt("PontuacaoAnterior ", 0)})";
        }
    }

    public void AtualizaVida()
    {
        vida = vida - 1;
        if (vida <= 0)
        {
            PlayerPrefs.SetInt("PontosPrefs", pontos);
            SceneManager.LoadScene("a");
            // terminar o jogo
        }
        TextoVidas.text = "Vidas: " + vida;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("asteroide"))
        {
            AtualizaVida();
        }
    }
}
