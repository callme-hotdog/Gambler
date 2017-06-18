using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed;
    public float Jump;
    public bool Jumpable = true;

	void Update ()
    {
       
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }


	}
}
