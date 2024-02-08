namespace ClientWindow2
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
            sendBtn = new Button();
            message = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            MenuTab = new TabPage();
            tabPage2 = new TabPage();
            saveBtn = new Button();
            PORTtxt = new TextBox();
            label2 = new Label();
            IPtxt = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            MenuTab.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // sendBtn
            // 
            sendBtn.BackColor = Color.Black;
            sendBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            sendBtn.ForeColor = Color.Lime;
            sendBtn.Location = new Point(108, 149);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(201, 74);
            sendBtn.TabIndex = 7;
            sendBtn.Text = "Надіслати";
            sendBtn.UseVisualStyleBackColor = false;
            sendBtn.Click += sendBtn_Click;
            // 
            // message
            // 
            message.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            message.ForeColor = Color.Red;
            message.Location = new Point(19, 94);
            message.Name = "message";
            message.Size = new Size(394, 31);
            message.TabIndex = 5;
            message.KeyDown += message_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(19, 48);
            label1.Name = "label1";
            label1.Size = new Size(394, 31);
            label1.TabIndex = 4;
            label1.Text = "Введіть повідомлення на сервер:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(MenuTab);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(446, 285);
            tabControl1.TabIndex = 15;
            // 
            // MenuTab
            // 
            MenuTab.BackColor = Color.Black;
            MenuTab.Controls.Add(label1);
            MenuTab.Controls.Add(message);
            MenuTab.Controls.Add(sendBtn);
            MenuTab.ForeColor = Color.Red;
            MenuTab.Location = new Point(4, 29);
            MenuTab.Name = "MenuTab";
            MenuTab.Padding = new Padding(3);
            MenuTab.Size = new Size(438, 252);
            MenuTab.TabIndex = 0;
            MenuTab.Text = "Меню";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(saveBtn);
            tabPage2.Controls.Add(PORTtxt);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(IPtxt);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(438, 252);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Налаштування";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Black;
            saveBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            saveBtn.ForeColor = Color.Blue;
            saveBtn.Location = new Point(137, 191);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(159, 51);
            saveBtn.TabIndex = 19;
            saveBtn.Text = "Зберегти";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // PORTtxt
            // 
            PORTtxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PORTtxt.ForeColor = Color.Lime;
            PORTtxt.Location = new Point(6, 139);
            PORTtxt.Name = "PORTtxt";
            PORTtxt.Size = new Size(420, 31);
            PORTtxt.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(6, 101);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 17;
            label2.Text = "Порт сервера:";
            // 
            // IPtxt
            // 
            IPtxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            IPtxt.ForeColor = Color.Red;
            IPtxt.Location = new Point(6, 53);
            IPtxt.Name = "IPtxt";
            IPtxt.Size = new Size(420, 31);
            IPtxt.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(6, 17);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 15;
            label3.Text = "IP адрес сервера:";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(442, 283);
            Controls.Add(tabControl1);
            Name = "Menu";
            Text = "Program";
            tabControl1.ResumeLayout(false);
            MenuTab.ResumeLayout(false);
            MenuTab.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button sendBtn;
        private TextBox message;
        private Label label1;
        private TabControl tabControl1;
        private TabPage MenuTab;
        private TabPage tabPage2;
        private Button saveBtn;
        private TextBox PORTtxt;
        private Label label2;
        private TextBox IPtxt;
        private Label label3;
    }
}