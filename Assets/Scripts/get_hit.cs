using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_hit : MonoBehaviour
{

    GameObject cam;
    camera_follow camScript;

    public Transform nextObj;
    bool alreadyFollowed = false;


    /*Camera mainCam;
    GameObject cameraObject;
    public bool activeObject = false;
    */

    // Start is called before the first frame update
    void Start()
    {
        //cameraObject = GameObject.Find("Main Camera");
        //mainCam = cameraObject.GetComponent<Camera>();

        cam = GameObject.Find("Main Camera");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter2D(Collision2D other)
    {
        /*if(activeObject == true)
        {
            if(other.gameObject.tag != "Floor")
            {
                //GameObject variable class
                //gameObject anything that the script is attached to
                Transform followThis = other.gameObject.transform;
                mainCam.GetComponent<camera_follow>().followTransform = followThis;

                other.gameObject.GetComponent<get_hit>().activeObject = true;
                //activeObject = false;

                Debug.Log(other.gameObject.GetComponent<get_hit>().activeObject);

            }

        }
        */

        if(other.gameObject.tag == "hitThing" && !alreadyFollowed)
        {
            camScript = (camera_follow)cam.GetComponent(typeof(camera_follow));
            camScript.followTransform = nextObj;
            alreadyFollowed = true;

        }


        
            
    }
    








}

