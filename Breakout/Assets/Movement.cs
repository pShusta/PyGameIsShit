using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    private int lives;
    public int yVelocity, xVelocity, curX, curY, zVelocity, curZ;
    public Transform trans;
    public GameObject spawn, _text, _player;
    private bool blah;


	// Use this for initialization
	void Start () {
        blah = false;
        yVelocity = 3;
        xVelocity = 3;
        zVelocity = 3;
        curZ = 3;
        curX = 3;
        curY = 3;
        lives = 3;
	}

    public void playAudio(){
        this.gameObject.GetComponent<AudioSource>().Play();
    }

    void AddLives()
    {
        lives++;
    }
    int GetLives() { return lives; }

	// Update is called once per frame
	void Update () {
        trans.position = Vector3.Lerp(trans.position, new Vector3(trans.position.x + curX, trans.position.y + curY, trans.position.z + curZ), Time.deltaTime);
        if (trans.position.x >= 12.0) { curX = xVelocity * -1; }
        if (trans.position.x < .4) { curX = xVelocity; }
        if (trans.position.z >= 0.0) { curZ = zVelocity * -1; }
        if (trans.position.z < -6.6) { curZ = zVelocity; }
        if (trans.position.y >= 10.17) { curY = yVelocity * -1; }
        if (trans.position.y <= -1.5) { newball(); }
	}

    void newball()
    {
        lives--;
        if (lives <= 0 && blah == false) { endgame(); blah = true;  return; }
        if (lives <= 0) { return;  }
        trans.position = spawn.transform.position;
        curY = yVelocity;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().Play();
    }
    void endgame()
    {
        _text.SetActive(true);
        _player.GetComponent<MovePaddle>().enabled = false;
        GameObject.FindGameObjectWithTag("Respawn").GetComponent<AudioSource>().Play();
    }
}
