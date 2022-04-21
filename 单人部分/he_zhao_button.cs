using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class he_zhao_button : MonoBehaviour
{
    public  GameObject computer_desk_button; 
    public void OnClick()
    {
        computer_desk_button.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
