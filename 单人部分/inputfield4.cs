using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class inputfield4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject inputFieldGo = GameObject.Find("InputField4");
        InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();
        Debug.Log(inputFieldCo.text);
        if(inputFieldCo.text == "62783")
        {
            SceneManager.LoadScene(2);
        }
    }
}
