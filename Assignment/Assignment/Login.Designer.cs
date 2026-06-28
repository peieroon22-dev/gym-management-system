namespace Assignment
{
    partial class Login
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
            this.radio_receptionist = new System.Windows.Forms.RadioButton();
            this.radio_manager = new System.Windows.Forms.RadioButton();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_showPW = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_receptionist
            // 
            this.radio_receptionist.AutoSize = true;
            this.radio_receptionist.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_receptionist.Location = new System.Drawing.Point(552, 166);
            this.radio_receptionist.Margin = new System.Windows.Forms.Padding(4);
            this.radio_receptionist.Name = "radio_receptionist";
            this.radio_receptionist.Size = new System.Drawing.Size(146, 27);
            this.radio_receptionist.TabIndex = 51;
            this.radio_receptionist.TabStop = true;
            this.radio_receptionist.Text = "RECEPTIONIST";
            this.radio_receptionist.UseVisualStyleBackColor = true;
            // 
            // radio_manager
            // 
            this.radio_manager.AutoSize = true;
            this.radio_manager.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_manager.Location = new System.Drawing.Point(389, 166);
            this.radio_manager.Margin = new System.Windows.Forms.Padding(4);
            this.radio_manager.Name = "radio_manager";
            this.radio_manager.Size = new System.Drawing.Size(113, 27);
            this.radio_manager.TabIndex = 52;
            this.radio_manager.TabStop = true;
            this.radio_manager.Text = "MANAGER";
            this.radio_manager.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(480, 434);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 34);
            this.btn_clear.TabIndex = 49;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(323, 434);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(107, 34);
            this.btn_login.TabIndex = 50;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.PapayaWhip;
            this.txt_email.Location = new System.Drawing.Point(458, 259);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(233, 22);
            this.txt_email.TabIndex = 47;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.PapayaWhip;
            this.txt_password.Location = new System.Drawing.Point(458, 324);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(233, 22);
            this.txt_password.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(352, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(322, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(472, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 40);
            this.label1.TabIndex = 44;
            this.label1.Text = "LOGIN";
            // 
            // panel_header
            // 
            this.panel_header.Controls.Add(this.btn_restore);
            this.panel_header.Controls.Add(this.btn_min);
            this.panel_header.Controls.Add(this.btn_max);
            this.panel_header.Controls.Add(this.btn_close);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1067, 36);
            this.panel_header.TabIndex = 53;
            this.panel_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_header_Paint);
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(233)))));
            this.btn_restore.BackgroundImage = global::Assignment.Properties.Resources.minification__2_;
            this.btn_restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_restore.FlatAppearance.BorderSize = 0;
            this.btn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restore.Location = new System.Drawing.Point(896, 8);
            this.btn_restore.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(20, 20);
            this.btn_restore.TabIndex = 14;
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Visible = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(233)))));
            this.btn_min.BackgroundImage = global::Assignment.Properties.Resources.min;
            this.btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Location = new System.Drawing.Point(941, 8);
            this.btn_min.Margin = new System.Windows.Forms.Padding(4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(20, 20);
            this.btn_min.TabIndex = 15;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(233)))));
            this.btn_max.BackgroundImage = global::Assignment.Properties.Resources.max;
            this.btn_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Location = new System.Drawing.Point(984, 8);
            this.btn_max.Margin = new System.Windows.Forms.Padding(4);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(20, 20);
            this.btn_max.TabIndex = 16;
            this.btn_max.UseVisualStyleBackColor = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(233)))));
            this.btn_close.BackgroundImage = global::Assignment.Properties.Resources.close;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(1031, 8);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 20);
            this.btn_close.TabIndex = 17;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(637, 434);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 34);
            this.btn_back.TabIndex = 54;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_showPW
            // 
            this.btn_showPW.BackgroundImage = global::Assignment.Properties.Resources.eye2;
            this.btn_showPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_showPW.Location = new System.Drawing.Point(703, 320);
            this.btn_showPW.Name = "btn_showPW";
            this.btn_showPW.Size = new System.Drawing.Size(31, 31);
            this.btn_showPW.TabIndex = 55;
            this.btn_showPW.UseVisualStyleBackColor = true;
            this.btn_showPW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_showPW_MouseDown);
            this.btn_showPW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_showPW_MouseUp);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.Controls.Add(this.btn_showPW);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.radio_receptionist);
            this.Controls.Add(this.radio_manager);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_receptionist;
        private System.Windows.Forms.RadioButton radio_manager;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_showPW;
    }
}