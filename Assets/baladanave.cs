using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baladanave : MonoBehaviour
  
{
    public GameObject Player;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Destroy(this.gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * vel);
    }
    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.transform.CompareTag("asteroide"))
        {
            Player.GetComponent<jogador_mov>().AtualizaPontos();
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }

}
