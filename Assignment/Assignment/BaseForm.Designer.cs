namespace Assignment
{
    partial class BaseForm
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_receptionist = new System.Windows.Forms.Button();
            this.btn_trainer = new System.Windows.Forms.Button();
            this.btn_member = new System.Windows.Forms.Button();
            this.btn_trainSession = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_appointment = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_header.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.Controls.Add(this.btn_restore);
            this.panel_header.Controls.Add(this.btn_min);
            this.panel_header.Controls.Add(this.btn_max);
            this.panel_header.Controls.Add(this.btn_close);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(267, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(800, 36);
            this.panel_header.TabIndex = 74;
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(233)))));
            this.btn_restore.BackgroundImage = global::Assignment.Properties.Resources.minification__2_;
            this.btn_restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_restore.FlatAppearance.BorderSize = 0;
            this.btn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restore.Location = new System.Drawing.Point(628, 8);
            this.btn_restore.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(20, 20);
            this.btn_restore.TabIndex = 10;
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
            this.btn_min.Location = new System.Drawing.Point(674, 8);
            this.btn_min.Margin = new System.Windows.Forms.Padding(4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(20, 20);
            this.btn_min.TabIndex = 11;
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
            this.btn_max.Location = new System.Drawing.Point(716, 8);
            this.btn_max.Margin = new System.Windows.Forms.Padding(4);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(20, 20);
            this.btn_max.TabIndex = 12;
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
            this.btn_close.Location = new System.Drawing.Point(763, 8);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 20);
            this.btn_close.TabIndex = 13;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(77, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "MANAGER";
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Moccasin;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_home.FlatAppearance.BorderSize = 2;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_home.Location = new System.Drawing.Point(35, 188);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(203, 35);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "HOME";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_receptionist
            // 
            this.btn_receptionist.BackColor = System.Drawing.Color.Moccasin;
            this.btn_receptionist.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_receptionist.FlatAppearance.BorderSize = 2;
            this.btn_receptionist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_receptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_receptionist.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_receptionist.Location = new System.Drawing.Point(35, 235);
            this.btn_receptionist.Margin = new System.Windows.Forms.Padding(4);
            this.btn_receptionist.Name = "btn_receptionist";
            this.btn_receptionist.Size = new System.Drawing.Size(203, 35);
            this.btn_receptionist.TabIndex = 2;
            this.btn_receptionist.Text = "RECEPTIONIST";
            this.btn_receptionist.UseVisualStyleBackColor = false;
            this.btn_receptionist.Click += new System.EventHandler(this.btn_receptionist_Click);
            // 
            // btn_trainer
            // 
            this.btn_trainer.BackColor = System.Drawing.Color.Moccasin;
            this.btn_trainer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_trainer.FlatAppearance.BorderSize = 2;
            this.btn_trainer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_trainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trainer.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_trainer.Location = new System.Drawing.Point(35, 281);
            this.btn_trainer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_trainer.Name = "btn_trainer";
            this.btn_trainer.Size = new System.Drawing.Size(203, 35);
            this.btn_trainer.TabIndex = 2;
            this.btn_trainer.Text = "TRAINER";
            this.btn_trainer.UseVisualStyleBackColor = false;
            this.btn_trainer.Click += new System.EventHandler(this.btn_trainer_Click);
            // 
            // btn_member
            // 
            this.btn_member.BackColor = System.Drawing.Color.Moccasin;
            this.btn_member.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_member.FlatAppearance.BorderSize = 2;
            this.btn_member.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_member.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_member.Location = new System.Drawing.Point(35, 327);
            this.btn_member.Margin = new System.Windows.Forms.Padding(4);
            this.btn_member.Name = "btn_member";
            this.btn_member.Size = new System.Drawing.Size(203, 35);
            this.btn_member.TabIndex = 2;
            this.btn_member.Text = "MEMBER";
            this.btn_member.UseVisualStyleBackColor = false;
            this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
            // 
            // btn_trainSession
            // 
            this.btn_trainSession.BackColor = System.Drawing.Color.Moccasin;
            this.btn_trainSession.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_trainSession.FlatAppearance.BorderSize = 2;
            this.btn_trainSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_trainSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trainSession.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_trainSession.Location = new System.Drawing.Point(35, 374);
            this.btn_trainSession.Margin = new System.Windows.Forms.Padding(4);
            this.btn_trainSession.Name = "btn_trainSession";
            this.btn_trainSession.Size = new System.Drawing.Size(203, 35);
            this.btn_trainSession.TabIndex = 2;
            this.btn_trainSession.Text = "TRAINING SESSION";
            this.btn_trainSession.UseVisualStyleBackColor = false;
            this.btn_trainSession.Click += new System.EventHandler(this.btn_trainSession_Click);
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.Moccasin;
            this.btn_product.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_product.FlatAppearance.BorderSize = 2;
            this.btn_product.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_product.Location = new System.Drawing.Point(35, 421);
            this.btn_product.Margin = new System.Windows.Forms.Padding(4);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(203, 35);
            this.btn_product.TabIndex = 2;
            this.btn_product.Text = "PRODUCT";
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_appointment
            // 
            this.btn_appointment.BackColor = System.Drawing.Color.Moccasin;
            this.btn_appointment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_appointment.FlatAppearance.BorderSize = 2;
            this.btn_appointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appointment.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_appointment.Location = new System.Drawing.Point(35, 468);
            this.btn_appointment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_appointment.Name = "btn_appointment";
            this.btn_appointment.Size = new System.Drawing.Size(203, 35);
            this.btn_appointment.TabIndex = 2;
            this.btn_appointment.Text = "APPOINTMENT";
            this.btn_appointment.UseVisualStyleBackColor = false;
            this.btn_appointment.Click += new System.EventHandler(this.btn_appointment_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Moccasin;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_logout.FlatAppearance.BorderSize = 2;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_logout.Location = new System.Drawing.Point(35, 516);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(203, 35);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.btn_appointment);
            this.panel2.Controls.Add(this.btn_product);
            this.panel2.Controls.Add(this.btn_trainSession);
            this.panel2.Controls.Add(this.btn_member);
            this.panel2.Controls.Add(this.btn_trainer);
            this.panel2.Controls.Add(this.btn_receptionist);
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 600);
            this.panel2.TabIndex = 73;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment.Properties.Resources.GYM_logo_1_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.panel_header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_receptionist;
        private System.Windows.Forms.Button btn_trainer;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.Button btn_trainSession;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_appointment;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel2;
    }
}