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
            this.List_Hire_Assassins = new System.Windows.Forms.ListBox();
            this.List_Current_Assassins = new System.Windows.Forms.ListBox();
            this.List_Retired_Assassins = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List_Hire_Assassins
            // 
            this.List_Hire_Assassins.FormattingEnabled = true;
            this.List_Hire_Assassins.ItemHeight = 25;
            this.List_Hire_Assassins.Location = new System.Drawing.Point(12, 193);
            this.List_Hire_Assassins.Name = "List_Hire_Assassins";
            this.List_Hire_Assassins.Size = new System.Drawing.Size(626, 729);
            this.List_Hire_Assassins.TabIndex = 0;
            this.List_Hire_Assassins.SelectedIndexChanged += new System.EventHandler(this.List_Hire_Assassins_SelectedIndexChanged);
            // 
            // List_Current_Assassins
            // 
            this.List_Current_Assassins.FormattingEnabled = true;
            this.List_Current_Assassins.ItemHeight = 25;
            this.List_Current_Assassins.Location = new System.Drawing.Point(759, 193);
            this.List_Current_Assassins.Name = "List_Current_Assassins";
            this.List_Current_Assassins.Size = new System.Drawing.Size(626, 729);
            this.List_Current_Assassins.TabIndex = 1;
            this.List_Current_Assassins.SelectedIndexChanged += new System.EventHandler(this.List_Current_Assassins_SelectedIndexChanged);
            // 
            // List_Retired_Assassins
            // 
            this.List_Retired_Assassins.FormattingEnabled = true;
            this.List_Retired_Assassins.ItemHeight = 25;
            this.List_Retired_Assassins.Location = new System.Drawing.Point(1496, 193);
            this.List_Retired_Assassins.Name = "List_Retired_Assassins";
            this.List_Retired_Assassins.Size = new System.Drawing.Size(626, 729);
            this.List_Retired_Assassins.TabIndex = 2;
            this.List_Retired_Assassins.SelectedIndexChanged += new System.EventHandler(this.List_Retired_Assassins_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(625, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hire Selected Assassin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(759, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(625, 75);
            this.button2.TabIndex = 4;
            this.button2.Text = "Retire Selected Assassin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1496, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(625, 75);
            this.button3.TabIndex = 5;
            this.button3.Text = "Rehire Selected Assassin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2134, 934);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.List_Retired_Assassins);
            this.Controls.Add(this.List_Current_Assassins);
            this.Controls.Add(this.List_Hire_Assassins);
            this.Name = "Form2";
            this.Text = "Assassin Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox List_Hire_Assassins;
        private System.Windows.Forms.ListBox List_Current_Assassins;
        private System.Windows.Forms.ListBox List_Retired_Assassins;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}