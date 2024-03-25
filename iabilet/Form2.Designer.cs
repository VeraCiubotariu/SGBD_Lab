using System.ComponentModel;

namespace iabilet
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.parentDataGridView = new System.Windows.Forms.DataGridView();
            this.parentLabel = new System.Windows.Forms.Label();
            this.childLabel = new System.Windows.Forms.Label();
            this.childDataGridView = new System.Windows.Forms.DataGridView();
            this.reloadButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // parentDataGridView
            // 
            this.parentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentDataGridView.Location = new System.Drawing.Point(40, 59);
            this.parentDataGridView.Name = "parentDataGridView";
            this.parentDataGridView.Size = new System.Drawing.Size(310, 306);
            this.parentDataGridView.TabIndex = 0;
            // 
            // parentLabel
            // 
            this.parentLabel.Location = new System.Drawing.Point(40, 26);
            this.parentLabel.Name = "parentLabel";
            this.parentLabel.Size = new System.Drawing.Size(95, 21);
            this.parentLabel.TabIndex = 2;
            this.parentLabel.Text = "label1";
            // 
            // childLabel
            // 
            this.childLabel.Location = new System.Drawing.Point(412, 26);
            this.childLabel.Name = "childLabel";
            this.childLabel.Size = new System.Drawing.Size(100, 23);
            this.childLabel.TabIndex = 3;
            this.childLabel.Text = "label1";
            // 
            // childDataGridView
            // 
            this.childDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childDataGridView.Location = new System.Drawing.Point(412, 59);
            this.childDataGridView.Name = "childDataGridView";
            this.childDataGridView.Size = new System.Drawing.Size(315, 306);
            this.childDataGridView.TabIndex = 4;
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(59, 394);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 5;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(153, 394);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(86, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.childDataGridView);
            this.Controls.Add(this.childLabel);
            this.Controls.Add(this.parentLabel);
            this.Controls.Add(this.parentDataGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.DataGridView childDataGridView;

        private System.Windows.Forms.Label parentLabel;
        private System.Windows.Forms.Label childLabel;

        private System.Windows.Forms.DataGridView parentDataGridView;

        #endregion
    }
}