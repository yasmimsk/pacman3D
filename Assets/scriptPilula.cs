using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPilula : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        scriptPlacar.incrementarPlacar(10);
        Destroy(this.gameObject);
    }
}
