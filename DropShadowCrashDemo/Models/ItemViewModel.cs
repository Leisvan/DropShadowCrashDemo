using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace DropShadowCrashDemo.Models
{
    public class ItemViewModel
    {
        private static Random random = new Random();
        public Brush ColorBrush { get; set; }
        public ItemViewModel()
        {
            ColorBrush = new SolidColorBrush(new Color
            {
                R = (byte)random.Next(byte.MaxValue),
                G = (byte)random.Next(byte.MaxValue),
                B = (byte)random.Next(byte.MaxValue),
                A = byte.MaxValue,
            });
        }
    }
}
