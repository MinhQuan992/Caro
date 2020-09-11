namespace Game_Caro
{
    partial class frmOnePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOnePlayer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbXStar = new System.Windows.Forms.RadioButton();
            this.rdbOLove = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLuotDi = new System.Windows.Forms.ComboBox();
            this.ptbOLove = new System.Windows.Forms.PictureBox();
            this.ptbXStar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOLove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXStar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mời bạn nhập thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên người chơi";
            // 
            // txtPlayer
            // 
            this.txtPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayer.Location = new System.Drawing.Point(96, 46);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(213, 20);
            this.txtPlayer.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.Location = new System.Drawing.Point(129, 277);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chọn quân cờ";
            // 
            // rdbXStar
            // 
            this.rdbXStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbXStar.AutoSize = true;
            this.rdbXStar.Location = new System.Drawing.Point(133, 175);
            this.rdbXStar.Name = "rdbXStar";
            this.rdbXStar.Size = new System.Drawing.Size(14, 13);
            this.rdbXStar.TabIndex = 9;
            this.rdbXStar.TabStop = true;
            this.rdbXStar.UseVisualStyleBackColor = true;
            // 
            // rdbOLove
            // 
            this.rdbOLove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbOLove.AutoSize = true;
            this.rdbOLove.Location = new System.Drawing.Point(257, 175);
            this.rdbOLove.Name = "rdbOLove";
            this.rdbOLove.Size = new System.Drawing.Size(14, 13);
            this.rdbOLove.TabIndex = 10;
            this.rdbOLove.TabStop = true;
            this.rdbOLove.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bạn chọn";
            // 
            // cbbLuotDi
            // 
            this.cbbLuotDi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLuotDi.FormattingEnabled = true;
            this.cbbLuotDi.Items.AddRange(new object[] {
            "Đi trước",
            "Đi sau"});
            this.cbbLuotDi.Location = new System.Drawing.Point(96, 194);
            this.cbbLuotDi.Name = "cbbLuotDi";
            this.cbbLuotDi.Size = new System.Drawing.Size(121, 21);
            this.cbbLuotDi.TabIndex = 12;
            // 
            // ptbOLove
            // 
            this.ptbOLove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbOLove.BackgroundImage = global::Game_Caro.Properties.Resources.OLove;
            this.ptbOLove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbOLove.Location = new System.Drawing.Point(219, 79);
            this.ptbOLove.Name = "ptbOLove";
            this.ptbOLove.Size = new System.Drawing.Size(90, 90);
            this.ptbOLove.TabIndex = 8;
            this.ptbOLove.TabStop = false;
            // 
            // ptbXStar
            // 
            this.ptbXStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbXStar.BackgroundImage = global::Game_Caro.Properties.Resources.XStar;
            this.ptbXStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbXStar.Location = new System.Drawing.Point(96, 79);
            this.ptbXStar.Name = "ptbXStar";
            this.ptbXStar.Size = new System.Drawing.Size(90, 90);
            this.ptbXStar.TabIndex = 7;
            this.ptbXStar.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cấp độ";
            // 
            // cbbLevel
            // 
            this.cbbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5"});
            this.cbbLevel.Location = new System.Drawing.Point(96, 233);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(121, 21);
            this.cbbLevel.TabIndex = 14;
            // 
            // frmOnePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 317);
            this.Controls.Add(this.cbbLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbLuotDi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbOLove);
            this.Controls.Add(this.rdbXStar);
            this.Controls.Add(this.ptbOLove);
            this.Controls.Add(this.ptbXStar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOnePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One player";
            ((System.ComponentModel.ISupportInitialize)(this.ptbOLove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbXStar;
        private System.Windows.Forms.PictureBox ptbOLove;
        private System.Windows.Forms.RadioButton rdbXStar;
        private System.Windows.Forms.RadioButton rdbOLove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLuotDi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbLevel;
    }
}