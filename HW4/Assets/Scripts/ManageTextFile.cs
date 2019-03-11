using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class ManageTextFile : MonoBehaviour
{

    static void ReadString()
    {
        string path = "Assets/Resources/test.txt";
        StreamReader reader = new StreamReader(path); 
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

}