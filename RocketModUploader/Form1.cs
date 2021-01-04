using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace RocketModUploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gunaLineTextBox1.Enabled = false;
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click_1(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(gunaLineTextBox1.Text);
            info.CopyTo($@"{Application.StartupPath}\" + $@"{gunaLineTextBox2.Text}.dll");

            UploadFtpFile("ip", $@"{Application.StartupPath}\{gunaLineTextBox2.Text}.dll", "ftpusername", "ftppassword");

            MessageBox.Show($"Lisans eklendi, eklenen lisans kodu: {gunaLineTextBox2.Text}", "Plugin Uploader", MessageBoxButtons.OK, MessageBoxIcon.Information);

             File.Delete($@"{Application.StartupPath}\{gunaLineTextBox2.Text}.dll");
        }

        public static Task UploadFtpFile(string Server, string DosyaAdi, string KullaniciAdi, string Sifre)
        {
            return Task.Run(() =>
            {
                FtpWebRequest request = null;
                try
                {
                    string SadeDosyaAdi = Path.GetFileName(DosyaAdi);
                    request = WebRequest.Create(new Uri($@"ftp://{Server}/{SadeDosyaAdi}")) as FtpWebRequest;
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.UseBinary = true;
                    request.UsePassive = true;
                    request.KeepAlive = true;
                    request.Credentials = new NetworkCredential(KullaniciAdi, Sifre);
                    request.ConnectionGroupName = "group";

                    using (FileStream fs = File.OpenRead(DosyaAdi))
                    {
                        byte[] buffer = new byte[fs.Length];
                        fs.Read(buffer, 0, buffer.Length);
                        fs.Close();
                        Stream requestStream = request.GetRequestStream();
                        requestStream.Write(buffer, 0, buffer.Length);
                        requestStream.Flush();
                        requestStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            });
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "DLL Dosyası |*.dll";
                file.ShowDialog();

            gunaLineTextBox1.Text = file.FileName;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public static void DeleteFtpFile(string Server, string DosyaAdi, string KullaniciAdi, string Sifre)
        {

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{Server}/{DosyaAdi}");
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                request.Credentials = new NetworkCredential(KullaniciAdi, Sifre);

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            }
            catch
            {
                throw;
            }
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            string FTPDosyaYolu = $"ftp://ftpadress/{gunaLineTextBox3.Text}.dll";
            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(FTPDosyaYolu);

            string username = "ftpusername";
            string password = "ftppassword";
            request.Credentials = new NetworkCredential(username, password);

            request.UsePassive = true; // pasif olarak kullanabilme
            request.UseBinary = true; // aktarım binary ile olacak
            request.KeepAlive = false; // sürekli açık tutma

            request.Method = WebRequestMethods.Ftp.GetFileSize;

            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                DeleteFtpFile("212.64.215.185", $"{gunaLineTextBox3.Text}.dll", "ftpusername", "ftppassword");
                MessageBox.Show($"Lisans Silindi, silinen lisans kodu: {gunaLineTextBox3.Text}", "RocketMod Uploader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (WebException ex)
            {
                MessageBox.Show($"Lisans Bulunamadı, silinmek istenen lisans kodu: {gunaLineTextBox3.Text}", "RocketMod Uploader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
