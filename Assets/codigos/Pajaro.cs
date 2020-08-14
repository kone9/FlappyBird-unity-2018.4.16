using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pajaro : MonoBehaviour
{
    
    public GameController _ManejadorJuego;
    public float fuerzaImpulso = 0.1f;
    public GameObject boton;
    public float fuerzaImpulsoMorir = 5;
    private Rigidbody pajaroFisico;
    
    private void Awake()
    {
        pajaroFisico = GetComponent<Rigidbody>();
        boton.SetActive(false);

    }

    private void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
            {
                pajaroFisico.velocity = new Vector3(0,0,0);
                pajaroFisico.AddForce(new Vector3(0,fuerzaImpulso,0),ForceMode.Impulse);
            }
        // // if(_ManejadorJuego.GameOver == false)
        // // {
            
        // // }
    }


    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.CompareTag("Finish"))
        {
           
            print("colisiono el pajaro con un obstaculo");
            pajaroFisico.AddForce(new Vector3(0,-fuerzaImpulsoMorir,0),ForceMode.Impulse);
            boton.SetActive(true);
            _ManejadorJuego.gameOver = true;
        }    
    }
    
    public void Reiniciar()
    {
        print("tendria que reiniciar");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    

}
