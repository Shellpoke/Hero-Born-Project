using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehavior : MonoBehaviour
{
    //Variables that allow to set the initial and end positions through unity's inspector
    public Vector3 myStartPosition = new Vector3(-45, 0, 0);
    public Vector3 myEndPosition = new Vector3(-12, 0, 0);
    public int speed = 3;
    public bool forward = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Movement Of plaform and its limts code here.

        //If we reach the end then change our direction boolean to go backward
        if (gameObject.transform.position.x >= myEndPosition.x)
        {
            forward = false;
        }
        //If we reach the begining then change our direction boolean to go forward
        if (gameObject.transform.position.x <= myStartPosition.x)
        {
            forward = true;
        }

        //If we are going forward then add the speed
        if (forward == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + (Time.deltaTime * speed), gameObject.transform.position.y, gameObject.transform.position.z);
        }
        //If we are going backward then subtract the speed
        if (forward == false)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - (Time.deltaTime * speed), gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}
