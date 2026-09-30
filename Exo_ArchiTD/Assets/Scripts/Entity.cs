using UnityEngine;
using UnityEngine.UI;

public abstract class Entity : MonoBehaviour
{
    private int HP;
    private string name;
    private Image sprite;
    private Image uiImage;
    Collider2D collider;
    Rigidbody2D rb;
    
    protected virtual void TakeDamage(int damage)
    {
        HP -= damage;
    }
    
    protected virtual void healDamage(int damage)
    {
        HP += damage;
    }

    protected virtual void Die()
    {
        
    }
}