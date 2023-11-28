namespace XIIRPL1_07_Ticketing.MasterForm
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            txtNama = new TextBox();
            txtPassword = new TextBox();
            txtNomorTlp = new TextBox();
            txtUsername = new TextBox();
            txtTglLahir = new DateTimePicker();
            btnDaftar = new Button();
            txtLinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Daftar Akun";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 45);
            label2.Name = "label2";
            label2.Size = new Size(304, 15);
            label2.TabIndex = 1;
            label2.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 76);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 298);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 3;
            label4.Text = "Sudah punya akun?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 201);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 170);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 5;
            label6.Text = "Nomor Telepon";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 139);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 6;
            label7.Text = "Tanggal Lahir";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 107);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 7;
            label8.Text = "Nama";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(402, 86);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 162);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(135, 107);
            txtNama.Margin = new Padding(3, 2, 3, 2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(219, 23);
            txtNama.TabIndex = 9;
            txtNama.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(135, 201);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(219, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtNomorTlp
            // 
            txtNomorTlp.Location = new Point(135, 170);
            txtNomorTlp.Margin = new Padding(3, 2, 3, 2);
            txtNomorTlp.Name = "txtNomorTlp";
            txtNomorTlp.Size = new Size(219, 23);
            txtNomorTlp.TabIndex = 11;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(135, 76);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(219, 23);
            txtUsername.TabIndex = 12;
            // 
            // txtTglLahir
            // 
            txtTglLahir.Location = new Point(135, 139);
            txtTglLahir.Margin = new Padding(3, 2, 3, 2);
            txtTglLahir.Name = "txtTglLahir";
            txtTglLahir.Size = new Size(219, 23);
            txtTglLahir.TabIndex = 13;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(269, 235);
            btnDaftar.Margin = new Padding(3, 2, 3, 2);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(82, 22);
            btnDaftar.TabIndex = 14;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Location = new Point(135, 298);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(37, 15);
            txtLinkLabel.TabIndex = 15;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Login";
            txtLinkLabel.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(700, 338);
            Controls.Add(txtLinkLabel);
            Controls.Add(btnDaftar);
            Controls.Add(txtTglLahir);
            Controls.Add(txtUsername);
            Controls.Add(txtNomorTlp);
            Controls.Add(txtPassword);
            Controls.Add(txtNama);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRegister";
            Text = "FrmRegister";
            Load += FrmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private TextBox txtNama;
        private TextBox txtPassword;
        private TextBox txtNomorTlp;
        private TextBox txtUsername;
        private DateTimePicker txtTglLahir;
        private Button btnDaftar;
        private LinkLabel txtLinkLabel;
    }
}