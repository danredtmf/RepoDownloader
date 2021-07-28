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
    public partial class MainWindow : Form
    {
        string httpsTamplate = "https://";
        string domen;
        string repoLink;
        string repoDirs;
        string dropLink;
        string filename;

        ToolTip toolTip = new ToolTip();

        public MainWindow()
        {
            InitializeComponent();
        }

        void DragNDropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                hintLabel.Text = "Можете отпустить мышь";
                e.Effect = DragDropEffects.Copy;
            }
        }

        void DragNDropPanel_DragLeave(object sender, EventArgs e)
        {
            hintLabel.Text = "Перетащите ссылку сюда";
        }

        void DragNDropPanel_DragDrop(object sender, DragEventArgs e)
        {
            hintLabel.Text = "Перетащите ссылку сюда";

            dropLink = (string)e.Data.GetData(DataFormats.Text);
            linkBox.Text = dropLink;

            domen = new Uri(dropLink).Host;
        }

        void DragNDropPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2)
            {
                DashPattern = new float[] { 2, 2 }
            };
            dragNDropPanel.CreateGraphics().DrawRectangle(pen, 1, 1, dragNDropPanel.Width - 2, dragNDropPanel.Height - 2);
        }

        void DownloadButton_Click(object sender, EventArgs e)
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
                    GetLinkAsync(url, "d-flex flex-items-center color-text-primary text-bold no-underline p-3");
                }
                else if (domen == "gitlab.com")
                {
                    GetLinkAsync(url, "gl-button btn btn-sm btn-confirm");
                }
            }
        }

        async void GetLinkAsync(string url, string cssClass)
        {
            IConfiguration config = Configuration.Default.WithDefaultLoader();
            IDocument document = await BrowsingContext.New(config).OpenAsync(url);
            IEnumerable<IElement> aElement = document.All.Where(m => m.LocalName == "a"
                && m.ClassName == cssClass);
            repoLink = aElement.Last().GetAttribute("href");
            url = httpsTamplate + domen + repoLink;
            linkBox.Text = url;
            downloadButton.Enabled = false;

            filename = new Uri(url).Segments.Last();

            CreateRepoPath();
            DownloadFile(url);
        }

        void CreateRepoPath()
        {
            repoDirs = $@".\{domen}{Path.GetDirectoryName(repoLink)}";

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
                        downloadButton.Enabled = true;
                    };
                    downloadButton.Enabled = false;
                    wc.DownloadFileAsync(new Uri(url), $@"{repoDirs}\{filename}");
                }
                catch (WebException err)
                {
                    progressLabel.Text = err.Message;
                    Console.WriteLine(err.Response.Headers);
                }
            }
        }

        void LinkBox_MouseHover(object sender, EventArgs e)
        {
            if (linkBox.Text != "")
                toolTip.Show("Вы можете нажать на текст и с помощью стрелочек\nили клавишей Home/End перемещаться по тексту", window: linkBox);
        }
    }
}
