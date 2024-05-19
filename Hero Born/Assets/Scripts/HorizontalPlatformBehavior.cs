using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalPlatformBehavior : MonoBehaviour
{
    // Set initial position, available on inspector
    public Vector3 HoriStartPosition = new Vector3(0, 0,-10);
    public Vector3 HoriEndPosition = new Vector3(0, 0,-5);
    public int SideSpeed = 1;
    public bool side = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        //If we reach the intended right limit, the platform will now move left
        if (gameObject.transform.position.z >= HoriEndPosition.z)
        {
            side = false;
        }
        //if we reach the intended left limit, the platform will now move right
        if (gameObject.transform.position.z <= HoriStartPosition.z)
        {
            side = true;
        }

        //If we are going right, speed is added, If we are going left, speed is substracted.
        if (side == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + (Time.deltaTime * SideSpeed));
        }
        if (side == false)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - (Time.deltaTime * SideSpeed));
        }
    }
}
