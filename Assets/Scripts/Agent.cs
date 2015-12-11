using UnityEngine;
using System.Collections;

public class Agent : MonoBehaviour
{

    private string agentType;
    private Rigidbody body;
    private float hp;
    private Vector3 targetPos;
    public float speed = 10;


    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        plan();
    }

    void FixedUpdate()
    {
        move();
    }

    void move()
    {
        Vector3 movement = Vector3.Normalize(targetPos - body.position) * speed * Time.deltaTime;
        body.MovePosition(body.position + movement);
    }

    void plan()
    {
        targetPos.x = 10;
    }
}
