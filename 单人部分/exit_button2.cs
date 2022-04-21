using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit_button2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject colorpaper;
    public GameObject pic_806393;
    public GameObject ASCII;
    public GameObject maincamera;
    public GameObject subcamera;
    public Click2 other;
    public GameObject pic_desk4;
    public GameObject unlock4;
    public GameObject desk3;
    public GameObject tip_camera;
    public GameObject dairy_3;
    public GameObject iphone_lock;
    public GameObject unlock;

    void OnClick()
    {
        other.changemode(0);
        maincamera.SetActive(true);
        subcamera.SetActive(false);
        colorpaper.SetActive(false);
        pic_806393.SetActive(false);
        ASCII.SetActive(false);
        pic_desk4.SetActive(false);
        unlock4.SetActive(false);
        desk3.SetActive(false);
        tip_camera.SetActive(false);
        dairy_3.SetActive(false);
        iphone_lock.SetActive(false);
        unlock.SetActive(false);
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
