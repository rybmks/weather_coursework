namespace weather
{
    partial class MainForm
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
            this.LogAsAdmin = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.TextBox();
            this.FindWeather = new System.Windows.Forms.Button();
            this.SessionLabel = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogAsAdmin
            // 
            this.LogAsAdmin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LogAsAdmin.AutoSize = true;
            this.LogAsAdmin.BackColor = System.Drawing.Color.RoyalBlue;
            this.LogAsAdmin.FlatAppearance.BorderSize = 0;
            this.LogAsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogAsAdmin.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogAsAdmin.ForeColor = System.Drawing.Color.White;
            this.LogAsAdmin.Location = new System.Drawing.Point(189, 325);
            this.LogAsAdmin.Name = "LogAsAdmin";
            this.LogAsAdmin.Size = new System.Drawing.Size(206, 35);
            this.LogAsAdmin.TabIndex = 0;
            this.LogAsAdmin.Text = "Вхід для адміністраторів";
            this.LogAsAdmin.UseVisualStyleBackColor = false;
            this.LogAsAdmin.Click += new System.EventHandler(this.LogAsAdmin_Click);
            this.LogAsAdmin.MouseEnter += new System.EventHandler(this.FindWeather_MouseEnter);
            this.LogAsAdmin.MouseLeave += new System.EventHandler(this.FindWeather_MouseLeave);
            // 
            // Location
            // 
            this.Location.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Location.BackColor = System.Drawing.Color.White;
            this.Location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Location.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location.ForeColor = System.Drawing.Color.Black;
            this.Location.Location = new System.Drawing.Point(194, 139);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(196, 31);
            this.Location.TabIndex = 1;
            // 
            // FindWeather
            // 
            this.FindWeather.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FindWeather.BackColor = System.Drawing.Color.RoyalBlue;
            this.FindWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FindWeather.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(49)))), ((int)(((byte)(94)))));
            this.FindWeather.FlatAppearance.BorderSize = 0;
            this.FindWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindWeather.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindWeather.ForeColor = System.Drawing.Color.White;
            this.FindWeather.Location = new System.Drawing.Point(164, 181);
            this.FindWeather.Name = "FindWeather";
            this.FindWeather.Size = new System.Drawing.Size(256, 63);
            this.FindWeather.TabIndex = 2;
            this.FindWeather.Text = "Пошук погоди";
            this.FindWeather.UseVisualStyleBackColor = false;
            this.FindWeather.Click += new System.EventHandler(this.FindWeather_Click);
            this.FindWeather.MouseEnter += new System.EventHandler(this.FindWeather_MouseEnter);
            this.FindWeather.MouseLeave += new System.EventHandler(this.FindWeather_MouseLeave);
            // 
            // SessionLabel
            // 
            this.SessionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SessionLabel.AutoSize = true;
            this.SessionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SessionLabel.Location = new System.Drawing.Point(269, 367);
            this.SessionLabel.Name = "SessionLabel";
            this.SessionLabel.Size = new System.Drawing.Size(45, 19);
            this.SessionLabel.TabIndex = 3;
            this.SessionLabel.Text = "label1";
            // 
            // LogOut
            // 
            this.LogOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogOut.AutoSize = true;
            this.LogOut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut.ForeColor = System.Drawing.Color.MediumBlue;
            this.LogOut.Location = new System.Drawing.Point(273, 390);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(38, 15);
            this.LogOut.TabIndex = 4;
            this.LogOut.Text = "label1";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            this.LogOut.MouseEnter += new System.EventHandler(this.LogOut_MouseEnter);
            this.LogOut.MouseLeave += new System.EventHandler(this.LogOut_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть назву міста:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LogOut, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.FindWeather, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Location, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SessionLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LogAsAdmin, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.06725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.41215F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.99349F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.00434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.073753F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.18438F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 461);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather.com";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogAsAdmin;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Button FindWeather;
        private System.Windows.Forms.Label SessionLabel;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}