using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wechatbutton2 : MonoBehaviour
{
    
    public GameObject wechat_picture;
    
    public void OnClick()
    {
        wechat_picture.SetActive(true);
    }
    // Start is called before the first frame updates
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
