using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SciFiPlanetPointer : MonoBehaviour
{

    public ClickOnObject newObject; 

    private GameObject myOwnPointer;

    private Vector3 firstLine = new Vector3(-125,100,-300);
    private LineRenderer myLine;
    public GameObject middle; 
    public GameObject thePlace;

    private Vector3 negativeVec;

    private Vector3 sideVec3;
    private Vector3 negativesideVec3;




    // Start is called before the first frame update
    void Start()
    {
            newObject = GameObject.FindGameObjectWithTag("Manager").gameObject.GetComponent<ClickOnObject>();
            middle = GameObject.FindGameObjectWithTag("Middle").gameObject;
            thePlace = gameObject; //this game obehct
        



        myLine = gameObject.GetComponent<LineRenderer>();
        myLine.widthMultiplier = 1.7f;
        myLine.positionCount = 3;

        negativeVec = new Vector3(125, 100, -300);


        sideVec3 = new Vector3(-375, 100, -300);
        negativesideVec3 = new Vector3(375, 100, -300);
    }

    // Update is called once per frame
    void Update()
    {



        //myOwnPointer = newObject.currentObject;
        if(myOwnPointer != null) 
        {
            if (myOwnPointer.transform.position.x > middle.transform.position.x)
            {
               
                myLine.SetPosition(0, myOwnPointer.transform.position);
                myLine.SetPosition(1, negativeVec);
                myLine.SetPosition(2, negativesideVec3);
                
               
              
            }
            else
            {
               

                
                myLine.SetPosition(0, myOwnPointer.transform.position);
                myLine.SetPosition(1, firstLine);
                myLine.SetPosition(2, sideVec3);
                
            }


            if (myOwnPointer.transform.position.z > middle.transform.position.x)
            {

                myOwnPointer = null;
                myLine.SetPosition(0, middle.transform.position);
                myLine.SetPosition(1, middle.transform.position);
                myLine.SetPosition(2, middle.transform.position);

            }
            else
            {

              
            }
        }
        

        if (newObject.currentObject == null || newObject.currentObject.gameObject.tag == "Moon")
        {

        }
        else 
        {
            myOwnPointer = newObject.currentObject;
        }

        
            
        

             


    }
}
