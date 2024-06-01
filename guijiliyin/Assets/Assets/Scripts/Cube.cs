using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    void Update()
    {
        bool isKeyUp = Input.GetKey(KeyCode.UpArrow);
        bool isKeyDown = Input.GetKey(KeyCode.DownArrow);
        bool isKeyLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isKeyRight = Input.GetKey(KeyCode.RightArrow);
        if (isKeyUp)
        {
            //œÚ…œ
            transform.Translate(0, 0, 1.0f * Time.deltaTime);
        }
        if (isKeyDown)
        {
            transform.Translate(0, 0, -1.0f * Time.deltaTime);
        }
        if (isKeyLeft)
        {
            transform.Translate(-1.0f * Time.deltaTime, 0, 0);
        }
        if (isKeyRight)
        {
            transform.Translate(1.0f * Time.deltaTime, 0, 0);

        }
    }
    void OnCollisionEnter()
    {

    }
}
