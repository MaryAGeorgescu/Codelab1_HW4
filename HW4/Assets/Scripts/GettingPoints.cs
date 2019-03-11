using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingPoints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "PlayerController")
        {
            KeepScore.Score += 100;
            Debug.Log("yea it werks");
        }
    }
}
