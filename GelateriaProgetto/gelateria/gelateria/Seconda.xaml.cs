using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

namespace gelateria
{
    /// <summary>
    /// Logica di interazione per Seconda.xaml
    /// </summary>
    public partial class Seconda : Window
    {
        Ordine ordine = new Ordine();
        Ordini ordini = new Ordini();

        Bitmap qrCodeImage;
        QRCodeGenerator qrGenerator;
        QRCodeData qrCodeData;
        BitmapImage BitmapToImageSouce(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }
        public Seconda(Ordini ordini1)
        {
            InitializeComponent();
            ordini = ordini1;
            ordine = ordini.ordini.ElementAt(ordini.ordini.Count-1);
            nome.Content = ordine.nome;
            cognome.Content = ordine.cognome;
            gelato.Content = ordine.gelato;
            qrGenerator = new QRCodeGenerator();
            qrCodeData = qrGenerator.CreateQrCode(this.ordine.codice, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            qrCodeImage = qrCode.GetGraphic(20);
            qr.Source = BitmapToImageSouce(qrCodeImage);            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(ordini);
            MessageBox.Show("Grazie ad alla prossima!");
            this.Hide();
            mainWindow.Show();
        }
    }
}
