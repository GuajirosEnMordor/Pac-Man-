using UnityEngine;
using System.Collections;

public class DotsNORMAL : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacman")
            puntaje.puntos+=10;
            Destroy(gameObject);

        //Buscar como coño pondras el HighScore. Como contar los objetos destruidos. 
        //Listo. Idiota.

    }
}