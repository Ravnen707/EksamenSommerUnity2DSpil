using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmg : MonoBehaviour
{
    public float hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().hp -= hit;
        }
    }
}
