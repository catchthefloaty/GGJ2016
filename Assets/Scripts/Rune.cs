using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using System;

public class Rune : MonoBehaviour {
    public bool affectBefore = false;
    public int beforeDirection = -1;
    public float beforemagnitude = 5;
    

    public bool affectSame = true;
    public int sameDirection = 1;
    public float sameMagnitude = 5;


    public bool affectAfter = false;
    public int affectDirection = 1;
    public float affectMagnitude = 5;


    int ringnumber;

    public GameObject before;
    public GameObject after;
    Game game;

    // Use this for initialization
    void Start () {
        ringnumber = int.Parse( transform.parent.tag.Substring(4,1));
        Debug.Log(ringnumber);
        game = GameObject.FindGameObjectWithTag("Game").GetComponent<Game>();

        if (ringnumber > 1)
        {
            before = game.rings[ringnumber -1];
        }
        if(ringnumber < 4)
        {
            after = game.rings[ringnumber + 1];
        }
        

	}
	
	// Update is called once per frame
	void Update () {
	




	}

    void OnEnable()
    {
        GetComponent<TapGesture>().Tapped += TapHandler;
    }

    private void TapHandler(object sender, EventArgs eventArgs)
    {
        //var tap = sender as TapGesture;
        Debug.Log("DTap");
        if (affectBefore)
        {
            before.GetComponent<Ring>().
        }
        if (affectSame)
        {

        }
        if (affectAfter) {

        }

    }



}
