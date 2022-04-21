using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class four_girl_button : MonoBehaviour
{
    // Start is called before the first frame update
    public bool click=false;
    public void OnClick()
    {
        click=true;
    }
    public bool getclick()
    {
        return click;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }
}
