using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class interact1 : intact
{
    private string name="Å®Î×";
    public dialogCON dialogcon;
    private string[] str1;

    private void Start()
    {
        string path = Application.dataPath + "/font/" + name + ".txt";
        StreamReader sr = new StreamReader(path);
        string str = sr.ReadToEnd();
        str1 = str.Split("\n");
    }
    public override void act()
    {
        dialogcon.Show(name, str1);
    }
}
