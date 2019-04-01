﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

    public Camera camera;
    public NavMeshAgent agent;
    RaycastHit hit;

    Animator myAnim;
    float dist;     //distance between the hit point and the character

    Quaternion newRotation;
    float rotSpeed = 5f;    

    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
 
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);

                Vector3 relativePos = hit.point - transform.position;
                newRotation = Quaternion.LookRotation(relativePos, Vector3.up);
                newRotation.x = 0.0f;
                newRotation.z = 0.0f;

                myAnim.SetBool("isRunning", true);
            }
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotSpeed * Time.deltaTime);

        //Trigger the Run -> Idle transition if the distance between the destination point and current position is less than...
        dist = Vector3.Distance(hit.point, transform.position);
        //Debug.Log("Distance:" + dist);
        if (dist < 1f)
        {
            myAnim.SetBool("isRunning", false);
        }

    }
}
