using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public int velocidad = 1;
    private Rigidbody moverSuelo;
    private Vector3 Movimiento;

    public GameObject emphtyReposicionar;
    public GameController _ManejadorJuego;
    
     void Awake()
     {
        
        moverSuelo = this.GetComponent<Rigidbody>();
          
     }
    // Start is called before the first frame update
    void Start()
    {
        //moverSuelo.velocity = new Vector3(0,0,velocidad);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(_ManejadorJuego.gameOver == false)
        {
            //Movimiento.z = 1f * Time.deltaTime;
            this.transform.position += new Vector3(0,0,_ManejadorJuego.velocidadJuego) * Time.deltaTime ;
            //transform.Translate((Vector3.forward * _ManejadorJuego.velocidadJuego * Time.deltaTime),(Space.World));
            //moverSuelo.MovePosition(this.transform.position + Movimiento * _ManejadorJuego.velocidadJuego);
            if(this.transform.position.z > 60)
            {
                print("el suelo tendría que reposicionarse");
                //this.transform.Translate(new Vector3(this.transform.position.x,-30,this.transform.position.z),Space.World);
                this.transform.position = new Vector3(
                    this.transform.position.x,
                    this.transform.position.y,
                    emphtyReposicionar.transform.position.z);
            }
        }

        
        
    }
}
