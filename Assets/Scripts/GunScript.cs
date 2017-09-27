using UnityEngine.Events;
using UnityEngine;

public class GunScript : MonoBehaviour {

   
    public float range = 1f;
    public UnityEvent grow;
    public UnityEvent shrink;
    public Camera fpsCam;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1"))
        {
            
            ShootGrow();
            grow.Invoke();

        }

        if (Input.GetButton("Fire2"))
        {

            ShootShrink();
            shrink.Invoke();

        }
    }


    void ShootGrow()
    {
        RaycastHit hit;



        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range) && hit.collider.gameObject.tag == "ScaleObject")
        {
            hit.collider.gameObject.GetComponent<TargetScale>().ScaleGrow();
            Debug.Log(hit.transform.name);

        }

    
        else
        {
            Debug.Log("Not Hit Skybox");

        }


    }

    void ShootShrink()
    {
        RaycastHit hit2;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit2, range) && hit2.collider.gameObject.tag == "ScaleObject")
        {
            hit2.collider.gameObject.GetComponent<TargetScale>().ScaleShrink();
            Debug.Log(hit2.transform.name);

        }
       

        else
        {
            Debug.Log("Not Hit Skybox");

        }



    }
}
