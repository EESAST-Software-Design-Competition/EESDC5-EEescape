using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit_button : MonoBehaviour
{
    public GameObject obje1;
    public GameObject maincamera;
    public GameObject notebookpicture2;
    public GameObject dian_lu;
    public GameObject subcamera;
    public GameObject yi_gui_door2;
    public GameObject Input_field;
    public GameObject computer2_desktop;
    public GameObject computer_paword2;
    public GameObject computer1_desktop;
    public GameObject computer_paword1;
    public GameObject wechat_picture;
    public ClickRayCastHitControl other;
    public GameObject drawer;
    public GameObject moers;
    public GameObject locker;
    public GameObject tip;
    public GameObject closeof1;
    public GameObject number;
    public GameObject yi_gui_door1;
    public GameObject lock_book;
    public GameObject lock_book_pic;
    public GameObject lock_UI;
    public GameObject unlock;
    public GameObject computer1_password;
    public void OnClick()
    {
        obje1.SetActive(false);
        notebookpicture2.SetActive(false);
        dian_lu.SetActive(false);
        Input_field.SetActive(false);
        Debug.Log("3");
        //GameObject.Find("MainCamera").SetActive(true);
        maincamera.SetActive(true);
        Debug.Log("345678");
        subcamera.SetActive(false);
        Vector3 Pos =new Vector3(-85.89893f,-137.3658f,-35f);
        yi_gui_door2.SetActive(true);
        yi_gui_door1.SetActive(true);
        computer2_desktop.SetActive(false);
        wechat_picture.SetActive(false);
        other.changemode(0);
        Pos=new Vector3(-4.55f,0.6724579f,1.28151f);
        drawer.transform.position = Pos;
        moers.SetActive(false);
        computer_paword2.SetActive(false);
        computer1_desktop.SetActive(false);
        computer_paword1.SetActive(false);
        locker.SetActive(false);
        tip.SetActive(false);
        closeof1.SetActive(true);
        number.SetActive(false);
        lock_book.SetActive(false);
        lock_book_pic.SetActive(false);
        unlock.SetActive(false);
        Debug.Log("11");
        lock_UI.SetActive(false);
        computer1_password.SetActive(false);

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
