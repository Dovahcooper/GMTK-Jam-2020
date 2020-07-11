using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //I know this is bad code bractice to call a function break, but I can't call it destroy in Unity
    //and essentially this is what the game requires the function to do
    public void Break()
    {
        Debug.Log("Interactable Destroyed");
        //put actual actions here in the morning, k fam?
    }
}
