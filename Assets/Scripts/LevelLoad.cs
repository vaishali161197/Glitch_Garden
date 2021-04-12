using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    [SerializeField] int TimeToWait = 4;
    int CurrentSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(WaitForTime());
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(TimeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(CurrentSceneIndex + 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
