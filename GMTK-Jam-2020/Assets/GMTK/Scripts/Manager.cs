using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    FIRST = 0,
    SECOND, 
    THIRD, 
    FOURTH, 
    FIFTH, 
    SIXTH, 
    SEVENTH, 
    EIGHTH, 
    WIN, 
    LOSE
}

public class Manager : MonoBehaviour
{
    public GameState currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = GameState.FIRST;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Win()
    {

    }
}
