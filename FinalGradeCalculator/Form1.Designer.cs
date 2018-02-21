namespace FinalGradeCalculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passOrFailBox = new System.Windows.Forms.TextBox();
            this.correctAnswerBox = new System.Windows.Forms.TextBox();
            this.incorrectAnswerBox = new System.Windows.Forms.TextBox();
            this.questionsMissedBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pass or Failed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of incorrect answers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of correct answers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of questions missed:";
            // 
            // passOrFailBox
            // 
            this.passOrFailBox.Location = new System.Drawing.Point(172, 30);
            this.passOrFailBox.Name = "passOrFailBox";
            this.passOrFailBox.ReadOnly = true;
            this.passOrFailBox.Size = new System.Drawing.Size(100, 20);
            this.passOrFailBox.TabIndex = 3;
            // 
            // correctAnswerBox
            // 
            this.correctAnswerBox.Location = new System.Drawing.Point(172, 63);
            this.correctAnswerBox.Name = "correctAnswerBox";
            this.correctAnswerBox.ReadOnly = true;
            this.correctAnswerBox.Size = new System.Drawing.Size(100, 20);
            this.correctAnswerBox.TabIndex = 4;
            // 
            // incorrectAnswerBox
            // 
            this.incorrectAnswerBox.Location = new System.Drawing.Point(172, 94);
            this.incorrectAnswerBox.Name = "incorrectAnswerBox";
            this.incorrectAnswerBox.ReadOnly = true;
            this.incorrectAnswerBox.Size = new System.Drawing.Size(100, 20);
            this.incorrectAnswerBox.TabIndex = 5;
            // 
            // questionsMissedBox
            // 
            this.questionsMissedBox.Location = new System.Drawing.Point(172, 130);
            this.questionsMissedBox.Name = "questionsMissedBox";
            this.questionsMissedBox.ReadOnly = true;
            this.questionsMissedBox.Size = new System.Drawing.Size(100, 20);
            this.questionsMissedBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Grade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.questionsMissedBox);
            this.Controls.Add(this.incorrectAnswerBox);
            this.Controls.Add(this.correctAnswerBox);
            this.Controls.Add(this.passOrFailBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passOrFailBox;
        private System.Windows.Forms.TextBox correctAnswerBox;
        private System.Windows.Forms.TextBox incorrectAnswerBox;
        private System.Windows.Forms.TextBox questionsMissedBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

