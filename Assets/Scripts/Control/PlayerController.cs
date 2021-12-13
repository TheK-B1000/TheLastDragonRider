using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform target;
    Ray lastRay;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MoveToCursor();
        }
    }

    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);
        if (hasHit)
        {
            MoveTo(hit.point);
        }
    }

    public void MoveTo(Vector3 destination)
    {
        GetComponent<Mover>().MoveTo(destination);
    }
}
