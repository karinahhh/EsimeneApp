using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EsimeneApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class stepSlide : ContentPage
    {
        Label red, green, blue;

        public stepSlide()
        {
            InitializeComponent();
            red = new Label()
            {

            };
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                
            }
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                Slider.Value = e.NewValue;
            }
        }

        private void Slider2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0) { 
            }
        }

        private void Slider3_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }
}