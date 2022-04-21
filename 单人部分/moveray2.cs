using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveray2 : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    GameObject obj;
    private bool getmouse=false;
    public Text T2;
    public GameObject mouse;
    public Click2 other;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int mode2 = other.GetMode();
        if(mode2 ==0 )
        {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log(hit.collider.gameObject.name);
            obj = hit.collider.gameObject;
            if(obj.name =="mouse4")
            {
                T2.text="地上的鼠标";
            }
            else if(obj.name == "screen")
            {
                getmouse=other.getmousestation();
                if(getmouse)
                {
                    T2.text = "未上锁的电脑";
                }
                else
                {
                    T2.text="";
                }
            }
            else if(obj.name == "color paper")
            {
                T2.text="一个折成的千纸鹤";
            }
            else if(obj.name == "phone1k")
            {
                T2.text = "一部手机";
            }
            else if(obj.name == "brain_jar")
            {
                T2.text = "一个有趣的罐子";
            }
            else if(obj.name == "Book_chengshe")
            {
                T2.text = "一本程设书";
            }
            else if(obj.name == "Plant(3)")
            {
                T2.text = "一盆花";
            }
            else if(obj.name == "photo_frame")
            {
                T2.text = "宿舍的合照";
            }
            else if(obj.name == "display.004")
            {
                T2.text = "一台电脑";
            }
            else if(obj.name == "Guitar_01")
            {
                T2.text = "一把吉他";
            }
            else
            {
                T2.text = "";
            }
        }
        }
        else 
        {
            T2.text ="";
        }
    }
}
