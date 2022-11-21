using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPowerUp : MonoBehaviour
{
    public GameObject pc;

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
        if (collider.gameObject.Equals(pc))
        {
            scriptNPC.AtivarVulnerabilidade();
            scriptPlacar.incrementarPlacar(50);
            Destroy(this.gameObject);
        }
    }
}
