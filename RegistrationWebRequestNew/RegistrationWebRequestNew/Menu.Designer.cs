namespace RegistrationWebRequestNew
{
    partial class Menu
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
            tabControl1 = new TabControl();
            tabRegistration = new TabPage();
            btnLogOn = new Button();
            btnChoosePhoto = new Button();
            textPhoto = new TextBox();
            textConfirmpassword = new TextBox();
            textPassword = new TextBox();
            textPhone = new TextBox();
            textEmail = new TextBox();
            textSecondname = new TextBox();
            textFirstname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabViewDB = new TabPage();
            dataGridViewDB = new DataGridView();
            tabControl1.SuspendLayout();
            tabRegistration.SuspendLayout();
            tabViewDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDB).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabRegistration);
            tabControl1.Controls.Add(tabViewDB);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(976, 484);
            tabControl1.TabIndex = 0;
            // 
            // tabRegistration
            // 
            tabRegistration.BackColor = Color.Black;
            tabRegistration.Controls.Add(btnLogOn);
            tabRegistration.Controls.Add(btnChoosePhoto);
            tabRegistration.Controls.Add(textPhoto);
            tabRegistration.Controls.Add(textConfirmpassword);
            tabRegistration.Controls.Add(textPassword);
            tabRegistration.Controls.Add(textPhone);
            tabRegistration.Controls.Add(textEmail);
            tabRegistration.Controls.Add(textSecondname);
            tabRegistration.Controls.Add(textFirstname);
            tabRegistration.Controls.Add(label7);
            tabRegistration.Controls.Add(label6);
            tabRegistration.Controls.Add(label5);
            tabRegistration.Controls.Add(label4);
            tabRegistration.Controls.Add(label3);
            tabRegistration.Controls.Add(label2);
            tabRegistration.Controls.Add(label1);
            tabRegistration.ForeColor = Color.Black;
            tabRegistration.Location = new Point(4, 29);
            tabRegistration.Name = "tabRegistration";
            tabRegistration.Padding = new Padding(3);
            tabRegistration.Size = new Size(968, 451);
            tabRegistration.TabIndex = 0;
            tabRegistration.Text = "Реєстрація";
            // 
            // btnLogOn
            // 
            btnLogOn.BackColor = Color.Black;
            btnLogOn.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnLogOn.ForeColor = Color.White;
            btnLogOn.Location = new Point(380, 379);
            btnLogOn.Name = "btnLogOn";
            btnLogOn.Size = new Size(241, 63);
            btnLogOn.TabIndex = 15;
            btnLogOn.Text = "Зареєструватись";
            btnLogOn.UseVisualStyleBackColor = false;
            btnLogOn.Click += btnLogOn_Click;
            // 
            // btnChoosePhoto
            // 
            btnChoosePhoto.BackColor = Color.Black;
            btnChoosePhoto.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoosePhoto.ForeColor = Color.FromArgb(255, 128, 0);
            btnChoosePhoto.Location = new Point(799, 330);
            btnChoosePhoto.Name = "btnChoosePhoto";
            btnChoosePhoto.Size = new Size(162, 34);
            btnChoosePhoto.TabIndex = 14;
            btnChoosePhoto.Text = "Вибрати...";
            btnChoosePhoto.UseVisualStyleBackColor = false;
            btnChoosePhoto.Click += btnChoosePhoto_Click;
            // 
            // textPhoto
            // 
            textPhoto.BackColor = Color.Black;
            textPhoto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPhoto.ForeColor = Color.FromArgb(255, 128, 0);
            textPhoto.Location = new Point(78, 330);
            textPhoto.Name = "textPhoto";
            textPhoto.Size = new Size(715, 34);
            textPhoto.TabIndex = 13;
            // 
            // textConfirmpassword
            // 
            textConfirmpassword.BackColor = Color.Black;
            textConfirmpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textConfirmpassword.ForeColor = Color.Blue;
            textConfirmpassword.Location = new Point(267, 279);
            textConfirmpassword.Name = "textConfirmpassword";
            textConfirmpassword.Size = new Size(694, 34);
            textConfirmpassword.TabIndex = 12;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.Black;
            textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.ForeColor = Color.FromArgb(0, 0, 192);
            textPassword.Location = new Point(100, 227);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(861, 34);
            textPassword.TabIndex = 11;
            // 
            // textPhone
            // 
            textPhone.BackColor = Color.Black;
            textPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPhone.ForeColor = Color.Fuchsia;
            textPhone.Location = new Point(121, 164);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(840, 34);
            textPhone.TabIndex = 10;
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.Black;
            textEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textEmail.ForeColor = Color.Yellow;
            textEmail.Location = new Point(89, 108);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(872, 34);
            textEmail.TabIndex = 9;
            // 
            // textSecondname
            // 
            textSecondname.BackColor = Color.Black;
            textSecondname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textSecondname.ForeColor = Color.Lime;
            textSecondname.Location = new Point(146, 62);
            textSecondname.Name = "textSecondname";
            textSecondname.Size = new Size(815, 34);
            textSecondname.TabIndex = 8;
            // 
            // textFirstname
            // 
            textFirstname.BackColor = Color.Black;
            textFirstname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textFirstname.ForeColor = Color.Red;
            textFirstname.Location = new Point(81, 11);
            textFirstname.Name = "textFirstname";
            textFirstname.Size = new Size(880, 34);
            textFirstname.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(8, 333);
            label7.Name = "label7";
            label7.Size = new Size(64, 28);
            label7.TabIndex = 6;
            label7.Text = "Фото";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(8, 282);
            label6.Name = "label6";
            label6.Size = new Size(253, 28);
            label6.TabIndex = 5;
            label6.Text = "Підтвердження паролю";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(8, 227);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 4;
            label5.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Fuchsia;
            label4.Location = new Point(6, 170);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 3;
            label4.Text = "Телефон";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 2;
            label3.Text = "Пошта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(134, 35);
            label2.TabIndex = 1;
            label2.Text = "Прізвище";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(67, 37);
            label1.TabIndex = 0;
            label1.Text = "Ім'я";
            // 
            // tabViewDB
            // 
            tabViewDB.BackColor = Color.Black;
            tabViewDB.Controls.Add(dataGridViewDB);
            tabViewDB.Location = new Point(4, 29);
            tabViewDB.Name = "tabViewDB";
            tabViewDB.Padding = new Padding(3);
            tabViewDB.Size = new Size(968, 451);
            tabViewDB.TabIndex = 1;
            tabViewDB.Text = "Вивід Бази";
            // 
            // dataGridViewDB
            // 
            dataGridViewDB.AllowUserToAddRows = false;
            dataGridViewDB.AllowUserToDeleteRows = false;
            dataGridViewDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDB.GridColor = Color.Blue;
            dataGridViewDB.Location = new Point(0, 0);
            dataGridViewDB.Name = "dataGridViewDB";
            dataGridViewDB.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewDB.RowTemplate.Height = 29;
            dataGridViewDB.Size = new Size(968, 451);
            dataGridViewDB.TabIndex = 0;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 483);
            Controls.Add(tabControl1);
            Name = "Menu";
            Text = "Меню";
            tabControl1.ResumeLayout(false);
            tabRegistration.ResumeLayout(false);
            tabRegistration.PerformLayout();
            tabViewDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabRegistration;
        private Button btnChoosePhoto;
        private TextBox textPhoto;
        private TextBox textConfirmpassword;
        private TextBox textPassword;
        private TextBox textPhone;
        private TextBox textEmail;
        private TextBox textSecondname;
        private TextBox textFirstname;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabViewDB;
        private Button btnLogOn;
        private DataGridView dataGridViewDB;
    }
}