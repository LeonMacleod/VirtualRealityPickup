using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JointManager : MonoBehaviour
{

    public FixedJoint joint;
    public GameObject rigidCube;

    public TextMeshPro canCatchText;

    public bool isRightHandHoldingObject;
    public bool canCatch;
    public bool onCollisionWay;


    // Start is called before the first frame update
    void Start()
    {
        canCatch = true;
        isRightHandHoldingObject = false;



        
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject == rigidCube && canCatch == true && onCollisionWay == true)
        {
            //getting all joints on the rigidcube
            FixedJoint[] joints = rigidCube.GetComponents<FixedJoint>();

            //ensuring the rigidcube is only being held by one hand at a time (frame problems can cause this to happen with multiple collisions occuring at the exact same time etc)
            if (joints.Length > 1)
            {
                foreach (FixedJoint fx in joints)
                {
                    Destroy(fx);
                }
            }
            else
            {
                Destroy(rigidCube.GetComponent<FixedJoint>());
            }


            FixedJoint fixedJointToCreate = rigidCube.AddComponent<FixedJoint>();
            fixedJointToCreate.connectedBody = this.gameObject.GetComponent<Rigidbody>();

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
        if (Input.GetButtonDown("RightTriggerPress"))
        {
            if (canCatch == false)
            {
                canCatch = true;
  

            }
            else if (canCatch == true)
            {
                FixedJoint[] joints = rigidCube.GetComponents<FixedJoint>();
                foreach (FixedJoint joint in joints)
                {
                    Destroy(joint);

                }


                canCatch = false;



            }



            //Debug.Log("pressed");
            //rigidCube.GetComponent<FixedJoint>().connectedBody = null;
        }

        canCatchText.text = "Catch mode :" + canCatch.ToString();
    }
}
