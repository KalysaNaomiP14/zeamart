namespace zeamart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_stok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_kategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_namabarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ZeaMart = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tb_stok);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_harga);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_kategori);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_namabarang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(44, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 341);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 341);
            this.panel3.TabIndex = 10;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.Location = new System.Drawing.Point(56, 290);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(140, 34);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.IndianRed;
            this.btn_update.Location = new System.Drawing.Point(56, 243);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(140, 34);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.IndianRed;
            this.btn_add.Location = new System.Drawing.Point(56, 196);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(140, 34);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.Image = global::zeamart.Properties.Resources.image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tb_stok
            // 
            this.tb_stok.Location = new System.Drawing.Point(415, 262);
            this.tb_stok.Name = "tb_stok";
            this.tb_stok.Size = new System.Drawing.Size(378, 31);
            this.tb_stok.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stok";
            // 
            // tb_harga
            // 
            this.tb_harga.Location = new System.Drawing.Point(415, 209);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(378, 31);
            this.tb_harga.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Harga";
            // 
            // tb_kategori
            // 
            this.tb_kategori.Location = new System.Drawing.Point(415, 156);
            this.tb_kategori.Name = "tb_kategori";
            this.tb_kategori.Size = new System.Drawing.Size(378, 31);
            this.tb_kategori.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori";
            // 
            // tb_namabarang
            // 
            this.tb_namabarang.Location = new System.Drawing.Point(415, 100);
            this.tb_namabarang.Name = "tb_namabarang";
            this.tb_namabarang.Size = new System.Drawing.Size(378, 31);
            this.tb_namabarang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Barang";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(415, 48);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(378, 31);
            this.tb_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // ZeaMart
            // 
            this.ZeaMart.AutoSize = true;
            this.ZeaMart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ZeaMart.ForeColor = System.Drawing.Color.DarkRed;
            this.ZeaMart.Location = new System.Drawing.Point(407, 45);
            this.ZeaMart.Name = "ZeaMart";
            this.ZeaMart.Size = new System.Drawing.Size(93, 28);
            this.ZeaMart.TabIndex = 1;
            this.ZeaMart.Text = "ZeaMart";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.tb_search);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(44, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 337);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(754, 221);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(119, 28);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(674, 31);
            this.tb_search.TabIndex = 11;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 854);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ZeaMart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private PictureBox pictureBox1;
        private TextBox tb_stok;
        private Label label5;
        private TextBox tb_harga;
        private Label label4;
        private TextBox tb_kategori;
        private Label label3;
        private TextBox tb_namabarang;
        private Label label2;
        private TextBox tb_id;
        private Label label1;
        private Label ZeaMart;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox tb_search;
        private Label label6;
    }
}