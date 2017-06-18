using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Idle,
    Chase,
    Return
}

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    public State NowState = State.Idle;
    public Vector2 StartPosition;
    public float ChaseRange; // Chase Range 거리 안으로 들어오면 쫓아감
    public float ReturnRange; // Return Range 거리보다 바깥으로 가면 처음 위치로 돌아감

	// Use this for initialization
	void Start ()
    {
        StartPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (NowState == State.Idle)
        {
            ActIdle();
        }
        else if (NowState == State.Chase)
        {
            ActChase();
        }
        else if (NowState == State.Return)
        {
            ActReturn();
        }
	}

    void ActIdle()
    {
        Vector3 dir = Player.transform.position - transform.position;
        float distance = dir.magnitude;

        if (distance < ChaseRange)
        {
            NowState = State.Chase;
        }
    }

    void ActChase()
    {
        Vector3 dir = Player.transform.position - transform.position;
        float distance = dir.magnitude;

        if (distance > ChaseRange)
        {
            NowState = State.Idle;
        }

        dir.Normalize();
        transform.Translate(dir * Time.deltaTime);
    }

    void ActReturn()
    {
    }
}
