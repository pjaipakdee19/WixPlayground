﻿
namespace PropertySetupAction
{
    partial class FolderSelectForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHistoryLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDBLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDatabaseSelect = new System.Windows.Forms.Button();
            this.btnCSVSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCSVSelect);
            this.panel1.Controls.Add(this.btnDatabaseSelect);
            this.panel1.Controls.Add(this.txtCustomerId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtHistoryLocation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDBLocation);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(164, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 312);
            this.panel1.TabIndex = 1;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(122, 188);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(195, 22);
            this.txtCustomerId.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "รหัสร้านค้า";
            // 
            // txtHistoryLocation
            // 
            this.txtHistoryLocation.Location = new System.Drawing.Point(122, 154);
            this.txtHistoryLocation.Name = "txtHistoryLocation";
            this.txtHistoryLocation.Size = new System.Drawing.Size(174, 22);
            this.txtHistoryLocation.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "ที่ตั้งประวัติข้อมูล";
            // 
            // txtDBLocation
            // 
            this.txtDBLocation.Location = new System.Drawing.Point(122, 117);
            this.txtDBLocation.Name = "txtDBLocation";
            this.txtDBLocation.Size = new System.Drawing.Size(174, 22);
            this.txtDBLocation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "ที่ตั้งฐานข้อมูล";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "กรุณากรอกข้อมูลด้านล่างให้ครบถ้วนและถูกต้อง";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "กรุณาเพิ่มข้อมูลตามแบบฟอร์มด้านล่าง";
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(-6, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 5);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(406, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(310, 325);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(235, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDatabaseSelect
            // 
            this.btnDatabaseSelect.Location = new System.Drawing.Point(302, 116);
            this.btnDatabaseSelect.Name = "btnDatabaseSelect";
            this.btnDatabaseSelect.Size = new System.Drawing.Size(23, 23);
            this.btnDatabaseSelect.TabIndex = 8;
            this.btnDatabaseSelect.Text = "...";
            this.btnDatabaseSelect.UseVisualStyleBackColor = true;
            this.btnDatabaseSelect.Click += new System.EventHandler(this.btnDatabaseSelect_Click);
            // 
            // btnCSVSelect
            // 
            this.btnCSVSelect.Location = new System.Drawing.Point(302, 154);
            this.btnCSVSelect.Name = "btnCSVSelect";
            this.btnCSVSelect.Size = new System.Drawing.Size(23, 23);
            this.btnCSVSelect.TabIndex = 9;
            this.btnCSVSelect.Text = "...";
            this.btnCSVSelect.UseVisualStyleBackColor = true;
            this.btnCSVSelect.Click += new System.EventHandler(this.btnCSVSelect_Click);
            // 
            // FolderSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(493, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FolderSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Win App Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHistoryLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDBLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCSVSelect;
        private System.Windows.Forms.Button btnDatabaseSelect;
    }
}