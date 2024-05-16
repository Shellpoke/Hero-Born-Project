using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    //Sets rotation speed, adjustable on inspector
    public int RotationSpeed = 100;
    private Transform ItemTransform;
    // Start is called before the first frame update
    void Start()
    {
        //Gets transform component info from item.
        ItemTransform =this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       //Item rotation animation
        ItemTransform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
    }
}
