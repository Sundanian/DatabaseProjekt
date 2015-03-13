namespace Guns_For_Hire
{
    partial class Form2
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
            this.List_Current_Assassins = new System.Windows.Forms.ListBox();
            this.List_Retired_Assassins = new System.Windows.Forms.ListBox();
            this.Btn_Hire_Assassin = new System.Windows.Forms.Button();
            this.btn_Retire_Assassin = new System.Windows.Forms.Button();
            this.btn_Rehire = new System.Windows.Forms.Button();
            this.List_Hire_Assassins = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // List_Current_Assassins
            // 
            this.List_Current_Assassins.FormattingEnabled = true;
            this.List_Current_Assassins.ItemHeight = 16;
            this.List_Current_Assassins.Location = new System.Drawing.Point(506, 124);
            this.List_Current_Assassins.Margin = new System.Windows.Forms.Padding(2);
            this.List_Current_Assassins.Name = "List_Current_Assassins";
            this.List_Current_Assassins.Size = new System.Drawing.Size(419, 468);
            this.List_Current_Assassins.TabIndex = 1;
            this.List_Current_Assassins.SelectedIndexChanged += new System.EventHandler(this.List_Current_Assassins_SelectedIndexChanged);
            // 
            // List_Retired_Assassins
            // 
            this.List_Retired_Assassins.FormattingEnabled = true;
            this.List_Retired_Assassins.ItemHeight = 16;
            this.List_Retired_Assassins.Location = new System.Drawing.Point(997, 124);
            this.List_Retired_Assassins.Margin = new System.Windows.Forms.Padding(2);
            this.List_Retired_Assassins.Name = "List_Retired_Assassins";
            this.List_Retired_Assassins.Size = new System.Drawing.Size(419, 468);
            this.List_Retired_Assassins.TabIndex = 2;
            this.List_Retired_Assassins.SelectedIndexChanged += new System.EventHandler(this.List_Retired_Assassins_SelectedIndexChanged);
            // 
            // Btn_Hire_Assassin
            // 
            this.Btn_Hire_Assassin.Location = new System.Drawing.Point(9, 72);
            this.Btn_Hire_Assassin.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Hire_Assassin.Name = "Btn_Hire_Assassin";
            this.Btn_Hire_Assassin.Size = new System.Drawing.Size(417, 48);
            this.Btn_Hire_Assassin.TabIndex = 3;
            this.Btn_Hire_Assassin.Text = "Hire Selected Assassin";
            this.Btn_Hire_Assassin.UseVisualStyleBackColor = true;
            this.Btn_Hire_Assassin.Click += new System.EventHandler(this.Btn_Hire_Assassin_Click);
            // 
            // btn_Retire_Assassin
            // 
            this.btn_Retire_Assassin.Location = new System.Drawing.Point(506, 72);
            this.btn_Retire_Assassin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Retire_Assassin.Name = "btn_Retire_Assassin";
            this.btn_Retire_Assassin.Size = new System.Drawing.Size(417, 48);
            this.btn_Retire_Assassin.TabIndex = 4;
            this.btn_Retire_Assassin.Text = "Retire Selected Assassin";
            this.btn_Retire_Assassin.UseVisualStyleBackColor = true;
            this.btn_Retire_Assassin.Click += new System.EventHandler(this.btn_Retire_Assassin_Click);
            // 
            // btn_Rehire
            // 
            this.btn_Rehire.Location = new System.Drawing.Point(997, 72);
            this.btn_Rehire.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Rehire.Name = "btn_Rehire";
            this.btn_Rehire.Size = new System.Drawing.Size(417, 48);
            this.btn_Rehire.TabIndex = 5;
            this.btn_Rehire.Text = "Rehire Selected Assassin";
            this.btn_Rehire.UseVisualStyleBackColor = true;
            this.btn_Rehire.Click += new System.EventHandler(this.btn_Rehire_Click);
            // 
            // List_Hire_Assassins
            // 
            this.List_Hire_Assassins.FormattingEnabled = true;
            this.List_Hire_Assassins.ItemHeight = 16;
            this.List_Hire_Assassins.Location = new System.Drawing.Point(8, 124);
            this.List_Hire_Assassins.Margin = new System.Windows.Forms.Padding(2);
            this.List_Hire_Assassins.Name = "List_Hire_Assassins";
            this.List_Hire_Assassins.Size = new System.Drawing.Size(419, 468);
            this.List_Hire_Assassins.TabIndex = 0;
            this.List_Hire_Assassins.SelectedIndexChanged += new System.EventHandler(this.List_Hire_Assassins_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 598);
            this.Controls.Add(this.btn_Rehire);
            this.Controls.Add(this.btn_Retire_Assassin);
            this.Controls.Add(this.Btn_Hire_Assassin);
            this.Controls.Add(this.List_Retired_Assassins);
            this.Controls.Add(this.List_Current_Assassins);
            this.Controls.Add(this.List_Hire_Assassins);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Assassin Management";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox List_Current_Assassins;
        private System.Windows.Forms.ListBox List_Retired_Assassins;
        private System.Windows.Forms.Button Btn_Hire_Assassin;
        private System.Windows.Forms.Button btn_Retire_Assassin;
        private System.Windows.Forms.Button btn_Rehire;
        private System.Windows.Forms.ListBox List_Hire_Assassins;

    }
}