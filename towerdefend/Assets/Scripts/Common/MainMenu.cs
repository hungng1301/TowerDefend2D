using Assets.Scripts.Level;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Main menu operate.
/// </summary>
public class MainMenu : MonoBehaviour
{
    private Invoker invoker;

    private void Awake()
    {
        invoker = new Invoker();
    }
    public void OnStartButtonClick()
    {
        invoker.SetCommand(new StartButtonCommand());
        invoker.Invoke();
    }

    public void OnQuitButtonClick()
    {
        invoker.SetCommand(new QuitButtonCommand());
        invoker.Invoke();
    }
}
