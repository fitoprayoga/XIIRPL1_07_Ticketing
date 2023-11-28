namespace XIIRPL1_07_Ticketing.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
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
            txtHargaPerTiket = new NumericUpDown();
            txtDurasiPenerbangan = new TextBox();
            txtWaktuKeberangkatan = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            txtTanggal = new DateTimePicker();
            txtDari = new ComboBox();
            txtKe = new ComboBox();
            txtMaskapai = new ComboBox();
            label5 = new Label();
            btnSimpan = new Button();
            button1 = new Button();
            txtKodePenerbangan = new TextBox();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtHargaPerTiket
            // 
            txtHargaPerTiket.Location = new Point(540, 297);
            txtHargaPerTiket.Margin = new Padding(3, 2, 3, 2);
            txtHargaPerTiket.Name = "txtHargaPerTiket";
            txtHargaPerTiket.Size = new Size(249, 23);
            txtHargaPerTiket.TabIndex = 82;
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(540, 274);
            txtDurasiPenerbangan.Margin = new Padding(3, 2, 3, 2);
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(250, 23);
            txtDurasiPenerbangan.TabIndex = 81;
            // 
            // txtWaktuKeberangkatan
            // 
            txtWaktuKeberangkatan.Location = new Point(540, 248);
            txtWaktuKeberangkatan.Margin = new Padding(3, 2, 3, 2);
            txtWaktuKeberangkatan.Name = "txtWaktuKeberangkatan";
            txtWaktuKeberangkatan.Size = new Size(250, 23);
            txtWaktuKeberangkatan.TabIndex = 80;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(395, 273);
            label10.Name = "label10";
            label10.Size = new Size(113, 15);
            label10.TabIndex = 79;
            label10.Text = "Durasi Penerbangan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(395, 299);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 78;
            label9.Text = "Harga per Tiket";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 248);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 77;
            label7.Text = "Waktu Keberangkatan";
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(540, 224);
            txtTanggal.Margin = new Padding(3, 2, 3, 2);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(250, 23);
            txtTanggal.TabIndex = 76;
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(136, 248);
            txtDari.Margin = new Padding(3, 2, 3, 2);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(251, 23);
            txtDari.TabIndex = 75;
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(136, 273);
            txtKe.Margin = new Padding(3, 2, 3, 2);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(251, 23);
            txtKe.TabIndex = 74;
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(136, 299);
            txtMaskapai.Margin = new Padding(3, 2, 3, 2);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(251, 23);
            txtMaskapai.TabIndex = 73;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 299);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 72;
            label5.Text = "Maskapai";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(715, 344);
            btnSimpan.Margin = new Padding(3, 2, 3, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(82, 22);
            btnSimpan.TabIndex = 71;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(540, 344);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 70;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(136, 222);
            txtKodePenerbangan.Margin = new Padding(3, 2, 3, 2);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(251, 23);
            txtKodePenerbangan.TabIndex = 69;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(4, 59);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(785, 141);
            dataGridView1.TabIndex = 68;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += FrmMasterJadwalPenerbangan_Load;
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
            label8.Location = new Point(395, 222);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 67;
            label8.Text = "Tanggal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 273);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 66;
            label6.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 248);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 65;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 222);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 64;
            label3.Text = "Kode Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 33);
            label2.Name = "label2";
            label2.Size = new Size(343, 16);
            label2.TabIndex = 63;
            label2.Text = "Semua jadwal penerbangan yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(321, 32);
            label1.TabIndex = 62;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // id
            // 
            id.Location = new Point(408, 359);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 83;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(628, 344);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 84;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button2_Click;
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(txtHargaPerTiket);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(txtWaktuKeberangkatan);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(txtTanggal);
            Controls.Add(txtDari);
            Controls.Add(txtKe);
            Controls.Add(txtMaskapai);
            Controls.Add(label5);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterJadwalPenerbangan";
            Text = "FrmMasterJadwalPenerbangan";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTiket).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown txtHargaPerTiket;
        private TextBox txtDurasiPenerbangan;
        private TextBox txtWaktuKeberangkatan;
        private Label label10;
        private Label label9;
        private Label label7;
        private DateTimePicker txtTanggal;
        private ComboBox txtDari;
        private ComboBox txtKe;
        private ComboBox txtMaskapai;
        private Label label5;
        private Button btnSimpan;
        private Button button1;
        private TextBox txtKodePenerbangan;
        private DataGridView dataGridView1;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn Edit;
        private DataGridViewTextBoxColumn Delete;
        private TextBox id;
        private Button btnEdit;
    }
}