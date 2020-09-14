using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_Clicking : MonoBehaviour
{
    public Text counter;
    public float counterNumber;
    public float ammountPerClick == 1.0f;


    // Update is called once per frame
    void Update()
    {
        counter.text = counterNumber + " Cookies";
    }

    public void Clicked()
    {
        counterNumber += ammountPerClick
    }
}
