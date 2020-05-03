using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DonusumIslemleri
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void translationPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TranslationPage());
        }

        private void textEffectsPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TextEffectsPage());
        }

        private void depthPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DepthPage());
        }

        private void scalePage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScalePage());
        }

        private void rotationPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RotationPage());
        }

       
    }
}
