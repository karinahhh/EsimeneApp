using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EsimeneApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new stepSlide();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
