namespace classFinal
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
            amountTextBox = new TextBox();
            AddButton = new Button();
            ViewButton = new Button();
            amountLabel = new Label();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ClearButton = new Button();
            totalLabel = new Label();
            descriptionTextBox = new TextBox();
            label3 = new Label();
            summaryLabel = new Label();
            totalTitleLabel = new Label();
            viewTextBox = new TextBox();
            successLabel = new Label();
            averageLabel = new Label();
            averageButton = new Button();
            SuspendLayout();
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(13, 225);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(100, 23);
            amountTextBox.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 286);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click_1;
            // 
            // ViewButton
            // 
            ViewButton.Location = new Point(148, 286);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(75, 23);
            ViewButton.TabIndex = 3;
            ViewButton.Text = "View";
            ViewButton.UseVisualStyleBackColor = true;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(13, 195);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(51, 15);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Amount";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(148, 195);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(55, 15);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "Categroy";
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(148, 225);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(121, 23);
            categoryComboBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(314, 30);
            label1.TabIndex = 7;
            label1.Text = "Welcome to my expense tracker.\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(338, 119);
            label2.TabIndex = 8;
            label2.Text = "Please enter an amount either using a whole number or decimal\r\nExample  12 OR 12.10 are both acceptable\r\n\r\nYou will be able to select a category.\r\nGroceries\r\nRent\r\nUtilities\r\nEntertainment\r\nOther";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(428, 333);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 10;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.BorderStyle = BorderStyle.FixedSingle;
            totalLabel.Location = new Point(578, 331);
            totalLabel.MinimumSize = new Size(50, 25);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(50, 25);
            totalLabel.TabIndex = 11;
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            totalLabel.Click += totalLabel_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(291, 225);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 23);
            descriptionTextBox.TabIndex = 13;
            descriptionTextBox.TextChanged += discriptionTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 195);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 14;
            label3.Text = "Discription";
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.BorderStyle = BorderStyle.FixedSingle;
            summaryLabel.Location = new Point(428, 49);
            summaryLabel.MinimumSize = new Size(200, 25);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(200, 25);
            summaryLabel.TabIndex = 16;
            // 
            // totalTitleLabel
            // 
            totalTitleLabel.AutoSize = true;
            totalTitleLabel.BorderStyle = BorderStyle.FixedSingle;
            totalTitleLabel.Location = new Point(522, 331);
            totalTitleLabel.MinimumSize = new Size(50, 25);
            totalTitleLabel.Name = "totalTitleLabel";
            totalTitleLabel.Size = new Size(50, 25);
            totalTitleLabel.TabIndex = 17;
            totalTitleLabel.Text = "Total";
            totalTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // viewTextBox
            // 
            viewTextBox.Location = new Point(428, 77);
            viewTextBox.MinimumSize = new Size(200, 200);
            viewTextBox.Multiline = true;
            viewTextBox.Name = "viewTextBox";
            viewTextBox.Size = new Size(200, 250);
            viewTextBox.TabIndex = 18;
            // 
            // successLabel
            // 
            successLabel.AutoSize = true;
            successLabel.Location = new Point(269, 290);
            successLabel.Name = "successLabel";
            successLabel.Size = new Size(0, 15);
            successLabel.TabIndex = 19;
            // 
            // averageLabel
            // 
            averageLabel.AutoSize = true;
            averageLabel.BorderStyle = BorderStyle.FixedSingle;
            averageLabel.Location = new Point(528, 362);
            averageLabel.MinimumSize = new Size(100, 25);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(100, 25);
            averageLabel.TabIndex = 20;
            // 
            // averageButton
            // 
            averageButton.Location = new Point(428, 362);
            averageButton.Name = "averageButton";
            averageButton.Size = new Size(75, 23);
            averageButton.TabIndex = 22;
            averageButton.Text = "Average";
            averageButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(averageButton);
            Controls.Add(averageLabel);
            Controls.Add(successLabel);
            Controls.Add(viewTextBox);
            Controls.Add(totalTitleLabel);
            Controls.Add(summaryLabel);
            Controls.Add(label3);
            Controls.Add(descriptionTextBox);
            Controls.Add(totalLabel);
            Controls.Add(ClearButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(categoryComboBox);
            Controls.Add(categoryLabel);
            Controls.Add(amountLabel);
            Controls.Add(ViewButton);
            Controls.Add(AddButton);
            Controls.Add(amountTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox amountTextBox;
        private Button AddButton;
        private Button ViewButton;
        private Label amountLabel;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private Label label1;
        private Label label2;
        private Button ClearButton;
        private Label totalLabel;
        private TextBox descriptionTextBox;
        private Label label3;
        private Label summaryLabel;
        private Label totalTitleLabel;
        private TextBox viewTextBox;
        private Label successLabel;
        private Label averageLabel;
        private Button averageButton;
    }
}