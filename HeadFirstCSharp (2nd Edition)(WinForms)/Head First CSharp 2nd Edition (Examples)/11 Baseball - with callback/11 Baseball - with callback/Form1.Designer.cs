namespace _1_Baseball___with_callback
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
            this.trajectory = new System.Windows.Forms.NumericUpDown();
            this.distance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playBall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trajectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).BeginInit();
            this.SuspendLayout();
            // 
            // trajectory
            // 
            this.trajectory.Location = new System.Drawing.Point(90, 12);
            this.trajectory.Name = "trajectory";
            this.trajectory.Size = new System.Drawing.Size(120, 22);
            this.trajectory.TabIndex = 0;
            this.trajectory.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(90, 40);
            this.distance.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(120, 22);
            this.distance.TabIndex = 1;
            this.distance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trajectory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Distance";
            // 
            // playBall
            // 
            this.playBall.Location = new System.Drawing.Point(90, 68);
            this.playBall.Name = "playBall";
            this.playBall.Size = new System.Drawing.Size(92, 23);
            this.playBall.TabIndex = 4;
            this.playBall.Text = "Play ball!";
            this.playBall.UseVisualStyleBackColor = true;
            this.playBall.Click += new System.EventHandler(this.playBall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 103);
            this.Controls.Add(this.playBall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.trajectory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Baseball";
            ((System.ComponentModel.ISupportInitialize)(this.trajectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown trajectory;
        private System.Windows.Forms.NumericUpDown distance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button playBall;
    }
}

