using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target; 
    // Start is called before the first frame update
    public bool enable;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enable) {
            transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
            transform.LookAt(target.parent);
        }
    }
}
