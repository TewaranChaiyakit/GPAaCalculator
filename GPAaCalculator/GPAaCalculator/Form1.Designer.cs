namespace GPAaCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxGPA_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxG = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxMinname = new System.Windows.Forms.TextBox();
            this.TextBoxMaxname = new System.Windows.Forms.TextBox();
            this.TextBoxGPAxx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxMinGPA = new System.Windows.Forms.TextBox();
            this.TextBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxName_Input = new System.Windows.Forms.TextBox();
            this.TextBoxAllData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxGPA_input
            // 
            this.TextBoxGPA_input.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxGPA_input.Location = new System.Drawing.Point(759, 53);
            this.TextBoxGPA_input.Name = "TextBoxGPA_input";
            this.TextBoxGPA_input.Size = new System.Drawing.Size(299, 74);
            this.TextBoxGPA_input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "GPA Input";
            // 
            // TextBoxG
            // 
            this.TextBoxG.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxG.Location = new System.Drawing.Point(1123, 60);
            this.TextBoxG.Name = "TextBoxG";
            this.TextBoxG.Size = new System.Drawing.Size(153, 65);
            this.TextBoxG.TabIndex = 2;
            this.TextBoxG.Text = "ADD";
            this.TextBoxG.UseVisualStyleBackColor = true;
            this.TextBoxG.Click += new System.EventHandler(this.TextBoxG_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxMinname);
            this.groupBox1.Controls.Add(this.TextBoxMaxname);
            this.groupBox1.Controls.Add(this.TextBoxGPAxx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxMinGPA);
            this.groupBox1.Controls.Add(this.TextBoxMaxGPA);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(39, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1259, 306);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // TextBoxMinname
            // 
            this.TextBoxMinname.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMinname.Location = new System.Drawing.Point(268, 186);
            this.TextBoxMinname.Name = "TextBoxMinname";
            this.TextBoxMinname.ReadOnly = true;
            this.TextBoxMinname.Size = new System.Drawing.Size(413, 74);
            this.TextBoxMinname.TabIndex = 13;
            // 
            // TextBoxMaxname
            // 
            this.TextBoxMaxname.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMaxname.Location = new System.Drawing.Point(268, 100);
            this.TextBoxMaxname.Name = "TextBoxMaxname";
            this.TextBoxMaxname.ReadOnly = true;
            this.TextBoxMaxname.Size = new System.Drawing.Size(413, 74);
            this.TextBoxMaxname.TabIndex = 12;
            // 
            // TextBoxGPAxx
            // 
            this.TextBoxGPAxx.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxGPAxx.Location = new System.Drawing.Point(720, 26);
            this.TextBoxGPAxx.Name = "TextBoxGPAxx";
            this.TextBoxGPAxx.ReadOnly = true;
            this.TextBoxGPAxx.Size = new System.Drawing.Size(299, 74);
            this.TextBoxGPAxx.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 57);
            this.label4.TabIndex = 10;
            this.label4.Text = "MIN GPA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 57);
            this.label3.TabIndex = 9;
            this.label3.Text = "MAX GPA";
            // 
            // TextBoxMinGPA
            // 
            this.TextBoxMinGPA.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMinGPA.Location = new System.Drawing.Point(720, 186);
            this.TextBoxMinGPA.Name = "TextBoxMinGPA";
            this.TextBoxMinGPA.ReadOnly = true;
            this.TextBoxMinGPA.Size = new System.Drawing.Size(299, 74);
            this.TextBoxMinGPA.TabIndex = 8;
            // 
            // TextBoxMaxGPA
            // 
            this.TextBoxMaxGPA.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMaxGPA.Location = new System.Drawing.Point(720, 106);
            this.TextBoxMaxGPA.Name = "TextBoxMaxGPA";
            this.TextBoxMaxGPA.ReadOnly = true;
            this.TextBoxMaxGPA.Size = new System.Drawing.Size(299, 74);
            this.TextBoxMaxGPA.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1128, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 67);
            this.label2.TabIndex = 4;
            this.label2.Text = "GPAX";
            // 
            // TextBoxName_Input
            // 
            this.TextBoxName_Input.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxName_Input.Location = new System.Drawing.Point(310, 53);
            this.TextBoxName_Input.Name = "TextBoxName_Input";
            this.TextBoxName_Input.Size = new System.Drawing.Size(413, 74);
            this.TextBoxName_Input.TabIndex = 0;
            // 
            // TextBoxAllData
            // 
            this.TextBoxAllData.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxAllData.Location = new System.Drawing.Point(39, 469);
            this.TextBoxAllData.Multiline = true;
            this.TextBoxAllData.Name = "TextBoxAllData";
            this.TextBoxAllData.ReadOnly = true;
            this.TextBoxAllData.Size = new System.Drawing.Size(1019, 205);
            this.TextBoxAllData.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1330, 686);
            this.Controls.Add(this.TextBoxAllData);
            this.Controls.Add(this.TextBoxName_Input);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBoxG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxGPA_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxGPA_input;
        private Label label1;
        private Button TextBoxG;
        private TextBox TextBoxGPAx;
        private GroupBox groupBox1;
        private Label label2;
        private Button button1;
        private Label label4;
        private Label label3;
        private TextBox TextBoxMinGPA;
        private TextBox TextBoxMaxGPA;
        private TextBox TextBoxMinname;
        private TextBox TextBoxMaxname;
        private TextBox TextBoxGPAxx;
        private TextBox TextBoxName_Input;
        private TextBox TextBoxAllData;
    }
}