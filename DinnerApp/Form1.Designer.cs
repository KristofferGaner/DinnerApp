namespace DinnerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Allrecipies = new System.Windows.Forms.CheckBox();
            this.Dinner = new System.Windows.Forms.Button();
            this.Addrecipe = new System.Windows.Forms.Button();
            this.Preptime = new System.Windows.Forms.ComboBox();
            this.Meattype = new System.Windows.Forms.ComboBox();
            this.Symbol = new System.Windows.Forms.ComboBox();
            this.RecipeListBox = new System.Windows.Forms.ListBox();
            // 
            // Allrecipies
            // 
            this.Allrecipies.AutoSize = true;
            this.Allrecipies.Location = new System.Drawing.Point(57, 120);
            this.Allrecipies.Name = "Allrecipies";
            this.Allrecipies.Size = new System.Drawing.Size(70, 19);
            this.Allrecipies.TabIndex = 0;
            this.Allrecipies.Text = "Show all";
            this.Allrecipies.UseVisualStyleBackColor = true;
            // 
            // Dinner
            // 
            this.Dinner.AutoSize = true;
            this.Dinner.Location = new System.Drawing.Point(57, 145);
            this.Dinner.Name = "Dinner";
            this.Dinner.Size = new System.Drawing.Size(75, 25);
            this.Dinner.TabIndex = 1;
            this.Dinner.Text = "Dinner?";
            this.Dinner.UseVisualStyleBackColor = true;
            this.Dinner.Click += new System.EventHandler(this.Dinner_Click_1);
            // 
            // Addrecipe
            // 
            this.Addrecipe.AutoSize = true;
            this.Addrecipe.Location = new System.Drawing.Point(195, 18);
            this.Addrecipe.Name = "Addrecipe";
            this.Addrecipe.Size = new System.Drawing.Size(77, 25);
            this.Addrecipe.TabIndex = 2;
            this.Addrecipe.Text = "Add Recipe";
            this.Addrecipe.UseVisualStyleBackColor = true;
            this.Addrecipe.Click += new System.EventHandler(this.Addrecipe_Click_1);
            // 
            // Preptime
            // 
            this.Preptime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Preptime.FormattingEnabled = true;
            this.Preptime.Location = new System.Drawing.Point(57, 62);
            this.Preptime.Name = "Preptime";
            this.Preptime.Size = new System.Drawing.Size(121, 23);
            this.Preptime.TabIndex = 3;
            // 
            // Meattype
            // 
            this.Meattype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Meattype.FormattingEnabled = true;
            this.Meattype.Location = new System.Drawing.Point(57, 91);
            this.Meattype.Name = "Meattype";
            this.Meattype.Size = new System.Drawing.Size(121, 23);
            this.Meattype.TabIndex = 4;
            // 
            // Symbol
            // 
            this.Symbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Symbol.FormattingEnabled = true;
            this.Symbol.Items.AddRange(new object[] {
            "=",
            "<=",
            ">="});
            this.Symbol.Location = new System.Drawing.Point(7, 62);
            this.Symbol.Name = "Symbol";
            this.Symbol.Size = new System.Drawing.Size(44, 23);
            this.Symbol.TabIndex = 5;
            // 
            // RecipeListBox
            // 
            this.RecipeListBox.FormattingEnabled = true;
            this.RecipeListBox.ItemHeight = 15;
            this.RecipeListBox.Location = new System.Drawing.Point(195, 62);
            this.RecipeListBox.Name = "RecipeListBox";
            this.RecipeListBox.Size = new System.Drawing.Size(210, 154);
            this.RecipeListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(434, 239);
            this.Controls.Add(this.RecipeListBox);
            this.Controls.Add(this.Symbol);
            this.Controls.Add(this.Meattype);
            this.Controls.Add(this.Preptime);
            this.Controls.Add(this.Addrecipe);
            this.Controls.Add(this.Dinner);
            this.Controls.Add(this.Allrecipies);
            this.Name = "Form1";

        }

        #endregion

        private System.Windows.Forms.CheckBox Allrecipies;
        private System.Windows.Forms.Button Dinner;
        private System.Windows.Forms.Button Addrecipe;
        private System.Windows.Forms.ComboBox Preptime;
        private System.Windows.Forms.ComboBox Meattype;
        private System.Windows.Forms.ComboBox Symbol;
        private System.Windows.Forms.ListBox RecipeListBox;
    }
}

