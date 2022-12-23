namespace Bilgi_Yarismasi
{
    partial class byanaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(byanaform));
            this.Btna = new System.Windows.Forms.Button();
            this.Btnb = new System.Windows.Forms.Button();
            this.Btnc = new System.Windows.Forms.Button();
            this.Btnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSoru = new System.Windows.Forms.Label();
            this.LblDogru = new System.Windows.Forms.Label();
            this.LblYanlıs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btna
            // 
            this.Btna.BackColor = System.Drawing.Color.Wheat;
            this.Btna.Location = new System.Drawing.Point(54, 240);
            this.Btna.Name = "Btna";
            this.Btna.Size = new System.Drawing.Size(168, 55);
            this.Btna.TabIndex = 1;
            this.Btna.Text = "A";
            this.Btna.UseVisualStyleBackColor = false;
            this.Btna.Click += new System.EventHandler(this.Btna_Click);
            // 
            // Btnb
            // 
            this.Btnb.BackColor = System.Drawing.Color.Wheat;
            this.Btnb.Location = new System.Drawing.Point(258, 240);
            this.Btnb.Name = "Btnb";
            this.Btnb.Size = new System.Drawing.Size(168, 55);
            this.Btnb.TabIndex = 2;
            this.Btnb.Text = "B";
            this.Btnb.UseVisualStyleBackColor = false;
            this.Btnb.Click += new System.EventHandler(this.Btnb_Click);
            // 
            // Btnc
            // 
            this.Btnc.BackColor = System.Drawing.Color.Wheat;
            this.Btnc.Location = new System.Drawing.Point(54, 328);
            this.Btnc.Name = "Btnc";
            this.Btnc.Size = new System.Drawing.Size(168, 55);
            this.Btnc.TabIndex = 3;
            this.Btnc.Text = "C";
            this.Btnc.UseVisualStyleBackColor = false;
            this.Btnc.Click += new System.EventHandler(this.Btnc_Click);
            // 
            // Btnd
            // 
            this.Btnd.BackColor = System.Drawing.Color.Wheat;
            this.Btnd.Location = new System.Drawing.Point(258, 328);
            this.Btnd.Name = "Btnd";
            this.Btnd.Size = new System.Drawing.Size(168, 55);
            this.Btnd.TabIndex = 4;
            this.Btnd.Text = "D";
            this.Btnd.UseVisualStyleBackColor = false;
            this.Btnd.Click += new System.EventHandler(this.Btnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(574, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(574, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(574, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış Sayısı";
            // 
            // LblSoru
            // 
            this.LblSoru.AutoSize = true;
            this.LblSoru.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblSoru.Location = new System.Drawing.Point(674, 26);
            this.LblSoru.Name = "LblSoru";
            this.LblSoru.Size = new System.Drawing.Size(25, 29);
            this.LblSoru.TabIndex = 8;
            this.LblSoru.Text = "0";
            // 
            // LblDogru
            // 
            this.LblDogru.AutoSize = true;
            this.LblDogru.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblDogru.Location = new System.Drawing.Point(687, 78);
            this.LblDogru.Name = "LblDogru";
            this.LblDogru.Size = new System.Drawing.Size(25, 29);
            this.LblDogru.TabIndex = 9;
            this.LblDogru.Text = "0";
            // 
            // LblYanlıs
            // 
            this.LblYanlıs.AutoSize = true;
            this.LblYanlıs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblYanlıs.Location = new System.Drawing.Point(683, 134);
            this.LblYanlıs.Name = "LblYanlıs";
            this.LblYanlıs.Size = new System.Drawing.Size(25, 29);
            this.LblYanlıs.TabIndex = 10;
            this.LblYanlıs.Text = "0";
            this.LblYanlıs.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(623, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(603, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(603, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSonraki.Location = new System.Drawing.Point(54, 431);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(153, 70);
            this.BtnSonraki.TabIndex = 17;
            this.BtnSonraki.Text = "Sonraki Soru";
            this.BtnSonraki.UseVisualStyleBackColor = false;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(6, -4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(548, 226);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(737, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 48);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // byanaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblYanlıs);
            this.Controls.Add(this.LblDogru);
            this.Controls.Add(this.LblSoru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnd);
            this.Controls.Add(this.Btnc);
            this.Controls.Add(this.Btnb);
            this.Controls.Add(this.Btna);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "byanaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Btna;
        private Button Btnb;
        private Button Btnc;
        private Button Btnd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblSoru;
        private Label LblDogru;
        private Label LblYanlıs;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Button BtnSonraki;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}