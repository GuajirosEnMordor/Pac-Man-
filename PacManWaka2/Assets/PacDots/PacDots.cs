using UnityEngine;
using System.Collections;

public class PacDots : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacman")
            puntaje.puntos += 50;
            Destroy(gameObject);

        //Buscar como Coño darle poderes a PacMan y temporizador

    }
}
