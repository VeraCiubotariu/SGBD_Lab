namespace iabilet
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
            this.genresListBox = new System.Windows.Forms.ListBox();
            this.genresLabel = new System.Windows.Forms.Label();
            this.artistsListBox = new System.Windows.Forms.ListBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.bandComboBox = new System.Windows.Forms.ComboBox();
            this.bandLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // genresListBox
            // 
            this.genresListBox.FormattingEnabled = true;
            this.genresListBox.Location = new System.Drawing.Point(11, 59);
            this.genresListBox.Margin = new System.Windows.Forms.Padding(2);
            this.genresListBox.Name = "genresListBox";
            this.genresListBox.Size = new System.Drawing.Size(191, 251);
            this.genresListBox.TabIndex = 0;
            this.genresListBox.SelectedIndexChanged += new System.EventHandler(this.genresListBox_SelectedIndexChanged);
            // 
            // genresLabel
            // 
            this.genresLabel.Location = new System.Drawing.Point(11, 38);
            this.genresLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(75, 19);
            this.genresLabel.TabIndex = 1;
            this.genresLabel.Text = "Genuri";
            // 
            // artistsListBox
            // 
            this.artistsListBox.FormattingEnabled = true;
            this.artistsListBox.Location = new System.Drawing.Point(216, 59);
            this.artistsListBox.Name = "artistsListBox";
            this.artistsListBox.Size = new System.Drawing.Size(195, 251);
            this.artistsListBox.TabIndex = 2;
            // 
            // artistLabel
            // 
            this.artistLabel.Location = new System.Drawing.Point(216, 38);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(100, 18);
            this.artistLabel.TabIndex = 3;
            this.artistLabel.Text = "Artisti";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(468, 91);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.modifyButton);
            this.addGroupBox.Controls.Add(this.bandComboBox);
            this.addGroupBox.Controls.Add(this.bandLabel);
            this.addGroupBox.Controls.Add(this.nameLabel);
            this.addGroupBox.Controls.Add(this.nameTextBox);
            this.addGroupBox.Location = new System.Drawing.Point(427, 130);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(161, 161);
            this.addGroupBox.TabIndex = 5;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add/Modify";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(41, 120);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(41, 91);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 4;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // bandComboBox
            // 
            this.bandComboBox.FormattingEnabled = true;
            this.bandComboBox.Location = new System.Drawing.Point(90, 58);
            this.bandComboBox.Name = "bandComboBox";
            this.bandComboBox.Size = new System.Drawing.Size(56, 21);
            this.bandComboBox.TabIndex = 3;
            // 
            // bandLabel
            // 
            this.bandLabel.Location = new System.Drawing.Point(6, 61);
            this.bandLabel.Name = "bandLabel";
            this.bandLabel.Size = new System.Drawing.Size(66, 15);
            this.bandLabel.TabIndex = 2;
            this.bandLabel.Text = "Is it a band?";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(6, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(52, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(94, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.artistsListBox);
            this.Controls.Add(this.genresLabel);
            this.Controls.Add(this.genresListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox bandComboBox;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button addButton;

        private System.Windows.Forms.Label nameLabel;

        private System.Windows.Forms.Label bandLabel;

        private System.Windows.Forms.TextBox nameTextBox;

        private System.Windows.Forms.GroupBox addGroupBox;

        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.ListBox artistsListBox;
        private System.Windows.Forms.Label artistLabel;

        private System.Windows.Forms.Label genresLabel;

        private System.Windows.Forms.ListBox genresListBox;

        #endregion
    }
}