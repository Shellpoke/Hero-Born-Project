using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    int BuildIndex;
    void Start()
    {
        BuildIndex = SceneManager.GetActiveScene().buildIndex;
    }
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(BuildIndex + 1);
    }
}
