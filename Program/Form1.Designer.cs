namespace Program {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.NaOHmol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KnowAcidAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KnowAcidResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UnknowAcidResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UnkownAcidAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.KnowAcid = new System.Windows.Forms.ComboBox();
            this.UnknowAcid = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculations are done in mL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NaOHmol
            // 
            this.NaOHmol.Location = new System.Drawing.Point(68, 54);
            this.NaOHmol.Name = "NaOHmol";
            this.NaOHmol.Size = new System.Drawing.Size(100, 20);
            this.NaOHmol.TabIndex = 1;
            this.NaOHmol.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base : NaOH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mol : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Acid : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // KnowAcidAmount
            // 
            this.KnowAcidAmount.Location = new System.Drawing.Point(93, 138);
            this.KnowAcidAmount.Name = "KnowAcidAmount";
            this.KnowAcidAmount.Size = new System.Drawing.Size(36, 20);
            this.KnowAcidAmount.TabIndex = 7;
            this.KnowAcidAmount.Text = "25";
            this.KnowAcidAmount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Result : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // KnowAcidResult
            // 
            this.KnowAcidResult.Location = new System.Drawing.Point(93, 166);
            this.KnowAcidResult.Name = "KnowAcidResult";
            this.KnowAcidResult.Size = new System.Drawing.Size(36, 20);
            this.KnowAcidResult.TabIndex = 9;
            this.KnowAcidResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Result : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // UnknowAcidResult
            // 
            this.UnknowAcidResult.Location = new System.Drawing.Point(123, 263);
            this.UnknowAcidResult.Name = "UnknowAcidResult";
            this.UnknowAcidResult.Size = new System.Drawing.Size(36, 20);
            this.UnknowAcidResult.TabIndex = 15;
            this.UnknowAcidResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount : ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // UnkownAcidAmount
            // 
            this.UnkownAcidAmount.Location = new System.Drawing.Point(123, 237);
            this.UnkownAcidAmount.Name = "UnkownAcidAmount";
            this.UnkownAcidAmount.Size = new System.Drawing.Size(36, 20);
            this.UnkownAcidAmount.TabIndex = 13;
            this.UnkownAcidAmount.Text = "25";
            this.UnkownAcidAmount.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Unkown Acid :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(154, 301);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(125, 26);
            this.submit.TabIndex = 17;
            this.submit.Text = "Submit Calculations";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // KnowAcid
            // 
            this.KnowAcid.FormattingEnabled = true;
            this.KnowAcid.Location = new System.Drawing.Point(93, 105);
            this.KnowAcid.Name = "KnowAcid";
            this.KnowAcid.Size = new System.Drawing.Size(121, 21);
            this.KnowAcid.TabIndex = 18;
            this.KnowAcid.Text = "HCL";
            this.KnowAcid.SelectedIndexChanged += new System.EventHandler(this.KnowAcid_SelectedIndexChanged);
            // 
            // UnknowAcid
            // 
            this.UnknowAcid.FormattingEnabled = true;
            this.UnknowAcid.Location = new System.Drawing.Point(123, 207);
            this.UnknowAcid.Name = "UnknowAcid";
            this.UnknowAcid.Size = new System.Drawing.Size(121, 21);
            this.UnknowAcid.TabIndex = 19;
            this.UnknowAcid.Text = "CH3COOH";
            this.UnknowAcid.SelectedIndexChanged += new System.EventHandler(this.UnknowAcid_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(291, 339);
            this.Controls.Add(this.UnknowAcid);
            this.Controls.Add(this.KnowAcid);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UnknowAcidResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UnkownAcidAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KnowAcidResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KnowAcidAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NaOHmol);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tritration Calculator by Samuel Levin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NaOHmol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox KnowAcidAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KnowAcidResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UnknowAcidResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UnkownAcidAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox KnowAcid;
        private System.Windows.Forms.ComboBox UnknowAcid;
    }
}

