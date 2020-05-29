namespace WindowsFormsApp3
{
    partial class Form2
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
            System.Windows.Forms.PictureBox pictureBox1;
            this.save = new System.Windows.Forms.Button();
            this.logo2 = new System.Windows.Forms.Label();
            this.withdraw = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.look = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Red;
            pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources._13231;
            pictureBox1.Location = new System.Drawing.Point(709, 571);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(128, 107);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Gold;
            this.save.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._37624aa360377bd208778bc89c1528ed1;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Location = new System.Drawing.Point(501, 246);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(177, 99);
            this.save.TabIndex = 2;
            this.save.Text = "ฝาก";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // logo2
            // 
            this.logo2.AutoSize = true;
            this.logo2.BackColor = System.Drawing.Color.PaleGreen;
            this.logo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logo2.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo2.ForeColor = System.Drawing.Color.White;
            this.logo2.Image = global::WindowsFormsApp3.Properties.Resources.a1bc02744ef2569869d7b7c6ca6c1085;
            this.logo2.Location = new System.Drawing.Point(375, 70);
            this.logo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(682, 97);
            this.logo2.TabIndex = 1;
            this.logo2.Text = "ธนาคารเงินคำกำแก้ว";
            this.logo2.Click += new System.EventHandler(this.logo2_Click);
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.Gold;
            this.withdraw.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._37624aa360377bd208778bc89c1528ed;
            this.withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.withdraw.ForeColor = System.Drawing.Color.Black;
            this.withdraw.Location = new System.Drawing.Point(824, 246);
            this.withdraw.Margin = new System.Windows.Forms.Padding(4);
            this.withdraw.Name = "withdraw";
            this.withdraw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.withdraw.Size = new System.Drawing.Size(177, 99);
            this.withdraw.TabIndex = 3;
            this.withdraw.Text = "ถอน";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.Gold;
            this.open.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._37624aa360377bd208778bc89c1528ed;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.open.Location = new System.Drawing.Point(238, 383);
            this.open.Margin = new System.Windows.Forms.Padding(4);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(288, 113);
            this.open.TabIndex = 4;
            this.open.Text = "เปิดบัญชี";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // look
            // 
            this.look.BackColor = System.Drawing.Color.SpringGreen;
            this.look.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._37624aa360377bd208778bc89c1528ed;
            this.look.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.look.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.look.ForeColor = System.Drawing.SystemColors.ControlText;
            this.look.Location = new System.Drawing.Point(962, 401);
            this.look.Margin = new System.Windows.Forms.Padding(4);
            this.look.Name = "look";
            this.look.Size = new System.Drawing.Size(288, 113);
            this.look.TabIndex = 5;
            this.look.Text = "ดูการเคลือนไหวบัญชี";
            this.look.UseVisualStyleBackColor = false;
            this.look.Click += new System.EventHandler(this.look_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.pngtree_fresh_book_student_advertising_background_backgroundwhite_bordercloudhand_paintedbookfreshstudentcloud_image_68054;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1433, 752);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.look);
            this.Controls.Add(this.open);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.logo2);
            this.Controls.Add(this.save);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label logo2;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button look;
    }
}