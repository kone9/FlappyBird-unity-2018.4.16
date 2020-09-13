using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boton : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator botonAnimator;
    public GameObject fondoReiniciar;
    private AudioSource SelectMenuSound;
    
    private void Awake()
    {
        botonAnimator = gameObject.GetComponent<Animator>();    
        SelectMenuSound = GameObject.FindGameObjectWithTag("SelectMenuSound").GetComponent<AudioSource>();
    }
    public void EntroElMouse()
    {
        print("el mouse entro al area del boton");
        botonAnimator.SetTrigger("activarBoton ");
        SelectMenuSound.Play();
    }

    public void SalioElmouse()
    {
        botonAnimator.SetTrigger("activarBoton ");
        print("el mouse SALIO DEL area del boton");   
    }

    public void ReiniciarEscena()
    {
        StartCoroutine("fondoAnimado");
    }

    public void CambiarNivel()
    {
        //fondoReiniciar.SetActive(true);
        SceneManager.LoadScene("SampleScene");
     }


    IEnumerator fondoAnimado()
    {
        
        GetComponent<Image>().enabled = false;
        fondoReiniciar.GetComponent<Animator>().SetTrigger("FondoColorAnimacion");
        print("tiene que pasar 1 segundo");
        yield return new WaitForSeconds(1.0f);
        print("ya paso 1 segundo");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
