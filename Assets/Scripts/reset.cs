using UnityEngine;
using System.Collections;

public class reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Click() {
        GameObject.FindGameObjectWithTag("Game").GetComponent<Game>().gameState = 0;
    }
}
