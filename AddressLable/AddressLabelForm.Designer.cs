namespace AddressLable
{
    partial class AddressLabelForm
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
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CityTextBox = new TextBox();
            StateTextBox = new TextBox();
            ZipTextBox = new TextBox();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            StreetLabel = new Label();
            CityLabel = new Label();
            StateLabel = new Label();
            ZipLabel = new Label();
            InfoGroupBox = new GroupBox();
            DisplayButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            Displaylabel = new Label();
            InfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(128, 24);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(252, 31);
            FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(128, 86);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(252, 31);
            LastNameTextBox.TabIndex = 1;
            // 
            // StreetTextBox
            // 
            StreetTextBox.AccessibleRole = AccessibleRole.PageTabList;
            StreetTextBox.Location = new Point(128, 148);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(252, 31);
            StreetTextBox.TabIndex = 2;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(128, 208);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(252, 31);
            CityTextBox.TabIndex = 3;
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(128, 270);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(252, 31);
            StateTextBox.TabIndex = 4;
            // 
            // ZipTextBox
            // 
            ZipTextBox.Location = new Point(128, 338);
            ZipTextBox.Name = "ZipTextBox";
            ZipTextBox.Size = new Size(252, 31);
            ZipTextBox.TabIndex = 5;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(6, 27);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(97, 25);
            FirstNameLabel.TabIndex = 6;
            FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(6, 89);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(95, 25);
            LastNameLabel.TabIndex = 7;
            LastNameLabel.Text = "Last Name";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(6, 151);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(127, 25);
            StreetLabel.TabIndex = 8;
            StreetLabel.Text = "Street Address";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(6, 211);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(42, 25);
            CityLabel.TabIndex = 9;
            CityLabel.Text = "City";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(6, 273);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(51, 25);
            StateLabel.TabIndex = 10;
            StateLabel.Text = "State";
            // 
            // ZipLabel
            // 
            ZipLabel.AutoSize = true;
            ZipLabel.Location = new Point(6, 341);
            ZipLabel.Name = "ZipLabel";
            ZipLabel.Size = new Size(84, 25);
            ZipLabel.TabIndex = 11;
            ZipLabel.Text = "Zip Code";
            // 
            // InfoGroupBox
            // 
            InfoGroupBox.Controls.Add(FirstNameLabel);
            InfoGroupBox.Controls.Add(ZipLabel);
            InfoGroupBox.Controls.Add(FirstNameTextBox);
            InfoGroupBox.Controls.Add(StateLabel);
            InfoGroupBox.Controls.Add(LastNameTextBox);
            InfoGroupBox.Controls.Add(CityLabel);
            InfoGroupBox.Controls.Add(StreetTextBox);
            InfoGroupBox.Controls.Add(StreetLabel);
            InfoGroupBox.Controls.Add(CityTextBox);
            InfoGroupBox.Controls.Add(LastNameLabel);
            InfoGroupBox.Controls.Add(StateTextBox);
            InfoGroupBox.Controls.Add(ZipTextBox);
            InfoGroupBox.Location = new Point(12, 12);
            InfoGroupBox.Name = "InfoGroupBox";
            InfoGroupBox.Size = new Size(402, 426);
            InfoGroupBox.TabIndex = 12;
            InfoGroupBox.TabStop = false;
            InfoGroupBox.Text = "Info";
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(440, 364);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(112, 74);
            DisplayButton.TabIndex = 13;
            DisplayButton.Text = "&Display";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(558, 364);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 74);
            ClearButton.TabIndex = 14;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(676, 364);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 74);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Displaylabel
            // 
            Displaylabel.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Displaylabel.Location = new Point(440, 33);
            Displaylabel.Name = "Displaylabel";
            Displaylabel.Size = new Size(348, 310);
            Displaylabel.TabIndex = 17;
            // 
            // AddressLabelForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Displaylabel);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(DisplayButton);
            Controls.Add(InfoGroupBox);
            Name = "AddressLabelForm";
            Text = "Form1";
            InfoGroupBox.ResumeLayout(false);
            InfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox StreetTextBox;
        private TextBox CityTextBox;
        private TextBox StateTextBox;
        private TextBox ZipTextBox;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label StreetLabel;
        private Label CityLabel;
        private Label StateLabel;
        private Label ZipLabel;
        private GroupBox InfoGroupBox;
        private Button DisplayButton;
        private Button ClearButton;
        private Button ExitButton;
        private Label Displaylabel;
    }
}
