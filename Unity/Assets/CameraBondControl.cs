using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBondControl : MonoBehaviour
{
    public GameObject head;
    public GameObject dodecahedron;
    public float distance;
    public bool attached = false;

    // detach from nematode
    void Detach()
    {
        this.GetComponent<FollowCamera>().enabled = false;
        this.GetComponent<FPSController>().enabled = true;

        head.GetComponent<BigBoid>().playerSteeringEnabled = false;
    }

    void Attach()
    {
        this.GetComponent<FollowCamera>().enabled = true;
        this.GetComponent<FPSController>().enabled = false;

        head.GetComponent<BigBoid>().playerSteeringEnabled = true;
        dodecahedron.GetComponent<dodecamaterial>();
        attached = true;
    }

    // attach to nematode on collision
    void OnCollisionEnter(Collision collision)
    {
        Attach();
        Debug.Log("collided");
    }

    void OnCollisionExit(Collision collision)
    {

    }

    void OnCollisionStay(Collision collision)
    {

    }

    void OnTriggerEnter(Collider c)
    {
        Debug.Log("collided trigger");
    }

    void OnTriggerExit()
    {
    }

    void OnTriggerStay()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<FollowCamera>().enabled = false;
        this.GetComponent<FPSController>().enabled = true;
        head.GetComponent<BigBoid>().playerSteeringEnabled = false;
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
        if (Input.GetKey(KeyCode.X))
        {
            Attach();
            Debug.Log("pressed X");
        }

        if (attached == true)
        {
        }
    }
}
