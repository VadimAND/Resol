using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using Resol.Test.Infrastructure.Commands;
using Resol.Test.Model;
using Resol.Test.Services;
using Resol.Test.ViewModels.Base;

namespace Resol.Test.ViewModels
{
    internal class RoundButtonViewModel: ViewModel
    {
        private RoundButton _button;

        public RoundButtonViewModel(string id)
        {
            _button = new RoundButton(id);
            SetRandomColorCommand = new RelayCommand(OnSetRandomColorCommandExecuted, CanSetRandomColorCommandExecute);
        }
        
        public SolidColorBrush Color
        {
            get => _button.Color;
            set
            {
                Set(ref _button.Color, value);
            }
        }

        public ICommand SetRandomColorCommand { get; }

        private bool CanSetRandomColorCommandExecute(object p)
        {
            return true;
        }

        private void OnSetRandomColorCommandExecuted(object p)
        {
            Color = Generator.GetRandomColor();
        }
    }
}
