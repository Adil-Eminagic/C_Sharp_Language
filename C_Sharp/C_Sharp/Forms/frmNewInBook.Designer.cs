namespace C_Sharp.Forms
{
    partial class frmNewInBook
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTitle = new TextBox();
            txtPubYear = new TextBox();
            cmbAuthor = new ComboBox();
            btnAddBook = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(121, 32);
            label1.Name = "label1";
            label1.Size = new Size(227, 57);
            label1.TabIndex = 0;
            label1.Text = "New book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 131);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 214);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 2;
            label3.Text = "Publishing year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 283);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Author";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(175, 128);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(237, 27);
            txtTitle.TabIndex = 4;
            // 
            // txtPubYear
            // 
            txtPubYear.Location = new Point(175, 211);
            txtPubYear.Name = "txtPubYear";
            txtPubYear.Size = new Size(235, 27);
            txtPubYear.TabIndex = 5;
            // 
            // cmbAuthor
            // 
            cmbAuthor.FormattingEnabled = true;
            cmbAuthor.Location = new Point(175, 280);
            cmbAuthor.Name = "cmbAuthor";
            cmbAuthor.Size = new Size(235, 28);
            cmbAuthor.TabIndex = 6;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(302, 383);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(110, 29);
            btnAddBook.TabIndex = 7;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // frmNewInBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            Controls.Add(btnAddBook);
            Controls.Add(cmbAuthor);
            Controls.Add(txtPubYear);
            Controls.Add(txtTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNewInBook";
            Text = "frmNewInBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTitle;
        private TextBox txtPubYear;
        private ComboBox cmbAuthor;
        private Button btnAddBook;
    }
}