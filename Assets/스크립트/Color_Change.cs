using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Change : MonoBehaviour
{
    Renderer colors;

    private int[] RGBYP = new int[] { 255, 0, 0, 0, 255, 0, 0, 0, 255, 255, 255, 0, 255, 0, 255 };
    private int ranR = 0;
    private int ranG = 0;
    private int ranB = 0;

    private int randomNum;

    // Start is called before the first frame update
    void Start()
    {
        colors = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            randomNum = Random.Range(1, 6);

            switch (randomNum)
            {
                case 1:
                    ranR = RGBYP[0];
                    ranG = RGBYP[1];
                    ranB = RGBYP[2];
                    break;
                case 2:
                    ranR = RGBYP[3];
                    ranG = RGBYP[4];
                    ranB = RGBYP[5];
                    break;
                case 3:
                    ranR = RGBYP[6];
                    ranG = RGBYP[7];
                    ranB = RGBYP[8];
                    break;
                case 4:
                    ranR = RGBYP[9];
                    ranG = RGBYP[10];
                    ranB = RGBYP[11];
                    break;
                case 5:
                    ranR = RGBYP[12];
                    ranG = RGBYP[13];
                    ranB = RGBYP[14];
                    break;
            }

            colors.material.color = new Color((float)ranR / 255, (float)ranG / 255, (float)ranB / 255);
        }
    }
}
