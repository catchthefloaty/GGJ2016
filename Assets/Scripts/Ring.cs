using UnityEngine;
using System.Collections;

public class Ring : MonoBehaviour {
    public float rotationToGo;
    private float speed = 25;
    
    
    // Use this for initialization
    void Start () {
        
    }



    // Update is called once per frame
    void Update() {
        if (Mathf.Abs(rotationToGo) > 0)
        {
            float dif = 0; 

            if (rotationToGo > 0) {
                dif = Time.deltaTime * speed;
                transform.Rotate(0, 0, (dif));
                
            }
            else
            {
                dif = Time.deltaTime * speed *-1;
                transform.Rotate(0, 0, (dif));
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
