using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arboles : MonoBehaviour
{
    private float velocidad;
    public int eleguirVelocidadarboles = 4;
    public GameController _ManejadorJuego;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(_ManejadorJuego.gameOver == false)
        {
            velocidad = _ManejadorJuego.velocidadJuego / eleguirVelocidadarboles;
            gameObject.transform.Translate(Vector3.down *  velocidad * Time.deltaTime);
            // moverSuelo.MovePosition(this.transform.position + Movimiento * velocidad);
            if(transform.position.z > 130)
            {
                // gameObject.transform.position = new Vector3(this.transform.position.x,0,this.transform.position.z);
                transform.position =new Vector3(transform.position.x,transform.position.y,-50);
            }
        }

    }
}
