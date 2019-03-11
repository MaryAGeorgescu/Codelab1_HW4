using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//Usage: To put placed on a text that will change as the score changes
//Intent: To keep score of something 
public class KeepScore : MonoBehaviour
{

    public static int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(100,100,100,100), Score.ToString());
    }
}
