using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class time60 : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] TextMeshPro tiempo;

    private float restante;
    private bool enMarcha = true;

    // Start is called before the first frame update
    void Start()
    {
        restante = seg;
    }

    // Update is called once per frame
    void Update()
    {
        if (enMarcha)
        {
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                enMarcha = true;
            }
            //int tempMin = Mathf.FloorToInt(restante);
            int tempSeg = Mathf.FloorToInt(restante);
            tiempo.text = string.Format("{00:00}", restante)+"s";
        }
    }
}
