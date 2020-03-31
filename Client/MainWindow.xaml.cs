using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Client
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

        private async void btnsomma_Click(object sender, RoutedEventArgs e)
        {
            double ris = 0;
            int a = Convert.ToInt32(txtn1.Text);
            int b = Convert.ToInt32(txtn2.Text);

            HttpClient client = new HttpClient();
            string uri = $"https://localhost:44320/api/operations/GetSomma?a={a}&b={b}";
             
            HttpResponseMessage risposta = await client.GetAsync(uri);
            string content = await risposta.Content.ReadAsStringAsync();
            ris = JsonConvert.DeserializeObject<int>(content);
            Dispatcher.Invoke(() => lblris.Content = ris);
        }
    }
}
