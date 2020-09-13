using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    
    public bool gameOver = false;
    public float velocidadJuego = 1;
    public bool comienzaJuego = false;
    public int tiempoAntesComenzarJuego = 3;
    public int tiempoAumentarDificultad = 10;//tiempo en segundos para saber cada cuanto aumenta la dificultad

    public float dificultad = 0.1f;

    // Start is called before the first frame update
    private void Awake()
    {

    }
    void Start()
    {
        StartCoroutine("Timer");
        StartCoroutine("TimerAumentarDificultad");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reiniciar()
    {
        print("tendria que reiniciar");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    IEnumerator Timer()
    {
        yield return new WaitForSeconds(tiempoAntesComenzarJuego);
        comienzaJuego = true;
    }

    IEnumerator TimerAumentarDificultad()
    {
        while(true)
        {
            yield return new WaitForSeconds(tiempoAumentarDificultad);
            velocidadJuego += dificultad;
            print("aumento dificutad");
        }
        
    }


}
