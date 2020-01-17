using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour
{
    [SerializeField] GameObject ObjForView;

    GameObject cam;
    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {        
        cam = GameObject.Find("MainCamera");
        startPosition = cam.transform.position;
    }

    // Update is called once per frame
    public void ObjectView()
    {
        cam.transform.SetParent(ObjForView.transform);
        cam.transform.localPosition = new Vector3(0.1f, 1.1f, -2.3f);     
    }

    public void MainView() {
        cam.transform.SetParent(null);
        cam.transform.localPosition = new Vector3();
        cam.transform.position = startPosition;
    }

}
