using QRCoder;
using System;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace gelateria
{
    public partial class MainWindow : Window
    {
        Ordine ordine = new Ordine();
        Ordini ordini = new Ordini();

        public MainWindow(Ordini ordini1)
        {            
            InitializeComponent();
            combo1.Items.Add("cioccolato");
            combo1.Items.Add("vaniglia");
            combo1.Items.Add("stracciatella");
            combo1.Items.Add("fiordilatte");
            combo1.Items.Add("menta");
            combo1.Items.Add("nocciola");
            combo1.Items.Add("crema");
            combo1.Items.Add("zabaione");

            ordini = ordini1;
        }
        public MainWindow()
        {                        
            InitializeComponent();
            combo1.Items.Add("cioccolato");
            combo1.Items.Add("vaniglia");
            combo1.Items.Add("stracciatella");
            combo1.Items.Add("fiordilatte");
            combo1.Items.Add("menta");
            combo1.Items.Add("nocciola");
            combo1.Items.Add("crema");
            combo1.Items.Add("zabaione");
            ordini.caricaLista(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\ordini.txt");
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if ((text1.Text.Length < 3) || (text2.Text.Length < 3))
            {
                MessageBox.Show("il campo 'nome,cognome' deve essere composto da almeno 3 caratteri");
            }
            else
            {               
                
                this.ordine.nome = text1.Text;
                this.ordine.cognome = text2.Text;
                this.ordine.gelato = combo1.SelectedItem.ToString();
                this.ordine.generaCodice();
                ordini.ordini.Add(this.ordine);
                Seconda seconda = new Seconda(ordini);       
                ordini.salvaLista(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\ordini.txt");
                this.Hide();
                seconda.Show();                         
            }
        }
    }
}
