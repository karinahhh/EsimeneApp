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
                TextColor=Color.White,
                FontSize=25
            };
            Frame r = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = red,
                CornerRadius = 110,
                Margin = new Thickness(150,0,150,0)
            };
            Label yellow = new Label()
            {
                Text = "yellow",
                TextColor = Color.White,
                FontSize = 25
            };
            Frame y = new Frame()
            {
                BackgroundColor = Color.Yellow,
                Content = yellow,
                CornerRadius = 110,
                Margin = new Thickness(150, 0, 150, 0)
            };
            Label green = new Label()
            {
                Text = "green",
                TextColor = Color.White,
                FontSize = 25
            };
            Frame g = new Frame()
            {
                BackgroundColor = Color.Green,
                Content = green,
                CornerRadius = 110,
                Margin = new Thickness(150, 0, 150, 0)
            };
            Button on = new Button()
            {
                Text = "ВКЛ",
                BackgroundColor = Color.Blue,
                BorderWidth = 2,
                FontAttributes = FontAttributes.Bold
            };
            Button off = new Button()
            {
                Text = "ВЫКЛ",
                BackgroundColor = Color.Purple,
                BorderWidth = 2,
                FontAttributes = FontAttributes.Bold
            };



            StackLayout stackLayout = new StackLayout()
            {
                Children = { r, y, g}
            };
            stackLayout.Orientation = StackOrientation.Vertical;
            Content = stackLayout;

            StackLayout stackLayoutBtn = new StackLayout()
            {
                Children = { on, off}
            };
            stackLayoutBtn.Orientation = StackOrientation.Vertical;
            Content = stackLayoutBtn;

            StackOrientation stack = new StackLayout()
            {
                Children = {}
            };
            Content = stack;
        }
    }
}