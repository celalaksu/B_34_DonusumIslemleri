using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DonusumIslemleri
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DepthPage : ContentPage
    {
        public DepthPage()
        {
            InitializeComponent();

            for (int i = 0; i < Device.OnPlatform(12, 12, 18); i++) 
            { 
                grid.Children.Insert(0, new Label { TranslationX = i, TranslationY = -i }); 
            }
        }
    }
}