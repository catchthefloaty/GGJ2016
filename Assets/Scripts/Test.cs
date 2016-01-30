using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
    public float direction = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(new Vector3(0,0,30*Time.deltaTime*direction));
        }
	}
}
