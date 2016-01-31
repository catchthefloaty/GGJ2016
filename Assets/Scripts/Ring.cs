using UnityEngine;
using System.Collections;
using System;

public class Ring : MonoBehaviour {
    public float rotationToGo;
    private float speed = 150;
    public float dif;

    // Use this for initialization
    void Start () {
        
    }

    

    // Update is called once per frame
    void Update() {
        if (Mathf.Abs((float)rotationToGo) > 0)
        {
            dif = 0; 

            if (rotationToGo > 0) {
                
                    dif = Time.deltaTime * speed;
                if (dif < rotationToGo) { 
                    transform.Rotate(0, 0, (float)(dif));
                }
                else
                {
                    transform.Rotate(0, 0, rotationToGo);
                    float roundoff = 0; 
                    if (transform.tag == "ring2")
                    {
                        roundoff = (float)Math.Round((decimal)transform.rotation.eulerAngles.z,2, MidpointRounding.AwayFromZero)+.5f ;
                    }
                    else {
                        roundoff = Mathf.RoundToInt(transform.rotation.eulerAngles.z);
                    }
                    transform.rotation = Quaternion.Euler(0,0,roundoff);
                }
                
            }
            else
            {
                dif = Time.deltaTime * speed *-1;
                if (dif > rotationToGo)
                {
                    transform.Rotate(0, 0, (float)(dif));
                }
                else
                {
                    transform.Rotate(0, 0, rotationToGo);
                    float roundoff = 0;
                    if (transform.tag == "ring2")
                    {
                        roundoff = (float)Math.Round((decimal)transform.rotation.eulerAngles.z,2, MidpointRounding.AwayFromZero) +.5f;
                    }
                    else {
                        roundoff = Mathf.RoundToInt(transform.rotation.eulerAngles.z);
                    }
                    transform.rotation = Quaternion.Euler(0, 0, roundoff);
                }
            }


            


            if (dif > 0)
            {
                if (dif > rotationToGo)
                {
                    rotationToGo = 0;
                }

                else {
                    rotationToGo -= dif;
                }
            }
            if (dif < 0)
            {
                if (dif < rotationToGo)
                {
                    rotationToGo = 0;
                }

                else {
                    rotationToGo -= dif;
                }
            }
        }
    }
    


}
