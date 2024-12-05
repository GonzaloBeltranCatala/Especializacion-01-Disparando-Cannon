using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    static public GameObject textoBalas;

    static int numBala = 0;

    


    void Start()
    {
        textoBalas = GameObject.Find("NumBala");


    }

    

    static public void ResetBala()
    {
        numBala = 0;

        textoBalas.GetComponent<TextMeshProUGUI>().text = numBala.ToString();
    }

    static public void AumentarBala()
    {
        numBala++;

        textoBalas.GetComponent<TextMeshProUGUI>().text = numBala.ToString();


    }

    static public void DisminuirBala()
    {

        numBala--;

        textoBalas.GetComponent<TextMeshProUGUI>().text = numBala.ToString();

    }

    


}
