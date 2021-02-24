using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnCollisionEnter(Collision colision)
    {
        Destroy(gameObject);
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
            Destroy(other.gameObject);  
    }
}
