using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Forecast.Weather
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GetWeather(object sender, EventArgs e)
        {
            foreach(var element in container.Children) 
            {
                if (element.IsVisible)
                {
                    element.IsVisible = false;
                }
                else
                {
                    element.IsVisible = true;
                }
            }
            container.BackgroundColor = Color.Black;

            ////удаление из контейнера
            //foreach(var element in container.Children.ToList())
            //{
            //    container.Children.Remove(element);
            //}
            ////или стирание значений
            //if(title != null)
            //{
            //    title.Text = "";   
            //}
            //if(getWeather != null)
            //{
            //    getWeather.Text = "";
            //    getWeather.BackgroundColor = Color.Transparent;
            //}
        }
    }
}
