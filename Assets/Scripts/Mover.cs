﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;

    // Update is called once per frame
    void Update()
    {
        //Raycast from camera to left mouse-click location
        if (Input.GetMouseButtonDown(1))
        {
            MoveToCursor();
        }
    }
    //implement click to move on left click
    private void MoveToCursor()
    {
        //create variable parameters for Raycast()
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // https://docs.unity3d.com/ScriptReference/RaycastHit.html
        RaycastHit hit;
        //when hasHit is true, store position of raycast in (out) hit.
        bool hasHit = Physics.Raycast(ray, out hit);
        if (hasHit)
        {
            //https://docs.unity3d.com/ScriptReference/RaycastHit-point.html
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
    }
}
