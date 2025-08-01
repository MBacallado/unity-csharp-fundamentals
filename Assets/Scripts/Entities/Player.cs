using UnityEngine;

public class Player : Entity
{
    private bool invencible;

    public override void Defense()
    {
        shield += 10;
    }

    public void RestoreHealth(int health)
    {
        this.health += health;
        //Remember to check if the life is greater than the total, equalise it to the total.
    }
}
