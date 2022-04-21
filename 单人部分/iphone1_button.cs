using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class iphone1_button : MonoBehaviour
{
    // Start is called before the first frame update
    private bool open=false;
    public GameObject lock_UI;
    public GameObject unlock;
    public GameObject[] phone_button=new GameObject[10];
    public string secret;
    
    private bool[] flag = new bool[10]{false,false,false,false,false,false,false,false,false,false};
    private int count=0;
     private string lock_b="";
    void OnClick()
    {
        if(!open)
        {
            lock_UI.SetActive(true);
        }
        else
        {
            unlock.SetActive(true);
        }

    }
    public void OnClick1()
    {
        if(!flag[1])
        {
            lock_b+="1";
            flag[1]=true;
            count++;
        }
        //Debug.Log("input1");
    }
    public void OnClick2()
    {
        if(!flag[2])
        {
            lock_b+="2";
            flag[2]=true;
            count++;
        }
        //Debug.Log("input2");
    }
    public void OnClick3()
    {
        if(!flag[3])
        {
            lock_b+="3";
            flag[3]=true;
            count++;
        }
    }
    public void OnClick4()
    {
        if(!flag[4])
        {
            lock_b+="4";
            flag[4]=true;
            count++;
        }
    }
    public void OnClick5()
    {
        if(!flag[5])
        {
            lock_b+="5";
            flag[5]=true;
            count++;
        }
    }
    public void OnClick6()
    {
        if(!flag[6])
        {
            lock_b+="6";
            flag[6]=true;
            count++;
        }
    }
    public void OnClick7()
    {
        if(!flag[7])
        {
            lock_b+="7";
            flag[7]=true;
            count++;
        }
    }
    public void OnClick8()
    {
        if(!flag[8])
        {
            lock_b+="8";
            flag[8]=true;
            count++;
        }
    }
    public void OnClick9()
    {
        if(!flag[9])
        {
            lock_b+="9";
            flag[9]=true;
            count++;
        }
    }
    public void OnClick0()
    {
        if(!flag[0])
        {
            lock_b+="0";
            flag[0]=true;
            count++;
        }
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
        if(!open)
        {
            phone_button[0].GetComponent<Button>().onClick.AddListener(OnClick0);
            phone_button[1].GetComponent<Button>().onClick.AddListener(OnClick1);
            phone_button[2].GetComponent<Button>().onClick.AddListener(OnClick2);
            phone_button[3].GetComponent<Button>().onClick.AddListener(OnClick3);
            phone_button[4].GetComponent<Button>().onClick.AddListener(OnClick4);
            phone_button[5].GetComponent<Button>().onClick.AddListener(OnClick5);
            phone_button[6].GetComponent<Button>().onClick.AddListener(OnClick6);
            phone_button[7].GetComponent<Button>().onClick.AddListener(OnClick7);
            phone_button[8].GetComponent<Button>().onClick.AddListener(OnClick8);
            phone_button[9].GetComponent<Button>().onClick.AddListener(OnClick9);
            Debug.Log(lock_b);
            if(lock_b==secret)
            {
                open =true;
                lock_UI.SetActive(false);
                unlock.SetActive(true);
            }
            else if(count==6)
            {
                count=0;
                for(int i=0;i<10;i++)
                    {
                        flag[i]=false;
                    }
                lock_b="";
            }
        }
    }
}
