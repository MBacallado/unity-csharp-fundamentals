using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] protected int attack;
    [SerializeField] protected int health;
    [SerializeField] protected int shield;

    public void Attack()
    {

    }

    public virtual void Defense()
    {
        shield += 5;
    }
}
