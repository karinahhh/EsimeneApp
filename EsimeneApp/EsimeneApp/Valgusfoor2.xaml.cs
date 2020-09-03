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
    public partial class Valgusfoor2 : ContentPage
    {
        public Valgusfoor2()
        {
            //InitializeComponent();
            Label red = new Label()
            {
                Text="red",
                TextColor=Color.Red,
                FontSize=25
            };
            Frame red = new Frame()
            {

            };
            Label yellow = new Label()
            {
                Text = "yellow",
                TextColor = Color.Yellow,
                FontSize = 25
            };
            Label green = new Label()
            {
                Text = "green",
                TextColor = Color.Green,
                FontSize = 25
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { red, yellow, green }
            };
            stackLayout.Orientation = StackOrientation.Horizontal;
            Content = stackLayout;
        }
    }
}