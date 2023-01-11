using System;
using System.Windows.Media;
using Color = System.Windows.Media.Color;

namespace Resol.Test.Services
{
    public static class Generator
    {
        public static SolidColorBrush GetRandomColor()
        {
            var _rnd = new Random();
            var b = new byte[3];
            _rnd.NextBytes(b);
            return new SolidColorBrush(Color.FromRgb(b[0], b[1], b[2]));
        }
    }
}
