using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEspelho : MonoBehaviour
{
    public GameObject camera;

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
        Vector3 posCamera = camera.transform.position;
        if (posCamera.x > 0)
            posCamera.x = posCamera.x - 1;
        else
            posCamera.x = posCamera.x + 1;
        collider.gameObject.transform.position = new Vector3(posCamera.x, collider.gameObject.transform.position.y, posCamera.z);
    }
}
