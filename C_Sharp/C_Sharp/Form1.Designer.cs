namespace C_Sharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnDelegate = new Button();
            btnInBooks = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(308, 32);
            label1.Name = "label1";
            label1.Size = new Size(189, 46);
            label1.TabIndex = 0;
            label1.Text = "Main menu";
            // 
            // btnDelegate
            // 
            btnDelegate.Location = new Point(163, 135);
            btnDelegate.Name = "btnDelegate";
            btnDelegate.Size = new Size(94, 29);
            btnDelegate.TabIndex = 1;
            btnDelegate.Text = "Delegates";
            btnDelegate.UseVisualStyleBackColor = true;
            btnDelegate.Click += btnDelegate_Click;
            // 
            // btnInBooks
            // 
            btnInBooks.Location = new Point(291, 135);
            btnInBooks.Name = "btnInBooks";
            btnInBooks.Size = new Size(94, 29);
            btnInBooks.TabIndex = 2;
            btnInBooks.Text = "InMemory books";
            btnInBooks.UseVisualStyleBackColor = true;
            btnInBooks.Click += btnInBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInBooks);
            Controls.Add(btnDelegate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDelegate;
        private Button btnInBooks;
    }
}
