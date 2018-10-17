namespace MegaDesk_4_IrynaKyman
{
    partial class AddQuote
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
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNamelb = new System.Windows.Forms.Label();
            this.Datelb = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.Widthlb = new System.Windows.Forms.Label();
            this.Depthlb = new System.Windows.Forms.Label();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(173, 46);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.CustomerNameTextBox.TabIndex = 1;
            // 
            // CustomerNamelb
            // 
            this.CustomerNamelb.AutoSize = true;
            this.CustomerNamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerNamelb.Location = new System.Drawing.Point(35, 45);
            this.CustomerNamelb.Name = "CustomerNamelb";
            this.CustomerNamelb.Size = new System.Drawing.Size(94, 15);
            this.CustomerNamelb.TabIndex = 2;
            this.CustomerNamelb.Text = "CustomerName";
            // 
            // Datelb
            // 
            this.Datelb.AutoSize = true;
            this.Datelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Datelb.Location = new System.Drawing.Point(35, 91);
            this.Datelb.Name = "Datelb";
            this.Datelb.Size = new System.Drawing.Size(33, 15);
            this.Datelb.TabIndex = 3;
            this.Datelb.Text = "Date";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(173, 90);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(134, 20);
            this.DateTextBox.TabIndex = 4;
            // 
            // Widthlb
            // 
            this.Widthlb.AutoSize = true;
            this.Widthlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Widthlb.Location = new System.Drawing.Point(35, 142);
            this.Widthlb.Name = "Widthlb";
            this.Widthlb.Size = new System.Drawing.Size(38, 15);
            this.Widthlb.TabIndex = 5;
            this.Widthlb.Text = "Width";
            // 
            // Depthlb
            // 
            this.Depthlb.AutoSize = true;
            this.Depthlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Depthlb.Location = new System.Drawing.Point(35, 189);
            this.Depthlb.Name = "Depthlb";
            this.Depthlb.Size = new System.Drawing.Size(40, 15);
            this.Depthlb.TabIndex = 6;
            this.Depthlb.Text = "Depth";
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.Location = new System.Drawing.Point(173, 184);
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(134, 20);
            this.DepthTextBox.TabIndex = 7;
            this.DepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthTextBox_KeyPress);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.CausesValidation = false;
            this.WidthTextBox.Location = new System.Drawing.Point(173, 137);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(134, 20);
            this.WidthTextBox.TabIndex = 8;
            this.WidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthTextBox_Validating);
                        // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(38, 289);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(140, 63);
            this.CalculateBtn.TabIndex = 9;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(38, 240);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "3 Days";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(173, 240);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "5 Days";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(310, 240);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "7 Days";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 384);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.Depthlb);
            this.Controls.Add(this.Widthlb);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.Datelb);
            this.Controls.Add(this.CustomerNamelb);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.button1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomerNamelb;
        private System.Windows.Forms.Label Datelb;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Label Widthlb;
        private System.Windows.Forms.Label Depthlb;
        private System.Windows.Forms.TextBox DepthTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}