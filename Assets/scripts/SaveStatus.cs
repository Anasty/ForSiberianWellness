using UnityEngine;
using System.IO;


public class SaveStatus : MonoBehaviour
{
    public GameObject panelB;

    string fileName = "SaveData";

    void Start()
    {
        if (File.Exists(Application.dataPath + "/Saves/" + fileName + ".fsw"))
        {
            string[] rows = File.ReadAllLines(Application.dataPath + "/Saves/" + fileName + ".fsw");
            int namberRow = 0;
            for (int i = 0; i < this.gameObject.transform.childCount; i++)
            {

                this.gameObject.transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(float.Parse(rows[namberRow++]), float.Parse(rows[namberRow++]), float.Parse(rows[namberRow++]), float.Parse(rows[namberRow++]));
            }
        }
    }
    
    private void OnApplicationQuit()
    { 
        Directory.CreateDirectory(Application.dataPath + "/Saves");
        StreamWriter sw = new StreamWriter(Application.dataPath + "/Saves/" + fileName + ".fsw");       
        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            sw.WriteLine(this.gameObject.transform.GetChild(i).GetComponent<Renderer>().material.color.r);
            sw.WriteLine(this.gameObject.transform.GetChild(i).GetComponent<Renderer>().material.color.g);
            sw.WriteLine(this.gameObject.transform.GetChild(i).GetComponent<Renderer>().material.color.b);
            sw.WriteLine(this.gameObject.transform.GetChild(i).GetComponent<Renderer>().material.color.a);
        }

        sw.Close();
    }
    
    public void Exit()
    { 
        Application.Quit();
    }
    
}
