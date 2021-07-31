using AngleSharp;
using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepoDownloader
{
    public partial class SearchWindow : Form
    {
        MainWindow main;
        string searchText = "";
        uint page = 1;
        const byte FirstPage = 1;
        uint maxPage;

        public SearchWindow(string search, MainWindow mainWindow)
        {
            InitializeComponent();
            searchText = search;
            searchBox.Text = searchText;
            main = mainWindow;

            SearchRepo();
        }

        void LogicPage()
        {
            pageLabel.Text = page.ToString();
            if (page == 1 && maxPage != 1)
            {
                firstPageButton.Enabled = false;
                previousPageButton.Enabled = false;
                nextPageButton.Enabled = true;
                lastPageButton.Enabled = true;
            }
            else if (page > 1 && page < maxPage)
            {
                firstPageButton.Enabled = true;
                previousPageButton.Enabled = true;
                nextPageButton.Enabled = true;
                lastPageButton.Enabled = true;
            }
            else if (page > 1 && page == maxPage)
            {
                firstPageButton.Enabled = true;
                previousPageButton.Enabled = true;
                nextPageButton.Enabled = false;
                lastPageButton.Enabled = false;
            }
            else if (page == 1 && maxPage == 0)
            {
                firstPageButton.Enabled = false;
                previousPageButton.Enabled = false;
                nextPageButton.Enabled = false;
                lastPageButton.Enabled = false;
            }
        }

        void SearchRepo()
        {
            firstPageButton.Enabled = false;
            previousPageButton.Enabled = false;
            nextPageButton.Enabled = false;
            lastPageButton.Enabled = false;

            if (searchBox.Text == "")
                return;
            else
            {
                if (searchText != searchBox.Text)
                {
                    searchText = searchBox.Text;
                    page = 1;
                }
            }

            SearchItem();
        }

        async void SearchItem()
        {
            repoTable.Rows.Clear();

            List<string> repoName = new List<string>();
            List<string> repoDisc = new List<string>();
            List<string> repoStar = new List<string>();
            List<string> repoLang = new List<string>();

            IConfiguration config = Configuration.Default.WithDefaultLoader();
            IDocument document = await BrowsingContext.New(config)
                    .OpenAsync($"https://github.com/search?p={page}&q={searchText}&type=Repositories");

            IEnumerable<IElement> IRepo = document.All.Where(m => m.LocalName == "li"
                && m.ClassName == "repo-list-item hx_hit-repo d-flex flex-justify-start py-4 public source");

            if (document.QuerySelector("div.blankslate") != null)
            {
                MessageBox.Show("Ничего не найдено!");
                return;
            }

            foreach (IElement repo in IRepo)
            {
                string name = repo.QuerySelector("a.v-align-middle").GetAttribute("href");
                string disc = repo.QuerySelector("p.mb-1") == null ? "Нет"
                    : repo.QuerySelector("p.mb-1").Text().Trim();
                string stars = repo.QuerySelector("a.Link--muted") == null ? "Нет"
                    : repo.QuerySelector("a.Link--muted").Text().Trim();
                string lang = repo.QuerySelector("span[itemprop='programmingLanguage']") == null ? "Неизвестно"
                    : repo.QuerySelector("span[itemprop='programmingLanguage']").Text().Trim();

                repoName.Add(name);
                repoDisc.Add(disc);
                repoStar.Add(stars);
                repoLang.Add(lang);
            }

            IElement currentPageElement = document.QuerySelector("em.current");
            if (currentPageElement == null)
            {
                maxPage = 1;
            }
            else
            {
                bool result = UInt32.TryParse(
                    document.QuerySelector("em.current").GetAttribute("data-total-pages"), 
                    out maxPage);
                if (result)
                {
                    Console.WriteLine("Преобразование выполнено успешно!");
                }
                else
                {
                    Console.WriteLine("Преобразование не выполнено!");
                    maxPage = 1;
                }
            }

            document.Dispose();

            InsertRepo(repoName, repoDisc, repoStar, repoLang);
        }

        void InsertRepo(List<string> repoName, List<string> repoDisc, List<string> repoStar, List<string> repoLang)
        {
            byte lengthRepo = (byte)repoName.Count;

            for (byte i = 0; i < lengthRepo - 1; i++)
                repoTable.Rows.Add(repoName[i], repoDisc[i], repoStar[i], repoLang[i], "Выбрать");

            LogicPage();
        }

        string GetRepoLink(string repoName)
        {
            return $"https://github.com{repoName}";
        }

        void SearchButton_Click(object sender, EventArgs e)
        {
            SearchRepo();
        }

        private void RepoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                main.SetLink(GetRepoLink(repoTable.Rows[e.RowIndex].Cells[0].Value.ToString()));
                main.Select();
            }
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchRepo();
        }

        private void FirstPageButton_Click(object sender, EventArgs e)
        {
            page = FirstPage;
            SearchRepo();
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            --page;
            SearchRepo();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            ++page;
            SearchRepo();
        }

        private void LastPageButton_Click(object sender, EventArgs e)
        {
            page = maxPage;
            SearchRepo();
        }
    }
}
