using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gerador_asteroide : MonoBehaviour
{
    public GameObject AsteroidePrefab;
    public float Temporizador, tempoParaCriarAsteroide;
    public Transform posParaCriar;

    // Start is called before the first frame update
    void Start()
    {
        tempoParaCriarAsteroide = Random.Range(2, 5); 
    }

    // Update is called once per frame
    void Update()
    {
        Temporizador = Temporizador + Time.deltaTime;

        //Debug.Log(Temporizador);
        if (Temporizador >= tempoParaCriarAsteroide)
        {
            GameObject ObjIntanciado = Instantiate(AsteroidePrefab, posParaCriar.transform.position, Quaternion.identity);
            ObjIntanciado.GetComponent<comportamento_ast>().RotacionaAsteroide();
            Temporizador = 0;
            tempoParaCriarAsteroide = Random.Range(1, 3);
        }
    }
}