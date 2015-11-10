using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour
{
    public float speed = 5f;
    Vector2 dest = Vector2.zero;
    float dirx;
    float diry;

    void Start()
    {
        dirx = 1;
        diry = 0;
    }

    //AGREGAR PARTE DEL SCRIPT PARA QUE PACMAN MUERA. 


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        { this.GetComponent<Rigidbody2D>().position += Vector2.up * Time.deltaTime * speed; diry = 1; dirx = 0; }
        if (Input.GetKey(KeyCode.RightArrow))
        { this.GetComponent<Rigidbody2D>().position += Vector2.right * Time.deltaTime * speed; dirx = 1; diry = 0; }
        if (Input.GetKey(KeyCode.DownArrow))
        { this.GetComponent<Rigidbody2D>().position += -Vector2.up * Time.deltaTime * speed; diry = -1; dirx = 0; }
        if (Input.GetKey(KeyCode.LeftArrow))
        { this.GetComponent<Rigidbody2D>().position += -Vector2.right * Time.deltaTime * speed; dirx = -1; diry = 0; }

        GetComponent<Animator>().SetFloat("DirX", dirx);
        GetComponent<Animator>().SetFloat("Dir-X", dirx);
        GetComponent<Animator>().SetFloat("Dir-Y", diry);
        GetComponent<Animator>().SetFloat("DirY", diry);
    }
}
