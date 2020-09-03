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
    public partial class Valgusfoor : ContentPage
    {
        public Valgusfoor()
        {
            InitializeComponent();
        }

        //int klik = 0;
        Random rnd = new Random();
        private void on_Clicked(object sender, EventArgs e)
        {
            /*
            klik++;
            if (klik == 1)
            {
                red.BackgroundColor=Color.FromHex("#DE1414");
            }
            else if (klik == 2)
            {
                yellow.BackgroundColor = Color.Yellow;
            }
            else if (klik == 3)
            {
                green.BackgroundColor = Color.Green;
            }
            */
            
            int c = rnd.Next(1, 4);
            if (c == 1)
            {
                red.BackgroundColor = Color.FromRgb(255, 0, 0);
                yellow.BackgroundColor = Color.FromHex("#363637");
                green.BackgroundColor = Color.FromHex("#363637");
            }
            else if (c == 2)
            {
                red.BackgroundColor = Color.FromHex("#363637");
                yellow.BackgroundColor = Color.FromRgb(255,255,0);
                green.BackgroundColor = Color.FromHex("#363637");
            }
            else
            {
                red.BackgroundColor = Color.FromHex("#363637");
                yellow.BackgroundColor = Color.FromHex("#363637");
                green.BackgroundColor = Color.FromRgb(0,255,0);
            }
        }

        private void off_Clicked(object sender, EventArgs e)
        {
            red.BackgroundColor = Color.FromHex("#363637");
            yellow.BackgroundColor = Color.FromHex("#363637");
            green.BackgroundColor = Color.FromHex("#363637");
        }
    }
}