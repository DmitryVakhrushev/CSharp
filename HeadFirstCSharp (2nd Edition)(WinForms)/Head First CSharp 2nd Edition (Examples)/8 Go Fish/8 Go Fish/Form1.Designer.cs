﻿namespace __Go_Fish
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listHand = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(15, 29);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(235, 22);
            this.textName.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(256, 29);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(132, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start the game!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.ItemHeight = 16;
            this.listHand.Location = new System.Drawing.Point(413, 29);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(148, 404);
            this.listHand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your hand";
            // 
            // buttonAsk
            // 
            this.buttonAsk.Location = new System.Drawing.Point(413, 439);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(148, 23);
            this.buttonAsk.TabIndex = 5;
            this.buttonAsk.Text = "Ask for a card";
            this.buttonAsk.UseVisualStyleBackColor = true;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(12, 74);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.ReadOnly = true;
            this.textProgress.Size = new System.Drawing.Size(376, 258);
            this.textProgress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Game progress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Books";
            // 
            // textBooks
            // 
            this.textBooks.Location = new System.Drawing.Point(12, 355);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.ReadOnly = true;
            this.textBooks.Size = new System.Drawing.Size(376, 107);
            this.textBooks.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 473);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAsk;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBooks;
    }
}

