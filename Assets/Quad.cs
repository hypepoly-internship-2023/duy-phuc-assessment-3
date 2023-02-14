using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad : MonoBehaviour
{
    private Vector3 pressPoint;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            pressPoint = Input.mousePosition;
        }
    }

    private void OnMouseDrag()
    {
        Vector3 targetDis = Input.mousePosition - pressPoint;
        float angle = Vector3.SignedAngle(pressPoint, targetDis, Vector3.forward);
        transform.eulerAngles = new Vector3(0,0,angle);
    }
}
