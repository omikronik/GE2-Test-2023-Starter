using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBondControl : MonoBehaviour
{
    public GameObject dodecahedron;
    public float distance;
    public bool attached = false;

    public FollowCamera fc;
    // detach from nematode
    void Detach()
    {
        attached = false;
        fc.enable = false;
    }

    // attach to nematode
    void attach()
    {
        attached = true;
        fc.enable = true;

    }

    // Start is called before the first frame update
    void Start()
    {
        fc = GetComponent<FollowCamera>();        
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
        if (distance > 2.0f && attached == false)
        {
            attach();
        }

    }
}
