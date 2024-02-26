namespace C_Sharp.Forms
{
    partial class frmInMemoryBooks
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
            gridBooks = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            PublishingYear = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            btnFrmNewBook = new Button();
            ((System.ComponentModel.ISupportInitialize)gridBooks).BeginInit();
            SuspendLayout();
            // 
            // gridBooks
            // 
            gridBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBooks.Columns.AddRange(new DataGridViewColumn[] { ID, Title, PublishingYear, Author });
            gridBooks.Location = new Point(70, 52);
            gridBooks.Name = "gridBooks";
            gridBooks.RowHeadersWidth = 51;
            gridBooks.Size = new Size(625, 188);
            gridBooks.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 125;
            // 
            // PublishingYear
            // 
            PublishingYear.HeaderText = "PublishingYear";
            PublishingYear.MinimumWidth = 6;
            PublishingYear.Name = "PublishingYear";
            PublishingYear.Width = 125;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 125;
            // 
            // btnFrmNewBook
            // 
            btnFrmNewBook.Location = new Point(566, 321);
            btnFrmNewBook.Name = "btnFrmNewBook";
            btnFrmNewBook.Size = new Size(129, 29);
            btnFrmNewBook.TabIndex = 1;
            btnFrmNewBook.Text = "Add new book";
            btnFrmNewBook.UseVisualStyleBackColor = true;
            btnFrmNewBook.Click += btnFrmNewBook_Click;
            // 
            // frmInMemoryBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFrmNewBook);
            Controls.Add(gridBooks);
            Name = "frmInMemoryBooks";
            Text = "frmInMemoryBooks";
            ((System.ComponentModel.ISupportInitialize)gridBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridBooks;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn PublishingYear;
        private DataGridViewTextBoxColumn Author;
        private Button btnFrmNewBook;
    }
}