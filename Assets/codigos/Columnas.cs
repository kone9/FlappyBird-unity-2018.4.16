using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columnas : MonoBehaviour
{
    //public Pajaro _Pajaro;
    private Rigidbody moverColumnas;
    private Vector3 Movimiento;
    public GameController _ManejadorJuego;
    
    void Awake()
    {
        moverColumnas = GetComponent<Rigidbody>();
        //_Pajaro = FindObjectOfType<Pajaro>();
    }
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(
            this.transform.position.x,
            Random.Range(4.5f, 8f),//columna posición aleatorio en Y,
            this.transform.position.z
        ); 
        
        // this.moverColumnas.MovePosition(
        //         new Vector3(
        //                 this.transform.position.x
        //                 ,
        //                 Random.Range(4.5f, 8f)//columna posición aleatorio en Y
        //                 ,
        //                 this.transform.position.z
        //                 )
        // );
        
        //moverColumnas.velocity = new Vector3(0,0,velocidad);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(_ManejadorJuego.gameOver == false && _ManejadorJuego.comienzaJuego == true)
        {
            this.transform.position += new Vector3(0,0,_ManejadorJuego.velocidadJuego) * Time.deltaTime;
            if(transform.position.z > 20)
            {
                this.transform.position = new Vector3(
                    this.transform.position.x,
                    Random.Range(4.5f,8f),//columna posición aleatorio en Y,
                    -50
                );
            }
        }
        
    }


}
