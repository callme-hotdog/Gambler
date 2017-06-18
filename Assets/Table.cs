using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Table : MonoBehaviour
{
    float time;

	// Update is called once per frame
	void Update ()
    {
           if(Input.GetMouseButtonDown(0))
        {
            if (Time.time - time < 0.25f)
            {
                SceneManager.LoadScene("OnTable");
            }
            time = Time.time;
        }
	}
}
