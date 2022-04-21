using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene0to1 : MonoBehaviour
{
    public int videoLength;
 
 
    // Use this for initialization
    void Start () 
    {
        StartCoroutine(waitChangeScene());
    }
     
    // Update is called once per frame
    void Update () {
         
    }
 
 
    IEnumerator waitChangeScene() 
    {
 
        yield return new WaitForSeconds(videoLength);
 
        SceneManager.LoadScene(1);
    }
}