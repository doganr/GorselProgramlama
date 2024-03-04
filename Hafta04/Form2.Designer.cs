namespace Hafta04
{
    partial class Form2
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
            seciliKlasorTxt = new TextBox();
            klasorSecBtn = new Button();
            resimlerLbox = new ListBox();
            resimalaniPbox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)resimalaniPbox).BeginInit();
            SuspendLayout();
            // 
            // seciliKlasorTxt
            // 
            seciliKlasorTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            seciliKlasorTxt.Enabled = false;
            seciliKlasorTxt.Location = new Point(12, 12);
            seciliKlasorTxt.Name = "seciliKlasorTxt";
            seciliKlasorTxt.ReadOnly = true;
            seciliKlasorTxt.Size = new Size(767, 23);
            seciliKlasorTxt.TabIndex = 0;
            // 
            // klasorSecBtn
            // 
            klasorSecBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            klasorSecBtn.Location = new Point(785, 11);
            klasorSecBtn.Name = "klasorSecBtn";
            klasorSecBtn.Size = new Size(75, 23);
            klasorSecBtn.TabIndex = 1;
            klasorSecBtn.Text = "Klasör Seç";
            klasorSecBtn.UseVisualStyleBackColor = true;
            klasorSecBtn.Click += klasorSecBtn_Click;
            // 
            // resimlerLbox
            // 
            resimlerLbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            resimlerLbox.FormattingEnabled = true;
            resimlerLbox.ItemHeight = 15;
            resimlerLbox.Location = new Point(12, 41);
            resimlerLbox.Name = "resimlerLbox";
            resimlerLbox.Size = new Size(180, 394);
            resimlerLbox.TabIndex = 2;
            resimlerLbox.SelectedIndexChanged += resimlerLbox_SelectedIndexChanged;
            // 
            // resimalaniPbox
            // 
            resimalaniPbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resimalaniPbox.BorderStyle = BorderStyle.FixedSingle;
            resimalaniPbox.Location = new Point(198, 41);
            resimalaniPbox.Name = "resimalaniPbox";
            resimalaniPbox.Size = new Size(662, 394);
            resimalaniPbox.SizeMode = PictureBoxSizeMode.Zoom;
            resimalaniPbox.TabIndex = 3;
            resimalaniPbox.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 450);
            Controls.Add(resimalaniPbox);
            Controls.Add(resimlerLbox);
            Controls.Add(klasorSecBtn);
            Controls.Add(seciliKlasorTxt);
            Name = "Form2";
            Text = "Resim Galerisi";
            ((System.ComponentModel.ISupportInitialize)resimalaniPbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox seciliKlasorTxt;
        private Button klasorSecBtn;
        private ListBox resimlerLbox;
        private PictureBox resimalaniPbox;
    }
}