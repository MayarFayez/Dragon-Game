using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bluedragonmovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    // Update is called once per frame
    void Update()
    {
      hadleinput(); 
    }
    private void OnCollisionEnter2D(Collision2D other) {
      if(other.gameObject.tag=="fireball"){
         return;
      }
       
        Destroy(gameObject);
        SceneManager.LoadScene(0);
    }

    void hadleinput(){
        if(Input.GetKey(KeyCode.RightArrow)){
        transform.Translate(0.02f,0,0);
     }   
     if(Input.GetKey(KeyCode.LeftArrow)){
        transform.Translate(-0.02f,0,0);
     }  
     if(Input.GetKey(KeyCode.UpArrow)){
        transform.Translate(0,0.02f,0);
     }  
     if(Input.GetKey(KeyCode.DownArrow)){
        transform.Translate(0,-0.02f,0);
     }
      if(Input.GetKeyDown(KeyCode.Space)){
        Instantiate(prefab,transform.position,Quaternion.identity);  
     }

    }
}
