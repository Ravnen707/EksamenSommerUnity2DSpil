using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{


    public Vector3 respawnPoint1n2;
    public GameObject fallDetector1n2;
    
    public Vector3 respawnPoint2n1;
    public GameObject fallDetector2n1;

    public Vector3 respawnPoint2n3;
    public GameObject fallDetector2n3;

    public Vector3 respawnPoint2n4;
    public GameObject fallDetector2n4;

    public Vector3 respawnPoint3n2;
    public GameObject fallDetector3n2;

    public Vector3 respawnPoint4n2;
    public GameObject fallDetector4n2;

    public Vector3 respawnPoint4n5;
    public GameObject fallDetector4n5;

    public Vector3 respawnPoint4n6;
    public GameObject fallDetector4n6;

    public Vector3 respawnPoint5n4;
    public GameObject fallDetector5n4;

    public Vector3 respawnPoint6n4;
    public GameObject fallDetector6n4;

    public Vector3 respawnPoint6n7;
    public GameObject fallDetector6n7;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "FallDetector")
        {
            transform.position = respawnPoint1n2;
        }
        if (collision.tag == "FallDetector2")
        {
            transform.position = respawnPoint2n1;
        }
        if (collision.tag == "FallDetector3")
        {
            transform.position = respawnPoint2n3;
        }
        if (collision.tag == "FallDetector4")
        {
            transform.position = respawnPoint2n4;
        }
        if (collision.tag == "FallDetector5")
        {
            transform.position = respawnPoint3n2;
        }
        if (collision.tag == "FallDetector6")
        {
            transform.position = respawnPoint4n2;
        }
        if (collision.tag == "FallDetector7")
        {
            transform.position = respawnPoint4n5;
        }
        if (collision.tag == "FallDetector8")
        {
            transform.position = respawnPoint4n6;
        }
        if (collision.tag == "FallDetector9")
        {
            transform.position = respawnPoint5n4;
        }
        if (collision.tag == "FallDetector10")
        {
            transform.position = respawnPoint6n4;
        }
        if (collision.tag == "FallDetector11")
        {
            transform.position = respawnPoint6n7;
        }
    }


 }

