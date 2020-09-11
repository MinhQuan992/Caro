namespace Game_Caro
{
    partial class frmTwoPlayers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTwoPlayers));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayerOne = new System.Windows.Forms.TextBox();
            this.txtPlayerTwo = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ptbXStar = new System.Windows.Forms.PictureBox();
            this.ptbOLove = new System.Windows.Forms.PictureBox();
            this.rdbXStar = new System.Windows.Forms.RadioButton();
            this.rdbOLove = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbLuotDi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbXStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOLove)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mời bạn nhập thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên người chơi 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên người chơi 2";
            // 
            // txtPlayerOne
            // 
            this.txtPlayerOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayerOne.Location = new System.Drawing.Point(105, 41);
            this.txtPlayerOne.Name = "txtPlayerOne";
            this.txtPlayerOne.Size = new System.Drawing.Size(161, 20);
            this.txtPlayerOne.TabIndex = 4;
            // 
            // txtPlayerTwo
            // 
            this.txtPlayerTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayerTwo.Location = new System.Drawing.Point(105, 65);
            this.txtPlayerTwo.Name = "txtPlayerTwo";
            this.txtPlayerTwo.Size = new System.Drawing.Size(161, 20);
            this.txtPlayerTwo.TabIndex = 5;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.Location = new System.Drawing.Point(105, 277);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Người chơi 1 chọn quân cờ nào?";
            // 
            // ptbXStar
            // 
            this.ptbXStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbXStar.BackgroundImage = global::Game_Caro.Properties.Resources.XStar;
            this.ptbXStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbXStar.Location = new System.Drawing.Point(31, 125);
            this.ptbXStar.Name = "ptbXStar";
            this.ptbXStar.Size = new System.Drawing.Size(90, 90);
            this.ptbXStar.TabIndex = 8;
            this.ptbXStar.TabStop = false;
            // 
            // ptbOLove
            // 
            this.ptbOLove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbOLove.BackgroundImage = global::Game_Caro.Properties.Resources.OLove;
            this.ptbOLove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbOLove.Location = new System.Drawing.Point(157, 125);
            this.ptbOLove.Name = "ptbOLove";
            this.ptbOLove.Size = new System.Drawing.Size(90, 90);
            this.ptbOLove.TabIndex = 9;
            this.ptbOLove.TabStop = false;
            // 
            // rdbXStar
            // 
            this.rdbXStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdbXStar.AutoSize = true;
            this.rdbXStar.Location = new System.Drawing.Point(68, 221);
            this.rdbXStar.Name = "rdbXStar";
            this.rdbXStar.Size = new System.Drawing.Size(14, 13);
            this.rdbXStar.TabIndex = 10;
            this.rdbXStar.TabStop = true;
            this.rdbXStar.UseVisualStyleBackColor = true;
            // 
            // rdbOLove
            // 
            this.rdbOLove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbOLove.AutoSize = true;
            this.rdbOLove.Location = new System.Drawing.Point(195, 221);
            this.rdbOLove.Name = "rdbOLove";
            this.rdbOLove.Size = new System.Drawing.Size(14, 13);
            this.rdbOLove.TabIndex = 11;
            this.rdbOLove.TabStop = true;
            this.rdbOLove.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ai đi trước?";
            // 
            // cbbLuotDi
            // 
            this.cbbLuotDi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLuotDi.FormattingEnabled = true;
            this.cbbLuotDi.Items.AddRange(new object[] {
            "Người chơi 1",
            "Người chơi 2"});
            this.cbbLuotDi.Location = new System.Drawing.Point(88, 244);
            this.cbbLuotDi.Name = "cbbLuotDi";
            this.cbbLuotDi.Size = new System.Drawing.Size(121, 21);
            this.cbbLuotDi.TabIndex = 13;
            // 
            // frmTwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.cbbLuotDi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdbOLove);
            this.Controls.Add(this.rdbXStar);
            this.Controls.Add(this.ptbOLove);
            this.Controls.Add(this.ptbXStar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtPlayerTwo);
            this.Controls.Add(this.txtPlayerOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTwoPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Two players";
            ((System.ComponentModel.ISupportInitialize)(this.ptbXStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOLove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlayerOne;
        private System.Windows.Forms.TextBox txtPlayerTwo;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptbXStar;
        private System.Windows.Forms.PictureBox ptbOLove;
        private System.Windows.Forms.RadioButton rdbXStar;
        private System.Windows.Forms.RadioButton rdbOLove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbLuotDi;
    }
}