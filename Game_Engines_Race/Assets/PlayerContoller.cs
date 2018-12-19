using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour {


    public bool isFalling;
     Vector3 originalPosition;
    
    // Start is called before the first frame update
    void Start() {

        originalPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (!isFalling) {


                GetComponent<Rigidbody>().isKinematic = false;
                isFalling = true;

            } else {

                //TODO: RESET

                transform.position = originalPosition;

                isFalling = false;

                GetComponent<Rigidbody>().isKinematic = true;



            }
        }




    }
}
