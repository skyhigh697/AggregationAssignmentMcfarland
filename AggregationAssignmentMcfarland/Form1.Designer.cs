namespace AggregationAssignmentMcfarland
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
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.btnInsturctor = new System.Windows.Forms.Button();
            this.btnRoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCourse
            // 
            this.lstCourse.FormattingEnabled = true;
            this.lstCourse.Location = new System.Drawing.Point(12, 12);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(120, 212);
            this.lstCourse.TabIndex = 0;
            // 
            // btnInsturctor
            // 
            this.btnInsturctor.Location = new System.Drawing.Point(159, 35);
            this.btnInsturctor.Name = "btnInsturctor";
            this.btnInsturctor.Size = new System.Drawing.Size(114, 55);
            this.btnInsturctor.TabIndex = 1;
            this.btnInsturctor.Text = "View Instructor";
            this.btnInsturctor.UseVisualStyleBackColor = true;
            // 
            // btnRoster
            // 
            this.btnRoster.Location = new System.Drawing.Point(159, 135);
            this.btnRoster.Name = "btnRoster";
            this.btnRoster.Size = new System.Drawing.Size(114, 53);
            this.btnRoster.TabIndex = 2;
            this.btnRoster.Text = "View Roster";
            this.btnRoster.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRoster);
            this.Controls.Add(this.btnInsturctor);
            this.Controls.Add(this.lstCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCourse;
        private System.Windows.Forms.Button btnInsturctor;
        private System.Windows.Forms.Button btnRoster;
    }
}

