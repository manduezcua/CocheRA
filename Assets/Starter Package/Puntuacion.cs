using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    int puntuacionControl;
    public Text numero;
    public GameObject panel;
    private void Start()
    {
        panel.SetActive(false);
        puntuacionControl = 0;
        numero.text= puntuacionControl.ToString();
    }
    private void Update()
    {
        if (puntuacionControl == 10)
        {
            panel.SetActive (true);
        }
    }
    public void SumarPuntaucion()
    {
        puntuacionControl ++;
        numero.text= puntuacionControl.ToString();
    }
    public void Resetear()
    {
        puntuacionControl = 0;
        numero.text = puntuacionControl.ToString();
    }
    public void ReiniciarJuego()
    {
        SceneManager.LoadScene(0);
    }
    
}
