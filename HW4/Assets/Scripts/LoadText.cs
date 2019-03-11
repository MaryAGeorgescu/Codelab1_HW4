using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Usage: leave as a script.
//Intent: To just display text from a text file.
public class LoadText : MonoBehaviour
{
    public string txtfile = "test";

    private string txtContents;
    
    
    // Start is called before the first frame update
    void Start()
    {
        TextAsset txtAssets = (TextAsset) Resources.Load("txtfile");
        txtContents = txtAssets.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
       GUILayout.Label(txtContents);
    }
}
