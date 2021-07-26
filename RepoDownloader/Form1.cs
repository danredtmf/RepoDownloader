using AngleSharp;
using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepoDownloader
{
    public partial class Form1 : Form
    {
        string httpsTamplate = "https://";
        string domen;
        string repoLink;
        string repoDirs;
        string dropLink;
        string filename;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                hintLabel.Text = "Можете отпустить мышь";
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
            hintLabel.Text = "Перетащите ссылку сюда";
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            hintLabel.Text = "Перетащите ссылку сюда";

            dropLink = (string)e.Data.GetData(DataFormats.Text);
            linkBox.Text = dropLink;

            domen = new Uri(dropLink).Host;
        }

        async void panel1_Paint(object sender, PaintEventArgs e)
        {
            await Task.Run(async () =>
            {
                Pen pen = new Pen(Color.Black, 2);
                for (int i = 30; i > 2; i--, await Task.Delay(30))
                {
                    panel1.CreateGraphics().Clear(SystemColors.Control);
                    pen.DashPattern = new float[] { 2, i };
                    panel1.CreateGraphics().DrawRectangle(pen, 1, 1, panel1.Width - 2, panel1.Height - 2);
                }
            });
        }

        void button1_Click(object sender, EventArgs e)
        {
            string url = dropLink;
            progressLabel.Text = "";
            progressBar1.Value = 0;
            if (url == "")
            {
                progressLabel.Text = "Невозможно загрузить, вы не указали ссылку";
                return;
            } else
            {
                if (domen == "github.com")
                {
                    GetLinkAsync(url);
                }
            }
        }

        async void GetLinkAsync(string url)
        {
            IConfiguration config = Configuration.Default.WithDefaultLoader();
            IDocument document = await BrowsingContext.New(config).OpenAsync(url);
            IEnumerable<IElement> aElement = document.All.Where(m => m.LocalName == "a"
                && m.ClassName == "d-flex flex-items-center color-text-primary text-bold no-underline p-3");
            repoLink = aElement.Last().GetAttribute("href");
            url = httpsTamplate + domen + repoLink;
            linkBox.Text = url;
            button1.Enabled = false;

            filename = new Uri(url).Segments.Last();

            CreateRepoPath();
            DownloadFile(url);
        }

        void CreateRepoPath()
        {
            repoDirs = $@".\{domen}{Path.GetDirectoryName(repoLink)}";
            Console.WriteLine($@"{repoDirs}\{filename}");
            if (!Directory.Exists(repoDirs))
            {
                Directory.CreateDirectory(repoDirs);
            }
        }

        void DownloadFile(string url)
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    wc.DownloadProgressChanged += (s, e) =>
                    {
                        progressLabel.Text =
                        $"\nПрогресс: {e.ProgressPercentage}% ({((double)e.BytesReceived / 1024).ToString("# КБ")})";
                        progressBar1.Value = e.ProgressPercentage;
                    };
                    wc.DownloadFileCompleted += (s, e) =>
                    {
                        button1.Enabled = true;
                    };
                    button1.Enabled = false;
                    wc.DownloadFileAsync(new Uri(url), $@"{repoDirs}\{filename}");
                }
                catch (WebException err)
                {
                    progressLabel.Text = err.Message;
                    Console.WriteLine(err.Response.Headers);
                }
            }
        }
    }
}
