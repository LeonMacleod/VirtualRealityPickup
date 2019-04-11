using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointManager : MonoBehaviour
{

    public FixedJoint joint;
    public GameObject rigidCube;

    public GameObject RHand;
    public GameObject LHand;




    // Start is called before the first frame update
    void Start()
    {


        
    }


    private void OnCollisionEnter(Collision collision)
    {


        bool isRightHolding = GameManager.isRightHandHoldingObject;
        string name = collision.gameObject.name;

        if (collision.gameObject == rigidCube && GameManager.canCatch == true)
        {

            rigidCube.GetComponent<FixedJoint>().connectedBody = this.gameObject.GetComponent<Rigidbody>();
            Debug.Log("Contact");

            //joint.connectedBody = rigidCube.GetComponent<Rigidbody>();

    
        }


        // CURRENT PROBLEM

        // IF YOU TRY pick the object in the right hand up using your left hand it may not work because the left hand joint still exists
        // therefore the left hands joint must be cleared before it trys to take the object on the right hand and on this collision the right hand joint must be cleared.



    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        bool isRightHolding = GameManager.isRightHandHoldingObject;
        string name = collision.gameObject.name;

        if (collision.gameObject == rigidCube)
        {
            //right hand is holding and left hand wants to take the object
            if(isRightHolding == true && name == "LHand")
            {
                joint.connectedBody = rigidCube.
            }



            Debug.Log("Contact");

            joint.connectedBody = rigidCube.GetComponent<Rigidbody>();

            
            if(this.gameObject.name == "RHand")
            {
                GameManager.isRightHandHoldingObject = true;
            }
            if(this.gameObject.name == "LHand")
            {
                GameManager.isRightHandHoldingObject = false;
            }

            
        }
    }
    */
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("RightMiddleFingerPress")) 
        {
            //Debug.Log("pressed");
            rigidCube.GetComponent<FixedJoint>().connectedBody = null;
        }
        

    }
}
