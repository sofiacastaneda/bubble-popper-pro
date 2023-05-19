using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class botones : MonoBehaviour

{
    private GameObject showBubblesModo1Obj;
    private GameObject showBubblesModo2Obj;
    private GameObject showBubblesModo3Obj;

    void Start()
    {
        GameObject showBubblesModo1Obj = GameObject.Find("Modo1");
        GameObject showBubblesModo2Obj = GameObject.Find("Modo2");
        GameObject showBubblesModo3Obj = GameObject.Find("Modo3");

        showBubblesModo1Obj.SetActive(false);
        showBubblesModo2Obj.SetActive(false);
        showBubblesModo3Obj.SetActive(false);

    }

    public void botonA() {

        showBubblesModo1Obj.SetActive(true);
        showBubblesModo2Obj.SetActive(false);
        showBubblesModo3Obj.SetActive(false);

    }

    public void botonB()
    {
        showBubblesModo1Obj.SetActive(false);
        showBubblesModo2Obj.SetActive(true);
        showBubblesModo3Obj.SetActive(false);

    }

    public void botonC()
    {
        showBubblesModo1Obj.SetActive(false);
        showBubblesModo2Obj.SetActive(false);
        showBubblesModo3Obj.SetActive(true);

    }

    void Update()
    {
        
    }
}
