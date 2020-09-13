
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuelosTestMoviento : MonoBehaviour
{
    public float velocidadJuego = 1;
    public Transform emphtyReposicionar;
    private float limitZ;

    private void Start()
    {
        limitZ = transform.position.z;
    }

    private void Update()
    {


        if (this.transform.position.z <= limitZ - 40f)
        {
            //Debug.Break();
            //float posicionEmphty = emphtyReposicionar.position.z + 20;
            print("el suelo tendría que reposicionarse");
            //this.transform.Translate(new Vector3(this.transform.position.x,-30,this.transform.position.z),Space.World);

            this.transform.position = new Vector3(
                this.transform.position.x,
                this.transform.position.y,
                this.transform.position.z + 40
                );


            //print("la posicion del empty es: " + posicionEmphty);
            //print("la posicion de la plataforma es : " + this.transform.position.z);
            //print("----------------------------------------------------------------");
        }
        else
        {
            transform.Translate(0, 0, Time.deltaTime * -velocidadJuego);
        }
    }

}
