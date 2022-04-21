using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click2 : MonoBehaviour
{
    // Start is called before the first frame update
    Ray ray;
    RaycastHit hit;
    GameObject obj;
    private int mode = 0;
    private bool getmouse =false;
    public GameObject colorPaper;
    public GameObject pic_806393;
    public GameObject ASCII;
    public GameObject plant;
    public GameObject maincamera;
    public GameObject subcamera;
    public GameObject lamp;
    public GameObject pic_desk4;
    public GameObject unlock4;
    public GameObject desk3;
    public GameObject photo_button;
    public GameObject iphone_lock;
    private bool interval=false;
    private bool getguitar=false;
    private bool getfamily_pic=false;
    public float interval_time;
    public float long_time;
    public float short_time;
    private float current_time=0;
    private bool[] flag = new bool[15]{false,true,true,true,true,true,true,true,true,true,false,false,false,false,true};
    public int count=0;
    private bool plantisdown=false;
    public int GetMode()
    {
        return mode;
    }
    public void changemode(int m)
    {
        this.mode=m;
    }
    public bool getmousestation()
    {
        return getmouse;
    }
    public bool guitar()
    {
        return getguitar;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(mode)
        {
            case 0:
            {
                if (Input.GetMouseButtonDown(0))
                {
                    //Debug.Log(TAG+"点击鼠标左键");
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit))
                    {
                        //Debug.Log(hit.collider.gameObject.name);
                        obj = hit.collider.gameObject;
                        if(obj.name == "mouse4")
                        {
                            getmouse = true;
                        }
                        else if(obj.name == "color paper")
                        {
                            colorPaper.SetActive(true);
                        }
                        else if(obj.name == "brain_jar")
                        {
                            pic_806393.SetActive(true);
                        }
                        else if(obj.name == "Book_chengshe")
                        {
                            ASCII.SetActive(true);
                        }
                        else if(obj.name == "Plant(3)")
                        {
                            if(!plantisdown)
                            {
                                mode = 1;
                                count=0;
                            }
                            else
                            {
                               plant.transform.rotation = Quaternion.Euler(0f,0f,0f);
                            }
                        }
                        else if(obj.name == "display.004")
                        {
                            if(!getguitar)
                            {
                                pic_desk4.SetActive(true);
                            }
                            else 
                            {
                                unlock4.SetActive(true);
                            }
                        }
                        else if(obj.name =="Guitar_01" )
                        {
                            getguitar=true;
                        }
                        else if(obj.name == "screen")
                        {
                            if(getmouse)
                            {
                                mode = 2;
                            }
                        }
                        else if(obj.name == "photo_frame")
                        {
                            getfamily_pic = true;
                            photo_button.SetActive(true);
                        }
                        else if(obj.name == "phone1k")
                        {
                            iphone_lock.SetActive(true);
                        }
                        else
                        {

                        }
                    }
                }
            }break;
            case 1:
            {
                plant.transform.rotation = Quaternion.Euler(-90f,0f,0f);
                maincamera.SetActive(false);
                subcamera.SetActive(true);
                Vector3 pos =new Vector3(1.081f,1.228f,-1.911f);
                subcamera.transform.rotation = Quaternion.Euler(0f,90f,0f);
                if(!interval&&count<15)
                {
                    if(flag[count])
                    {
                        if(current_time>long_time)
                        {
                            interval=true;
                            current_time=0;
                        }
                        else
                        {
                            lamp.SetActive(true);
                            current_time+=Time.deltaTime;
                        }
                    }
                    else
                    {
                        if(current_time>short_time)
                        {
                            interval=true;
                            current_time=0;
                        }
                        else
                        {
                            lamp.SetActive(true);
                            current_time+=Time.deltaTime;
                        }
                    }
                }
                else if(count<12)
                {
                    if(current_time>interval_time)
                    {
                        interval=false;
                        current_time=0;
                        count++;
                    }
                    else
                    {
                        lamp.SetActive(false);
                        current_time+=Time.deltaTime;
                    }
                }
                else
                {
                    lamp.SetActive(false);
                }
            }break;
            case 2:
            {
                desk3.SetActive(true);
                
            }break;
        }
    }
}
