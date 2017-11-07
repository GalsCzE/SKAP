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
using System.Windows.Shapes;
using RestSharp;
using Skap.Entity;

namespace Skap
{
    /// <summary>
    /// Interakční logika pro Adde.xaml
    /// </summary>
    public partial class Adde : Window
    {
        public Adde()
        {
            InitializeComponent();
        }

        private void RUN()
        {
            User us = new User();
            us.slovo = word.Text;

            string url = "https://student.sps-prosek.cz/~sevcima14/4ITB/skapp/Insert.php";
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-contorl", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(us), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }

        private void pridat_Click(object sender, RoutedEventArgs e)
        {
            RUN();
            MessageBox.Show("Slovo přidáno do databáze!");

        }
    }
}
