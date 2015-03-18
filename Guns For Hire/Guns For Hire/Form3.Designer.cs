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
            this.Btn_Select_Mission = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.list_Mission = new System.Windows.Forms.ListView();
            this.list_Mission_Ongoing = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Available_Assassins = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Select_Mission
            // 
            this.Btn_Select_Mission.Location = new System.Drawing.Point(437, 539);
            this.Btn_Select_Mission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Select_Mission.Name = "Btn_Select_Mission";
            this.Btn_Select_Mission.Size = new System.Drawing.Size(419, 48);
            this.Btn_Select_Mission.TabIndex = 4;
            this.Btn_Select_Mission.Text = "Start Mission";
            this.Btn_Select_Mission.UseVisualStyleBackColor = true;
            this.Btn_Select_Mission.Click += new System.EventHandler(this.Btn_Select_Mission_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1292, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_Mission
            // 
            this.list_Mission.FullRowSelect = true;
            this.list_Mission.Location = new System.Drawing.Point(12, 67);
            this.list_Mission.Name = "list_Mission";
            this.list_Mission.Size = new System.Drawing.Size(419, 468);
            this.list_Mission.TabIndex = 6;
            this.list_Mission.UseCompatibleStateImageBehavior = false;
            this.list_Mission.View = System.Windows.Forms.View.Details;
            this.list_Mission.SelectedIndexChanged += new System.EventHandler(this.list_Mission_SelectedIndexChanged);
            // 
            // list_Mission_Ongoing
            // 
            this.list_Mission_Ongoing.FullRowSelect = true;
            this.list_Mission_Ongoing.Location = new System.Drawing.Point(948, 67);
            this.list_Mission_Ongoing.Name = "list_Mission_Ongoing";
            this.list_Mission_Ongoing.Size = new System.Drawing.Size(419, 468);
            this.list_Mission_Ongoing.TabIndex = 8;
            this.list_Mission_Ongoing.UseCompatibleStateImageBehavior = false;
            this.list_Mission_Ongoing.View = System.Windows.Forms.View.Details;
            this.list_Mission_Ongoing.SelectedIndexChanged += new System.EventHandler(this.list_Mission_Ongoing_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Available Missions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Available Assassins";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(945, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Your Missions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "Remember to select a mission AND an assassin. \r\nDon\'t mind the visual selection d" +
    "issapearing, it\'s still selected.";
            // 
            // Available_Assassins
            // 
            this.Available_Assassins.FullRowSelect = true;
            this.Available_Assassins.Location = new System.Drawing.Point(437, 67);
            this.Available_Assassins.Name = "Available_Assassins";
            this.Available_Assassins.Size = new System.Drawing.Size(419, 468);
            this.Available_Assassins.TabIndex = 13;
            this.Available_Assassins.UseCompatibleStateImageBehavior = false;
            this.Available_Assassins.View = System.Windows.Forms.View.Details;
            this.Available_Assassins.SelectedIndexChanged += new System.EventHandler(this.Available_Assassins_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(948, 540);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(419, 48);
            this.button2.TabIndex = 14;
            this.button2.Text = "Finnish All Missions";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 598);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Available_Assassins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Mission_Ongoing);
            this.Controls.Add(this.list_Mission);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Select_Mission);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Select_Mission;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView list_Mission;
        private System.Windows.Forms.ListView list_Mission_Ongoing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView Available_Assassins;
        private System.Windows.Forms.Button button2;

    }
}