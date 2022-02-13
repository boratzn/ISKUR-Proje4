namespace Odev3Matris
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
            this.tbBoyut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSayilar = new System.Windows.Forms.TextBox();
            this.btnSayiEkle = new System.Windows.Forms.Button();
            this.btnIslem = new System.Windows.Forms.Button();
            this.lbxMatrix = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTwoAxis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFirstAxis = new System.Windows.Forms.Label();
            this.lblSecondAxis = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBoyut
            // 
            this.tbBoyut.Location = new System.Drawing.Point(117, 17);
            this.tbBoyut.Name = "tbBoyut";
            this.tbBoyut.Size = new System.Drawing.Size(100, 22);
            this.tbBoyut.TabIndex = 0;
            this.tbBoyut.Leave += new System.EventHandler(this.tbBoyut_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dizinin Boyutu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayılar";
            // 
            // tbSayilar
            // 
            this.tbSayilar.Location = new System.Drawing.Point(117, 58);
            this.tbSayilar.Name = "tbSayilar";
            this.tbSayilar.Size = new System.Drawing.Size(100, 22);
            this.tbSayilar.TabIndex = 3;
            // 
            // btnSayiEkle
            // 
            this.btnSayiEkle.Location = new System.Drawing.Point(15, 98);
            this.btnSayiEkle.Name = "btnSayiEkle";
            this.btnSayiEkle.Size = new System.Drawing.Size(97, 34);
            this.btnSayiEkle.TabIndex = 4;
            this.btnSayiEkle.Text = "Sayı Ekle";
            this.btnSayiEkle.UseVisualStyleBackColor = true;
            this.btnSayiEkle.Click += new System.EventHandler(this.btnSayiEkle_Click);
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(118, 98);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(99, 34);
            this.btnIslem.TabIndex = 4;
            this.btnIslem.Text = "İşlem";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // lbxMatrix
            // 
            this.lbxMatrix.FormattingEnabled = true;
            this.lbxMatrix.ItemHeight = 16;
            this.lbxMatrix.Location = new System.Drawing.Point(245, 17);
            this.lbxMatrix.Name = "lbxMatrix";
            this.lbxMatrix.Size = new System.Drawing.Size(246, 132);
            this.lbxMatrix.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eksen 1 ve 2 :";
            // 
            // lblTwoAxis
            // 
            this.lblTwoAxis.AutoSize = true;
            this.lblTwoAxis.Location = new System.Drawing.Point(107, 211);
            this.lblTwoAxis.Name = "lblTwoAxis";
            this.lblTwoAxis.Size = new System.Drawing.Size(0, 16);
            this.lblTwoAxis.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Eksen 1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Eksen 2 :";
            // 
            // lblFirstAxis
            // 
            this.lblFirstAxis.AutoSize = true;
            this.lblFirstAxis.Location = new System.Drawing.Point(110, 240);
            this.lblFirstAxis.Name = "lblFirstAxis";
            this.lblFirstAxis.Size = new System.Drawing.Size(0, 16);
            this.lblFirstAxis.TabIndex = 8;
            // 
            // lblSecondAxis
            // 
            this.lblSecondAxis.AutoSize = true;
            this.lblSecondAxis.Location = new System.Drawing.Point(110, 269);
            this.lblSecondAxis.Name = "lblSecondAxis";
            this.lblSecondAxis.Size = new System.Drawing.Size(0, 16);
            this.lblSecondAxis.TabIndex = 8;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(245, 155);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(246, 38);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 297);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblSecondAxis);
            this.Controls.Add(this.lblFirstAxis);
            this.Controls.Add(this.lblTwoAxis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxMatrix);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.btnSayiEkle);
            this.Controls.Add(this.tbSayilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBoyut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBoyut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSayilar;
        private System.Windows.Forms.Button btnSayiEkle;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.ListBox lbxMatrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTwoAxis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFirstAxis;
        private System.Windows.Forms.Label lblSecondAxis;
        private System.Windows.Forms.Button btnTemizle;
    }
}

