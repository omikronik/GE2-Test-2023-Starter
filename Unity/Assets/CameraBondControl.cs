using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBondControl : MonoBehaviour
{
    public GameObject dodecahedron;
    public float distance;
    public bool attached = false;

    // detach from nematode
    void Detach()
    {
        this.GetComponent<FollowCamera>().enabled = false;
        this.GetComponent<FPSController>().enabled = true;
    }

    // attach to nematode
    void OnCollisionEnter(Collision collision)
    {
        this.GetComponent<FollowCamera>().enabled = true;
        this.GetComponent<FPSController>().enabled = false;
        attached = true;
        Debug.Log("collided");
    }

    void OnCollisionExit(Collision collision)
    {
    
    }

    void OnCollisionStay(Collision collision)
    {
    
    }
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<FollowCamera>().enabled = false;
        this.GetComponent<FPSController>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(dodecahedron.transform.position, this.transform.position);
        if (Input.GetKey(KeyCode.Z))
        {
            Detach();
            Debug.Log("pressed Z");
        }

        if (attached == true)
        {
            transform.rotation = dodecahedron.transform.rotation;
        }
    }
}
