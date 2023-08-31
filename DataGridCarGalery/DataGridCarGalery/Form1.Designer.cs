
namespace DataGridCarGalery
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
            this.dataGridViewCarList = new System.Windows.Forms.DataGridView();
            this.textBoxMrk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMdl = new System.Windows.Forms.TextBox();
            this.Tutar = new System.Windows.Forms.Label();
            this.textBoxTtr = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonGtr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCarList
            // 
            this.dataGridViewCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarList.Location = new System.Drawing.Point(104, 320);
            this.dataGridViewCarList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCarList.Name = "dataGridViewCarList";
            this.dataGridViewCarList.RowHeadersWidth = 62;
            this.dataGridViewCarList.Size = new System.Drawing.Size(960, 231);
            this.dataGridViewCarList.TabIndex = 0;
            // 
            // textBoxMrk
            // 
            this.textBoxMrk.Location = new System.Drawing.Point(192, 131);
            this.textBoxMrk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMrk.Name = "textBoxMrk";
            this.textBoxMrk.Size = new System.Drawing.Size(148, 26);
            this.textBoxMrk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // textBoxMdl
            // 
            this.textBoxMdl.Location = new System.Drawing.Point(489, 131);
            this.textBoxMdl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMdl.Name = "textBoxMdl";
            this.textBoxMdl.Size = new System.Drawing.Size(148, 26);
            this.textBoxMdl.TabIndex = 3;
            // 
            // Tutar
            // 
            this.Tutar.AutoSize = true;
            this.Tutar.Location = new System.Drawing.Point(684, 142);
            this.Tutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tutar.Name = "Tutar";
            this.Tutar.Size = new System.Drawing.Size(46, 20);
            this.Tutar.TabIndex = 6;
            this.Tutar.Text = "Tutar";
            // 
            // textBoxTtr
            // 
            this.textBoxTtr.Location = new System.Drawing.Point(746, 131);
            this.textBoxTtr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTtr.Name = "textBoxTtr";
            this.textBoxTtr.Size = new System.Drawing.Size(148, 26);
            this.textBoxTtr.TabIndex = 5;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(135, 248);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(112, 35);
            this.buttonEkle.TabIndex = 7;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonGtr
            // 
            this.buttonGtr.Location = new System.Drawing.Point(900, 248);
            this.buttonGtr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGtr.Name = "buttonGtr";
            this.buttonGtr.Size = new System.Drawing.Size(112, 35);
            this.buttonGtr.TabIndex = 8;
            this.buttonGtr.Text = "Getir";
            this.buttonGtr.UseVisualStyleBackColor = true;
            this.buttonGtr.Click += new System.EventHandler(this.buttonGtr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonGtr);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.Tutar);
            this.Controls.Add(this.textBoxTtr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMdl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMrk);
            this.Controls.Add(this.dataGridViewCarList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCarList;
        private System.Windows.Forms.TextBox textBoxMrk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMdl;
        private System.Windows.Forms.Label Tutar;
        private System.Windows.Forms.TextBox textBoxTtr;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonGtr;
    }
}

