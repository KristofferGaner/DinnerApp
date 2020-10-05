namespace DinnerApp
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
            this.Recipename = new System.Windows.Forms.TextBox();
            this.Preptime = new System.Windows.Forms.ComboBox();
            this.Meattype = new System.Windows.Forms.ComboBox();
            this.Addrecipe = new System.Windows.Forms.Button();
            // 
            // Recipename
            // 
            this.Recipename.Location = new System.Drawing.Point(42, 30);
            this.Recipename.Name = "Recipename";
            this.Recipename.Size = new System.Drawing.Size(185, 23);
            this.Recipename.TabIndex = 0;
            this.Recipename.Text = "Name of recipe";
            // 
            // Preptime
            // 
            this.Preptime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Preptime.FormattingEnabled = true;
            this.Preptime.Location = new System.Drawing.Point(42, 59);
            this.Preptime.Name = "Preptime";
            this.Preptime.Size = new System.Drawing.Size(121, 23);
            this.Preptime.TabIndex = 1;
            // 
            // Meattype
            // 
            this.Meattype.FormattingEnabled = true;
            this.Meattype.Location = new System.Drawing.Point(42, 88);
            this.Meattype.Name = "Meattype";
            this.Meattype.Size = new System.Drawing.Size(121, 23);
            this.Meattype.TabIndex = 2;
            this.Meattype.Text = "Meat";
            // 
            // Addrecipe
            // 
            this.Addrecipe.AutoSize = true;
            this.Addrecipe.Location = new System.Drawing.Point(42, 127);
            this.Addrecipe.Name = "Addrecipe";
            this.Addrecipe.Size = new System.Drawing.Size(75, 25);
            this.Addrecipe.TabIndex = 3;
            this.Addrecipe.Text = "Add recipe";
            this.Addrecipe.UseVisualStyleBackColor = true;
            this.Addrecipe.Click += new System.EventHandler(this.Addrecipe_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(252, 170);
            this.Controls.Add(this.Addrecipe);
            this.Controls.Add(this.Meattype);
            this.Controls.Add(this.Preptime);
            this.Controls.Add(this.Recipename);
            this.Name = "Form2";

        }

        #endregion

        private System.Windows.Forms.TextBox Recipename;
        private System.Windows.Forms.ComboBox Preptime;
        private System.Windows.Forms.ComboBox Meattype;
        private System.Windows.Forms.Button Addrecipe;
        
    }
}