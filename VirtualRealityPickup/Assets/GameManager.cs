using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject floor;

    public TextMeshPro levelText;

    public static bool isRightHandHoldingObject;

    public void instantiateLevel(string name, Material color, float gravity)
    {

        levelText.text = name;
        floor.GetComponent<Material>();





    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        




        
    }
}
