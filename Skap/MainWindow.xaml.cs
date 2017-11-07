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
using Skap.Entity;
using Skap.Interface;
using Skap.Jsson;
using RestSharp;
using Newtonsoft.Json;

namespace Skap
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetUserListAsync();
        }

        public async Task GetUserListAsync()
        {
            try
            {
                string url = "https://student.sps-prosek.cz/~sevcima14/4ITB/skapp/dotaz.php";
                var client = new RestClient(url);
                var request = new RestRequest("resource/{id}", Method.POST);
                request.AddHeader("header", "value");
                IRestResponse response = client.Execute(request);
                IParser parser = new JsonParse();
                MistView.ItemsSource = await parser.ParseStringAsync<List<User>>(response.Content);
            }
            catch
            {
                MessageBox.Show("Problém s připojením!");
            }
        }

        private void Addd_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow windowss = new NavigationWindow();
            windowss.Source = new Uri("Adde.xaml", UriKind.Relative);
            windowss.Show();
        }
    }
}
