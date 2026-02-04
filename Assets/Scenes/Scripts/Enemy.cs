using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    [SerializeField] private Transform jugador;
    [SerializeField] private NavMeshAgent agente;





    private void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }


    private void Update()
    {
        agente.SetDestination(jugador.position);
    }


}
