namespace SendToEmail
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabSendMenu = new TabPage();
            labelSend = new Label();
            buttonAddToList = new Button();
            comboBoxFormats = new ComboBox();
            buttonSendEmail = new Button();
            buttonAddFile = new Button();
            listBoxFiles = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            label7 = new Label();
            textBoxBody = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBoxSubject = new TextBox();
            comboBoxEmails = new ComboBox();
            label4 = new Label();
            tabCfgDatabase = new TabPage();
            labelDelete = new Label();
            labelSaveData = new Label();
            btnSave = new Button();
            DGVUsers = new DataGridView();
            tabAddUser = new TabPage();
            labelErroeAdd = new Label();
            labelSuccesAdd = new Label();
            buttonAddUser = new Button();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxName = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timerAddUser = new System.Windows.Forms.Timer(components);
            timerSend = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabSendMenu.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tabCfgDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsers).BeginInit();
            tabAddUser.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabSendMenu);
            tabControl1.Controls.Add(tabCfgDatabase);
            tabControl1.Controls.Add(tabAddUser);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 447);
            tabControl1.TabIndex = 0;
            // 
            // tabSendMenu
            // 
            tabSendMenu.BackColor = Color.Black;
            tabSendMenu.Controls.Add(labelSend);
            tabSendMenu.Controls.Add(buttonAddToList);
            tabSendMenu.Controls.Add(comboBoxFormats);
            tabSendMenu.Controls.Add(buttonSendEmail);
            tabSendMenu.Controls.Add(buttonAddFile);
            tabSendMenu.Controls.Add(listBoxFiles);
            tabSendMenu.Controls.Add(label7);
            tabSendMenu.Controls.Add(textBoxBody);
            tabSendMenu.Controls.Add(label6);
            tabSendMenu.Controls.Add(label5);
            tabSendMenu.Controls.Add(textBoxSubject);
            tabSendMenu.Controls.Add(comboBoxEmails);
            tabSendMenu.Controls.Add(label4);
            tabSendMenu.Location = new Point(4, 29);
            tabSendMenu.Name = "tabSendMenu";
            tabSendMenu.Padding = new Padding(3);
            tabSendMenu.Size = new Size(791, 414);
            tabSendMenu.TabIndex = 0;
            tabSendMenu.Text = "Відправка листів";
            // 
            // labelSend
            // 
            labelSend.AutoSize = true;
            labelSend.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelSend.ForeColor = Color.White;
            labelSend.Location = new Point(509, 254);
            labelSend.Name = "labelSend";
            labelSend.Size = new Size(205, 28);
            labelSend.TabIndex = 12;
            labelSend.Text = "Успішно надіслано!";
            labelSend.Visible = false;
            // 
            // buttonAddToList
            // 
            buttonAddToList.BackColor = Color.Black;
            buttonAddToList.Enabled = false;
            buttonAddToList.ForeColor = Color.FromArgb(255, 128, 0);
            buttonAddToList.Location = new Point(694, 202);
            buttonAddToList.Name = "buttonAddToList";
            buttonAddToList.Size = new Size(90, 29);
            buttonAddToList.TabIndex = 11;
            buttonAddToList.Text = "Додати";
            buttonAddToList.UseVisualStyleBackColor = false;
            buttonAddToList.Click += buttonAddToList_Click;
            // 
            // comboBoxFormats
            // 
            comboBoxFormats.BackColor = Color.Black;
            comboBoxFormats.ForeColor = Color.Cyan;
            comboBoxFormats.FormattingEnabled = true;
            comboBoxFormats.Items.AddRange(new object[] { "text", "image", "audio", "video", "application" });
            comboBoxFormats.Location = new Point(578, 202);
            comboBoxFormats.Name = "comboBoxFormats";
            comboBoxFormats.Size = new Size(110, 28);
            comboBoxFormats.TabIndex = 10;
            comboBoxFormats.SelectedIndexChanged += comboBoxFormats_SelectedIndexChanged;
            // 
            // buttonSendEmail
            // 
            buttonSendEmail.BackColor = SystemColors.ActiveCaptionText;
            buttonSendEmail.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSendEmail.ForeColor = Color.White;
            buttonSendEmail.Location = new Point(518, 303);
            buttonSendEmail.Name = "buttonSendEmail";
            buttonSendEmail.Size = new Size(196, 105);
            buttonSendEmail.TabIndex = 9;
            buttonSendEmail.Text = "Надіслати листа";
            buttonSendEmail.UseVisualStyleBackColor = false;
            buttonSendEmail.Click += buttonSendEmail_Click;
            // 
            // buttonAddFile
            // 
            buttonAddFile.BackColor = Color.Black;
            buttonAddFile.ForeColor = Color.Yellow;
            buttonAddFile.Location = new Point(424, 202);
            buttonAddFile.Name = "buttonAddFile";
            buttonAddFile.Size = new Size(138, 29);
            buttonAddFile.TabIndex = 8;
            buttonAddFile.Text = "Вибрати...";
            buttonAddFile.UseVisualStyleBackColor = false;
            buttonAddFile.Click += buttonAddFile_Click;
            // 
            // listBoxFiles
            // 
            listBoxFiles.BackColor = Color.Black;
            listBoxFiles.ContextMenuStrip = contextMenuStrip1;
            listBoxFiles.ForeColor = Color.Yellow;
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.ItemHeight = 20;
            listBoxFiles.Location = new Point(355, 32);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(429, 164);
            listBoxFiles.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { DeleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(145, 28);
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(144, 24);
            DeleteToolStripMenuItem.Text = "Видалити";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(355, 3);
            label7.Name = "label7";
            label7.Size = new Size(193, 28);
            label7.TabIndex = 6;
            label7.Text = "Прикріпити файл";
            // 
            // textBoxBody
            // 
            textBoxBody.BackColor = Color.Black;
            textBoxBody.ForeColor = Color.Blue;
            textBoxBody.Location = new Point(8, 211);
            textBoxBody.Multiline = true;
            textBoxBody.Name = "textBoxBody";
            textBoxBody.Size = new Size(396, 197);
            textBoxBody.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(9, 176);
            label6.Name = "label6";
            label6.Size = new Size(153, 28);
            label6.TabIndex = 4;
            label6.Text = "Повідомлення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(6, 71);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 3;
            label5.Text = "Заголовок";
            // 
            // textBoxSubject
            // 
            textBoxSubject.BackColor = Color.Black;
            textBoxSubject.ForeColor = Color.Lime;
            textBoxSubject.Location = new Point(6, 115);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(325, 27);
            textBoxSubject.TabIndex = 2;
            // 
            // comboBoxEmails
            // 
            comboBoxEmails.BackColor = Color.Black;
            comboBoxEmails.ForeColor = Color.Red;
            comboBoxEmails.FormattingEnabled = true;
            comboBoxEmails.Location = new Point(8, 40);
            comboBoxEmails.Name = "comboBoxEmails";
            comboBoxEmails.Size = new Size(323, 28);
            comboBoxEmails.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(8, 3);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 0;
            label4.Text = "Пошта";
            // 
            // tabCfgDatabase
            // 
            tabCfgDatabase.BackColor = Color.Black;
            tabCfgDatabase.Controls.Add(labelDelete);
            tabCfgDatabase.Controls.Add(labelSaveData);
            tabCfgDatabase.Controls.Add(btnSave);
            tabCfgDatabase.Controls.Add(DGVUsers);
            tabCfgDatabase.Location = new Point(4, 29);
            tabCfgDatabase.Name = "tabCfgDatabase";
            tabCfgDatabase.Padding = new Padding(3);
            tabCfgDatabase.Size = new Size(791, 414);
            tabCfgDatabase.TabIndex = 1;
            tabCfgDatabase.Text = "Видалення і редагування юзера";
            // 
            // labelDelete
            // 
            labelDelete.AutoSize = true;
            labelDelete.ForeColor = Color.Blue;
            labelDelete.Location = new Point(332, 327);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new Size(143, 20);
            labelDelete.TabIndex = 3;
            labelDelete.Text = "Успішно видалено!";
            labelDelete.Visible = false;
            // 
            // labelSaveData
            // 
            labelSaveData.AutoSize = true;
            labelSaveData.ForeColor = Color.Lime;
            labelSaveData.Location = new Point(332, 327);
            labelSaveData.Name = "labelSaveData";
            labelSaveData.Size = new Size(154, 20);
            labelSaveData.TabIndex = 2;
            labelSaveData.Text = "Успішно збережено!";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.ForeColor = Color.Lime;
            btnSave.Location = new Point(350, 359);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 49);
            btnSave.TabIndex = 1;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // DGVUsers
            // 
            DGVUsers.ColumnHeadersHeight = 29;
            DGVUsers.Location = new Point(6, 6);
            DGVUsers.Name = "DGVUsers";
            DGVUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DGVUsers.RowTemplate.Height = 29;
            DGVUsers.Size = new Size(779, 307);
            DGVUsers.TabIndex = 0;
            DGVUsers.KeyDown += DGVUsers_KeyDown;
            // 
            // tabAddUser
            // 
            tabAddUser.BackColor = Color.Black;
            tabAddUser.Controls.Add(labelErroeAdd);
            tabAddUser.Controls.Add(labelSuccesAdd);
            tabAddUser.Controls.Add(buttonAddUser);
            tabAddUser.Controls.Add(textBoxEmail);
            tabAddUser.Controls.Add(textBoxPhone);
            tabAddUser.Controls.Add(label3);
            tabAddUser.Controls.Add(label2);
            tabAddUser.Controls.Add(label1);
            tabAddUser.Controls.Add(textBoxName);
            tabAddUser.Location = new Point(4, 29);
            tabAddUser.Name = "tabAddUser";
            tabAddUser.Size = new Size(791, 414);
            tabAddUser.TabIndex = 2;
            tabAddUser.Text = "Додавання юзера";
            // 
            // labelErroeAdd
            // 
            labelErroeAdd.AutoSize = true;
            labelErroeAdd.ForeColor = Color.Red;
            labelErroeAdd.Location = new Point(317, 280);
            labelErroeAdd.Name = "labelErroeAdd";
            labelErroeAdd.Size = new Size(168, 20);
            labelErroeAdd.TabIndex = 8;
            labelErroeAdd.Text = "Не заповнені всі поля!";
            labelErroeAdd.Visible = false;
            // 
            // labelSuccesAdd
            // 
            labelSuccesAdd.AutoSize = true;
            labelSuccesAdd.ForeColor = Color.Lime;
            labelSuccesAdd.Location = new Point(333, 280);
            labelSuccesAdd.Name = "labelSuccesAdd";
            labelSuccesAdd.Size = new Size(127, 20);
            labelSuccesAdd.TabIndex = 7;
            labelSuccesAdd.Text = "Успішно додано!";
            labelSuccesAdd.Visible = false;
            // 
            // buttonAddUser
            // 
            buttonAddUser.BackColor = SystemColors.ActiveCaptionText;
            buttonAddUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonAddUser.ForeColor = Color.Blue;
            buttonAddUser.Location = new Point(273, 319);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(250, 75);
            buttonAddUser.TabIndex = 6;
            buttonAddUser.Text = "Додати юзера";
            buttonAddUser.UseVisualStyleBackColor = false;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxEmail.ForeColor = Color.Lime;
            textBoxEmail.Location = new Point(49, 234);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(735, 34);
            textBoxEmail.TabIndex = 5;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxPhone.ForeColor = Color.Yellow;
            textBoxPhone.Location = new Point(49, 154);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(735, 34);
            textBoxPhone.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(49, 195);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 3;
            label3.Text = "Пошта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(49, 122);
            label2.Name = "label2";
            label2.Size = new Size(184, 28);
            label2.TabIndex = 2;
            label2.Text = "Номер телефону";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(49, 33);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 1;
            label1.Text = "Повне ім'я";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.Red;
            textBoxName.Location = new Point(49, 74);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(735, 34);
            textBoxName.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timerAddUser
            // 
            timerAddUser.Interval = 1000;
            timerAddUser.Tick += timerAddUser_Tick;
            // 
            // timerSend
            // 
            timerSend.Interval = 1000;
            timerSend.Tick += timerSend_Tick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            tabControl1.ResumeLayout(false);
            tabSendMenu.ResumeLayout(false);
            tabSendMenu.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            tabCfgDatabase.ResumeLayout(false);
            tabCfgDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsers).EndInit();
            tabAddUser.ResumeLayout(false);
            tabAddUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabSendMenu;
        private TabPage tabCfgDatabase;
        private Button btnSave;
        private DataGridView DGVUsers;
        private TabPage tabAddUser;
        private Button buttonAddUser;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxName;
        private ComboBox comboBoxEmails;
        private Label label4;
        private TextBox textBoxBody;
        private Label label6;
        private Label label5;
        private TextBox textBoxSubject;
        private Button buttonAddFile;
        private ListBox listBoxFiles;
        private Label label7;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private Button buttonSendEmail;
        private Button buttonAddToList;
        private ComboBox comboBoxFormats;
        private Label labelSaveData;
        private System.Windows.Forms.Timer timer1;
        private Label labelErroeAdd;
        private Label labelSuccesAdd;
        private System.Windows.Forms.Timer timerAddUser;
        private Label labelDelete;
        private Label labelSend;
        private System.Windows.Forms.Timer timerSend;
    }
}