using UnityEngine;

public class ExplainClasses : MonoBehaviour
{
    void Start()
    {
        ExplainCreateClass();
        ExplainInheritance();
    }

    private void ExplainCreateClass()
    {
        Container small = new Container("Plastic", -9999);

        small.State();

        small.Close();
        small.Open();
        small.Open();
        small.Use();
    }

    private void ExplainInheritance()
    {
        Player player = new Player();
        player.Attack();
        player.RestoreHealth(50);

        Enemy enemy = new Enemy();
        enemy.Defense();
        enemy.Suicide();
    }
}
