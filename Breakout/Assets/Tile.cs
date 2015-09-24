using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

    public BoxCollider collider;
    public GameObject me;
    public GameObject thing;

    void OnTriggerEnter(Collider _other)
    {
        Debug.Log("Trigger");
        _other.gameObject.GetComponent<Movement>().curY = _other.gameObject.GetComponent<Movement>().curY * -1;
        _other.gameObject.GetComponent<Movement>().playAudio();
        if (me.active)
        {
            me.SetActive(false);
            thing = GameObject.FindGameObjectWithTag("Respawn");
            thing.GetComponent<GenerateTiles>().decrement();
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
