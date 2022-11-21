using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPC : MonoBehaviour
{
    public float velocidade = 5;

    private Rigidbody rbd;
    private Quaternion rotacaoInicial;
    private float contadorRotX = 0;

    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
        rotacaoInicial = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        float movFrente = Input.GetAxis("Vertical");
        float movLado = Input.GetAxis("Horizontal");
        rbd.velocity = transform.TransformDirection(new Vector3(movLado * velocidade, rbd.velocity.y, movFrente * velocidade));

        contadorRotX += Input.GetAxis("Mouse X");
        Quaternion lado = Quaternion.AngleAxis(contadorRotX, Vector3.up);
        transform.localRotation = rotacaoInicial * lado;
    }
}
