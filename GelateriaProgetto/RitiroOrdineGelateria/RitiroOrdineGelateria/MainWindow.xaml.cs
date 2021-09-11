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

namespace RitiroOrdineGelateria
{
    public partial class MainWindow : Window
    {
        string ultimoCodice = "";
        Ordine ordine = new Ordine();
        Ordini ordini = new Ordini();
        public MainWindow()
        {
            InitializeComponent();
            ordini.caricaLista("E:\\Andrea Scuola\\Informatica\\C#\\GelateriaProgetto\\gelateria\\ordini.txt");           
        }

        private void camSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            webCam.CameraIndex = camSelect.SelectedIndex;
        }
        private void QrWebCamControl_QrDecoded(object sender, string e)
        {
            if (ultimoCodice == e)
            {

            }
            else
            {
                ultimoCodice = e;
                string s = "";
                for (int i = e.Length - 1; i >= 0; i--)
                {
                    s += e.ElementAt(i);
                }
                string[] split = s.Split(' ');
                string stringagusto = "";
                if (split[2] == "cio")
                {
                    stringagusto = "cioccolato";
                }
                else if (split[2] == "van")
                {
                    stringagusto = "vaniglia";
                }
                else if (split[2] == "str")
                {
                    stringagusto = "stracciatella";
                }
                else if (split[2] == "fio")
                {
                    stringagusto = "fiordilatte";
                }
                else if (split[2] == "men")
                {
                    stringagusto = "menta";
                }
                else if (split[2] == "noc")
                {
                    stringagusto = "nocciola";
                }
                else if (split[2] == "cre")
                {
                    stringagusto = "crema";
                }
                else if (split[2] == "zab")
                {
                    stringagusto = "zabaione";
                }
                for (int i = 0; i < ordini.ordini.Count; i++)
                {
                    if (ordini.ordini.ElementAt(i).nome.Substring(0, 3) == split[0])
                        if (ordini.ordini.ElementAt(i).cognome.Substring(0, 3) == split[1])
                            if (ordini.ordini.ElementAt(i).gusto.Substring(0, 3) == split[2])
                                ordini.delOrdine(i);
                }
                ordini.salvaLista("E:\\Andrea Scuola\\Informatica\\C#\\GelateriaProgetto\\gelateria\\ordini.txt");
                MessageBox.Show("ordine gelato al gusto " + stringagusto + "appena ritirato!, alla prossima!");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            camSelect.ItemsSource = webCam.CameraNames;
        }
    }
}
