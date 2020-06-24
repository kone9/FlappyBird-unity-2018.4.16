using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columnas : MonoBehaviour
{
    public int velocidad = 1;
    public Pajaro _Pajaro;
    private Rigidbody moverColumnas;
    private Vector3 Movimiento;
     void Awake()
     {
        moverColumnas = GetComponent<Rigidbody>();
        _Pajaro = FindObjectOfType<Pajaro>();
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(_Pajaro.GameOver == false)//sino es GameOVer
        {
            Movimiento.z = 1f * Time.deltaTime;
            moverColumnas.MovePosition(this.transform.position + Movimiento * velocidad);
            if(moverColumnas.transform.position.z > 20)
            {
                this.moverColumnas.MovePosition(
                    new Vector3(0
                                ,
                                Random.Range(4.5f, 8f)//columna posición aleatorio en Y
                                ,
                                -50
                    )
                );
                
            }
        }

        
        
    }
}
