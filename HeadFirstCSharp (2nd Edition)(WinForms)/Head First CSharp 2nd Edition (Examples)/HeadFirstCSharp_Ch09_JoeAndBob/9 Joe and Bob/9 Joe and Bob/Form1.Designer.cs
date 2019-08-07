namespace __Joe_and_Bob__serialized
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
            this.joesCash = new System.Windows.Forms.Label();
            this.bankCash = new System.Windows.Forms.Label();
            this.bobsCash = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveJoe = new System.Windows.Forms.Button();
            this.loadJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joesCash
            // 
            this.joesCash.AutoSize = true;
            this.joesCash.Location = new System.Drawing.Point(29, 9);
            this.joesCash.Name = "joesCash";
            this.joesCash.Size = new System.Drawing.Size(66, 17);
            this.joesCash.TabIndex = 5;
            this.joesCash.Text = "joesCash";
            // 
            // bankCash
            // 
            this.bankCash.AutoSize = true;
            this.bankCash.Location = new System.Drawing.Point(29, 72);
            this.bankCash.Name = "bankCash";
            this.bankCash.Size = new System.Drawing.Size(71, 17);
            this.bankCash.TabIndex = 6;
            this.bankCash.Text = "bankCash";
            // 
            // bobsCash
            // 
            this.bobsCash.AutoSize = true;
            this.bobsCash.Location = new System.Drawing.Point(29, 41);
            this.bobsCash.Name = "bobsCash";
            this.bobsCash.Size = new System.Drawing.Size(71, 17);
            this.bobsCash.TabIndex = 7;
            this.bobsCash.Text = "bobsCash";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(135, 161);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(92, 45);
            this.bobGivesToJoe.TabIndex = 10;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(32, 161);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(92, 45);
            this.joeGivesToBob.TabIndex = 9;
            this.joeGivesToBob.Text = "Joe gives $10 to Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveJoe
            // 
            this.saveJoe.Location = new System.Drawing.Point(32, 238);
            this.saveJoe.Name = "saveJoe";
            this.saveJoe.Size = new System.Drawing.Size(92, 23);
            this.saveJoe.TabIndex = 11;
            this.saveJoe.Text = "Save Joe";
            this.saveJoe.UseVisualStyleBackColor = true;
            this.saveJoe.Click += new System.EventHandler(this.saveJoe_Click);
            // 
            // loadJoe
            // 
            this.loadJoe.Location = new System.Drawing.Point(135, 238);
            this.loadJoe.Name = "loadJoe";
            this.loadJoe.Size = new System.Drawing.Size(92, 23);
            this.loadJoe.TabIndex = 12;
            this.loadJoe.Text = "Load Joe";
            this.loadJoe.UseVisualStyleBackColor = true;
            this.loadJoe.Click += new System.EventHandler(this.loadJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 273);
            this.Controls.Add(this.loadJoe);
            this.Controls.Add(this.saveJoe);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bobsCash);
            this.Controls.Add(this.bankCash);
            this.Controls.Add(this.joesCash);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joesCash;
        private System.Windows.Forms.Label bankCash;
        private System.Windows.Forms.Label bobsCash;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bobGivesToJoe;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveJoe;
        private System.Windows.Forms.Button loadJoe;
    }
}

