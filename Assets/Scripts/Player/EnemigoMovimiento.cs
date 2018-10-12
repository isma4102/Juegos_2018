using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemigoMovimiento : MonoBehaviour {

    Transform jugador; //Guarda la posicion del jugador
    NavMeshAgent IA;

    private void Awake()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
        IA = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        IA.SetDestination(jugador.position);
    }
}
