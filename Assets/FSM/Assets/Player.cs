using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;

	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Speed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Speed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.0f, -Speed * Time.deltaTime, 0.0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0.0f, Speed * Time.deltaTime, 0.0f);
        }

        Vector3 cameraPos = transform.position;
        cameraPos.z = -10.0f;

        Camera.main.transform.position = cameraPos;
    }
}
