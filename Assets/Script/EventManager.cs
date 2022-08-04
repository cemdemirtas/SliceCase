using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public delegate void LevelWinDelegate();
    public static event LevelWinDelegate LevelWin;
    
    public delegate void LevelLoseDelegate();
    public static event LevelWinDelegate LevelLose;
}
