using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{
    public GameObject opendoor; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Object.FindFirstObjectByType<SoundManager>().PlayKeySound();
        Debug.Log("You collect the key!");
        Destroy(opendoor);
        Destroy(this.gameObject);
        
    }
}
