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
    
    private virtual void TakeDamage(int damage)
    {
        HP -= damage;
    }
    
    private virtual void healDamage(int damage)
    {
        HP += damage;
    }

    private virtual void Die()
    {
        
    }
}
