using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScale : MonoBehaviour {


    public float Grow;
    public float GrowTime;
    public float Shrink;
    public GameObject Self;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ScaleGrow()
    {
        Self.transform.localScale = Vector3.Lerp(Self.transform.localScale, new Vector3(Grow, Grow, Grow), Time.deltaTime * GrowTime);
        Debug.Log("HOLYSHITTHATWORKED");

    }

    public void ScaleShrink()
    {
        Self.transform.localScale = Vector3.Lerp(Self.transform.localScale, new Vector3(Shrink, Shrink, Shrink), Time.deltaTime * GrowTime);
        Debug.Log("HOLYSHITTHATWORKED");

    }
}
