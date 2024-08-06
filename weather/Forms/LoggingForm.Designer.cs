namespace weather
{
    partial class LoggingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Label();
            this.aut = new System.Windows.Forms.Label();
            this.LogginField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.aut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 88);
            this.panel1.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BackButton.Location = new System.Drawing.Point(344, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(56, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseEnter += new System.EventHandler(this.BackButton_MouseEnter);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // aut
            // 
            this.aut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.aut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aut.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aut.Location = new System.Drawing.Point(0, 0);
            this.aut.Name = "aut";
            this.aut.Size = new System.Drawing.Size(400, 88);
            this.aut.TabIndex = 0;
            this.aut.Text = "Авторизація";
            this.aut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogginField
            // 
            this.LogginField.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogginField.Location = new System.Drawing.Point(118, 118);
            this.LogginField.Multiline = true;
            this.LogginField.Name = "LogginField";
            this.LogginField.Size = new System.Drawing.Size(197, 47);
            this.LogginField.TabIndex = 3;
            this.LogginField.Enter += new System.EventHandler(this.LogginField_Enter);
            this.LogginField.Leave += new System.EventHandler(this.LogginField_Leave);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.Location = new System.Drawing.Point(118, 195);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(197, 34);
            this.PasswordField.TabIndex = 4;
            this.PasswordField.UseSystemPasswordChar = true;
            this.PasswordField.Enter += new System.EventHandler(this.PasswordField_Enter);
            this.PasswordField.Leave += new System.EventHandler(this.PasswordField_Leave);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EnterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EnterButton.FlatAppearance.BorderSize = 0;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.ForeColor = System.Drawing.Color.White;
            this.EnterButton.Location = new System.Drawing.Point(118, 269);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(155, 38);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Вхід";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            this.EnterButton.MouseEnter += new System.EventHandler(this.EnterButton_MouseEnter);
            this.EnterButton.MouseLeave += new System.EventHandler(this.EnterButton_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::weather.Properties.Resources.password_icon;
            this.pictureBox2.Location = new System.Drawing.Point(52, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::weather.Properties.Resources.user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(52, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoggingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(400, 342);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.LogginField);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoggingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoggingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoggingForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label aut;
        private System.Windows.Forms.Label BackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LogginField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button EnterButton;
    }
}