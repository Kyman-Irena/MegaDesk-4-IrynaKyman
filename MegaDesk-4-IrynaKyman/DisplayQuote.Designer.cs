namespace MegaDesk_4_IrynaKyman
{
    partial class DisplayQuote
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
            this.CustomerName = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.Label();
            this.DeskWidth = new System.Windows.Forms.Label();
            this.DeskDepth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(66, 34);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(79, 13);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.Text = "CustomerName";
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSize = true;
            this.OrderDate.Location = new System.Drawing.Point(66, 82);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(56, 13);
            this.OrderDate.TabIndex = 1;
            this.OrderDate.Text = "OrderDate";
            // 
            // DeskWidth
            // 
            this.DeskWidth.AutoSize = true;
            this.DeskWidth.Location = new System.Drawing.Point(66, 131);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(60, 13);
            this.DeskWidth.TabIndex = 2;
            this.DeskWidth.Text = "DeskWidth";
            // 
            // DeskDepth
            // 
            this.DeskDepth.AutoSize = true;
            this.DeskDepth.Location = new System.Drawing.Point(66, 176);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(61, 13);
            this.DeskDepth.TabIndex = 3;
            this.DeskDepth.Text = "DeskDepth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Details of the order";
            // 
            // ReturnToMainMenu
            // 
            this.ReturnToMainMenu.Location = new System.Drawing.Point(547, 246);
            this.ReturnToMainMenu.Name = "ReturnToMainMenu";
            this.ReturnToMainMenu.Size = new System.Drawing.Size(175, 55);
            this.ReturnToMainMenu.TabIndex = 6;
            this.ReturnToMainMenu.Text = "Return to the Main Menu";
            this.ReturnToMainMenu.UseVisualStyleBackColor = true;
            this.ReturnToMainMenu.Click += new System.EventHandler(this.GoToMainMenu);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnToMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.CustomerName);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.Label DeskWidth;
        private System.Windows.Forms.Label DeskDepth;
         private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReturnToMainMenu;
    }
}