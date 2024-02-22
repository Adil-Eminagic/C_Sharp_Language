namespace C_Sharp.Forms
{
    partial class frmDelegate
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
            gbNotif = new GroupBox();
            btnSend = new Button();
            cbJane = new CheckBox();
            cbTom = new CheckBox();
            cbEma = new CheckBox();
            cbJohn = new CheckBox();
            btnClear = new Button();
            txtJohn = new TextBox();
            txtEma = new TextBox();
            txtTom = new TextBox();
            txtJane = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            gbNotif.SuspendLayout();
            SuspendLayout();
            // 
            // gbNotif
            // 
            gbNotif.Controls.Add(btnSend);
            gbNotif.Controls.Add(cbJane);
            gbNotif.Controls.Add(cbTom);
            gbNotif.Controls.Add(cbEma);
            gbNotif.Controls.Add(cbJohn);
            gbNotif.Location = new Point(25, 42);
            gbNotif.Name = "gbNotif";
            gbNotif.Size = new Size(252, 259);
            gbNotif.TabIndex = 0;
            gbNotif.TabStop = false;
            gbNotif.Text = "Notfications";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(6, 202);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(217, 36);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send notifications";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // cbJane
            // 
            cbJane.AutoSize = true;
            cbJane.Location = new Point(6, 158);
            cbJane.Name = "cbJane";
            cbJane.Size = new Size(60, 24);
            cbJane.TabIndex = 3;
            cbJane.Text = "Jane";
            cbJane.UseVisualStyleBackColor = true;
            cbJane.CheckedChanged += cbJane_CheckedChanged;
            // 
            // cbTom
            // 
            cbTom.AutoSize = true;
            cbTom.Location = new Point(6, 119);
            cbTom.Name = "cbTom";
            cbTom.Size = new Size(60, 24);
            cbTom.TabIndex = 2;
            cbTom.Text = "Tom";
            cbTom.UseVisualStyleBackColor = true;
            cbTom.CheckedChanged += cbTom_CheckedChanged;
            // 
            // cbEma
            // 
            cbEma.AutoSize = true;
            cbEma.Location = new Point(6, 80);
            cbEma.Name = "cbEma";
            cbEma.Size = new Size(60, 24);
            cbEma.TabIndex = 1;
            cbEma.Text = "Ema";
            cbEma.UseVisualStyleBackColor = true;
            cbEma.CheckedChanged += cbEma_CheckedChanged;
            // 
            // cbJohn
            // 
            cbJohn.AutoSize = true;
            cbJohn.Location = new Point(6, 40);
            cbJohn.Name = "cbJohn";
            cbJohn.Size = new Size(61, 24);
            cbJohn.TabIndex = 0;
            cbJohn.Text = "John";
            cbJohn.UseVisualStyleBackColor = true;
            cbJohn.CheckedChanged += cbJohn_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(31, 325);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear boxes";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtJohn
            // 
            txtJohn.Location = new Point(649, 42);
            txtJohn.Multiline = true;
            txtJohn.Name = "txtJohn";
            txtJohn.Size = new Size(139, 78);
            txtJohn.TabIndex = 6;
            // 
            // txtEma
            // 
            txtEma.Location = new Point(649, 146);
            txtEma.Multiline = true;
            txtEma.Name = "txtEma";
            txtEma.Size = new Size(139, 78);
            txtEma.TabIndex = 7;
            // 
            // txtTom
            // 
            txtTom.Location = new Point(649, 264);
            txtTom.Multiline = true;
            txtTom.Name = "txtTom";
            txtTom.Size = new Size(139, 78);
            txtTom.TabIndex = 8;
            // 
            // txtJane
            // 
            txtJane.Location = new Point(649, 375);
            txtJane.Multiline = true;
            txtJane.Name = "txtJane";
            txtJane.Size = new Size(139, 78);
            txtJane.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(532, 72);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 10;
            label1.Text = "John";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(532, 187);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 11;
            label2.Text = "Ema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(532, 295);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 12;
            label3.Text = "Tom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 403);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 13;
            label4.Text = "Jane";
            // 
            // frmDelegate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 499);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtJane);
            Controls.Add(txtTom);
            Controls.Add(txtEma);
            Controls.Add(txtJohn);
            Controls.Add(btnClear);
            Controls.Add(gbNotif);
            Name = "frmDelegate";
            Text = "frmDelegate";
            gbNotif.ResumeLayout(false);
            gbNotif.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbNotif;
        private Button btnSend;
        private CheckBox cbJane;
        private CheckBox cbTom;
        private CheckBox cbEma;
        private CheckBox cbJohn;
        private Button btnClear;
        private TextBox txtJohn;
        private TextBox txtEma;
        private TextBox txtTom;
        private TextBox txtJane;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}