using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stumpmovement : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startposition;
    void Start(){
        startposition=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.01f,0,0);

        if(transform.position.x < -12){
            transform.position = startposition;
        }
    }
    }
