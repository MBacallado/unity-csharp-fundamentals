using UnityEngine;

public class Container : MonoBehaviour
{
    [SerializeField] private Sprite image;
    [SerializeField] private string material;
    [SerializeField] private int size;
    [SerializeField] private float scale;

    private bool closed;
    private int content;

    //Constructor
    public Container(string material, int size)
    {
        if (size < 0)
        {
            this.size = 250;
        }
        else
        {
            this.size = size;
        }

        content = this.size;
        this.material = material;
        closed = true;
    }

    public void State()
    {
        Debug.Log("MATERIAL: + " + material + " | SIZE: " + size);
    }

    public void Open()
    {
        if (closed)
        {
            closed = false;
            Debug.Log("The container is already open.");
        }
        else
        {
            Debug.Log("The container is already open. Pay attention next time.");
            //emit an wrong sound
        }
    }

    public void Close()
    {
        if (closed)
        {
            Debug.Log("The container is already closed. Pay attention next time.");
            //emit an wrong sound
        }
        else
        {
            closed = true;
            Debug.Log("The container is already closed.");
        }
    }

    public void Use()
    {
        if (!closed && content > 0)
        {
            Debug.Log("BEFORE CONTENT: " + content);
            content--;
            Debug.Log("AFTER CONTENT: " + content);
        }
        else
        {
            Debug.Log("The container is either closed or empty.");
        }
    }
}
