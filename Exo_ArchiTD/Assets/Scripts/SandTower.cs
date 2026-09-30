using UnityEngine;

public class SandTower : TickingBuilding
{
    private int damage;
    private Collider2D enemyDetectionZone;

    private void Shoot(Enemy enemy)
    {
        // faire en sorte que les PV de l'ennemi descende 
        enemy.Entity
    }

    private void OnTriggerEnter2D()
    {
        // detecte l'ennemie qui rentre dans l'enemy detection Zone
    }
}
