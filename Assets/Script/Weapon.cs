using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	
	// Update is called once per frame
	void Update ()
	{
	    ControlRotation();

	}
    protected void ControlRotation()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var lookingVector = mousePosition - transform.position;
        var angle = Mathf.Atan2(lookingVector.y, lookingVector.x) * Mathf.Rad2Deg;
        transform.localRotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public bool SwitchDirection { get; set; }
}
