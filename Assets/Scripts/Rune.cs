using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using System;

public class Rune : MonoBehaviour {
    public bool affectBefore = false;
    public int beforeDirection = -1;
    public float beforemagnitude = 5;
    public bool winRune = false;

    public bool affectSame = true;
    public int sameDirection = 1;
    public float sameMagnitude = 5;


    public bool affectAfter = false;
    public int afterDirection = 1;
    public float afterMagnitude = 5;


    public int ringnumber;

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
            before = game.rings[ringnumber -2];
        }
        if(ringnumber < 4)
        {
            after = game.rings[ringnumber];
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
            if (before != null)
            {
                before.GetComponent<Ring>().rotationToGo += beforeDirection * (360/(before.transform.childCount)) * beforemagnitude;
                //before.GetComponent<Ring>().start = before.transform.eulerAngles;
            }
        }
        if (affectSame)
        {
            transform.parent.gameObject.GetComponent<Ring>().rotationToGo += sameDirection * (360 / (transform.parent.transform.childCount)) * sameMagnitude;
            //transform.parent.gameObject.GetComponent<Ring>().start = transform.parent.gameObject.transform.eulerAngles;
        }
        if (affectAfter)
        {
            if (after != null)
            {
                after.GetComponent<Ring>().rotationToGo += afterDirection * (360 / (after.transform.childCount)) * afterMagnitude;
                // after.GetComponent<Ring>().start = after.transform.eulerAngles;
            }
        }

    }



}
