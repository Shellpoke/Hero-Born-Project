using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MythicalForElloopsoid : MonoBehaviour
{
    string[] MythicCredits = new string[4];
    // Start is called before the first frame update
    void Start()
    {
        //Content of the Console Credits that uses my secret for loop convenienty placed here
        MythicCredits[0] = "Simplatform";
        MythicCredits[1] = "Project By Christopher Neira";
        MythicCredits[2] = "Hope this project find you well Professor :D";
        MythicCredits[3] = "Sorry, I just couldn't figure out where to put this guy ):";
        
    }
    void OnTriggerEnter(Collider other)
    {
        //A convenient while loop that triggers when the player touches the mythical For Elloopsoid
        for (int i = 0; i < MythicCredits.Length; i++)
        {
            Debug.Log(MythicCredits[i]);
        }
    }
}
