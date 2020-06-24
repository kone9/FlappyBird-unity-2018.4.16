using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pajaro : MonoBehaviour
{
    
    public bool GameOver = false;
    public float fuerzaImpulso = 0.1f;
    public float fuerzaImpulsoMorir = 5;
    private Rigidbody pajaroFisico;
    
    private void Awake()
    {
        pajaroFisico = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            pajaroFisico.velocity = new Vector3(0,0,0);
            pajaroFisico.AddForce(new Vector3(0,fuerzaImpulso,0),ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.CompareTag("Finish"))
        {
            GameOver = true;
             pajaroFisico.AddForce(new Vector3(0,-fuerzaImpulsoMorir,0),ForceMode.Impulse);
        }    
    }

}
