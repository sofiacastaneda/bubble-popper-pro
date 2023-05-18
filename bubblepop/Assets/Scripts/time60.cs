using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class time60 : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] TextMeshPro tiempo;
    [SerializeField] TextMeshPro puntos;

    //Variables tiempo
    private float restante;
    private bool enMarcha = true;

    //Variables puntaje
    private int pts;


    void Start()
    {
        restante = seg;
    }

    void Update()
    {
        if (enMarcha)
        {
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                enMarcha = false;
            }
            //Tiempo
            int tempSeg = Mathf.FloorToInt(restante);
            tiempo.text = string.Format("{00:00}", restante) + "s";

            //aqui verificar que la burbuja hizo pop
            // si si, pts +=1 

            //Puntos
            int points = pts;
            puntos.text = string.Format("{0}", pts);
        }
        else {
            tiempo.text = string.Format("Time's up!");
        }
    }
}
