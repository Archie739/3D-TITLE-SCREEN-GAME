using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class WorldInteraction : MonoBehaviour
{

    [SerializeField]
    public NavMeshAgent playerAgent;

    void start()
    {
        playerAgent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            GetInteraction();
        }

    }
    void GetInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;

        if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
        {
            GameObject interactedObjects = interactionInfo.collider.gameObject;
            if (interactedObjects.tag == "Interactable Objet")
            {
                interactedObjects.GetComponent<Interactable>().MoveToInteration(playerAgent);
                Debug.Log("GetComponent");
            }
            else
            {
                playerAgent.destination = interactionInfo.point;
                Debug.Log("point");
            }
        }
    }
}

