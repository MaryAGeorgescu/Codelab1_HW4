using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
//to create a class that there can be only one of

{
    public static GameManager manager;
    public float endurance;

    public float humor;
    
    public float exhaustion;
    
    // Start is called before the first frame update
    void Awake()
    {
        //if there is no game controller make this the one and only game controller
        if (manager == null)

        {
            DontDestroyOnLoad(gameObject);
            manager =this
        }
        else if (manager!= this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
