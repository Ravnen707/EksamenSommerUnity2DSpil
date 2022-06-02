using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * moveSpeed;

        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

    }

    void Jump(){
        if (Input.GetButtonDown("Jump") && isGrounded == true) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);

        }
    
        }

}
