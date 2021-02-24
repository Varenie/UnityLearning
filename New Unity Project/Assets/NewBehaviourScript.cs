using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour 
{
    private float number = 7;
    public GameObject gm;

    // Start is called before the first frame update
    void Start()
    {
        Randomiser();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Randomiser()
    {
        number = UnityEngine.Random.Range(1, 100);
        UnityEngine.Debug.Log(number);

        if (number == 3)
        {
            UnityEngine.Debug.Log("Проверка условия");
        }
    }
}
