namespace Lab_6
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.comboDifficulty = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(170, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Number Guessing Game";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMin
            // 
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(123, 178);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(100, 23);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "Min:";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMax
            // 
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(123, 234);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(100, 23);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Max:";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(123, 285);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(100, 23);
            this.lblDifficulty.TabIndex = 3;
            this.lblDifficulty.Text = "Difficulty:";
            this.lblDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(310, 181);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(120, 20);
            this.tbMin.TabIndex = 4;
            this.tbMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(310, 237);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(120, 20);
            this.tbMax.TabIndex = 5;
            this.tbMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMax.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboDifficulty
            // 
            this.comboDifficulty.FormattingEnabled = true;
            this.comboDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.comboDifficulty.Location = new System.Drawing.Point(310, 287);
            this.comboDifficulty.Name = "comboDifficulty";
            this.comboDifficulty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboDifficulty.Size = new System.Drawing.Size(121, 21);
            this.comboDifficulty.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(175, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(175, 524);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Developer: Izzatbek Karimov (ID: 69978)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboDifficulty);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.ComboBox comboDifficulty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

