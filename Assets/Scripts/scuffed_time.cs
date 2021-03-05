using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scuffed_time : MonoBehaviour
{
    public bool start = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(start == true){

            StartCoroutine(StartTimer());

            IEnumerator StartTimer(){
            start = false;

            yield return new WaitForSeconds(3);

            Debug.Log("Race started dummy");

            }
        }



    }

}

