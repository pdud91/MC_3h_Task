using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // add Enemy list Enemies can subscribe to
    // on Update take Player's position and move each Enemy on the list away from the Player
    static EnemyManager instance;
    public static EnemyManager GetInstance => instance;

    static List<Enemy> enemies = new List<Enemy>();
    static Transform playerTransform;

    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        instance = this;

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public static void Subscribe(Enemy enemy)
    {
        if (instance == null)
        {
            Debug.LogError("EnemyManager instance is null!");
        }

        if (enemies.Contains(enemy))
            return;

        enemies.Add(enemy);
    }

    public static void Unsubscribe(Enemy enemy)
    {
        if (instance == null)
        {
            Debug.LogError("EnemyManager instance is null!");
        }

        if (enemies.Contains(enemy))
            enemies.Remove(enemy);
    }

    private void FixedUpdate()
    {
        MoveEnemies();
    }

    private void MoveEnemies()
    {
        Vector2 playerPosition = playerTransform.position;
        foreach (Enemy enemy in enemies)
        {
            MoveEnemyAwayFromPlayer(enemy, playerPosition);
        }
    }

    void MoveEnemyAwayFromPlayer(Enemy enemy, Vector2 playerPosition)
    {
        Vector2 enemyPosition = enemy.transform.position;
        Vector2 moveDir = (enemyPosition - playerPosition).normalized;
        enemy.MoveTowards(moveDir);
    }
}
