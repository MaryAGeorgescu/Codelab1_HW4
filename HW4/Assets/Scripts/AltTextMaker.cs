using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; //use this whenever you're using a text file

public class AltTextMaker : MonoBehaviour
{
    void CreateText()
    {
        string path = Application.dataPath + "/Log.txt"; //path of file we created

        if (!File.Exists(path)) //create the file only if it doesn't exist
        {
            File.WriteAllText(path, "Login log \n\n");
            
        }

        string content = "Login date: " + System.DateTime.Now + "\n";
        
        File.AppendAllText(path,content);
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
