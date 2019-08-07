namespace __Excuse_Manager___with_serialization
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
            this.description = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.folder = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.randomExcuse = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.FileDate = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excuse";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(90, 6);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(285, 22);
            this.description.TabIndex = 1;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(90, 34);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(285, 22);
            this.results.TabIndex = 3;
            this.results.TextChanged += new System.EventHandler(this.results_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Used";
            // 
            // lastUsed
            // 
            this.lastUsed.Location = new System.Drawing.Point(90, 62);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(258, 22);
            this.lastUsed.TabIndex = 5;
            this.lastUsed.ValueChanged += new System.EventHandler(this.lastUsed_ValueChanged);
            // 
            // folder
            // 
            this.folder.Location = new System.Drawing.Point(9, 121);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(75, 23);
            this.folder.TabIndex = 6;
            this.folder.Text = "Folder";
            this.folder.UseVisualStyleBackColor = true;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(90, 121);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // randomExcuse
            // 
            this.randomExcuse.Enabled = false;
            this.randomExcuse.Location = new System.Drawing.Point(252, 121);
            this.randomExcuse.Name = "randomExcuse";
            this.randomExcuse.Size = new System.Drawing.Size(123, 23);
            this.randomExcuse.TabIndex = 8;
            this.randomExcuse.Text = "Random Excuse";
            this.randomExcuse.UseVisualStyleBackColor = true;
            this.randomExcuse.Click += new System.EventHandler(this.randomExcuse_Click);
            // 
            // open
            // 
            this.open.Enabled = false;
            this.open.Location = new System.Drawing.Point(171, 121);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 9;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // FileDate
            // 
            this.FileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FileDate.Location = new System.Drawing.Point(90, 87);
            this.FileDate.Name = "FileDate";
            this.FileDate.Size = new System.Drawing.Size(285, 23);
            this.FileDate.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "File date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 156);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FileDate);
            this.Controls.Add(this.open);
            this.Controls.Add(this.randomExcuse);
            this.Controls.Add(this.save);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.lastUsed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Windows.Forms.Button folder;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button randomExcuse;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label FileDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
    }
}

