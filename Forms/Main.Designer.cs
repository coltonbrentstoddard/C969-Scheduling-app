
namespace SchedulingApp3
{
    partial class Main
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
            this.customerRecordsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerRecordsButton
            // 
            this.customerRecordsButton.Location = new System.Drawing.Point(262, 74);
            this.customerRecordsButton.Name = "customerRecordsButton";
            this.customerRecordsButton.Size = new System.Drawing.Size(229, 52);
            this.customerRecordsButton.TabIndex = 0;
            this.customerRecordsButton.Text = "Customer Records";
            this.customerRecordsButton.UseVisualStyleBackColor = true;
            this.customerRecordsButton.Click += new System.EventHandler(this.customerRecordsButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerRecordsButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerRecordsButton;
    }
}