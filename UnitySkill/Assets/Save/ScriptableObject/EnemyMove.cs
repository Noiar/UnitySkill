using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public EnemyData data;

    float timer;
    int limit = 5;
    bool moveLeft = false;

	// Use this for initialization
	void Start () {
        gameObject.name = data.name;
        timer = data.moveTime;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Move();
            timer += data.moveTime;
        }
	}

    void Move()
    {
        if (!moveLeft)
        {
            transform.position += Vector3.right;
        }
        else
        {
            transform.position += Vector3.left;
        }

        if(Mathf.Abs(transform.position.x) >= limit)
        {
            moveLeft = !moveLeft;
        }
    }
}
