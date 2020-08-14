using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arboles : MonoBehaviour
{
    public int velocidad = 1;
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
            // Movimiento.z = 1f * Time.deltaTime;
            // this.transform.position = this.transform.position + Movimiento * velocidad;
            transform.Translate(Vector3.down *  _ManejadorJuego.velocidadJuego * Time.deltaTime);
            // moverSuelo.MovePosition(this.transform.position + Movimiento * velocidad);
            if(transform.position.z > 130)
            {
                transform.Translate(new Vector3(this.transform.position.x,0,this.transform.position.z));
                //this.transform.position =new Vector3(0,0,-50);
            }
        }

    }
}
