
namespace week_10praktikum
{
    partial class Form1
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
            this.lbl_hasilskor = new System.Windows.Forms.Label();
            this.lbl_hasiltanggal = new System.Windows.Forms.Label();
            this.lbl_skor = new System.Windows.Forms.Label();
            this.lbl_tanggal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Minutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnplayername1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columntipe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnplayername2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columntipe2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_check = new System.Windows.Forms.Button();
            this.lbl_namacapacity = new System.Windows.Forms.Label();
            this.lbl_namastadium = new System.Windows.Forms.Label();
            this.lbl_capacity = new System.Windows.Forms.Label();
            this.lbl_stadium = new System.Windows.Forms.Label();
            this.lbl_namamanager2 = new System.Windows.Forms.Label();
            this.lbl_namacaptain2 = new System.Windows.Forms.Label();
            this.lbl_namacaptain1 = new System.Windows.Forms.Label();
            this.lbl_namamanager1 = new System.Windows.Forms.Label();
            this.lbl_captainkanan = new System.Windows.Forms.Label();
            this.lbl_managerkanan = new System.Windows.Forms.Label();
            this.lbl_captainkiri = new System.Windows.Forms.Label();
            this.lbl_managerkiri = new System.Windows.Forms.Label();
            this.lbl_vs = new System.Windows.Forms.Label();
            this.cBox_away = new System.Windows.Forms.ComboBox();
            this.cBox_home = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_hasilskor
            // 
            this.lbl_hasilskor.AutoSize = true;
            this.lbl_hasilskor.Location = new System.Drawing.Point(520, 484);
            this.lbl_hasilskor.Name = "lbl_hasilskor";
            this.lbl_hasilskor.Size = new System.Drawing.Size(0, 17);
            this.lbl_hasilskor.TabIndex = 41;
            // 
            // lbl_hasiltanggal
            // 
            this.lbl_hasiltanggal.AutoSize = true;
            this.lbl_hasiltanggal.Location = new System.Drawing.Point(525, 445);
            this.lbl_hasiltanggal.Name = "lbl_hasiltanggal";
            this.lbl_hasiltanggal.Size = new System.Drawing.Size(28, 17);
            this.lbl_hasiltanggal.TabIndex = 40;
            this.lbl_hasiltanggal.Text = ".....";
            // 
            // lbl_skor
            // 
            this.lbl_skor.AutoSize = true;
            this.lbl_skor.Location = new System.Drawing.Point(453, 485);
            this.lbl_skor.Name = "lbl_skor";
            this.lbl_skor.Size = new System.Drawing.Size(65, 17);
            this.lbl_skor.TabIndex = 39;
            this.lbl_skor.Text = "Skor      :";
            // 
            // lbl_tanggal
            // 
            this.lbl_tanggal.AutoSize = true;
            this.lbl_tanggal.Location = new System.Drawing.Point(450, 445);
            this.lbl_tanggal.Name = "lbl_tanggal";
            this.lbl_tanggal.Size = new System.Drawing.Size(68, 17);
            this.lbl_tanggal.TabIndex = 38;
            this.lbl_tanggal.Text = "Tanggal :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Minutes,
            this.Columnplayername1,
            this.Columntipe1,
            this.Columnplayername2,
            this.Columntipe2});
            this.dataGridView1.Location = new System.Drawing.Point(189, 567);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 358);
            this.dataGridView1.TabIndex = 37;
            // 
            // Minutes
            // 
            this.Minutes.HeaderText = "Minutes";
            this.Minutes.MinimumWidth = 6;
            this.Minutes.Name = "Minutes";
            this.Minutes.Width = 125;
            // 
            // Columnplayername1
            // 
            this.Columnplayername1.HeaderText = "Player Name 1";
            this.Columnplayername1.MinimumWidth = 6;
            this.Columnplayername1.Name = "Columnplayername1";
            this.Columnplayername1.Width = 125;
            // 
            // Columntipe1
            // 
            this.Columntipe1.HeaderText = "Tipe 1";
            this.Columntipe1.MinimumWidth = 6;
            this.Columntipe1.Name = "Columntipe1";
            this.Columntipe1.Width = 125;
            // 
            // Columnplayername2
            // 
            this.Columnplayername2.HeaderText = "Player Name 2";
            this.Columnplayername2.MinimumWidth = 6;
            this.Columnplayername2.Name = "Columnplayername2";
            this.Columnplayername2.Width = 125;
            // 
            // Columntipe2
            // 
            this.Columntipe2.HeaderText = "Tipe 2";
            this.Columntipe2.MinimumWidth = 6;
            this.Columntipe2.Name = "Columntipe2";
            this.Columntipe2.Width = 125;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(482, 399);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 36;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            // 
            // lbl_namacapacity
            // 
            this.lbl_namacapacity.AutoSize = true;
            this.lbl_namacapacity.Location = new System.Drawing.Point(542, 354);
            this.lbl_namacapacity.Name = "lbl_namacapacity";
            this.lbl_namacapacity.Size = new System.Drawing.Size(31, 17);
            this.lbl_namacapacity.TabIndex = 35;
            this.lbl_namacapacity.Text = "N/A";
            // 
            // lbl_namastadium
            // 
            this.lbl_namastadium.AutoSize = true;
            this.lbl_namastadium.Location = new System.Drawing.Point(542, 308);
            this.lbl_namastadium.Name = "lbl_namastadium";
            this.lbl_namastadium.Size = new System.Drawing.Size(31, 17);
            this.lbl_namastadium.TabIndex = 34;
            this.lbl_namastadium.Text = "N/A";
            // 
            // lbl_capacity
            // 
            this.lbl_capacity.AutoSize = true;
            this.lbl_capacity.Location = new System.Drawing.Point(447, 354);
            this.lbl_capacity.Name = "lbl_capacity";
            this.lbl_capacity.Size = new System.Drawing.Size(70, 17);
            this.lbl_capacity.TabIndex = 33;
            this.lbl_capacity.Text = "Capacity :";
            // 
            // lbl_stadium
            // 
            this.lbl_stadium.AutoSize = true;
            this.lbl_stadium.Location = new System.Drawing.Point(447, 308);
            this.lbl_stadium.Name = "lbl_stadium";
            this.lbl_stadium.Size = new System.Drawing.Size(71, 17);
            this.lbl_stadium.TabIndex = 32;
            this.lbl_stadium.Text = "Stadium  :";
            // 
            // lbl_namamanager2
            // 
            this.lbl_namamanager2.AutoSize = true;
            this.lbl_namamanager2.Location = new System.Drawing.Point(682, 187);
            this.lbl_namamanager2.Name = "lbl_namamanager2";
            this.lbl_namamanager2.Size = new System.Drawing.Size(31, 17);
            this.lbl_namamanager2.TabIndex = 31;
            this.lbl_namamanager2.Text = "N/A";
            // 
            // lbl_namacaptain2
            // 
            this.lbl_namacaptain2.AutoSize = true;
            this.lbl_namacaptain2.Location = new System.Drawing.Point(682, 239);
            this.lbl_namacaptain2.Name = "lbl_namacaptain2";
            this.lbl_namacaptain2.Size = new System.Drawing.Size(31, 17);
            this.lbl_namacaptain2.TabIndex = 30;
            this.lbl_namacaptain2.Text = "N/A";
            // 
            // lbl_namacaptain1
            // 
            this.lbl_namacaptain1.AutoSize = true;
            this.lbl_namacaptain1.Location = new System.Drawing.Point(303, 239);
            this.lbl_namacaptain1.Name = "lbl_namacaptain1";
            this.lbl_namacaptain1.Size = new System.Drawing.Size(31, 17);
            this.lbl_namacaptain1.TabIndex = 29;
            this.lbl_namacaptain1.Text = "N/A";
            // 
            // lbl_namamanager1
            // 
            this.lbl_namamanager1.AutoSize = true;
            this.lbl_namamanager1.Location = new System.Drawing.Point(303, 187);
            this.lbl_namamanager1.Name = "lbl_namamanager1";
            this.lbl_namamanager1.Size = new System.Drawing.Size(31, 17);
            this.lbl_namamanager1.TabIndex = 28;
            this.lbl_namamanager1.Text = "N/A";
            // 
            // lbl_captainkanan
            // 
            this.lbl_captainkanan.AutoSize = true;
            this.lbl_captainkanan.Location = new System.Drawing.Point(600, 239);
            this.lbl_captainkanan.Name = "lbl_captainkanan";
            this.lbl_captainkanan.Size = new System.Drawing.Size(72, 17);
            this.lbl_captainkanan.TabIndex = 27;
            this.lbl_captainkanan.Text = "Captain   :";
            // 
            // lbl_managerkanan
            // 
            this.lbl_managerkanan.AutoSize = true;
            this.lbl_managerkanan.Location = new System.Drawing.Point(600, 187);
            this.lbl_managerkanan.Name = "lbl_managerkanan";
            this.lbl_managerkanan.Size = new System.Drawing.Size(76, 17);
            this.lbl_managerkanan.TabIndex = 26;
            this.lbl_managerkanan.Text = "Manager : ";
            // 
            // lbl_captainkiri
            // 
            this.lbl_captainkiri.AutoSize = true;
            this.lbl_captainkiri.Location = new System.Drawing.Point(220, 239);
            this.lbl_captainkiri.Name = "lbl_captainkiri";
            this.lbl_captainkiri.Size = new System.Drawing.Size(72, 17);
            this.lbl_captainkiri.TabIndex = 25;
            this.lbl_captainkiri.Text = "Captain   :";
            // 
            // lbl_managerkiri
            // 
            this.lbl_managerkiri.AutoSize = true;
            this.lbl_managerkiri.Location = new System.Drawing.Point(220, 187);
            this.lbl_managerkiri.Name = "lbl_managerkiri";
            this.lbl_managerkiri.Size = new System.Drawing.Size(76, 17);
            this.lbl_managerkiri.TabIndex = 24;
            this.lbl_managerkiri.Text = "Manager : ";
            // 
            // lbl_vs
            // 
            this.lbl_vs.AutoSize = true;
            this.lbl_vs.Location = new System.Drawing.Point(517, 132);
            this.lbl_vs.Name = "lbl_vs";
            this.lbl_vs.Size = new System.Drawing.Size(26, 17);
            this.lbl_vs.TabIndex = 23;
            this.lbl_vs.Text = "VS";
            // 
            // cBox_away
            // 
            this.cBox_away.FormattingEnabled = true;
            this.cBox_away.Location = new System.Drawing.Point(603, 129);
            this.cBox_away.Name = "cBox_away";
            this.cBox_away.Size = new System.Drawing.Size(203, 24);
            this.cBox_away.TabIndex = 22;
            // 
            // cBox_home
            // 
            this.cBox_home.FormattingEnabled = true;
            this.cBox_home.Location = new System.Drawing.Point(220, 129);
            this.cBox_home.Name = "cBox_home";
            this.cBox_home.Size = new System.Drawing.Size(228, 24);
            this.cBox_home.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 1055);
            this.Controls.Add(this.lbl_hasilskor);
            this.Controls.Add(this.lbl_hasiltanggal);
            this.Controls.Add(this.lbl_skor);
            this.Controls.Add(this.lbl_tanggal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.lbl_namacapacity);
            this.Controls.Add(this.lbl_namastadium);
            this.Controls.Add(this.lbl_capacity);
            this.Controls.Add(this.lbl_stadium);
            this.Controls.Add(this.lbl_namamanager2);
            this.Controls.Add(this.lbl_namacaptain2);
            this.Controls.Add(this.lbl_namacaptain1);
            this.Controls.Add(this.lbl_namamanager1);
            this.Controls.Add(this.lbl_captainkanan);
            this.Controls.Add(this.lbl_managerkanan);
            this.Controls.Add(this.lbl_captainkiri);
            this.Controls.Add(this.lbl_managerkiri);
            this.Controls.Add(this.lbl_vs);
            this.Controls.Add(this.cBox_away);
            this.Controls.Add(this.cBox_home);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hasilskor;
        private System.Windows.Forms.Label lbl_hasiltanggal;
        private System.Windows.Forms.Label lbl_skor;
        private System.Windows.Forms.Label lbl_tanggal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnplayername1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columntipe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnplayername2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columntipe2;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label lbl_namacapacity;
        private System.Windows.Forms.Label lbl_namastadium;
        private System.Windows.Forms.Label lbl_capacity;
        private System.Windows.Forms.Label lbl_stadium;
        private System.Windows.Forms.Label lbl_namamanager2;
        private System.Windows.Forms.Label lbl_namacaptain2;
        private System.Windows.Forms.Label lbl_namacaptain1;
        private System.Windows.Forms.Label lbl_namamanager1;
        private System.Windows.Forms.Label lbl_captainkanan;
        private System.Windows.Forms.Label lbl_managerkanan;
        private System.Windows.Forms.Label lbl_captainkiri;
        private System.Windows.Forms.Label lbl_managerkiri;
        private System.Windows.Forms.Label lbl_vs;
        private System.Windows.Forms.ComboBox cBox_away;
        private System.Windows.Forms.ComboBox cBox_home;
    }
}

