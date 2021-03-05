using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_behavior : MonoBehaviour
{
    SpriteRenderer myRenderer;
    public Color floorColor;
    public Color gateColor;

    Rigidbody2D myBody;

    public float power;

    public bool disableInput = false;


    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        //gameObject is a reference to the object this script is on
        myBody = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(disableInput == false){
            if(Input.GetKeyDown(KeyCode.Space)){
                myBody.AddForce(new Vector3(1, 1, 0) * power);
            disableInput = true;
            //GameObject.FindWithTag("GameManager").GetComponent<scuffed_time>().start = true;
            
        }
            
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Floor"){
            myRenderer.color = floorColor;
            Debug.Log("Hit Floor");
            
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        //trigger doesnt have anything to do with physics. just matters if its touching
        if(other.gameObject.name == "Gate"){
            myRenderer.color = gateColor;
        }
    }
}
