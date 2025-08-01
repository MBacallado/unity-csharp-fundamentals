using UnityEngine;

public class Sample : MonoBehaviour
{ 
    void Start()
    {
        ExplainVariables();
    }

    private void ExplainVariables()
    {
        int cash = 0;
        string name = "Avengers";
        bool activated = false;

        cash = cash * 100;
        cash *= 100;

        Debug.Log("NAME:" + name);
        Debug.Log("ACTIVATED: " + activated);

        Debug.Log("CASH: " + ++cash);
        Debug.Log("CASH: " + cash);
    }
}