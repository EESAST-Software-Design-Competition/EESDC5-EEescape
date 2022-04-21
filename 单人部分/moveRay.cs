using UnityEngine;
using UnityEngine.UI;

public class moveRay : MonoBehaviour
{
    private string TAG = "ClickRayCastHitControl_";
    public Text T;  //将文本框拖入
    Ray ray;
    RaycastHit hit;
    GameObject obj;
    public ClickRayCastHitControl other;
    public Click2 other2;//联机的时候要删
    bool getkey = false;
    void Update()
    {
        
        int mode = other.GetMode();
        int mode2 =other2.GetMode();//联机的时候删掉
        getkey =other.getkeystation();
        if(mode == 0&&mode2 ==0){
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log(hit.collider.gameObject.name);
            obj = hit.collider.gameObject;
            //Debug.Log(TAG+"点中： name = " + obj.name+ "点中： tag = " + obj.tag);
            if (obj.tag == "diandianbook")
            {
                //Debug.Log("这是一本电电书");
                T.text = "这是一本电电书"; 
            }
            else if(obj.tag =="locker")
            {
                T.text = "一个收纳盒";
            }
            else if(obj.tag == "yi_gui2")
            {
                T.text = "没上锁的衣柜";
            }
            else if(obj.tag == "notebook2")
            {
                T.text = "一个日记本";
            }
            else if(obj.name == "laptop")
            {
                T.text = "一台未打开的电脑";
            }
            else if(obj.name =="Pillow(1)")
            {
                T.text = "可以移动的枕头";
            }
            else if(obj.name == "sm_key_01")
            {
                T.text ="一把钥匙";
            }
            else if(obj.name == "yi_gui_door(1)")
            {
                if(!getkey)
                {
                    T.text ="上锁的衣柜";
                }
                else
                {
                    T.text = "可以打开的衣柜";
                }
            }
            else if(obj.name == "phone512")
            {
                T.text = "一部没有解锁的手机";
            }
            else if(obj.name == "Plane_drawer (1)")
            {
                T.text = "一个抽屉";
            }
            else if(obj.name == "Book_shusuan")
            {
                T.text = "一本数算书";
            }
            else if(obj.name =="book_0001a")
            {
                T.text ="一个日记本";
            }
            else if(obj.name =="phone512")
            {
                T.text = "一部手机";
            }
            else if(obj.name == "Laptop(1)")
            {
                T.text = "一台电脑";
            }  
            else if(obj.name == "Closeof1")
            {
                T.text = "可以打开的桌边柜";
            }
            else if(obj.name == "Books(3)")
            {
                T.text = "急救手册";
            }
            else if(obj.name == "Book_shusuan")
            {
                T.text = "一本数算书";
            }
            else if(obj.name == "book_0001a")
            {
                T.text = "一个密码本";
            }
            else
            {
                T.text = " ";
            }
        }
        else 
        {
            T.text = " ";
        }
        }
        else 
        {
            T.text = " ";
        }
    }
}