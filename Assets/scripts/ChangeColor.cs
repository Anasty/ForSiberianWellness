using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    GameObject panelB;
    GameObject cam;
    // Start is called before the first frame update

    void Start()
    {
        panelB = GameObject.Find("PanelB");
        for (int i = 0; i < panelB.transform.childCount - 1; i++)
            {
                panelB.transform.GetChild(i).transform.GetChild(0).gameObject.SetActive(false);
            }
        panelB.gameObject.SetActive(false);
            cam = GameObject.Find("MainCamera");
    }

    public void Color(GameObject button) {
        GameObject Obj = cam.transform.parent.gameObject;
        Obj.GetComponent<Renderer>().material.color = button.GetComponent<Image>().color;
        button.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void CheckActiveColor()
    {       
        GameObject Obj = cam.transform.parent.gameObject;
        Color colorObj = Obj.GetComponent<Renderer>().material.color;
        for (int i = 0; i < panelB.transform.childCount - 1; i++)
        {
            if(colorObj == panelB.transform.GetChild(i).GetComponent<Image>().color)
            {
                panelB.transform.GetChild(i).transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }

}
