namespace WinUpload
{
    partial class MainForm
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
            txtPath = new TextBox();
            label1 = new Label();
            btnSelect = new Button();
            btnUploadToServer = new Button();
            SuspendLayout();
            // 
            // txtPath
            // 
            txtPath.Location = new Point(51, 76);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(392, 27);
            txtPath.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 41);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "Шлях до фото";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(464, 76);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Обрати";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnUploadToServer
            // 
            btnUploadToServer.Location = new Point(425, 194);
            btnUploadToServer.Name = "btnUploadToServer";
            btnUploadToServer.Size = new Size(94, 29);
            btnUploadToServer.TabIndex = 3;
            btnUploadToServer.Text = "Загрузить";
            btnUploadToServer.UseVisualStyleBackColor = true;
            btnUploadToServer.Click += btnUploadToServer_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 275);
            Controls.Add(btnUploadToServer);
            Controls.Add(btnSelect);
            Controls.Add(label1);
            Controls.Add(txtPath);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Загрузка фото на сервер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPath;
        private Label label1;
        private Button btnSelect;
        private Button btnUploadToServer;
    }
}