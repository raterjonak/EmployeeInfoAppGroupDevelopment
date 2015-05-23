namespace EmployeeInfoDatabaseGroupStudy
{
    partial class MainUI
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
            this.employeeGroupBox = new System.Windows.Forms.GroupBox();
            this.searchAndEditButton = new System.Windows.Forms.Button();
            this.addInfoButton = new System.Windows.Forms.Button();
            this.employeeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeGroupBox
            // 
            this.employeeGroupBox.Controls.Add(this.searchAndEditButton);
            this.employeeGroupBox.Controls.Add(this.addInfoButton);
            this.employeeGroupBox.Location = new System.Drawing.Point(50, 67);
            this.employeeGroupBox.Name = "employeeGroupBox";
            this.employeeGroupBox.Size = new System.Drawing.Size(272, 158);
            this.employeeGroupBox.TabIndex = 0;
            this.employeeGroupBox.TabStop = false;
            this.employeeGroupBox.Text = "Employee Info";
            // 
            // searchAndEditButton
            // 
            this.searchAndEditButton.Location = new System.Drawing.Point(152, 73);
            this.searchAndEditButton.Name = "searchAndEditButton";
            this.searchAndEditButton.Size = new System.Drawing.Size(75, 23);
            this.searchAndEditButton.TabIndex = 1;
            this.searchAndEditButton.Text = "Search/Edit";
            this.searchAndEditButton.UseVisualStyleBackColor = true;
            this.searchAndEditButton.Click += new System.EventHandler(this.searchAndEditButton_Click);
            // 
            // addInfoButton
            // 
            this.addInfoButton.Location = new System.Drawing.Point(41, 73);
            this.addInfoButton.Name = "addInfoButton";
            this.addInfoButton.Size = new System.Drawing.Size(75, 23);
            this.addInfoButton.TabIndex = 0;
            this.addInfoButton.Text = "Add";
            this.addInfoButton.UseVisualStyleBackColor = true;
            this.addInfoButton.Click += new System.EventHandler(this.addInfoButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 283);
            this.Controls.Add(this.employeeGroupBox);
            this.Name = "MainUI";
            this.Text = "Main UI";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.employeeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox employeeGroupBox;
        private System.Windows.Forms.Button searchAndEditButton;
        private System.Windows.Forms.Button addInfoButton;
    }
}

