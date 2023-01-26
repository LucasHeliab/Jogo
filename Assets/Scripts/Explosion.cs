using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{   
    public int damage = 3;

    private void OnTriggerEnter2D(Collider2D other){
        Enemy otherEnemy = other.GetComponent<Enemy>();
        if(otherEnemy != null){
            otherEnemy.TookDamage(damage);
        }
    }
}
