namespace Hafta06
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
            ogrenciEkleBtn = new Button();
            ogrenciFinalNud = new NumericUpDown();
            ogrenciVizeNud = new NumericUpDown();
            ogrenciSoyadiTxt = new TextBox();
            label5 = new Label();
            ogrenciAdiTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ogrenciNoTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            dosyaTsmi = new ToolStripMenuItem();
            yukleTsmi = new ToolStripMenuItem();
            kaydetTsmi = new ToolStripMenuItem();
            yardimTsmi = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)ogrencilerDgv).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ogrenciFinalNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ogrenciVizeNud).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ogrencilerDgv
            // 
            ogrencilerDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ogrencilerDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ogrencilerDgv.Location = new Point(335, 38);
            ogrencilerDgv.Name = "ogrencilerDgv";
            ogrencilerDgv.RowTemplate.Height = 25;
            ogrencilerDgv.Size = new Size(628, 619);
            ogrencilerDgv.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ogrenciEkleBtn);
            groupBox1.Controls.Add(ogrenciFinalNud);
            groupBox1.Controls.Add(ogrenciVizeNud);
            groupBox1.Controls.Add(ogrenciSoyadiTxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(ogrenciAdiTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ogrenciNoTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 234);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // ogrenciEkleBtn
            // 
            ogrenciEkleBtn.Location = new Point(115, 174);
            ogrenciEkleBtn.Name = "ogrenciEkleBtn";
            ogrenciEkleBtn.Size = new Size(180, 23);
            ogrenciEkleBtn.TabIndex = 6;
            ogrenciEkleBtn.Text = "Ekle";
            ogrenciEkleBtn.UseVisualStyleBackColor = true;
            ogrenciEkleBtn.Click += ogrenciEkleBtn_Click;
            // 
            // ogrenciFinalNud
            // 
            ogrenciFinalNud.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            ogrenciFinalNud.Location = new Point(115, 145);
            ogrenciFinalNud.Name = "ogrenciFinalNud";
            ogrenciFinalNud.Size = new Size(180, 23);
            ogrenciFinalNud.TabIndex = 5;
            // 
            // ogrenciVizeNud
            // 
            ogrenciVizeNud.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            ogrenciVizeNud.Location = new Point(115, 116);
            ogrenciVizeNud.Name = "ogrenciVizeNud";
            ogrenciVizeNud.Size = new Size(180, 23);
            ogrenciVizeNud.TabIndex = 4;
            // 
            // ogrenciSoyadiTxt
            // 
            ogrenciSoyadiTxt.Location = new Point(115, 87);
            ogrenciSoyadiTxt.Name = "ogrenciSoyadiTxt";
            ogrenciSoyadiTxt.Size = new Size(180, 23);
            ogrenciSoyadiTxt.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 147);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 0;
            label5.Text = "Final Notu:";
            // 
            // ogrenciAdiTxt
            // 
            ogrenciAdiTxt.Location = new Point(115, 58);
            ogrenciAdiTxt.Name = "ogrenciAdiTxt";
            ogrenciAdiTxt.Size = new Size(180, 23);
            ogrenciAdiTxt.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 118);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 0;
            label4.Text = "Vize Notu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 90);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 0;
            label3.Text = "Öğrenci Soyadı:";
            // 
            // ogrenciNoTxt
            // 
            ogrenciNoTxt.Location = new Point(115, 29);
            ogrenciNoTxt.Name = "ogrenciNoTxt";
            ogrenciNoTxt.Size = new Size(180, 23);
            ogrenciNoTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 61);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Öğrenci Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci No:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaTsmi, yardimTsmi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(975, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaTsmi
            // 
            dosyaTsmi.DropDownItems.AddRange(new ToolStripItem[] { yukleTsmi, kaydetTsmi });
            dosyaTsmi.Name = "dosyaTsmi";
            dosyaTsmi.Size = new Size(51, 20);
            dosyaTsmi.Text = "Dosya";
            // 
            // yukleTsmi
            // 
            yukleTsmi.Name = "yukleTsmi";
            yukleTsmi.Size = new Size(180, 22);
            yukleTsmi.Text = "Yükle";
            yukleTsmi.Click += yukleTsmi_Click;
            // 
            // kaydetTsmi
            // 
            kaydetTsmi.Name = "kaydetTsmi";
            kaydetTsmi.Size = new Size(180, 22);
            kaydetTsmi.Text = "Kaydet";
            kaydetTsmi.Click += kaydetTsmi_Click;
            // 
            // yardimTsmi
            // 
            yardimTsmi.Name = "yardimTsmi";
            yardimTsmi.Size = new Size(56, 20);
            yardimTsmi.Text = "Yardım";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 669);
            Controls.Add(groupBox1);
            Controls.Add(ogrencilerDgv);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Öğrenci Bilgileri";
            ((System.ComponentModel.ISupportInitialize)ogrencilerDgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ogrenciFinalNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)ogrenciVizeNud).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ogrencilerDgv;
        private GroupBox groupBox1;
        private NumericUpDown ogrenciVizeNud;
        private TextBox ogrenciSoyadiTxt;
        private TextBox ogrenciAdiTxt;
        private Label label4;
        private Label label3;
        private TextBox ogrenciNoTxt;
        private Label label2;
        private Label label1;
        private NumericUpDown ogrenciFinalNud;
        private Label label5;
        private Button ogrenciEkleBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaTsmi;
        private ToolStripMenuItem yukleTsmi;
        private ToolStripMenuItem yardimTsmi;
        private ToolStripMenuItem kaydetTsmi;
    }
}