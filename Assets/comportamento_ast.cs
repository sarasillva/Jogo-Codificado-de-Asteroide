using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamento_ast : MonoBehaviour
{
    public float vel;
    public Rigidbody2D rb2d;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * vel);
    }
    public void RotacionaAsteroide()
    {
        rb2d = GetComponent<Rigidbody2D>();
        vel = Random.Range(2, 6);
            Player = GameObject.FindGameObjectWithTag("Player");
    Vector2 pos = Player.transform.position - this.transform.position;

        float angoloParaOlhar = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - 90f;

        rb2d.rotation = angoloParaOlhar;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.CompareTag("Player"))
            Destroy(this.gameObject);
       }
    }
