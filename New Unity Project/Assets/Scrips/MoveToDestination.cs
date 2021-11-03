using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToDestination : MonoBehaviour
{
    public LayerMask hitLayers;
    Grid gridReference;
    public float movementSpeed;

    private void Awake()
    {
        gridReference = FindObjectOfType<Grid>();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Input.mousePosition;
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);
            RaycastHit hit;
            if(Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
            {
                transform.position = hit.point;
            }
        }

        //move
        if (gridReference.finalPath != null)
        {
            int maxCount = gridReference.finalPath.Count - 2;
            if (maxCount > 0)
            {
                Vector3 moveDir = gridReference.finalPath[maxCount].position - transform.position;
                transform.Translate(moveDir.normalized * Time.deltaTime * movementSpeed);
            }
        }
    }
}
