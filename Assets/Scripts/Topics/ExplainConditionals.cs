using UnityEngine;

public class ExplainConditionals : MonoBehaviour
{

    void Start()
    {
        string name = "Avengers";

        ExplainConditionalsIfElse(name);
        ExplainConditionalsSwitchCase(name);
    }

    private void ExplainConditionalsIfElse(string name)
    {
        ExplainConditionalsIfElseStrings(name);
        ExplainConditionalsIfElseEnemyLife();
    }

    private void ExplainConditionalsIfElseStrings(string value)
    {
        if (value == "avengers") // Si Avengers == avengers
        {
            Debug.Log("Marvel");
        }
        else if (value == "justiceleague") // Si Avengers == justiceleague
        {
            Debug.Log("DC");
        }
        else
        {
            Debug.Log("¿?");
        }
    }

    private void ExplainConditionalsIfElseEnemyLife()
    {
        int enemyLife = 100;
        int damage = 10;
        enemyLife -= damage;
        Debug.Log("RESULT: " + (enemyLife >= 90));

        if (enemyLife > 70)
        {
            Debug.Log("First phase");
        }
        else if (enemyLife > 40)
        {
            Debug.Log("Second phase");
        }
        else
        {
            Debug.Log("Third phase");
        }
    }

    private void ExplainConditionalsSwitchCase(string name)
    {
        ExplainConditionalsSwitchCaseString(name);
        ExplainConditionalsSwitchCaseInventory();
    }

    private void ExplainConditionalsSwitchCaseString(string name)
    {
        switch (name)
        {
            case "Avengers":
                Debug.Log("Marvel");
                break;
            case "justiceleague":
                Debug.Log("DC");
                break;
            default:
                Debug.Log("¿?");
                break;
        }
    }

    private void ExplainConditionalsSwitchCaseInventory()
    {
        string item = "Potion";
        int size = 5;
        switch (item)
        {
            case "Potion":
                size++;
                break;
            case "Granade":
                Debug.Log("Attack");
                break;
        }
    }
}
