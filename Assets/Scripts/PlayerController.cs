using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;
    public swordAttack Attack;
    Vector2 movementInput;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;
    Animator animator;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    bool canMove = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {   
        if(canMove){
            if(movementInput != Vector2.zero)
            {
            bool success = TryMove(movementInput);
            if(!success && movementInput.x > 0){
                success = TryMove(new Vector2(movementInput.x, 0));

                    if(!success && movementInput.y > 0){
                    success = TryMove(new Vector2(movementInput.y, 0));
                    }
            }

            animator.SetBool("isMoving", success);
            } else {
                animator.SetBool("isMoving", false);
            }
            if(movementInput.x < 0){
                spriteRenderer.flipX = true;
             
             }
            if(movementInput.x > 0){
                spriteRenderer.flipX = false;
            
            }    
            }
    }

    private bool TryMove(Vector2 direction){
     if(direction != Vector2.zero){
                
         int count = rb.Cast(
                movementInput,
                movementFilter,
                castCollisions,
                moveSpeed * Time.fixedDeltaTime + collisionOffset);

            if(count == 0){
                rb.MovePosition(rb.position + movementInput * moveSpeed * Time.fixedDeltaTime ); 
                return true;
            }else{ return false; }
            }else{ return false; }
}

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }

    void OnFire(){
        animator.SetTrigger("SpecAttack");
    }

    public void Swing(){
        lockMovement();
        if(spriteRenderer.flipX == true){
            Attack.AttackLeft();
        }else{
            Attack.AttackRight();
        }
    }
    
    public void lockMovement(){
        canMove = false;
    }
    public void unlockMovement(){
        canMove = true;
    }
}
