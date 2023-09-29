namespace MegaDesk_Sambrano
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
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numOfDrawersInput = new System.Windows.Forms.NumericUpDown();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.surfaceMaterialInput = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RushDaysInput = new System.Windows.Forms.ComboBox();
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.validationOutput = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDrawersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameInput
            // 
            this.customerNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameInput.Location = new System.Drawing.Point(304, 67);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(325, 30);
            this.customerNameInput.TabIndex = 0;
            this.customerNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.customerNameInput_Validating);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(113, 70);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(167, 25);
            this.customerNameLabel.TabIndex = 12;
            this.customerNameLabel.Text = "Customer Name";
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(127, 117);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(153, 25);
            this.widthLabel.TabIndex = 5;
            this.widthLabel.Text = "Width (inches)";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(126, 168);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(154, 25);
            this.depthLabel.TabIndex = 8;
            this.depthLabel.Text = "Depth (inches)";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Drawers";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numOfDrawersInput
            // 
            this.numOfDrawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfDrawersInput.Location = new System.Drawing.Point(304, 218);
            this.numOfDrawersInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numOfDrawersInput.Name = "numOfDrawersInput";
            this.numOfDrawersInput.Size = new System.Drawing.Size(137, 30);
            this.numOfDrawersInput.TabIndex = 3;
            // 
            // depthInput
            // 
            this.depthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthInput.Location = new System.Drawing.Point(304, 163);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(137, 30);
            this.depthInput.TabIndex = 2;
            this.depthInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthInput_KeyPress);
            this.depthInput.Validating += new System.ComponentModel.CancelEventHandler(this.depthInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Surface Material";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surfaceMaterialInput
            // 
            this.surfaceMaterialInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceMaterialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialInput.FormattingEnabled = true;
            this.surfaceMaterialInput.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.surfaceMaterialInput.Location = new System.Drawing.Point(304, 268);
            this.surfaceMaterialInput.Name = "surfaceMaterialInput";
            this.surfaceMaterialInput.Size = new System.Drawing.Size(233, 33);
            this.surfaceMaterialInput.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rush Order (days)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RushDaysInput
            // 
            this.RushDaysInput.DisplayMember = "14";
            this.RushDaysInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RushDaysInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushDaysInput.FormattingEnabled = true;
            this.RushDaysInput.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.RushDaysInput.Location = new System.Drawing.Point(304, 318);
            this.RushDaysInput.Name = "RushDaysInput";
            this.RushDaysInput.Size = new System.Drawing.Size(137, 33);
            this.RushDaysInput.TabIndex = 5;
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.BackColor = System.Drawing.Color.SteelBlue;
            this.addQuoteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addQuoteButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addQuoteButton.Location = new System.Drawing.Point(275, 379);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(166, 38);
            this.addQuoteButton.TabIndex = 6;
            this.addQuoteButton.Text = "Add Quote";
            this.addQuoteButton.UseVisualStyleBackColor = false;
            this.addQuoteButton.Click += new System.EventHandler(this.addQuoteButton_Click);
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthInput.Location = new System.Drawing.Point(304, 115);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(137, 30);
            this.widthInput.TabIndex = 1;
            this.widthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.widthInput_KeyPress);
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            // 
            // validationOutput
            // 
            this.validationOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationOutput.ForeColor = System.Drawing.Color.Red;
            this.validationOutput.Location = new System.Drawing.Point(114, 27);
            this.validationOutput.Name = "validationOutput";
            this.validationOutput.Size = new System.Drawing.Size(502, 25);
            this.validationOutput.TabIndex = 19;
            this.validationOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainMenu
            // 
            this.mainMenu.AutoSize = true;
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.ForeColor = System.Drawing.Color.SteelBlue;
            this.mainMenu.Location = new System.Drawing.Point(277, 424);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(158, 20);
            this.mainMenu.TabIndex = 20;
            this.mainMenu.Text = "Back To Main Menu";
            this.mainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click_1);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.validationOutput);
            this.Controls.Add(this.addQuoteButton);
            this.Controls.Add(this.RushDaysInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.surfaceMaterialInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.numOfDrawersInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameInput);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.numOfDrawersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numOfDrawersInput;
        private System.Windows.Forms.NumericUpDown depthInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox surfaceMaterialInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RushDaysInput;
        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.Label validationOutput;
        private System.Windows.Forms.Label mainMenu;
    }
}