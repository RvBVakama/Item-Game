using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject prefItem = null;
    private float fSpacingDist = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        PopulateLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PopulateLevel()
    {
        float fStartingX = -3.5f;
        float fStartingY = 4.5f;

        var a = Instantiate(prefItem);

        // make the rest of the items
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (i == 0 && j == 0)
                {
                    // make starting item
                    a.transform.position = new Vector3(fStartingX, fStartingY, 0);
                    continue;
                }
                a = Instantiate(prefItem);
                a.transform.position = new Vector3(fStartingX + (fSpacingDist * j), fStartingY + (-fSpacingDist * i), 0);
            }
        }
    }
}
