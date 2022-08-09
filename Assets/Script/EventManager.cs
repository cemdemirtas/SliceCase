using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public  class EventManager: MonoBehaviour
{
    public static EventManager instance;

    public delegate void LevelWinDelegate();
    
    public delegate void LevelLoseDelegate();
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
