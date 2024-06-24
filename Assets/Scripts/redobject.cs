using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redobject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    int frame_counter;

    // Update is called once per frame
    void Update()
    {
        
        if(frame_counter==0){
            var position = new Vector3(Random.Range(3.0f, 12.0f), Random.Range(1.0f, 5.0f), 0);
            Instantiate(prefab,position ,Quaternion.identity);
            }
            frame_counter++;
            if(frame_counter==200){
                frame_counter=0;
            }

    }
}
