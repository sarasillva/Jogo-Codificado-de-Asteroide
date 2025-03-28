using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vidas : MonoBehaviour
{

    public int vida = 5;
    public TextMeshProUGUI Textovida;
    

// Start is called before the first frame update
void Start()
{

}
private void OnCollisionEnter2D(Collision2D collision)

{

     /* 
     if (collision.gameObject.CompareTag("asteroide"))
    {
        vida = vida - 1;
        Textovida.text = "Vidas: " + vida;
        Debug.Log("A vida atual esta em: " + vida);
        GetComponent<SpriteRenderer>().color = Color.red;
        if (vida <= 0)
        {
            SceneManager.LoadScene("a");
        }
    }
     */

    //collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;

   }
}
