using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GenerateTiles : MonoBehaviour {

    List<GameObject> objs;
    int numTiles;
    public GameObject what, _player;

	// Use this for initialization
	void Start () {
        numTiles = 324;
        objs = new List<GameObject>();
        foreach (GameObject ob in GameObject.FindGameObjectsWithTag("Player"))
        {
            objs.Add(ob);
        }
        for (int q = 0; q < 60; q++)
        {
            int i = Random.Range(0, objs.Count - 1);
            if (objs[i].active != false) {
                objs[i].SetActive(false);
                numTiles--;
                Debug.Log("numTiles: " + numTiles);
            }
        }
	}

    public int getTiles() { return numTiles; }

    public void decrement()
    {
        numTiles--;
        Debug.Log("numTiles: " + numTiles);
        if (numTiles <= 0)
        {
            youWin();
        }
    }

    void youWin()
    {
        what.GetComponent<Text>().text = "You're a cheater!!!";
        what.SetActive(true);
        _player.GetComponent<MovePaddle>().enabled = false;
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
