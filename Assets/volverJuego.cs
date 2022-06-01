using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volverJuego : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void volver1Juego(){
        SceneManager.LoadScene("Juego");
    }
    public void irContactanos(){
        SceneManager.LoadScene("Contactanos");
    }


}
