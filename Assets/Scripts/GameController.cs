using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    public GameObject deerPrefab;

    private static GameController game;
    private static World world;
    private static List<Object> agents;
    private static float simSpeed = 1f;
    private static int seed = 1234;


	// Use this for initialization
	void Start () {
        if (game == null)
            game = this;
        else
            Destroy(this);
        initialize();
	}
	
	// Update is called once per frame
	void Update () {
        if (agents.Count == 0)
        {
            Object n = Instantiate(deerPrefab, new Vector3(0, 0, -10), new Quaternion());
            agents.Add(n);
        }
	}

    private void initialize()
    {
        agents = new List<Object>();
    }

    public GameController getGame()
    {
        return this;
    }

    public float getSimSpeed()
    {
        return simSpeed;
    }
}
