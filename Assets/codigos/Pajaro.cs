using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pajaro : MonoBehaviour
{
    
    public GameController _ManejadorJuego;
    public float fuerzaImpulso = 5f;
    public GameObject boton;
    public float fuerzaImpulsoMorir = -5;
    private int contador = 0;
    public Text puntaje; 
    private Rigidbody pajaroFisico;
    private AudioSource item;
    private AudioSource Morir;
    private AudioSource Musica;
    
    private void Awake()
    {
        pajaroFisico = GetComponent<Rigidbody>();
        boton.SetActive(false);
        item = GameObject.FindGameObjectWithTag("itemSound").GetComponent<AudioSource>();
        Morir = GameObject.FindGameObjectWithTag("MorirSound").GetComponent<AudioSource>();
        Musica = GameObject.FindGameObjectWithTag("MusicaFondo").GetComponent<AudioSource>();
    }


    private void FixedUpdate()
    {
        if(Input.GetMouseButton(0) &&  _ManejadorJuego.gameOver == false)
            {
                pajaroFisico.velocity = new Vector3(0,0,0);
                pajaroFisico.AddForce(new Vector3(0,fuerzaImpulso,0),ForceMode.Impulse);
            }
    }
    
    private void Start()
    {
        puntaje.text = Convert.ToString(contador);    
    }


    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.CompareTag("Finish"))
        {
           
            if(_ManejadorJuego.gameOver == false)
            {
                print("colisiono el pajaro con un obstaculo");
                Musica.Stop();
                Morir.Play();
                pajaroFisico.AddForce(new Vector3(0,fuerzaImpulsoMorir,0),ForceMode.Impulse);
                boton.SetActive(true);
                _ManejadorJuego.gameOver = true;
            }

        }    
    }

    private void OnTriggerEnter(Collider trigger)
    {
        if(trigger.CompareTag("puntaje"))
        {
            contador += 1;
            puntaje.text = Convert.ToString(contador);
            print("entre a un puntaje");
            item.Play();//ejecuto la música
        }
    }
    

    

}
