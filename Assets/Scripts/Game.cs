using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TouchScript.Gestures;

public class Game : MonoBehaviour {
    public GameObject Ring1;
    public GameObject Ring2;
    public GameObject Ring3;
    public GameObject Ring4;

    public float ringlock1;
    public float ringlock2;
    public float ringlock3;
    public float ringlock4;

    public int gameState = 1;
    private int prevState = 1;

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
	if(prevState != gameState)
        {
            if (gameState == 0) {
                Ring1.GetComponent<Ring>().rotationToGo -= Ring1.transform.rotation.eulerAngles.z;
                Ring2.GetComponent<Ring>().rotationToGo -= Ring2.transform.rotation.eulerAngles.z;
                Ring3.GetComponent<Ring>().rotationToGo -= Ring3.transform.rotation.eulerAngles.z;
                Ring4.GetComponent<Ring>().rotationToGo -= Ring4.transform.rotation.eulerAngles.z;
                for (int i = 0; i < rings.Count; i++)
                {
                    for (int k = 0; k < rings[i].transform.childCount; k++)
                    {
                        rings[i].transform.GetChild(k).GetComponent<TapGesture>().enabled = false;

                    }
                }





            }
            else if (gameState == 1)
            {
                for (int k = 0; k < rings[3].transform.childCount; k++)
                {
                    rings[3].transform.GetChild(k).GetComponent<TapGesture>().enabled = true;

                }
            }
            else if (gameState == 2)
            {
                for (int k = 0; k < rings[2].transform.childCount; k++)
                {
                    rings[2].transform.GetChild(k).GetComponent<TapGesture>().enabled = true;

                }
            }
            else if (gameState == 3)
            {
                for (int k = 0; k < rings[1].transform.childCount; k++)
                {
                    rings[1].transform.GetChild(k).GetComponent<TapGesture>().enabled = true;

                }
            }
            else if (gameState == 4)
            {
                for (int k = 0; k < rings[0].transform.childCount; k++)
                {
                    rings[0].transform.GetChild(k).GetComponent<TapGesture>().enabled = true;

                }
            }
            else if (gameState == 5)
            {
                for (int i = 0; i < rings.Count; i++)
                {
                    for (int k = 0; k < rings[i].transform.childCount; k++)
                    {
                        rings[i].transform.GetChild(k).GetComponent<TapGesture>().enabled = false;

                    }
                }
            }
        }
        prevState = gameState;
        if (gameState == 0)
        {
            if(Ring1.transform.rotation.eulerAngles.z == 0)
            {
                if (Ring2.transform.rotation.eulerAngles.z == 0)
                {
                    if (Ring3.transform.rotation.eulerAngles.z == 0)
                    {
                        if (Ring4.transform.rotation.eulerAngles.z == 0)
                        {
                            gameState = 1;
                        }
                        
                    }
                }
            }




        }
        else if (gameState == 1)
        {

        }
        else if (gameState == 2)
        {

        }
        else if (gameState == 3)
        {

        }
        else if (gameState == 4)
        {

        }
        else if (gameState == 5)
        {

        }



    }
}
