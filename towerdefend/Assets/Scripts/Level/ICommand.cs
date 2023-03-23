using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Level
{
    public interface ICommand
    {
        void Execute();
    }

    public class StartButtonCommand : ICommand
    {
        public void Execute()
        {
            SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
        }
    }

    public class PauseButtonCommand : ICommand
    {
        public void Execute()
        {
            Time.timeScale = 0;
        }
    }

    public class ResumeButtonCommand : ICommand
    {
        public void Execute()
        {
            Time.timeScale = 1;
        }
    }

    public class RestartButtonCommand : ICommand
    {
        public void Execute()
        {
            string activeScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(activeScene, LoadSceneMode.Single);
        }
    }

    public class BackButtonCommand : ICommand
    {
        public void Execute()
        {
            SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
        }
    }

    public class QuitButtonCommand : ICommand
    {
        public void Execute()
        {
            Application.Quit();
        }
    }
}
