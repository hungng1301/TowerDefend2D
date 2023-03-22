using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Level
{
    public class Invoker : MonoBehaviour
    {
        private ICommand curCommand;

        public void SetCommand(ICommand command)
        {
            this.curCommand = command;
        }

        public void Invoke()
        {
            curCommand.Execute();
        }
    }
}
