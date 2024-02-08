namespace Registration
{
    partial class Registration
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
            RegistrationTab = new TabPage();
            addUserBtn = new Button();
            choosePhotoBtn = new Button();
            photoPathTxt = new TextBox();
            label3 = new Label();
            passwordTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            nicknameTxt = new TextBox();
            UsersTab = new TabPage();
            UsersDataGridView = new DataGridView();
            tabControl1.SuspendLayout();
            RegistrationTab.SuspendLayout();
            UsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(RegistrationTab);
            tabControl1.Controls.Add(UsersTab);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 438);
            tabControl1.TabIndex = 0;
            // 
            // RegistrationTab
            // 
            RegistrationTab.BackColor = Color.Black;
            RegistrationTab.Controls.Add(addUserBtn);
            RegistrationTab.Controls.Add(choosePhotoBtn);
            RegistrationTab.Controls.Add(photoPathTxt);
            RegistrationTab.Controls.Add(label3);
            RegistrationTab.Controls.Add(passwordTxt);
            RegistrationTab.Controls.Add(label2);
            RegistrationTab.Controls.Add(label1);
            RegistrationTab.Controls.Add(nicknameTxt);
            RegistrationTab.Location = new Point(4, 29);
            RegistrationTab.Name = "RegistrationTab";
            RegistrationTab.Padding = new Padding(3);
            RegistrationTab.Size = new Size(786, 405);
            RegistrationTab.TabIndex = 0;
            RegistrationTab.Text = "Реєстрація";
            // 
            // addUserBtn
            // 
            addUserBtn.BackColor = Color.Black;
            addUserBtn.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            addUserBtn.ForeColor = Color.Blue;
            addUserBtn.Location = new Point(210, 347);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new Size(350, 52);
            addUserBtn.TabIndex = 7;
            addUserBtn.Text = "Зареєструватись";
            addUserBtn.UseVisualStyleBackColor = false;
            addUserBtn.Click += addUserBtn_Click;
            // 
            // choosePhotoBtn
            // 
            choosePhotoBtn.BackColor = Color.Black;
            choosePhotoBtn.Font = new Font("Snap ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            choosePhotoBtn.ForeColor = Color.Lime;
            choosePhotoBtn.Location = new Point(528, 268);
            choosePhotoBtn.Name = "choosePhotoBtn";
            choosePhotoBtn.Size = new Size(252, 56);
            choosePhotoBtn.TabIndex = 6;
            choosePhotoBtn.Text = "Обрати...";
            choosePhotoBtn.UseVisualStyleBackColor = false;
            choosePhotoBtn.Click += choosePhotoBtn_Click;
            // 
            // photoPathTxt
            // 
            photoPathTxt.BackColor = Color.Black;
            photoPathTxt.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point);
            photoPathTxt.ForeColor = Color.Lime;
            photoPathTxt.Location = new Point(32, 284);
            photoPathTxt.Name = "photoPathTxt";
            photoPathTxt.Size = new Size(473, 30);
            photoPathTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(32, 231);
            label3.Name = "label3";
            label3.Size = new Size(94, 42);
            label3.TabIndex = 4;
            label3.Text = "Фото";
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.Black;
            passwordTxt.Font = new Font("Yu Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTxt.ForeColor = Color.Fuchsia;
            passwordTxt.Location = new Point(31, 153);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(749, 60);
            passwordTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(31, 111);
            label2.Name = "label2";
            label2.Size = new Size(126, 42);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(32, 11);
            label1.Name = "label1";
            label1.Size = new Size(176, 42);
            label1.TabIndex = 1;
            label1.Text = "Псевдонім";
            // 
            // nicknameTxt
            // 
            nicknameTxt.BackColor = Color.Black;
            nicknameTxt.Font = new Font("Ravie", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            nicknameTxt.ForeColor = Color.Red;
            nicknameTxt.Location = new Point(31, 56);
            nicknameTxt.Name = "nicknameTxt";
            nicknameTxt.Size = new Size(749, 51);
            nicknameTxt.TabIndex = 0;
            // 
            // UsersTab
            // 
            UsersTab.Controls.Add(UsersDataGridView);
            UsersTab.Location = new Point(4, 29);
            UsersTab.Name = "UsersTab";
            UsersTab.Padding = new Padding(3);
            UsersTab.Size = new Size(786, 405);
            UsersTab.TabIndex = 1;
            UsersTab.Text = "Користувачі";
            UsersTab.UseVisualStyleBackColor = true;
            // 
            // UsersDataGridView
            // 
            UsersDataGridView.AllowUserToAddRows = false;
            UsersDataGridView.AllowUserToDeleteRows = false;
            UsersDataGridView.BackgroundColor = SystemColors.ActiveCaptionText;
            UsersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDataGridView.GridColor = Color.Red;
            UsersDataGridView.Location = new Point(6, 6);
            UsersDataGridView.Name = "UsersDataGridView";
            UsersDataGridView.ReadOnly = true;
            UsersDataGridView.RowHeadersWidth = 51;
            UsersDataGridView.RowTemplate.Height = 29;
            UsersDataGridView.Size = new Size(772, 393);
            UsersDataGridView.TabIndex = 0;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            tabControl1.ResumeLayout(false);
            RegistrationTab.ResumeLayout(false);
            RegistrationTab.PerformLayout();
            UsersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage RegistrationTab;
        private TabPage UsersTab;
        private Button choosePhotoBtn;
        private TextBox photoPathTxt;
        private Label label3;
        private TextBox passwordTxt;
        private Label label2;
        private Label label1;
        private TextBox nicknameTxt;
        private Button addUserBtn;
        private DataGridView UsersDataGridView;
    }
}