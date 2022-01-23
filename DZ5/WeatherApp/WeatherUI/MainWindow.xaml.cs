using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary;

namespace WeatherUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btn_Find_Click(object sender, RoutedEventArgs e)
        {
            string city = inputCity.Text;
            await WeatherAPI.GetWeather(city);
            txtShow.Text = WeatherAPI.final;
            var url = $"https://openweathermap.org/img/wn/{WeatherAPI.imgSc}@2x.png";
            BitmapImage icon = new BitmapImage();
            icon.BeginInit();
            icon.UriSource = new Uri(url);
            icon.EndInit();
            imageWeather.Source = icon;

        }
    }
}
