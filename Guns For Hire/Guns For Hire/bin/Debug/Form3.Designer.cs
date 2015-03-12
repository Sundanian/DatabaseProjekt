namespace Guns_For_Hire
{
    partial class Form3
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
            this.List_Mission = new System.Windows.Forms.ListBox();
            this.List_Mission_detail = new System.Windows.Forms.ListBox();
            this.List_Mission_ongoing = new System.Windows.Forms.ListBox();
            this.Btn_Select_Mission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List_Mission
            // 
            this.List_Mission.FormattingEnabled = true;
            this.List_Mission.ItemHeight = 25;
            this.List_Mission.Location = new System.Drawing.Point(12, 193);
            this.List_Mission.Name = "List_Mission";
            this.List_Mission.Size = new System.Drawing.Size(626, 729);
            this.List_Mission.TabIndex = 1;
            // 
            // List_Mission_detail
            // 
            this.List_Mission_detail.FormattingEnabled = true;
            this.List_Mission_detail.ItemHeight = 25;
            this.List_Mission_detail.Location = new System.Drawing.Point(644, 193);
            this.List_Mission_detail.Name = "List_Mission_detail";
            this.List_Mission_detail.Size = new System.Drawing.Size(626, 729);
            this.List_Mission_detail.TabIndex = 2;
            // 
            // List_Mission_ongoing
            // 
            this.List_Mission_ongoing.FormattingEnabled = true;
            this.List_Mission_ongoing.ItemHeight = 25;
            this.List_Mission_ongoing.Location = new System.Drawing.Point(1496, 193);
            this.List_Mission_ongoing.Name = "List_Mission_ongoing";
            this.List_Mission_ongoing.Size = new System.Drawing.Size(626, 729);
            this.List_Mission_ongoing.TabIndex = 3;
            // 
            // Btn_Select_Mission
            // 
            this.Btn_Select_Mission.Location = new System.Drawing.Point(12, 112);
            this.Btn_Select_Mission.Name = "Btn_Select_Mission";
            this.Btn_Select_Mission.Size = new System.Drawing.Size(626, 75);
            this.Btn_Select_Mission.TabIndex = 4;
            this.Btn_Select_Mission.Text = "Select Mission";
            this.Btn_Select_Mission.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2134, 934);
            this.Controls.Add(this.Btn_Select_Mission);
            this.Controls.Add(this.List_Mission_ongoing);
            this.Controls.Add(this.List_Mission_detail);
            this.Controls.Add(this.List_Mission);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox List_Mission;
        private System.Windows.Forms.ListBox List_Mission_detail;
        private System.Windows.Forms.ListBox List_Mission_ongoing;
        private System.Windows.Forms.Button Btn_Select_Mission;

    }
}