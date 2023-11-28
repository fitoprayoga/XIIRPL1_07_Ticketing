namespace XIIRPL1_07_Ticketing.MasterForm
{
    partial class FrmMasterMaskapai
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
            id = new TextBox();
            txtJumlahKru = new NumericUpDown();
            txtDeskripsi = new RichTextBox();
            btnSimpan = new Button();
            button1 = new Button();
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // id
            // 
            id.Location = new Point(374, 352);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 51;
            // 
            // txtJumlahKru
            // 
            txtJumlahKru.Location = new Point(98, 279);
            txtJumlahKru.Margin = new Padding(3, 2, 3, 2);
            txtJumlahKru.Name = "txtJumlahKru";
            txtJumlahKru.Size = new Size(250, 23);
            txtJumlahKru.TabIndex = 50;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(473, 230);
            txtDeskripsi.Margin = new Padding(3, 2, 3, 2);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(251, 71);
            txtDeskripsi.TabIndex = 49;
            txtDeskripsi.Text = "";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(601, 351);
            btnSimpan.Margin = new Padding(3, 2, 3, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(82, 22);
            btnSimpan.TabIndex = 48;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(506, 351);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 47;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(98, 255);
            txtPerusahaan.Margin = new Padding(3, 2, 3, 2);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(251, 23);
            txtPerusahaan.TabIndex = 46;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(98, 230);
            txtNama.Margin = new Padding(3, 2, 3, 2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(251, 23);
            txtNama.TabIndex = 45;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(710, 141);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(403, 230);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 43;
            label8.Text = "Deskripsi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 281);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 42;
            label6.Text = "Jumlah Kru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 255);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 41;
            label4.Text = "Perusahaan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 230);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 40;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(285, 16);
            label2.TabIndex = 39;
            label2.Text = "Semua maskapai yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 38;
            label1.Text = "Master Maskapai";
            // 
            // FrmMasterMaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(id);
            Controls.Add(txtJumlahKru);
            Controls.Add(txtDeskripsi);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterMaskapai";
            Text = "FrmMasterMaskapai";
            Load += FrmMasterMaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)txtJumlahKru).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id;
        private NumericUpDown txtJumlahKru;
        private RichTextBox txtDeskripsi;
        private Button button1;
        private TextBox txtPerusahaan;
        private TextBox txtNama;
        private DataGridView dataGridView1;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSimpan;
        private DataGridViewTextBoxColumn Edit;
        private DataGridViewTextBoxColumn Delete;
    }
}