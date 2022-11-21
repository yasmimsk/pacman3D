using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class scriptNPC : MonoBehaviour
{
    private NavMeshAgent agente;
    public GameObject pc;
    public GameObject[] waypoints = new GameObject[8];
    private int index = 0;

    private bool perseguicao = true;
    private static bool npcVulneravel = false;
    private static scriptNPC instance;

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!npcVulneravel)
        {
            agente.SetDestination(pc.transform.position);
            perseguicao = true;
        } 
        else if (perseguicao || Vector3.Distance(transform.position, agente.destination) < 1)
        {
            perseguicao = false;
            proximoDestino();
        }
    }

    private void proximoDestino()
    {
        agente.SetDestination(waypoints[index++].transform.position);
        if (index >= waypoints.Length)
            index = 0;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == pc.name)
        {
            if (npcVulneravel)
                Destroy(this.gameObject);
            else
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    public static void AtivarVulnerabilidade()
    {
        npcVulneravel = true;
        if (instance)
            instance.InvokeRepeating("DesativarVulnerabilidade", 30, 0);
    }

    private void DesativarVulnerabilidade()
    {
        npcVulneravel = false;
    }
}
