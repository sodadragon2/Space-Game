using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float Damage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyScript enemy = collision.GetComponent<EnemyScript>();
        if(enemy != null)
        {
            enemy.TakeDamage(Damage);
        }
    }
}
