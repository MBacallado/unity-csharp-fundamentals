using UnityEngine;

public class ExplainArrays : MonoBehaviour
{
    private string[] names;
    private string[] dni;
    private int[] ages;
    private string[] certificates;

    private char[,] chess;

    void Start()
    {
        //Arrays
        names = new string[13]; // -> [N_1][N_2][][][][][][][][][][][]
        dni = new string[13]; // -> [DNI_1][DNI_2][][][][][][][][][][][]
        ages = new int[13]; // -> [A_1][A_2][][][][][][][][][][][]
        certificates = new string[13]; // -> [C_1][C_2][][][][][][][][][][][]

        AddAgesRandom();
        ShowValuesAscendingOrder();
        Debug.Log("-----------------------------------------------");
        ShowValuesDescendingOrder();

        Debug.Log("-----------------------------------------------");
        ExpandArrayFromAnother();

        Chess();
    }

    private void AddAgesRandom()
    {
        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = Random.Range(0, 151);
        }
    }

    private void ShowValuesAscendingOrder()
    {
        //Remember that any array can be used, as they are all the same size.
        for (int i = 0; i < names.Length; i++)
        {
            Debug.Log("POSITION: " + (i + 1) + " | NAME: " + names[i] + " | DNI: " + dni[i] + " | AGE: " + ages[i] + " | CERT: " + certificates[i]);
        }
    }

    private void ShowValuesDescendingOrder()
    {
        //Remember that any array can be used, as they are all the same size.
        for (int i = names.Length-1; i >= 0; i--)
        {
            Debug.Log("POSITION: " + (i+1) + " | NAME: " + names[i] + " | DNI: " + dni[i] + " | AGE: " + ages[i] + " | CERT: " + certificates[i]);
        }
    }

    private void ExpandArrayFromAnother()
    {
        /*
        [][][][][][][][][][][][][]
        0 1 2 3 4 5 6 7 8 9 10 11 12*/

        int[] numbers = new int[10]; //-> [5][3][24]...[50]  -> 10 elementos

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Range(1, 151);
        }

        int[] newNumbers = new int[numbers.Length * 2]; //[5][3][24]...[50]...[] -> 20 elementos

        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log("POSITION: " + i);
            newNumbers[i] = numbers[i];
        }

        for (int i = 0; i < newNumbers.Length; i++)
        {
            Debug.Log("POSITION: " + i + " | VALUE: " + newNumbers[i]);
        }
    }

    private void Chess()
    {
        chess = new char[8, 8];

        /*
         * char[,] chess = new char[8,8];
         * Debug.Log(chess[3][3]); -> (P)
         * 
        0 [T][C][A][K][Q][A][C][T]
        1 [][][][][][][][]
        2 [][][][][][][][]
        3 [][][][P][][][][]
        4 [][][][][][][][]
        5 [][][][][][][][]
        6 [][][][][][][][]
        7 [][][][][][][][]
          0 1 2 3 4 5 6 7*/

        AddLetterToEachPosition();
        ShowChess();
    }

    private void AddLetterToEachPosition()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                chess[i, j] = 'F';
            }
        }
    }

    private void ShowChess()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Debug.Log("POSITION: [" + i + "]" + "[" + j + "] -> " + chess[i, j]);
            }
            Debug.Log("\n");
        }
    }
}
