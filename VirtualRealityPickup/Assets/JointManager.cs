using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointManager : MonoBehaviour
{

    public FixedJoint joint;
    public GameObject rigidCube;


    // Start is called before the first frame update
    void Start()
    {


        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == rigidCube)
        {
            Debug.Log("Contact");

            joint.connectedBody = rigidCube.GetComponent<Rigidbody>();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
