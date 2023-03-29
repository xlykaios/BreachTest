using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordAttack : MonoBehaviour
{   


    
    Vector2 attackOffset;
    Collider2D swordCollider;


    public void Start(){
        swordCollider = GetComponent<Collider2D>();
        attackOffset = transform.position;
    }

    
    public void AttackRight(){
        print("AttackRight");
        swordCollider.enabled = true;

        transform.position = attackOffset;
    }
    public void AttackLeft(){
        swordCollider.enabled = true;
        transform.position = new Vector3(attackOffset.x * -1, attackOffset.y);
    }
    public void StopAttack(){
        swordCollider.enabled = false;
    }
}
