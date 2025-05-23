using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador_mira : MonoBehaviour

{
    public SpriteRenderer Foguinho;
    public float temporizador, tempoParaApagarOFogo;
    public Transform PontoDeTiro;
    public GameObject Municao;
    public Camera cam;
    public Vector2 posParaOlhar;
    public Rigidbody2D rb2d;
   
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Municao, PontoDeTiro.position, this.gameObject.transform.rotation);
            Foguinho.enabled = true;
        }
        if (Foguinho.enabled == true)
        {
            temporizador += Time.deltaTime;
            if (temporizador >= tempoParaApagarOFogo)
            {
                Foguinho.enabled = false;
                temporizador = 0f;
            }
        }
    }
    private void FixedUpdate()
    {

        posParaOlhar = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = posParaOlhar - rb2d.position;

        float angoloParaOlhar = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - 90f ;
        rb2d.rotation = angoloParaOlhar;
    }
}

