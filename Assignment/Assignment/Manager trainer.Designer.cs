namespace Assignment
{
    partial class Manager_trainer
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
            this.dgrid_Trainer = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.TRAINER = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Trainer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_Trainer
            // 
            this.dgrid_Trainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Trainer.Location = new System.Drawing.Point(344, 206);
            this.dgrid_Trainer.Margin = new System.Windows.Forms.Padding(4);
            this.dgrid_Trainer.Name = "dgrid_Trainer";
            this.dgrid_Trainer.RowHeadersWidth = 51;
            this.dgrid_Trainer.RowTemplate.Height = 23;
            this.dgrid_Trainer.Size = new System.Drawing.Size(650, 250);
            this.dgrid_Trainer.TabIndex = 84;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(706, 495);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 33);
            this.btn_delete.TabIndex = 83;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Location = new System.Drawing.Point(887, 495);
            this.btn_report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(107, 33);
            this.btn_report.TabIndex = 80;
            this.btn_report.Text = "REPORT";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(525, 495);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(107, 33);
            this.btn_update.TabIndex = 81;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(344, 495);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 33);
            this.btn_add.TabIndex = 82;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // TRAINER
            // 
            this.TRAINER.AutoSize = true;
            this.TRAINER.Font = new System.Drawing.Font("SimHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TRAINER.Location = new System.Drawing.Point(587, 40);
            this.TRAINER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TRAINER.Name = "TRAINER";
            this.TRAINER.Size = new System.Drawing.Size(164, 40);
            this.TRAINER.TabIndex = 79;
            this.TRAINER.Text = "TRAINER";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(400, 127);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(539, 22);
            this.txt_search.TabIndex = 85;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // Manager_trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgrid_Trainer);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.TRAINER);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Manager_trainer";
            this.Text = "Manager_trainer";
            this.Load += new System.EventHandler(this.Manager_trainer_Load);
            this.Controls.SetChildIndex(this.TRAINER, 0);
            this.Controls.SetChildIndex(this.btn_add, 0);
            this.Controls.SetChildIndex(this.btn_update, 0);
            this.Controls.SetChildIndex(this.btn_report, 0);
            this.Controls.SetChildIndex(this.btn_delete, 0);
            this.Controls.SetChildIndex(this.dgrid_Trainer, 0);
            this.Controls.SetChildIndex(this.txt_search, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Trainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_Trainer;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label TRAINER;
        private System.Windows.Forms.TextBox txt_search;
    }
}