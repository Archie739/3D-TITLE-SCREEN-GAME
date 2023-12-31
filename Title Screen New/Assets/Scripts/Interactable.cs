using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour { 
    public NavMeshAgent playerAgent;
    public virtual void MoveToInteration(NavMeshAgent playerAgent)
    {
        this.playerAgent = playerAgent;
        playerAgent.stoppingDistance = 2f;
        playerAgent.destination = this.transform.position;

        Interact();
    }
    public virtual void Interact()
    {
        Debug.Log("Interacting with base class.");
    }
}
