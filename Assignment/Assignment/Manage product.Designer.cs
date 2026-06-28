namespace Assignment
{
    partial class Manage_product
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
            this.TRAINER = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TRAINER
            // 
            this.TRAINER.AutoSize = true;
            this.TRAINER.Font = new System.Drawing.Font("SimHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TRAINER.Location = new System.Drawing.Point(511, 40);
            this.TRAINER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TRAINER.Name = "TRAINER";
            this.TRAINER.Size = new System.Drawing.Size(311, 40);
            this.TRAINER.TabIndex = 87;
            this.TRAINER.Text = "MANAGE PRODUCT";
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_order.FlatAppearance.BorderSize = 0;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.Location = new System.Drawing.Point(613, 188);
            this.btn_order.Margin = new System.Windows.Forms.Padding(4);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(107, 33);
            this.btn_order.TabIndex = 90;
            this.btn_order.Text = "ORDER";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_sell.FlatAppearance.BorderSize = 0;
            this.btn_sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sell.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sell.Location = new System.Drawing.Point(613, 320);
            this.btn_sell.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(107, 33);
            this.btn_sell.TabIndex = 90;
            this.btn_sell.Text = "SELL";
            this.btn_sell.UseVisualStyleBackColor = false;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(176)))), ((int)(((byte)(128)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(613, 452);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 33);
            this.btn_back.TabIndex = 90;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Manage_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.TRAINER);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Manage_product";
            this.Text = "Manage_product";
            this.Controls.SetChildIndex(this.TRAINER, 0);
            this.Controls.SetChildIndex(this.btn_order, 0);
            this.Controls.SetChildIndex(this.btn_sell, 0);
            this.Controls.SetChildIndex(this.btn_back, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TRAINER;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_sell;
        private System.Windows.Forms.Button btn_back;
    }
}