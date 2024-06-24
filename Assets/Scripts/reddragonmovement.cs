using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reddragonmovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Color newColor = Color.black;   
    public float forceMagnitude = 5.0f;
    private Rigidbody2D rb;
    


    void Start()
    {        
        Destroy(gameObject,5.0f);
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;   
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.02f,0,0);       
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "fireball"){
            Scorescript.scorevalue ++;
            rb.bodyType=RigidbodyType2D.Dynamic;
            rb.gravityScale = 1f;
            rb.AddForce(Vector2.down * 100f ,ForceMode2D.Impulse);
            Destroy(gameObject, 0.3f);
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "reddragon" || other.gameObject.tag =="stump" ){
            return;
        }
        
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = newColor;
        
        // Vector3 force = -transform.up * forceMagnitude;
        // rb.AddForce(force, ForceMode.Force);
        while (gameObject.transform.position.y >= -3)
            {
                gameObject.transform.position += Vector3.down * 0.002f;
            }
   

        
    }
}
