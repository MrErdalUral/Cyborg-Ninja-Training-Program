using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform ChaseTarget;
    public float ChaseSpeed = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(ChaseTarget == null) return;
	    var moveVector = (ChaseTarget.position - transform.position).normalized;
	    moveVector.z = 0;
	    transform.position += moveVector * ChaseSpeed;
	}
}
