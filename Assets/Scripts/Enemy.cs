using System.Linq.Expressions;
using UnityEngine;

public class Enemy : Actor
{
    bool canMove = true;
    public bool CanMove => canMove;

    private void OnEnable()
    {
        EnemyManager.Subscribe(this);
    }

    private void OnDisable()
    {
        EnemyManager.Unsubscribe(this);
    }

    public void PlayerTouched()
    {
        if (canMove)
            SetCanMove(false);
    }

    void SetCanMove(bool flag)
    {
        canMove = flag;
    }
}
