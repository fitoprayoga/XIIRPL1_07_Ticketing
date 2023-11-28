namespace XIIRPL1_07_Ticketing.MasterForm
{
    partial class FrmMasterKodePromo
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
            btnSimpan = new Button();
            button1 = new Button();
            txtDeskripsi = new TextBox();
            label7 = new Label();
            txtMaksimumDiskon = new NumericUpDown();
            txtPresentaseDiskon = new NumericUpDown();
            txtBerlakuSampai = new DateTimePicker();
            label6 = new Label();
            label4 = new Label();
            txtKodePromo = new TextBox();
            label3 = new Label();
            BtnDelete = new DataGridViewButtonColumn();
            BtnEdit = new DataGridViewButtonColumn();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(678, 418);
            btnSimpan.Margin = new Padding(3, 2, 3, 2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(101, 30);
            btnSimpan.TabIndex = 32;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(574, 418);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(98, 30);
            button1.TabIndex = 31;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(491, 310);
            txtDeskripsi.Margin = new Padding(3, 2, 3, 2);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(289, 98);
            txtDeskripsi.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(425, 313);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 29;
            label7.Text = "Deskripsi";
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Location = new Point(127, 387);
            txtMaksimumDiskon.Margin = new Padding(3, 2, 3, 2);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(289, 23);
            txtMaksimumDiskon.TabIndex = 28;
            // 
            // txtPresentaseDiskon
            // 
            txtPresentaseDiskon.Location = new Point(127, 360);
            txtPresentaseDiskon.Margin = new Padding(3, 2, 3, 2);
            txtPresentaseDiskon.Name = "txtPresentaseDiskon";
            txtPresentaseDiskon.Size = new Size(289, 23);
            txtPresentaseDiskon.TabIndex = 27;
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(127, 335);
            txtBerlakuSampai.Margin = new Padding(3, 2, 3, 2);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(289, 23);
            txtBerlakuSampai.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 387);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 25;
            label6.Text = "Maksimum Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 338);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 23;
            label4.Text = "Berlaku Sampai";
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(127, 310);
            txtKodePromo.Margin = new Padding(3, 2, 3, 2);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(289, 23);
            txtKodePromo.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 313);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 21;
            label3.Text = "Kode Promo";
            // 
            // BtnDelete
            // 
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // BtnEdit
            // 
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 362);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 24;
            label5.Text = "Presentase Diskon";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(7, 58);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(772, 224);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 31);
            label2.Name = "label2";
            label2.Size = new Size(291, 15);
            label2.TabIndex = 19;
            label2.Text = "Semua kode promo yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 3);
            label1.Name = "label1";
            label1.Size = new Size(220, 30);
            label1.TabIndex = 18;
            label1.Text = "Master Kode Promo";
            // 
            // id
            // 
            id.Location = new Point(446, 418);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 52;
            // 
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 493);
            Controls.Add(id);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label7);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(txtPresentaseDiskon);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtKodePromo);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterKodePromo";
            Text = "FrmMasterKodePromo";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button button1;
        private TextBox txtDeskripsi;
        private Label label7;
        private NumericUpDown txtMaksimumDiskon;
        private NumericUpDown txtPresentaseDiskon;
        private DateTimePicker txtBerlakuSampai;
        private Label label6;
        private Label label4;
        private TextBox txtKodePromo;
        private Label label3;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewButtonColumn BtnEdit;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private TextBox id;
    }
}