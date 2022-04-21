using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class photo_buttton : MonoBehaviour
{
    public GameObject four_girl;
    public Click2 other;

    //private int mode = other.GetMode();
    // Start is called before the first frame update
    public void OnClick()
    {
        
        four_girl.SetActive(true);
    }
    // Start is called before the first frame updates
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        int mode = other.GetMode();
    }
}
