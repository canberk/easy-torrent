using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // çekme islemleri
            string aranilacak;
            string diziismi = dizi_isim_al.Text;
            string bolum = "s" + sezon_sayi_al.Text + "e" + bolum_sayi_al.Text;
            diziismi = diziismi.Replace(" ", "%20");
            if (sezon_sayi_al.Text == "" && bolum_sayi_al.Text == "")
            {
                aranilacak = diziismi;
            }
            else
            {
               aranilacak = diziismi + "%20" + bolum;
            }
           

           
            button1.Enabled = false;

            // internete erişim, internet verilerine ulaşma
            var request = WebRequest.Create("http://kickass.to/usearch/"+aranilacak);
            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = new StreamReader(new GZipStream(response.GetResponseStream(), CompressionMode.Decompress));
            var responseText = responseStream.ReadToEnd();
            string gelen=responseText;
            richTextBox1.Text = responseText;
            responseStream.Close();
            response.Close();
            int baslangic1=gelen.IndexOf("Torrent magnet link")+27;
            int bitis = gelen.IndexOf("class")-2;
            string cikis = gelen.Substring(baslangic1, 204);
            richTextBox1.Text = gelen.Substring(baslangic1, 204);

            button1.Enabled = true;
            System.Diagnostics.Process.Start(cikis);
        }
    }
}
