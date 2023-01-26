using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    public GameObject explosion;
    
    private void OnTriggerEnter2D(Collider2D other){
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
