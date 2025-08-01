using UnityEngine;

public class Enemy : Entity
{
    public void Suicide()
    {
        Destroy(gameObject);
        //When the enemy touches the player, it explodes and deals as much damage as its attack.
    }
}
