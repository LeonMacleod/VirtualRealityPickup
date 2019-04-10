using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceStart : MonoBehaviour
{

    public Rigidbody thisRigidbody; 

    // Start is called before the first frame update
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
        // adding a small force as a still object has trouble detecting initial collision unless a force is present (workaround)
        thisRigidbody.AddForce(new Vector3(1f,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
