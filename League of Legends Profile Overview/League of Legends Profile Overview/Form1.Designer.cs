namespace League_of_Legends_Profile_Overview
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.SummonerNameText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SummonerIconPicBox = new System.Windows.Forms.PictureBox();
            this.SumNameText = new System.Windows.Forms.TextBox();
            this.SumLevelText = new System.Windows.Forms.TextBox();
            this.SumIDText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SumRegionText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SummonerIconPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SummonerNameText
            // 
            this.SummonerNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SummonerNameText.Location = new System.Drawing.Point(47, 34);
            this.SummonerNameText.Multiline = true;
            this.SummonerNameText.Name = "SummonerNameText";
            this.SummonerNameText.Size = new System.Drawing.Size(161, 29);
            this.SummonerNameText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(214, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Stats";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Summoner Name";
            // 
            // SummonerIconPicBox
            // 
            this.SummonerIconPicBox.Location = new System.Drawing.Point(47, 69);
            this.SummonerIconPicBox.Name = "SummonerIconPicBox";
            this.SummonerIconPicBox.Size = new System.Drawing.Size(161, 163);
            this.SummonerIconPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SummonerIconPicBox.TabIndex = 3;
            this.SummonerIconPicBox.TabStop = false;
            // 
            // SumNameText
            // 
            this.SumNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SumNameText.Location = new System.Drawing.Point(214, 288);
            this.SumNameText.Multiline = true;
            this.SumNameText.Name = "SumNameText";
            this.SumNameText.Size = new System.Drawing.Size(161, 29);
            this.SumNameText.TabIndex = 4;
            // 
            // SumLevelText
            // 
            this.SumLevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SumLevelText.Location = new System.Drawing.Point(214, 323);
            this.SumLevelText.Multiline = true;
            this.SumLevelText.Name = "SumLevelText";
            this.SumLevelText.Size = new System.Drawing.Size(161, 29);
            this.SumLevelText.TabIndex = 5;
            // 
            // SumIDText
            // 
            this.SumIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SumIDText.Location = new System.Drawing.Point(214, 253);
            this.SumIDText.Multiline = true;
            this.SumIDText.Name = "SumIDText";
            this.SumIDText.Size = new System.Drawing.Size(644, 29);
            this.SumIDText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Summoner Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Summoner Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(80, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Summoner ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Summoner Region:";
            // 
            // SumRegionText
            // 
            this.SumRegionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SumRegionText.Location = new System.Drawing.Point(214, 358);
            this.SumRegionText.Multiline = true;
            this.SumRegionText.Name = "SumRegionText";
            this.SumRegionText.Size = new System.Drawing.Size(161, 29);
            this.SumRegionText.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(902, 780);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SumRegionText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SumIDText);
            this.Controls.Add(this.SumLevelText);
            this.Controls.Add(this.SumNameText);
            this.Controls.Add(this.SummonerIconPicBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SummonerNameText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SummonerIconPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SummonerNameText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SummonerIconPicBox;
        private System.Windows.Forms.TextBox SumNameText;
        private System.Windows.Forms.TextBox SumLevelText;
        private System.Windows.Forms.TextBox SumIDText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SumRegionText;
    }
}

