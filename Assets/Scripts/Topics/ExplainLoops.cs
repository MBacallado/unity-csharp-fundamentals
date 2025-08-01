using UnityEngine;

public class ExplainLoops : MonoBehaviour
{
    void Start()
    {
        ExplainWhile();
        ExplainDoWhile();
        ExplainFor();
    }

    private void ExplainWhile()
    {
        Debug.Log("While Loop");
        int num = 0;
        while (num <= 100)
        {
            Debug.Log("Num: " + num);
            num++;
        }
    }

    private void ExplainDoWhile()
    {
        Debug.Log("Do While Loop");
        int num = 1;
        do
        {
            num++;
            Debug.Log("Num:" + num);
        }
        while (num < 100);
    }

    private void ExplainFor()
    {
        //Par (% == 0) / Impar (% == 1)
        Debug.Log("For Loop");
        for (int num = 1; num <= 100; num++)
        {
            if (num%2 == 1)
            {
                Debug.Log("Num: " + num);
            }
        }
    }
}
