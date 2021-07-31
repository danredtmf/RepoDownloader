namespace RepoDownloader
{
    partial class SearchWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.repoTable = new System.Windows.Forms.DataGridView();
            this.repoNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repoDiscColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repoStarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repoLangColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repoLinkColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.firstPageButton = new System.Windows.Forms.Button();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.lastPageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.repoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(13, 13);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(661, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(680, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // repoTable
            // 
            this.repoTable.AllowUserToAddRows = false;
            this.repoTable.AllowUserToDeleteRows = false;
            this.repoTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.repoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repoNameColumn,
            this.repoDiscColumn,
            this.repoStarColumn,
            this.repoLangColumn,
            this.repoLinkColumn});
            this.repoTable.Location = new System.Drawing.Point(13, 40);
            this.repoTable.Name = "repoTable";
            this.repoTable.ReadOnly = true;
            this.repoTable.Size = new System.Drawing.Size(759, 371);
            this.repoTable.TabIndex = 2;
            this.repoTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RepoTable_CellContentClick);
            // 
            // repoNameColumn
            // 
            this.repoNameColumn.HeaderText = "Репозиторий";
            this.repoNameColumn.Name = "repoNameColumn";
            this.repoNameColumn.ReadOnly = true;
            this.repoNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.repoNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // repoDiscColumn
            // 
            this.repoDiscColumn.HeaderText = "Описание";
            this.repoDiscColumn.Name = "repoDiscColumn";
            this.repoDiscColumn.ReadOnly = true;
            // 
            // repoStarColumn
            // 
            this.repoStarColumn.HeaderText = "Звёзды";
            this.repoStarColumn.Name = "repoStarColumn";
            this.repoStarColumn.ReadOnly = true;
            // 
            // repoLangColumn
            // 
            this.repoLangColumn.HeaderText = "Язык";
            this.repoLangColumn.Name = "repoLangColumn";
            this.repoLangColumn.ReadOnly = true;
            // 
            // repoLinkColumn
            // 
            this.repoLinkColumn.HeaderText = "Ссылка";
            this.repoLinkColumn.Name = "repoLinkColumn";
            this.repoLinkColumn.ReadOnly = true;
            // 
            // firstPageButton
            // 
            this.firstPageButton.Enabled = false;
            this.firstPageButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstPageButton.Location = new System.Drawing.Point(13, 417);
            this.firstPageButton.Name = "firstPageButton";
            this.firstPageButton.Size = new System.Drawing.Size(44, 32);
            this.firstPageButton.TabIndex = 3;
            this.firstPageButton.Text = "<<";
            this.firstPageButton.UseVisualStyleBackColor = true;
            this.firstPageButton.Click += new System.EventHandler(this.FirstPageButton_Click);
            // 
            // previousPageButton
            // 
            this.previousPageButton.Enabled = false;
            this.previousPageButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previousPageButton.Location = new System.Drawing.Point(63, 417);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(44, 32);
            this.previousPageButton.TabIndex = 4;
            this.previousPageButton.Text = "<";
            this.previousPageButton.UseVisualStyleBackColor = true;
            this.previousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageLabel.Location = new System.Drawing.Point(113, 423);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(64, 23);
            this.pageLabel.TabIndex = 5;
            this.pageLabel.Text = "1";
            this.pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextPageButton
            // 
            this.nextPageButton.Enabled = false;
            this.nextPageButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextPageButton.Location = new System.Drawing.Point(183, 417);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(44, 32);
            this.nextPageButton.TabIndex = 6;
            this.nextPageButton.Text = ">";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // lastPageButton
            // 
            this.lastPageButton.Enabled = false;
            this.lastPageButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastPageButton.Location = new System.Drawing.Point(233, 417);
            this.lastPageButton.Name = "lastPageButton";
            this.lastPageButton.Size = new System.Drawing.Size(44, 32);
            this.lastPageButton.TabIndex = 7;
            this.lastPageButton.Text = ">>";
            this.lastPageButton.UseVisualStyleBackColor = true;
            this.lastPageButton.Click += new System.EventHandler(this.LastPageButton_Click);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lastPageButton);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.previousPageButton);
            this.Controls.Add(this.firstPageButton);
            this.Controls.Add(this.repoTable);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Name = "SearchWindow";
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.repoTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView repoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn repoNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repoDiscColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repoStarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repoLangColumn;
        private System.Windows.Forms.DataGridViewButtonColumn repoLinkColumn;
        private System.Windows.Forms.Button firstPageButton;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button lastPageButton;
    }
}