namespace XIIRPL1_07_Ticketing.MasterForm
{
    partial class FrmMasterBandara
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
            txtJumlahTerminal = new NumericUpDown();
            txtNegara = new ComboBox();
            txtAlamat = new RichTextBox();
            btnSimpan = new Button();
            button1 = new Button();
            txtKota = new TextBox();
            txtKodeIATA = new TextBox();
            txtNama = new TextBox();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // id
            // 
            id.Location = new Point(632, 401);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 57;
            id.Click += FrmMasterBandara_Load;
            // 
            // txtJumlahTerminal
            // 
            txtJumlahTerminal.Location = new Point(482, 232);
            txtJumlahTerminal.Margin = new Padding(3, 2, 3, 2);
            txtJumlahTerminal.Name = "txtJumlahTerminal";
            txtJumlahTerminal.Size = new Size(250, 23);
            txtJumlahTerminal.TabIndex = 56;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(98, 307);
            txtNegara.Margin = new Padding(3, 2, 3, 2);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(251, 23);
            txtNegara.TabIndex = 55;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(482, 257);
            txtAlamat.Margin = new Padding(3, 2, 3, 2);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(251, 72);
            txtAlamat.TabIndex = 54;
            txtAlamat.Text = "";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(650, 354);
            btnSimpan.Margin = new Padding(3, 2, 3, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(82, 22);
            btnSimpan.TabIndex = 53;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(478, 354);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 52;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(98, 281);
            txtKota.Margin = new Padding(3, 2, 3, 2);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(251, 23);
            txtKota.TabIndex = 51;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(98, 257);
            txtKodeIATA.Margin = new Padding(3, 2, 3, 2);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(251, 23);
            txtKodeIATA.TabIndex = 50;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(98, 232);
            txtNama.Margin = new Padding(3, 2, 3, 2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(251, 23);
            txtNama.TabIndex = 49;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(12, 61);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(721, 141);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(375, 232);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 47;
            label8.Text = "Jumlah Terminal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(375, 257);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 46;
            label7.Text = "Alamat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 307);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 45;
            label6.Text = "Negara";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 281);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 44;
            label5.Text = "Kota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 257);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 43;
            label4.Text = "Kode IATA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 232);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 42;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(277, 16);
            label2.TabIndex = 41;
            label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(190, 32);
            label1.TabIndex = 40;
            label1.Text = "Master Bandara";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(568, 353);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 58;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(txtJumlahTerminal);
            Controls.Add(txtNegara);
            Controls.Add(txtAlamat);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtKota);
            Controls.Add(txtKodeIATA);
            Controls.Add(txtNama);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterBandara";
            Text = "FrmMasterBandara";
            Load += FrmMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id;
        private NumericUpDown txtJumlahTerminal;
        private ComboBox txtNegara;
        private RichTextBox txtAlamat;
        private Button btnSimpan;
        private Button button1;
        private TextBox txtKota;
        private TextBox txtKodeIATA;
        private TextBox txtNama;
        private DataGridView dataGridView1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}