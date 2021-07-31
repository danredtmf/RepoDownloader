namespace RepoDownloader
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dragNDropPanel = new System.Windows.Forms.Panel();
            this.hintLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.linkBox = new System.Windows.Forms.RichTextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.dragNDropPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragNDropPanel
            // 
            this.dragNDropPanel.AllowDrop = true;
            this.dragNDropPanel.BackColor = System.Drawing.SystemColors.Control;
            this.dragNDropPanel.Controls.Add(this.hintLabel);
            this.dragNDropPanel.Location = new System.Drawing.Point(12, 39);
            this.dragNDropPanel.Name = "dragNDropPanel";
            this.dragNDropPanel.Padding = new System.Windows.Forms.Padding(10);
            this.dragNDropPanel.Size = new System.Drawing.Size(460, 114);
            this.dragNDropPanel.TabIndex = 0;
            this.dragNDropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragNDropPanel_DragDrop);
            this.dragNDropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragNDropPanel_DragEnter);
            this.dragNDropPanel.DragLeave += new System.EventHandler(this.DragNDropPanel_DragLeave);
            this.dragNDropPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DragNDropPanel_Paint);
            // 
            // hintLabel
            // 
            this.hintLabel.BackColor = System.Drawing.SystemColors.Control;
            this.hintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hintLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hintLabel.Location = new System.Drawing.Point(10, 10);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(440, 94);
            this.hintLabel.TabIndex = 0;
            this.hintLabel.Text = "Перетащите ссылку сюда";
            this.hintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadButton.Location = new System.Drawing.Point(169, 311);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(146, 38);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Скачать";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 282);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(456, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressLabel.Location = new System.Drawing.Point(12, 177);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 17);
            this.progressLabel.TabIndex = 4;
            // 
            // linkBox
            // 
            this.linkBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linkBox.DetectUrls = false;
            this.linkBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkBox.Location = new System.Drawing.Point(15, 159);
            this.linkBox.Multiline = false;
            this.linkBox.Name = "linkBox";
            this.linkBox.ReadOnly = true;
            this.linkBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.linkBox.Size = new System.Drawing.Size(457, 17);
            this.linkBox.TabIndex = 5;
            this.linkBox.Text = "";
            this.linkBox.MouseHover += new System.EventHandler(this.LinkBox_MouseHover);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(355, 20);
            this.searchBox.TabIndex = 6;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(373, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(99, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.dragNDropPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepoDownloader";
            this.dragNDropPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dragNDropPanel;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.RichTextBox linkBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
    }
}

