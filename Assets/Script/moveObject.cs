using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offsite;
    private float firstY;

    private void OnMouseDown()
    {
        //Debug.Log("beforeonMouseDown");
        firstY = transform.position.y;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offsite = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        //Debug.Log("afteronMouseDown");
    }

    private void OnMouseDrag()
    {
        //Debug.Log("beforeonMouseDrag");
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosisition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offsite;
        transform.position = curPosisition;
        //Debug.Log("afteronMouseDrag");
    }

    private void OnMouseUp()
    {
        //Debug.Log("beforeonMouseUp");
        transform.position = new Vector3(transform.position.x, firstY, transform.position.z);
        //Debug.Log("afteronMouseUp");
    }
}
