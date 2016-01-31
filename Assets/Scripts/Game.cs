using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour {
    public GameObject Ring1;
    public GameObject Ring2;
    public GameObject Ring3;
    public GameObject Ring4;

    public List<GameObject> rings = new List<GameObject>();
    // Use this for initialization


    void Awake() {
        rings.Add(Ring1);
        rings.Add(Ring2);
        rings.Add(Ring3);
        rings.Add(Ring4);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
