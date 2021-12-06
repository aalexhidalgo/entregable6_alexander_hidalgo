using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject ProjectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si pulsamos la tecla derecha aparece nuestro proyectil rotado para modificar su nueva dirección
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SpawnProjectile(Quaternion.Euler(0, 0, -90));
        }
        //Si pulsamos la tecla izquierda aparece nuestro proyectil rotado para modificar su nueva dirección
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SpawnProjectile(Quaternion.Euler(0, 0, 90));
        }
        //Si pulsamos la tecla arriba aparece nuestro proyectil rotado para modificar su nueva dirección
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SpawnProjectile(Quaternion.Euler(0, 0, 0));
        }
        //Si pulsamos la tecla abajo aparece nuestro proyectil rotado para modificar su nueva dirección
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SpawnProjectile(Quaternion.Euler(0, 0, 180));
        }

    }

    //Función que llama a nuestro proyectil
    public void SpawnProjectile(Quaternion Rotation)
    {
        Instantiate(ProjectilePrefab, transform.position, Rotation);
    }
}
