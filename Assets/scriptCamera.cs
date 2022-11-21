using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    private float contadorRotY = 0;
    private Quaternion rotacaoInicial;

    // Start is called before the first frame update
    void Start()
    {
        rotacaoInicial = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        contadorRotY += Input.GetAxis("Mouse Y");
        contadorRotY = Mathf.Clamp(contadorRotY, -50, 50);
        Quaternion rotacao = Quaternion.AngleAxis(contadorRotY, Vector3.left);
        transform.localRotation = rotacaoInicial * rotacao;
    }
}
