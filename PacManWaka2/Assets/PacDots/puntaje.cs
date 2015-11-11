using UnityEngine;
using System.Collections;

public class puntaje : MonoBehaviour
{
   
    public static int puntos=0;

    void OnGUI()
    {
        GUI.Label(new Rect(60, 60, 300, 120), "       " + puntos);
    }

    //Buscar como guardar esto en SQL, y luego buscar como reiniciar valor cuando Pacman muere.

}