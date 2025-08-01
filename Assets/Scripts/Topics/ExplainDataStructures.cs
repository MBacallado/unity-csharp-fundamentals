using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplainDataStructures : MonoBehaviour
{
    void Start()
    {
        ExplainList();
        ExplainStack();
        ExplainQueue();
    }

    private void ExplainList()
    {
        //1) Basic operation of a list.
        List<string> names = new List<string>();

        names.Add("Res");
        names.Add("Sar");
        names.Add("Cam");
        names.Add("Gabr");

        Debug.Log(names.Count);

        names.RemoveAt(2);

        Debug.Log(names.Count);

        names.Insert(1, "Joe");

        Debug.Log(names.Contains("Mel"));

        foreach(string name1 in names)
        {
            Debug.Log(name1);
        }

        //2) Create a battery of enemies and perform a wave action.
        Enemy em1 = new Enemy();
        Enemy em2 = new Enemy();
        Enemy em3 = new Enemy();

        List<Enemy> enemies = new List<Enemy>();
        enemies.Add(em1);
        enemies.Add (em2);
        enemies.Add(em3);

        foreach (Enemy enemy in enemies)
        {
            enemy.Attack();
        }
    }

    private void ExplainStack()
    {
        Stack names = new Stack();
        names.Push("Natasha Romanov");
        names.Push("Steve Rogers");
        names.Push("Matt Murdock");

        foreach (string name in names)
        {
            Debug.Log(name);
        }
    }

    private void ExplainQueue()
    {
        Queue names = new Queue();
        names.Enqueue("Natasha Romanov");
        names.Enqueue("Steve Rogers");
        names.Enqueue("Matt Murdock");

        foreach (string name in names)
        {
            Debug.Log(name);
        }
    }
}
