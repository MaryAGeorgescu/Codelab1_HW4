using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void on GUI()
    {
       GUILayout.Label(txtContents);
    }
}
