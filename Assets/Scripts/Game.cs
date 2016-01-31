using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TouchScript.Gestures;

public class Game : MonoBehaviour
{
    public bool disableRings = false;
    public Color off;
    public Color green;
    public Color red;
    public Color on;

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

    private List<float> locks = new List<float>();

    public List<GameObject> rings = new List<GameObject>();
    // Use this for initialization


    void Awake()
    {
        rings.Add(Ring1);
        rings.Add(Ring2);
        rings.Add(Ring3);
        rings.Add(Ring4);
        locks.Add(ringlock1);
        locks.Add(ringlock2);
        locks.Add(ringlock3);

        locks.Add(ringlock4);
    }

    // Update is called once per frame
    void Update()
    {
        if (prevState != gameState)
        {
            if (gameState == 0)
            {
                Ring1.GetComponent<Ring>().rotationToGo -= Ring1.transform.rotation.eulerAngles.z;
                Ring2.GetComponent<Ring>().rotationToGo -= Ring2.transform.rotation.eulerAngles.z;
                Ring3.GetComponent<Ring>().rotationToGo -= Ring3.transform.rotation.eulerAngles.z;
                Ring4.GetComponent<Ring>().rotationToGo -= Ring4.transform.rotation.eulerAngles.z;
                for (int i = 0; i < rings.Count; i++)
                {
                    for (int k = 0; k < rings[i].transform.childCount; k++)
                    {
                        rings[i].transform.GetChild(k).GetComponent<TapGesture>().enabled = false;
                        if (rings[i].transform.GetChild(k).GetComponent<Rune>().winRune)
                        {
                            rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = red;
                        }
                        else
                        {
                            rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = off;
                        }


                    }
                }





            }
            else if (gameState == 1)
            {
                for (int k = 0; k < rings[3].transform.childCount; k++)
                {
                    rings[3].transform.GetChild(k).GetComponent<TapGesture>().enabled = true;
                    if (rings[3].transform.GetChild(k).GetComponent<Rune>().winRune)
                    {
                        rings[3].transform.GetChild(k).GetComponent<SpriteRenderer>().color = red;
                    }
                    else
                    {
                        rings[3].transform.GetChild(k).GetComponent<SpriteRenderer>().color = on;
                    }

                }
                for (int i = 0; i < rings.Count; i++)
                {
                    if (i != 3)
                    {
                        for (int k = 0; k < rings[i].transform.childCount; k++)
                        {
                            rings[i].transform.GetChild(k).GetComponent<TapGesture>().enabled = false;
                            if (rings[i].transform.GetChild(k).GetComponent<Rune>().winRune)
                            {
                                if (locks[i] == rings[i].transform.rotation.eulerAngles.z)
                                {
                                    rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = green;
                                }
                                else {
                                    rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = red;
                                }
                            }
                            else
                            {
                                rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = off;
                            }
                        }
                    }
                }
            }
            else if (gameState == 2)
            {
                for (int k = 0; k < rings[2].transform.childCount; k++)
                {
                    rings[2].transform.GetChild(k).GetComponent<TapGesture>().enabled = true;
                    if (rings[2].transform.GetChild(k).GetComponent<Rune>().winRune)
                    {
                        rings[2].transform.GetChild(k).GetComponent<SpriteRenderer>().color = red;
                    }
                    else
                    {
                        rings[2].transform.GetChild(k).GetComponent<SpriteRenderer>().color = on;
                    }

                }
                for (int i = 0; i < rings.Count; i++)
                {
                    if (i != 2)
                    {
                        for (int k = 0; k < rings[i].transform.childCount; k++)
                        {
                            rings[i].transform.GetChild(k).GetComponent<TapGesture>().enabled = false;
                            if (rings[i].transform.GetChild(k).GetComponent<Rune>().winRune)
                            {
                                if (locks[i] == rings[i].transform.rotation.eulerAngles.z)
                                {
                                    rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = green;
                                }
                                else {
                                    rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = red;
                                }
                            }
                            else
                            {
                                rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = off;
                            }
                        }
                    }
                }
            }
            else if (gameState == 3)
            {
                for (int k = 0; k < rings[1].transform.childCount; k++)
                {
                    rings[1].transform.GetChild(k).GetComponent<TapGesture>().enabled = true;
                    if (rings[1].transform.GetChild(k).GetComponent<Rune>().winRune)
                    {
                        rings[1].transform.GetChild(k).GetComponent<SpriteRenderer>().color = red;
                    }
                    else
                    {
                        rings[1].transform.GetChild(k).GetComponent<SpriteRenderer>().color = on;
                    }
                }
                for (int i = 0; i < rings.Count; i++)
                {
                    if (i != 1)
                    {
                        for (int k = 0; k < rings[i].transform.childCount; k++)
                        {
                            rings[i].transform.GetChild(k).GetComponent<TapGesture>().enabled = false;
                            if (rings[i].transform.GetChild(k).GetComponent<Rune>().winRune)
                            {
                                if (locks[i] == (int)rings[i].transform.rotation.eulerAngles.z)
                                {
                                    rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = green;
                                }
                                else {
                                    rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = red;
                                }
                            }
                            else
                            {
                                rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = off;
                            }
                        }
                    }
                }
            }
            else if (gameState == 4)
            {
                for (int k = 0; k < rings[0].transform.childCount; k++)
                {
                    rings[0].transform.GetChild(k).GetComponent<TapGesture>().enabled = true;
                    if (rings[0].transform.GetChild(k).GetComponent<Rune>().winRune)
                    {
                        rings[0].transform.GetChild(k).GetComponent<SpriteRenderer>().color = red;
                    }
                    else
                    {
                        rings[0].transform.GetChild(k).GetComponent<SpriteRenderer>().color = on;
                    }
                }
                for (int i = 0; i < rings.Count; i++)
                {
                    if (i != 0)
                    {
                        for (int k = 0; k < rings[i].transform.childCount; k++)
                        {
                            rings[i].transform.GetChild(k).GetComponent<TapGesture>().enabled = false;
                            if (rings[i].transform.GetChild(k).GetComponent<Rune>().winRune)
                            {
                                if (locks[i] == (int)rings[i].transform.rotation.eulerAngles.z)
                                {
                                    rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = green;
                                }
                                else {
                                    rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = red;
                                }
                            }
                            else
                            {
                                rings[i].transform.GetChild(k).GetComponent<SpriteRenderer>().color = off;
                            }
                        }
                    }
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
            if (Ring1.transform.rotation.eulerAngles.z == 0)
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

            if ((int)Ring4.transform.rotation.eulerAngles.z == ringlock4 || (int)(Ring4.transform.rotation.eulerAngles.z + Ring4.GetComponent<Ring>().rotationToGo) == ringlock4)
            {
                gameState = 2;
            }
            lockCheck();

        }
        else if (gameState == 2)
        {
            ///Debug.Log((int)Ring3.transform.rotation.eulerAngles.z == (int)ringlock3 || (Ring3.transform.rotation.eulerAngles.z + Ring3.GetComponent<Ring>().rotationToGo) == ringlock3);// || (Ring3.transform.rotation.eulerAngles.z + Ring3.GetComponent<Ring>().rotationToGo) == ringlock3);
            if ((int)Ring3.transform.rotation.eulerAngles.z == ringlock3 || (int)(Ring3.transform.rotation.eulerAngles.z + Ring3.GetComponent<Ring>().rotationToGo) == ringlock3)
            {

                gameState = 3;
            }
            lockCheck();
            
        }
        else if (gameState == 3)
        {
            if ((int)Ring2.transform.rotation.eulerAngles.z == (int)ringlock2 || (int)(Ring2.transform.rotation.eulerAngles.z + Ring2.GetComponent<Ring>().rotationToGo) == ringlock2)
            {
                gameState = 4;
            }
            lockCheck();
        }
        else if (gameState == 4)
        {
            if (Ring1.transform.rotation.eulerAngles.z == ringlock1 || (Ring1.transform.rotation.eulerAngles.z + Ring1.GetComponent<Ring>().rotationToGo) == ringlock1)
            {
                gameState = 5;
            }
            lockCheck();
        }
        else if (gameState == 5)
        {

        }



    }


    void lockCheck()
    {
        if (!(Ring4.transform.rotation.eulerAngles.z == ringlock4))
        {
            gameState = 1;
        }
        else if (!((int)Ring3.transform.rotation.eulerAngles.z == (int)ringlock3))
        {
            
            gameState = 2;
        }
       else if (!(Ring2.transform.rotation.eulerAngles.z == ringlock2))
        {
            gameState = 3;
        }
        else if (!(Ring1.transform.rotation.eulerAngles.z == ringlock1))
        {
            gameState = 4;
        } 




    }


}
