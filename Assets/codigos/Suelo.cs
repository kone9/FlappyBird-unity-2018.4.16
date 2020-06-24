using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public int velocidad = 1;
    private Rigidbody moverSuelo;
    private Vector3 Movimiento;
    public Pajaro _Pajaro;
     void Awake()
     {
         moverSuelo = GetComponent<Rigidbody>();
          _Pajaro = FindObjectOfType<Pajaro>();
     }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(_Pajaro.GameOver == false)
        {
            Movimiento.z = 1f * Time.deltaTime;
            moverSuelo.MovePosition(this.transform.position + Movimiento * velocidad);
            if(moverSuelo.transform.position.z > 20)
            {
                this.moverSuelo.MovePosition(new Vector3(0,0,-50));
                
            }
        }

        
        
    }
}
