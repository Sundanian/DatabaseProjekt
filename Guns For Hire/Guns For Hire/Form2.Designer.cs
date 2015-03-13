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
            this.Btn_Hire_Assassin = new System.Windows.Forms.Button();
            this.btn_Retire_Assassin = new System.Windows.Forms.Button();
            this.btn_Rehire = new System.Windows.Forms.Button();
            this.List_Hire_Assassin = new System.Windows.Forms.ListView();
            this.List_Retire_Assassin = new System.Windows.Forms.ListView();
            this.List_Rehire_Assassin = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Btn_Hire_Assassin
            // 
            this.Btn_Hire_Assassin.Location = new System.Drawing.Point(13, 112);
            this.Btn_Hire_Assassin.Name = "Btn_Hire_Assassin";
            this.Btn_Hire_Assassin.Size = new System.Drawing.Size(626, 75);
            this.Btn_Hire_Assassin.TabIndex = 3;
            this.Btn_Hire_Assassin.Text = "Hire Selected Assassin";
            this.Btn_Hire_Assassin.UseVisualStyleBackColor = true;
            this.Btn_Hire_Assassin.Click += new System.EventHandler(this.Btn_Hire_Assassin_Click);
            // 
            // btn_Retire_Assassin
            // 
            this.btn_Retire_Assassin.Location = new System.Drawing.Point(759, 112);
            this.btn_Retire_Assassin.Name = "btn_Retire_Assassin";
            this.btn_Retire_Assassin.Size = new System.Drawing.Size(626, 75);
            this.btn_Retire_Assassin.TabIndex = 4;
            this.btn_Retire_Assassin.Text = "Retire Selected Assassin";
            this.btn_Retire_Assassin.UseVisualStyleBackColor = true;
            this.btn_Retire_Assassin.Click += new System.EventHandler(this.btn_Retire_Assassin_Click);
            // 
            // btn_Rehire
            // 
            this.btn_Rehire.Location = new System.Drawing.Point(1496, 112);
            this.btn_Rehire.Name = "btn_Rehire";
            this.btn_Rehire.Size = new System.Drawing.Size(626, 75);
            this.btn_Rehire.TabIndex = 5;
            this.btn_Rehire.Text = "Rehire Selected Assassin";
            this.btn_Rehire.UseVisualStyleBackColor = true;
            this.btn_Rehire.Click += new System.EventHandler(this.btn_Rehire_Click);
            // 
            // List_Hire_Assassin
            // 
            this.List_Hire_Assassin.Location = new System.Drawing.Point(13, 194);
            this.List_Hire_Assassin.Name = "List_Hire_Assassin";
            this.List_Hire_Assassin.Size = new System.Drawing.Size(626, 728);
            this.List_Hire_Assassin.TabIndex = 6;
            this.List_Hire_Assassin.UseCompatibleStateImageBehavior = false;
            this.List_Hire_Assassin.SelectedIndexChanged += new System.EventHandler(this.List_Hire_Assassin_SelectedIndexChanged);
            // 
            // List_Retire_Assassin
            // 
            this.List_Retire_Assassin.Location = new System.Drawing.Point(759, 194);
            this.List_Retire_Assassin.Name = "List_Retire_Assassin";
            this.List_Retire_Assassin.Size = new System.Drawing.Size(626, 728);
            this.List_Retire_Assassin.TabIndex = 7;
            this.List_Retire_Assassin.UseCompatibleStateImageBehavior = false;
            this.List_Retire_Assassin.SelectedIndexChanged += new System.EventHandler(this.List_Retire_Assassin_SelectedIndexChanged);
            // 
            // List_Rehire_Assassin
            // 
            this.List_Rehire_Assassin.Location = new System.Drawing.Point(1496, 194);
            this.List_Rehire_Assassin.Name = "List_Rehire_Assassin";
            this.List_Rehire_Assassin.Size = new System.Drawing.Size(626, 728);
            this.List_Rehire_Assassin.TabIndex = 8;
            this.List_Rehire_Assassin.UseCompatibleStateImageBehavior = false;
            this.List_Rehire_Assassin.SelectedIndexChanged += new System.EventHandler(this.List_Rehire_Assassin_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2134, 934);
            this.Controls.Add(this.List_Rehire_Assassin);
            this.Controls.Add(this.List_Retire_Assassin);
            this.Controls.Add(this.List_Hire_Assassin);
            this.Controls.Add(this.btn_Rehire);
            this.Controls.Add(this.btn_Retire_Assassin);
            this.Controls.Add(this.Btn_Hire_Assassin);
            this.Name = "Form2";
            this.Text = "Assassin Management";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Hire_Assassin;
        private System.Windows.Forms.Button btn_Retire_Assassin;
        private System.Windows.Forms.Button btn_Rehire;
        private System.Windows.Forms.ListView List_Hire_Assassin;
        private System.Windows.Forms.ListView List_Retire_Assassin;
        private System.Windows.Forms.ListView List_Rehire_Assassin;

    }
}