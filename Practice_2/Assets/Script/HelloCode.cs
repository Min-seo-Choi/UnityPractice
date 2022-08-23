using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal ani = new Animal();
        ani.name = "name";
        ani.sound = "sound";

        Debug.Log("Hello World!");
        ani.PlaySound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
