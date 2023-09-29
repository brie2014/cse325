namespace MegaDesk_Sambrano
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
            this.exitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameOutput = new System.Windows.Forms.Label();
            this.widthOutput = new System.Windows.Forms.Label();
            this.depthOutput = new System.Windows.Forms.Label();
            this.numOfDrawersOutput = new System.Windows.Forms.Label();
            this.materialOutput = new System.Windows.Forms.Label();
            this.RushDaysOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.orderDateOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.SteelBlue;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.exitButton.Location = new System.Drawing.Point(403, 403);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 38);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Rush Order (days)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Surface Material";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Drawers";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(149, 159);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(154, 25);
            this.depthLabel.TabIndex = 19;
            this.depthLabel.Text = "Depth (inches)";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(150, 117);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(153, 25);
            this.widthLabel.TabIndex = 18;
            this.widthLabel.Text = "Width (inches)";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(136, 79);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(167, 25);
            this.customerNameLabel.TabIndex = 17;
            this.customerNameLabel.Text = "Customer Name";
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerNameOutput
            // 
            this.customerNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameOutput.Location = new System.Drawing.Point(327, 75);
            this.customerNameOutput.Name = "customerNameOutput";
            this.customerNameOutput.Size = new System.Drawing.Size(276, 33);
            this.customerNameOutput.TabIndex = 23;
            this.customerNameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // widthOutput
            // 
            this.widthOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthOutput.Location = new System.Drawing.Point(327, 109);
            this.widthOutput.Name = "widthOutput";
            this.widthOutput.Size = new System.Drawing.Size(276, 33);
            this.widthOutput.TabIndex = 24;
            this.widthOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // depthOutput
            // 
            this.depthOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthOutput.Location = new System.Drawing.Point(327, 155);
            this.depthOutput.Name = "depthOutput";
            this.depthOutput.Size = new System.Drawing.Size(276, 33);
            this.depthOutput.TabIndex = 25;
            this.depthOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numOfDrawersOutput
            // 
            this.numOfDrawersOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfDrawersOutput.Location = new System.Drawing.Point(327, 192);
            this.numOfDrawersOutput.Name = "numOfDrawersOutput";
            this.numOfDrawersOutput.Size = new System.Drawing.Size(276, 33);
            this.numOfDrawersOutput.TabIndex = 26;
            this.numOfDrawersOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialOutput
            // 
            this.materialOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialOutput.Location = new System.Drawing.Point(327, 231);
            this.materialOutput.Name = "materialOutput";
            this.materialOutput.Size = new System.Drawing.Size(276, 33);
            this.materialOutput.TabIndex = 27;
            this.materialOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RushDaysOutput
            // 
            this.RushDaysOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushDaysOutput.Location = new System.Drawing.Point(327, 272);
            this.RushDaysOutput.Name = "RushDaysOutput";
            this.RushDaysOutput.Size = new System.Drawing.Size(276, 33);
            this.RushDaysOutput.TabIndex = 28;
            this.RushDaysOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(185, 357);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(126, 25);
            this.totalLabel.TabIndex = 29;
            this.totalLabel.Text = "Quote Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalOutput
            // 
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(327, 353);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(137, 33);
            this.totalOutput.TabIndex = 30;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderDateOutput
            // 
            this.orderDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateOutput.Location = new System.Drawing.Point(327, 36);
            this.orderDateOutput.Name = "orderDateOutput";
            this.orderDateOutput.Size = new System.Drawing.Size(276, 33);
            this.orderDateOutput.TabIndex = 32;
            this.orderDateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Order Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.mainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.ForeColor = System.Drawing.Color.White;
            this.mainMenu.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.mainMenu.Location = new System.Drawing.Point(529, 403);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(141, 38);
            this.mainMenu.TabIndex = 33;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = false;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.orderDateOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.RushDaysOutput);
            this.Controls.Add(this.materialOutput);
            this.Controls.Add(this.numOfDrawersOutput);
            this.Controls.Add(this.depthOutput);
            this.Controls.Add(this.widthOutput);
            this.Controls.Add(this.customerNameOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.exitButton);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerNameOutput;
        private System.Windows.Forms.Label widthOutput;
        private System.Windows.Forms.Label depthOutput;
        private System.Windows.Forms.Label numOfDrawersOutput;
        private System.Windows.Forms.Label materialOutput;
        private System.Windows.Forms.Label RushDaysOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label orderDateOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mainMenu;
    }
}