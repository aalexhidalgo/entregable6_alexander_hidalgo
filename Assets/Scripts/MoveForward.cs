using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float Speed = 5f;
    private float UpperLimit = 6f;
    private float LowerLimit = -6f;
    private float RightLimit = 7f;
    private float LeftLimit = -7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento hacia delante constante
        transform.Translate(Vector3.up * Speed * Time.deltaTime);

        //Si el proyectil cruza el límite superior desaparece
        if (transform.position.y > UpperLimit)
        {
            Destroy(gameObject);
        }
        //Si el proyectil cruza el límite inferior desaparece
        if (transform.position.y < LowerLimit)
        {
            Destroy(gameObject);
        }
        //Si el proyectil cruza el límite derecho desaparece
        if (transform.position.x > RightLimit)
        {
            Destroy(gameObject);
        }
        //Si el proyectil cruza el límite izquierdo desaparece
        if (transform.position.x < LeftLimit)
        {
            Destroy(gameObject);
        }
    }
}
