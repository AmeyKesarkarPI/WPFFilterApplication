using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFFilterApplication
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action cmd;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public RelayCommand(Action cmd)
        {
            this.cmd = cmd;
        }

        public void Execute(object parameter)
        {
            cmd?.Invoke();
        }
    }
}
