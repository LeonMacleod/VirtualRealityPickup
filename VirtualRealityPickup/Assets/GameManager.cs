using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject floor;

    public TextMeshPro levelText;

    public TextMeshPro canCatchText;

    public static bool canCatch;

    public static bool isRightHandHoldingObject;

    public GameObject RHand;



    public GameObject rigidCube;

    public void instantiateLevel(string name, Material color, float gravity)
    {

        levelText.text = name;
        floor.GetComponent<Material>();

        canCatchText.text = "Catch mode :" + canCatch.ToString();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("RightTriggerPress"))
        {
            if (canCatch == false)
            {
                canCatch = true;
                FixedJoint rfx = rigidCube.AddComponent<FixedJoint>();
                rfx.connectedBody = RHand.GetComponent<Rigidbody>();

            }
            else if (canCatch == true)
            {
                canCatch = false;
                Destroy(rigidCube.GetComponent<FixedJoint>());
            }



            //Debug.Log("pressed");
            //rigidCube.GetComponent<FixedJoint>().connectedBody = null;
        }

        canCatchText.text = "Catch mode :" + canCatch.ToString();



    }
}
