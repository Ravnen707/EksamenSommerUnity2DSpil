using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeaths : MonoBehaviour
{


    public Vector3 respawnPoint;
    public GameObject deathGround;


    // Start is called before the first frame update
    void Start()
    {
          respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        deathGround.transform.position = new Vector2(transform.position.x, deathGround.transform.position.y);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DeathGround")
        {
            transform.position = respawnPoint;
        }

    }
}
