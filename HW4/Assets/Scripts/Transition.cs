using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public int nextScene;

    void OnGui()
    {
        GUI.Label(new Rect(Screen.width/2-50,Screen.height- 80, 100, 30), "Current Scene:"+ (Application.loadedLevel +1));
        if (GUI.Button(new Rect(Screen.width/2-50,Screen.height- 50, 100, 40), "Load Scene"+ (nextScene +1)))
        {
            Application.LoadLevel(nextScene);
            
            PlayerPrefs.SetFloat("Health", 25);
            int x = PlayerPrefs.GetInt("health");
        }
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
