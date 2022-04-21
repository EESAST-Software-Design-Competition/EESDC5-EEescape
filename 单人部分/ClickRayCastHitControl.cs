using System;
using UnityEngine;
using UnityEngine.UI;

public class ClickRayCastHitControl : MonoBehaviour
{
    private string TAG = "ClickRayCastHitControl_";
    
    Ray ray;
    RaycastHit hit;
    GameObject obj;

    public Text T;  //将文本框拖入
    public GameObject maincamera;
    public GameObject subcamera;
    public GameObject dian_lu_picture;
    public GameObject yi_gui2;
    public GameObject notebook2;
    public GameObject notebook2_picture;
    public GameObject exit;
    public GameObject computer_password2;
    public GameObject computer2_desktop;
    public GameObject computer_password1;
    public GameObject conputer1_desktop;
    public GameObject drawer1;
    public GameObject moers;
    public GameObject Pillow1;
    public GameObject[] locker_button=new GameObject[10];
    private bool[] flag = new bool[10]{false,false,false,false,false,false,false,false,false,false};
    private int count=0;
    public GameObject locker2;
    public GameObject tip;
    public GameObject number;
    public GameObject lock_book;
    public GameObject lock_book_pic;
    public GameObject computer1_desk;
    public GameObject phone_button;
    public four_girl_button other2;
    private bool click_four_girl=false;
    private string locker_b="";
    private int mode=0;
    /*
       0是正常
       1是靠近收纳盒
       2是输入收纳盒2的密码
    */
    private bool opencomputer2=false;
    private bool getkey=false;

    public int GetMode()
    {
        return mode;
    }
    public bool getkeystation()
    {
        return getkey;
    } 
    public void changemode(int m)
    {
        this.mode=m;
    }
    public void OnClick1()
    {
        if(!flag[1])
        {
            locker_b+="1";
            flag[1]=true;
            count++;
        }
        Debug.Log("input1");
    }
    public void OnClick2()
    {
        if(!flag[2])
        {
            locker_b+="2";
            flag[2]=true;
            count++;
        }
        Debug.Log("input2");
    }
    public void OnClick3()
    {
        if(!flag[3])
        {
            locker_b+="3";
            flag[3]=true;
            count++;
        }
    }
    public void OnClick4()
    {
        if(!flag[4])
        {
            locker_b+="4";
            flag[4]=true;
            count++;
        }
    }
    public void OnClick5()
    {
        if(!flag[5])
        {
            locker_b+="5";
            flag[5]=true;
            count++;
        }
    }
    public void OnClick6()
    {
        if(!flag[6])
        {
            locker_b+="6";
            flag[6]=true;
            count++;
        }
    }
    public void OnClick7()
    {
        if(!flag[7])
        {
            locker_b+="7";
            flag[7]=true;
            count++;
        }
    }
    public void OnClick8()
    {
        if(!flag[8])
        {
            locker_b+="8";
            flag[8]=true;
            count++;
        }
    }
    public void OnClick9()
    {
        if(!flag[9])
        {
            locker_b+="9";
            flag[9]=true;
            count++;
        }
    }
    public void OnClick0()
    {
        if(!flag[0])
        {
            locker_b+="0";
            flag[0]=true;
            count++;
        }
    }
    async void Update()
    {
        click_four_girl=other2.getclick();
        switch (mode)
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
                        Debug.Log(TAG+"点中： name = " + obj.name+ "点中： tag = " + obj.tag);
                        if (obj.tag == "diandianbook")
                        {
                            //Debug.Log("点中" + obj.name);
                            dian_lu_picture.SetActive(true);
                            //exit.SetActive(true);
                        }
                        if(obj.tag == "locker")
                        {
                            //Debug.Log("点中" + obj.name);
                            maincamera.SetActive(false);
                            Debug.Log("1");
                            subcamera.SetActive(true);
                            Debug.Log("2");
                            Vector3 pos =new Vector3(-4.3f,2.562f,-4.459f);
                            subcamera.transform.position = pos;
                            subcamera.transform.rotation = Quaternion.Euler(0f,-90f,0f);
                            mode = 1;
                            locker2.SetActive(true);
                        }
                        if(obj.tag == "yi_gui2")
                        {
                            obj.SetActive(false);   
                            maincamera.SetActive(false);
                            Debug.Log("1");
                            subcamera.SetActive(true);
                            Vector3 pos1 =new Vector3(-4.3f,0.7f,-1.149f);
                            subcamera.transform.position = pos1;
                            subcamera.transform.rotation = Quaternion.Euler(0f,-90f,0f);
                            Debug.Log("2");                
                        }
                        if(obj.tag == "notebook2")
                        {
                            notebook2_picture.SetActive(true);
                        }
                        if(obj.name == "laptop")
                        {
                            if(!opencomputer2)
                            {
                                mode = 3;
                                computer_password2.SetActive(true);
                                Debug.Log("3");
                            }
                            else
                            {
                                mode = 4;
                                computer2_desktop.SetActive(true);
                            }
                        }
                        if(obj.name == "sm_key_01")
                        {
                            T.text = "拿到了一把钥匙";
                            getkey=true;
                            obj.SetActive(false);
                        }
                        if(obj.name == "Pillow(1)")
                        {
                            Vector3 pos3 =new Vector3(-4.344638f,2.43f,1.203f);
                            Pillow1.transform.position = pos3;
                        }
                        if(obj.name == "yi_gui_door(1)")
                        {
                            if(getkey)
                            {
                                obj.SetActive(false);
                                maincamera.SetActive(false);
                                subcamera.SetActive(true);
                                Vector3 pos1 =new Vector3(-3.8f,1.25f,0.13f);
                                subcamera.transform.position = pos1;  
                                subcamera.transform.rotation = Quaternion.Euler(0f,-90f,0f);
                                mode = 5;
                            }
                        }
                        if(obj.name == "Plane_drawer (1)")
                        {
                            Vector3 pos2 = new Vector3(-2.746f,0.225f,-0.3927f);
                            maincamera.SetActive(false);
                            subcamera.SetActive(true);
                            Vector3 pos1 =new Vector3(-2.9f,1.6f,1.15f);
                            subcamera.transform.position = pos1;
                            subcamera.transform.rotation = Quaternion.Euler(70f,-90f,0.0f);
                            mode =6;  
                            pos1=new Vector3(-4.075f,0.661f,1.27f);
                            drawer1.transform.position = pos1;
                        }
                        if(obj.name == "Laptop(1)")
                        {
                            mode=7;
                        }
                        if(obj.name == "Closeof1")
                        {
                            obj.SetActive(false);
                            maincamera.SetActive(false);
                            subcamera.SetActive(true);
                            Vector3 pos1 =new Vector3(-3.45f,-0.335f,1.02f);
                            subcamera.transform.position = pos1;  
                            subcamera.transform.rotation = Quaternion.Euler(0f,-90f,0f);
                            mode = 8;
                        }
                        
                    
                    }
                }
            }break;
            case 1:
            {
                Debug.Log("change mode to1");
                if (Input.GetMouseButtonDown(0))
                {
                    if (Physics.Raycast(ray, out hit))
                    {
                        obj = hit.collider.gameObject;
                        Debug.Log(obj.name);
                        if(obj.name == "Modern Liquor Cabinet")
                        {
                            T.text = "输入密码：";
                            mode=2;
                            Debug.Log("keyword");
                        }
                    }
                }
            }break;
            case 2:
            {
                locker_button[0].GetComponent<Button>().onClick.AddListener(OnClick0);
                locker_button[1].GetComponent<Button>().onClick.AddListener(OnClick1);
                locker_button[2].GetComponent<Button>().onClick.AddListener(OnClick2);
                locker_button[3].GetComponent<Button>().onClick.AddListener(OnClick3);
                locker_button[4].GetComponent<Button>().onClick.AddListener(OnClick4);
                locker_button[5].GetComponent<Button>().onClick.AddListener(OnClick5);
                locker_button[6].GetComponent<Button>().onClick.AddListener(OnClick6);
                locker_button[7].GetComponent<Button>().onClick.AddListener(OnClick7);
                locker_button[8].GetComponent<Button>().onClick.AddListener(OnClick8);
                locker_button[9].GetComponent<Button>().onClick.AddListener(OnClick9);
                Debug.Log(locker_b);
                if(locker_b =="31289")
                {
                    locker2.SetActive(false);
                    tip.SetActive(true);
                    T.text="获得了一张纸条";
                }
                else if(count==5)
                {
                    count=0;
                    for(int i=0;i<10;i++)
                    {
                        flag[i]=false;
                    }
                    locker_b="";
                    T.text="密码错误";
                }
            }break; 
            case 3:
            {
                Debug.Log("inputfield");
                //string textValue = GameObject.FindGameObjectsWithTag("computer2Input").GetComponent<InputField>().text;
                //transform.GetComponent<InputField>().onValueChanged.AddListener(ChangedValue);//用户输入文本时就会调用
                //transform.GetComponent<InputField>().onEndEdit.AddListener(EndValue);//文本输入结束时会调用
                GameObject inputFieldGo = GameObject.Find("InputField2");
                InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();
                Debug.Log(inputFieldCo.text);
                if(inputFieldCo.text == "806393")
                {
                    opencomputer2 = true;
                    computer_password2.SetActive(false);
                    computer2_desktop.SetActive(true);
                    mode = 4;
                }
                else
                {
                    T.text = "密码错误";
                }
                
            }break;
            case 4:
            {
                
            }break;
            case 5://1衣柜
            {
                if (Input.GetMouseButtonDown(0))
                {
                    //Debug.Log(TAG+"点击鼠标左键");
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit))
                    {
                        //Debug.Log(hit.collider.gameObject.name);
                        obj = hit.collider.gameObject;
                        if( obj.name == "Book_shusuan")
                        {
                            moers.SetActive(true);
                        }
                        if(obj.name =="book_0001a")
                        {
                            lock_book.SetActive(true);
                            mode = 9;
                        }
                    }
                }
            }break;
            case 6://1抽屉
            {
                if (Input.GetMouseButtonDown(0))
                {
                    //Debug.Log(TAG+"点击鼠标左键");
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit))
                    {
                        //Debug.Log(hit.collider.gameObject.name);
                        obj = hit.collider.gameObject;
                        if( obj.name == "phone512")
                        {
                            obj.SetActive(false);
                            T.text = "得到一部手机";
                            phone_button.SetActive(true);
                        }
                    }
                }

            }break;
            case 7:
            {
                if(!click_four_girl)
                {
                    computer_password1.SetActive(true);
                    T.text="需要人脸识别";
                }
                else 
                {
                    computer1_desk.SetActive(true);
                }

            }break;
            case 8:
            {
                if(Input.GetMouseButtonDown(0))
                {
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit))
                    {
                        //Debug.Log(hit.collider.gameObject.name);
                        obj = hit.collider.gameObject;
                        if(obj.name == "Books(3)")
                        {
                            number.SetActive(true);
                        }
                    }
                }
            }break;
            case 9:
            {
                //Debug.Log("inputfield");
                //string textValue = GameObject.FindGameObjectsWithTag("computer2Input").GetComponent<InputField>().text;
                //transform.GetComponent<InputField>().onValueChanged.AddListener(ChangedValue);//用户输入文本时就会调用
                //transform.GetComponent<InputField>().onEndEdit.AddListener(EndValue);//文本输入结束时会调用
                GameObject inputFieldGo3 = GameObject.Find("InputField3");
                InputField inputFieldCo3 = inputFieldGo3.GetComponent<InputField>();
                Debug.Log(inputFieldCo3.text);
                if(inputFieldCo3.text == "0711")
                {
                    lock_book_pic.SetActive(true);
                    lock_book.SetActive(false);
                    mode = 10;
                }
                else
                {
                    T.text = "密码错误";
                }
            }break;
            case 10:
            {

            }break;
            default:
            {
                Debug.Log("default");
            }break;
        
        }
    }
}

