using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int initialRow, initialCol;
    public float velocity = 10.0f;
    int currentRow, currentCol;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(initialCol, initialRow, 0);
        currentRow = initialRow;
        currentCol = initialCol;
    }

    // Update is called once per frame
    void Update()
    {
        //////Faire en sorte qu'en appuiyant long sur le touche on continue de se déplacer
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //transform.position = new Vector3(transform.position.x + 1, transform.position.y, 0);
            transform.Translate(velocity * Vector3.right * Time.deltaTime);
            currentRow++;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //transform.position = new Vector3(transform.position.x - 1, transform.position.y, 0);
            transform.Translate(velocity * -Vector3.right * Time.deltaTime);
            currentRow--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y + 1, 0);

            transform.Translate(velocity * Vector3.up * Time.deltaTime);
            currentCol++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y - 1, 0);

            transform.Translate(velocity * -Vector3.up * Time.deltaTime);
            currentCol--;
        }
    }
}
