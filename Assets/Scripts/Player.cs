using System;
using UnityEngine;
using System.Collections.Generic;

public class Player : Actor
{
    [SerializeField] ContactFilter2D contactFilter2D;

    Vector2 moveDir;    

    private void Update()
    {
        // read input
        ReadInput();        
    }

    private void ReadInput()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        moveDir = new Vector2(inputVertical, inputHorizontal).normalized;
    }

    // move Actor based on input
    public void FixedUpdate()
    {
        MoveTowards(moveDir);
        TouchEnemy();
    }

    private void TouchEnemy()
    {
        List<Collider2D> collidersHit = new List<Collider2D>();
        // detect if touching an enemy, then immobilize them
        if (myCollider.Overlap(contactFilter2D, collidersHit) >0)
        {
            foreach (Collider2D col in collidersHit)
            {
                if (col.TryGetComponent<Enemy>(out var enemyScript))
                {
                    enemyScript.PlayerTouched();
                }
            }
        }
    }
}
