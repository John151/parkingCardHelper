namespace parkingCardHelper
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtCreditAdded = new System.Windows.Forms.TextBox();
            this.txtOneParkNoCard = new System.Windows.Forms.TextBox();
            this.txtOneParkWithCard = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDaysParking = new System.Windows.Forms.TextBox();
            this.txtCreditRemaining = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSavings = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit added to Campus Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parking cost without Campus Card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parking cost with Campus Card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of days of parking";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Credit remaining";
            // 
            // txtCreditAdded
            // 
            this.txtCreditAdded.Location = new System.Drawing.Point(380, 33);
            this.txtCreditAdded.Name = "txtCreditAdded";
            this.txtCreditAdded.Size = new System.Drawing.Size(100, 20);
            this.txtCreditAdded.TabIndex = 5;
            this.txtCreditAdded.TextChanged += new System.EventHandler(this.txtCreditAdded_TextChanged);
            // 
            // txtOneParkNoCard
            // 
            this.txtOneParkNoCard.Location = new System.Drawing.Point(380, 75);
            this.txtOneParkNoCard.Name = "txtOneParkNoCard";
            this.txtOneParkNoCard.Size = new System.Drawing.Size(100, 20);
            this.txtOneParkNoCard.TabIndex = 6;
            this.txtOneParkNoCard.Text = "5";
            this.txtOneParkNoCard.TextChanged += new System.EventHandler(this.txtOneParkNoCard_TextChanged);
            // 
            // txtOneParkWithCard
            // 
            this.txtOneParkWithCard.Location = new System.Drawing.Point(380, 120);
            this.txtOneParkWithCard.Name = "txtOneParkWithCard";
            this.txtOneParkWithCard.Size = new System.Drawing.Size(100, 20);
            this.txtOneParkWithCard.TabIndex = 7;
            this.txtOneParkWithCard.Text = "2.5";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(380, 173);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtDaysParking
            // 
            this.txtDaysParking.Location = new System.Drawing.Point(380, 246);
            this.txtDaysParking.Name = "txtDaysParking";
            this.txtDaysParking.ReadOnly = true;
            this.txtDaysParking.Size = new System.Drawing.Size(100, 20);
            this.txtDaysParking.TabIndex = 9;
            // 
            // txtCreditRemaining
            // 
            this.txtCreditRemaining.Location = new System.Drawing.Point(380, 300);
            this.txtCreditRemaining.Name = "txtCreditRemaining";
            this.txtCreditRemaining.ReadOnly = true;
            this.txtCreditRemaining.Size = new System.Drawing.Size(100, 20);
            this.txtCreditRemaining.TabIndex = 10;
            this.txtCreditRemaining.TextChanged += new System.EventHandler(this.txtCreditRemaining_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(556, 396);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Savings";
            // 
            // txtSavings
            // 
            this.txtSavings.Location = new System.Drawing.Point(380, 348);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.ReadOnly = true;
            this.txtSavings.Size = new System.Drawing.Size(100, 20);
            this.txtSavings.TabIndex = 13;
            this.txtSavings.TextChanged += new System.EventHandler(this.txtSavings_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSavings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCreditRemaining);
            this.Controls.Add(this.txtDaysParking);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtOneParkWithCard);
            this.Controls.Add(this.txtOneParkNoCard);
            this.Controls.Add(this.txtCreditAdded);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCreditAdded;
        private System.Windows.Forms.TextBox txtOneParkNoCard;
        private System.Windows.Forms.TextBox txtOneParkWithCard;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDaysParking;
        private System.Windows.Forms.TextBox txtCreditRemaining;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSavings;
    }
}

