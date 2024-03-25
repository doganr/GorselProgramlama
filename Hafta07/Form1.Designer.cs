using System.Windows.Forms;

namespace Hafta07
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
            ogrencilerDgv = new DataGridView();
            groupBox1 = new GroupBox();
            ogrenciGüncelleBtn = new Button();
            ogrencSilBtn = new Button();
            ogrenciEkleBtn = new Button();
            emailTxt = new TextBox();
            soyisimTxt = new TextBox();
            isimTxt = new TextBox();
            numaraTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ogrencilerDgv).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ogrencilerDgv
            // 
            ogrencilerDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ogrencilerDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ogrencilerDgv.Location = new Point(359, 12);
            ogrencilerDgv.Name = "ogrencilerDgv";
            ogrencilerDgv.RowTemplate.Height = 25;
            ogrencilerDgv.Size = new Size(1026, 696);
            ogrencilerDgv.TabIndex = 7;
            ogrencilerDgv.SelectionChanged += ogrencilerDgv_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ogrenciGüncelleBtn);
            groupBox1.Controls.Add(ogrencSilBtn);
            groupBox1.Controls.Add(ogrenciEkleBtn);
            groupBox1.Controls.Add(emailTxt);
            groupBox1.Controls.Add(soyisimTxt);
            groupBox1.Controls.Add(isimTxt);
            groupBox1.Controls.Add(numaraTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 190);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // ogrenciGüncelleBtn
            // 
            ogrenciGüncelleBtn.Location = new Point(267, 150);
            ogrenciGüncelleBtn.Name = "ogrenciGüncelleBtn";
            ogrenciGüncelleBtn.Size = new Size(68, 23);
            ogrenciGüncelleBtn.TabIndex = 4;
            ogrenciGüncelleBtn.Text = "Güncelle";
            ogrenciGüncelleBtn.UseVisualStyleBackColor = true;
            ogrenciGüncelleBtn.Click += ogrenciGüncelleBtn_Click;
            // 
            // ogrencSilBtn
            // 
            ogrencSilBtn.Location = new Point(164, 150);
            ogrencSilBtn.Name = "ogrencSilBtn";
            ogrencSilBtn.Size = new Size(68, 23);
            ogrencSilBtn.TabIndex = 4;
            ogrencSilBtn.Text = "Sil";
            ogrencSilBtn.UseVisualStyleBackColor = true;
            ogrencSilBtn.Click += ogrencSilBtn_Click;
            // 
            // ogrenciEkleBtn
            // 
            ogrenciEkleBtn.Location = new Point(71, 150);
            ogrenciEkleBtn.Name = "ogrenciEkleBtn";
            ogrenciEkleBtn.Size = new Size(68, 23);
            ogrenciEkleBtn.TabIndex = 4;
            ogrenciEkleBtn.Text = "Ekle";
            ogrenciEkleBtn.UseVisualStyleBackColor = true;
            ogrenciEkleBtn.Click += ogrenciEkleBtn_Click;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(71, 121);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(264, 23);
            emailTxt.TabIndex = 3;
            // 
            // soyisimTxt
            // 
            soyisimTxt.Location = new Point(71, 92);
            soyisimTxt.Name = "soyisimTxt";
            soyisimTxt.Size = new Size(264, 23);
            soyisimTxt.TabIndex = 2;
            // 
            // isimTxt
            // 
            isimTxt.Location = new Point(71, 63);
            isimTxt.Name = "isimTxt";
            isimTxt.Size = new Size(264, 23);
            isimTxt.TabIndex = 1;
            // 
            // numaraTxt
            // 
            numaraTxt.Location = new Point(71, 34);
            numaraTxt.Name = "numaraTxt";
            numaraTxt.Size = new Size(264, 23);
            numaraTxt.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 124);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 95);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 0;
            label3.Text = "Soyisim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 66);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 0;
            label2.Text = "İsim";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 37);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Numara";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 720);
            Controls.Add(groupBox1);
            Controls.Add(ogrencilerDgv);
            Name = "Form1";
            Text = "SQLite Denemeleri";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)ogrencilerDgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView ogrencilerDgv;
        private GroupBox groupBox1;
        private TextBox emailTxt;
        private TextBox soyisimTxt;
        private TextBox isimTxt;
        private TextBox numaraTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button ogrenciEkleBtn;
        private Button ogrenciGüncelleBtn;
        private Button ogrencSilBtn;
    }
}