namespace BeeHiveManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nextShift = new System.Windows.Forms.Button();
            this.assignWork = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker Bee Assignments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job";
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Baby bee tutoring",
            "Egg care",
            "Hive maintenance",
            "Honey manufacturing",
            "Nector collector",
            "Sting patrol "});
            this.workerBeeJob.Location = new System.Drawing.Point(24, 76);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(158, 21);
            this.workerBeeJob.TabIndex = 2;
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(198, 77);
            this.shifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(69, 20);
            this.shifts.TabIndex = 3;
            this.shifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shifts";
            // 
            // nextShift
            // 
            this.nextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextShift.Location = new System.Drawing.Point(273, 33);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(135, 93);
            this.nextShift.TabIndex = 5;
            this.nextShift.TabStop = false;
            this.nextShift.Text = "Work the next shift";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // assignWork
            // 
            this.assignWork.Location = new System.Drawing.Point(24, 103);
            this.assignWork.Name = "assignWork";
            this.assignWork.Size = new System.Drawing.Size(243, 23);
            this.assignWork.TabIndex = 6;
            this.assignWork.Text = "Assign the work to a bee";
            this.assignWork.UseVisualStyleBackColor = true;
            this.assignWork.Click += new System.EventHandler(this.assignWork_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(12, 132);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(396, 199);
            this.report.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 343);
            this.Controls.Add(this.report);
            this.Controls.Add(this.assignWork);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shifts);
            this.Controls.Add(this.workerBeeJob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Behive Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.Button assignWork;
        private System.Windows.Forms.TextBox report;
    }
}

