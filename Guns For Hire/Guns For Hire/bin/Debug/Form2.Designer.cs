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
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List_Retire_Assassin = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.List_Rehire_Assassin = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // List_Hire_Assassin
            // 
            this.List_Hire_Assassin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.List_Hire_Assassin.FullRowSelect = true;
            this.List_Hire_Assassin.Location = new System.Drawing.Point(9, 124);
            this.List_Hire_Assassin.Margin = new System.Windows.Forms.Padding(2);
            this.List_Hire_Assassin.Name = "List_Hire_Assassin";
            this.List_Hire_Assassin.Size = new System.Drawing.Size(419, 467);
            this.List_Hire_Assassin.TabIndex = 6;
            this.List_Hire_Assassin.UseCompatibleStateImageBehavior = false;
            this.List_Hire_Assassin.View = System.Windows.Forms.View.Details;
            this.List_Hire_Assassin.SelectedIndexChanged += new System.EventHandler(this.List_Hire_Assassin_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id";
            this.columnHeader2.Width = 30;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Xp";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Level";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pris";
            // 
            // List_Retire_Assassin
            // 
            this.List_Retire_Assassin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.List_Retire_Assassin.FullRowSelect = true;
            this.List_Retire_Assassin.Location = new System.Drawing.Point(506, 124);
            this.List_Retire_Assassin.Margin = new System.Windows.Forms.Padding(2);
            this.List_Retire_Assassin.Name = "List_Retire_Assassin";
            this.List_Retire_Assassin.Size = new System.Drawing.Size(419, 467);
            this.List_Retire_Assassin.TabIndex = 7;
            this.List_Retire_Assassin.UseCompatibleStateImageBehavior = false;
            this.List_Retire_Assassin.View = System.Windows.Forms.View.Details;
            this.List_Retire_Assassin.SelectedIndexChanged += new System.EventHandler(this.List_Retire_Assassin_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Xp";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Level";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Pris";
            // 
            // List_Rehire_Assassin
            // 
            this.List_Rehire_Assassin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.List_Rehire_Assassin.FullRowSelect = true;
            this.List_Rehire_Assassin.Location = new System.Drawing.Point(997, 124);
            this.List_Rehire_Assassin.Margin = new System.Windows.Forms.Padding(2);
            this.List_Rehire_Assassin.Name = "List_Rehire_Assassin";
            this.List_Rehire_Assassin.Size = new System.Drawing.Size(419, 467);
            this.List_Rehire_Assassin.TabIndex = 8;
            this.List_Rehire_Assassin.UseCompatibleStateImageBehavior = false;
            this.List_Rehire_Assassin.View = System.Windows.Forms.View.Details;
            this.List_Rehire_Assassin.SelectedIndexChanged += new System.EventHandler(this.List_Rehire_Assassin_SelectedIndexChanged);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ID";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Name";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "XP";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Level";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Pris";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1339, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.List_Rehire_Assassin);
            this.Controls.Add(this.List_Retire_Assassin);
            this.Controls.Add(this.btn_Rehire);
            this.Controls.Add(this.btn_Retire_Assassin);
            this.Controls.Add(this.Btn_Hire_Assassin);
            this.Controls.Add(this.List_Hire_Assassin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;

    }
}