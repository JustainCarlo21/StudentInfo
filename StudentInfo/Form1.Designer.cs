﻿
namespace StudentInfo
{
    partial class Form1
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
            this.tName = new System.Windows.Forms.TextBox();
            this.rMale = new System.Windows.Forms.RadioButton();
            this.rFemale = new System.Windows.Forms.RadioButton();
            this.bEnter = new System.Windows.Forms.Button();
            this.cFav = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tSect = new System.Windows.Forms.TextBox();
            this.tAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tName
            // 
            this.tName.BackColor = System.Drawing.SystemColors.Control;
            this.tName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tName.Location = new System.Drawing.Point(12, 56);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(193, 29);
            this.tName.TabIndex = 0;
            // 
            // rMale
            // 
            this.rMale.AutoSize = true;
            this.rMale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rMale.Location = new System.Drawing.Point(276, 112);
            this.rMale.Name = "rMale";
            this.rMale.Size = new System.Drawing.Size(68, 25);
            this.rMale.TabIndex = 3;
            this.rMale.TabStop = true;
            this.rMale.Text = "MALE";
            this.rMale.UseVisualStyleBackColor = true;
            // 
            // rFemale
            // 
            this.rFemale.AutoSize = true;
            this.rFemale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rFemale.Location = new System.Drawing.Point(276, 138);
            this.rFemale.Name = "rFemale";
            this.rFemale.Size = new System.Drawing.Size(84, 25);
            this.rFemale.TabIndex = 4;
            this.rFemale.TabStop = true;
            this.rFemale.Text = "FEMALE";
            this.rFemale.UseVisualStyleBackColor = true;
            // 
            // bEnter
            // 
            this.bEnter.BackColor = System.Drawing.Color.Crimson;
            this.bEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEnter.ForeColor = System.Drawing.Color.White;
            this.bEnter.Location = new System.Drawing.Point(208, 274);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(75, 41);
            this.bEnter.TabIndex = 5;
            this.bEnter.Text = "ENTER";
            this.bEnter.UseVisualStyleBackColor = false;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // cFav
            // 
            this.cFav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cFav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cFav.FormattingEnabled = true;
            this.cFav.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green"});
            this.cFav.Location = new System.Drawing.Point(12, 237);
            this.cFav.Name = "cFav";
            this.cFav.Size = new System.Drawing.Size(139, 29);
            this.cFav.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // tSect
            // 
            this.tSect.BackColor = System.Drawing.SystemColors.Control;
            this.tSect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tSect.Location = new System.Drawing.Point(12, 112);
            this.tSect.Name = "tSect";
            this.tSect.Size = new System.Drawing.Size(193, 29);
            this.tSect.TabIndex = 8;
            // 
            // tAdd
            // 
            this.tAdd.BackColor = System.Drawing.SystemColors.Control;
            this.tAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tAdd.Location = new System.Drawing.Point(12, 170);
            this.tAdd.Name = "tAdd";
            this.tAdd.Size = new System.Drawing.Size(193, 29);
            this.tAdd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Section:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(270, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fav. Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(466, 348);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tAdd);
            this.Controls.Add(this.tSect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cFav);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.rFemale);
            this.Controls.Add(this.rMale);
            this.Controls.Add(this.tName);
            this.Name = "Form1";
            this.Text = "STUDENT INFO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.RadioButton rMale;
        private System.Windows.Forms.RadioButton rFemale;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.ComboBox cFav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tSect;
        private System.Windows.Forms.TextBox tAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

