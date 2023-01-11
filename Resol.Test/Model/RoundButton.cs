using Resol.Test.Services;
using Resol.Test.ViewModels.Base;
using System.Windows.Input;
using System.Windows.Media;
using Resol.Test.Infrastructure.Commands;

namespace Resol.Test.Model
{
    internal class RoundButton
    {
        public string Id { get; private set; }
        
        public SolidColorBrush Color;

        public RoundButton(string id)
        {
            Id = id;
            Color = Generator.GetRandomColor();
        }
    }
}
