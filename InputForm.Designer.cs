
namespace Modeling_1
{
    partial class InputForm
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
            this.Editable_Line = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.NewChar_Button = new System.Windows.Forms.Button();
            this.Ctg_Button = new System.Windows.Forms.Button();
            this.Tg_Button = new System.Windows.Forms.Button();
            this.Cos_Button = new System.Windows.Forms.Button();
            this.Sin_Button = new System.Windows.Forms.Button();
            this.Division_Button = new System.Windows.Forms.Button();
            this.Plus_Button = new System.Windows.Forms.Button();
            this.Minus_Button = new System.Windows.Forms.Button();
            this.Multiply_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Open_Bkt_Button = new System.Windows.Forms.Button();
            this.Close_Bkt_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Editable_Line
            // 
            this.Editable_Line.Location = new System.Drawing.Point(12, 12);
            this.Editable_Line.MaxLength = 80;
            this.Editable_Line.Name = "Editable_Line";
            this.Editable_Line.ReadOnly = true;
            this.Editable_Line.ShortcutsEnabled = false;
            this.Editable_Line.Size = new System.Drawing.Size(472, 20);
            this.Editable_Line.TabIndex = 0;
            this.Editable_Line.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.NewChar_Button);
            this.panel1.Controls.Add(this.Ctg_Button);
            this.panel1.Controls.Add(this.Tg_Button);
            this.panel1.Controls.Add(this.Cos_Button);
            this.panel1.Controls.Add(this.Sin_Button);
            this.panel1.Controls.Add(this.Division_Button);
            this.panel1.Controls.Add(this.Plus_Button);
            this.panel1.Controls.Add(this.Minus_Button);
            this.panel1.Controls.Add(this.Multiply_Button);
            this.panel1.Controls.Add(this.Clear_Button);
            this.panel1.Controls.Add(this.Open_Bkt_Button);
            this.panel1.Controls.Add(this.Close_Bkt_Button);
            this.panel1.Controls.Add(this.Delete_Button);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 62);
            this.panel1.TabIndex = 2;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Control;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(344, 34);
            this.Exit.MaximumSize = new System.Drawing.Size(125, 25);
            this.Exit.MinimumSize = new System.Drawing.Size(125, 25);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(125, 25);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Посчитать";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // NewChar_Button
            // 
            this.NewChar_Button.BackColor = System.Drawing.SystemColors.Control;
            this.NewChar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewChar_Button.Location = new System.Drawing.Point(344, 3);
            this.NewChar_Button.Name = "NewChar_Button";
            this.NewChar_Button.Size = new System.Drawing.Size(125, 25);
            this.NewChar_Button.TabIndex = 36;
            this.NewChar_Button.Text = "Новая переменная";
            this.NewChar_Button.UseVisualStyleBackColor = false;
            this.NewChar_Button.Click += new System.EventHandler(this.NewChar_Button_Click);
            // 
            // Ctg_Button
            // 
            this.Ctg_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Ctg_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ctg_Button.Location = new System.Drawing.Point(282, 34);
            this.Ctg_Button.Name = "Ctg_Button";
            this.Ctg_Button.Size = new System.Drawing.Size(56, 25);
            this.Ctg_Button.TabIndex = 35;
            this.Ctg_Button.Text = "ctg";
            this.Ctg_Button.UseVisualStyleBackColor = false;
            this.Ctg_Button.Click += new System.EventHandler(this.Ctg_Button_Click);
            // 
            // Tg_Button
            // 
            this.Tg_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Tg_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tg_Button.Location = new System.Drawing.Point(282, 3);
            this.Tg_Button.Name = "Tg_Button";
            this.Tg_Button.Size = new System.Drawing.Size(56, 25);
            this.Tg_Button.TabIndex = 34;
            this.Tg_Button.Text = "tg";
            this.Tg_Button.UseVisualStyleBackColor = false;
            this.Tg_Button.Click += new System.EventHandler(this.Tg_Button_Click);
            // 
            // Cos_Button
            // 
            this.Cos_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Cos_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cos_Button.Location = new System.Drawing.Point(220, 34);
            this.Cos_Button.Name = "Cos_Button";
            this.Cos_Button.Size = new System.Drawing.Size(56, 25);
            this.Cos_Button.TabIndex = 33;
            this.Cos_Button.Text = "cos";
            this.Cos_Button.UseVisualStyleBackColor = false;
            this.Cos_Button.Click += new System.EventHandler(this.Cos_Button_Click);
            // 
            // Sin_Button
            // 
            this.Sin_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Sin_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sin_Button.Location = new System.Drawing.Point(220, 3);
            this.Sin_Button.Name = "Sin_Button";
            this.Sin_Button.Size = new System.Drawing.Size(56, 25);
            this.Sin_Button.TabIndex = 32;
            this.Sin_Button.Text = "sin";
            this.Sin_Button.UseVisualStyleBackColor = false;
            this.Sin_Button.Click += new System.EventHandler(this.Sin_Button_Click);
            // 
            // Division_Button
            // 
            this.Division_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Division_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Division_Button.Location = new System.Drawing.Point(189, 34);
            this.Division_Button.Name = "Division_Button";
            this.Division_Button.Size = new System.Drawing.Size(25, 25);
            this.Division_Button.TabIndex = 23;
            this.Division_Button.Text = "/";
            this.Division_Button.UseVisualStyleBackColor = false;
            this.Division_Button.Click += new System.EventHandler(this.Division_Button_Click);
            // 
            // Plus_Button
            // 
            this.Plus_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Plus_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus_Button.Location = new System.Drawing.Point(158, 3);
            this.Plus_Button.Name = "Plus_Button";
            this.Plus_Button.Size = new System.Drawing.Size(25, 25);
            this.Plus_Button.TabIndex = 22;
            this.Plus_Button.Text = "+";
            this.Plus_Button.UseVisualStyleBackColor = false;
            this.Plus_Button.Click += new System.EventHandler(this.Plus_Button_Click);
            // 
            // Minus_Button
            // 
            this.Minus_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Minus_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus_Button.Location = new System.Drawing.Point(158, 34);
            this.Minus_Button.Name = "Minus_Button";
            this.Minus_Button.Size = new System.Drawing.Size(25, 25);
            this.Minus_Button.TabIndex = 21;
            this.Minus_Button.Text = "-";
            this.Minus_Button.UseVisualStyleBackColor = false;
            this.Minus_Button.Click += new System.EventHandler(this.Minus_Button_Click);
            // 
            // Multiply_Button
            // 
            this.Multiply_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Multiply_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiply_Button.Location = new System.Drawing.Point(189, 3);
            this.Multiply_Button.Name = "Multiply_Button";
            this.Multiply_Button.Size = new System.Drawing.Size(25, 25);
            this.Multiply_Button.TabIndex = 20;
            this.Multiply_Button.Text = "*";
            this.Multiply_Button.UseVisualStyleBackColor = false;
            this.Multiply_Button.Click += new System.EventHandler(this.Multiply_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.Location = new System.Drawing.Point(3, 34);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(118, 25);
            this.Clear_Button.TabIndex = 15;
            this.Clear_Button.Text = "Очистить";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Open_Bkt_Button
            // 
            this.Open_Bkt_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Open_Bkt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open_Bkt_Button.Location = new System.Drawing.Point(127, 3);
            this.Open_Bkt_Button.Name = "Open_Bkt_Button";
            this.Open_Bkt_Button.Size = new System.Drawing.Size(25, 25);
            this.Open_Bkt_Button.TabIndex = 11;
            this.Open_Bkt_Button.Text = "(";
            this.Open_Bkt_Button.UseVisualStyleBackColor = false;
            this.Open_Bkt_Button.Click += new System.EventHandler(this.Open_Bkt_Button_Click);
            // 
            // Close_Bkt_Button
            // 
            this.Close_Bkt_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Close_Bkt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Bkt_Button.Location = new System.Drawing.Point(127, 34);
            this.Close_Bkt_Button.Name = "Close_Bkt_Button";
            this.Close_Bkt_Button.Size = new System.Drawing.Size(25, 25);
            this.Close_Bkt_Button.TabIndex = 10;
            this.Close_Bkt_Button.Text = ")";
            this.Close_Bkt_Button.UseVisualStyleBackColor = false;
            this.Close_Bkt_Button.Click += new System.EventHandler(this.Close_Bkt_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Location = new System.Drawing.Point(3, 3);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(118, 25);
            this.Delete_Button.TabIndex = 9;
            this.Delete_Button.Text = "Стереть";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(491, 112);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Editable_Line);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(507, 151);
            this.MinimumSize = new System.Drawing.Size(507, 151);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Editable_Line;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Ctg_Button;
        private System.Windows.Forms.Button Tg_Button;
        private System.Windows.Forms.Button Cos_Button;
        private System.Windows.Forms.Button Sin_Button;
        private System.Windows.Forms.Button Division_Button;
        private System.Windows.Forms.Button Plus_Button;
        private System.Windows.Forms.Button Minus_Button;
        private System.Windows.Forms.Button Multiply_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Open_Bkt_Button;
        private System.Windows.Forms.Button Close_Bkt_Button;
        private System.Windows.Forms.Button Delete_Button;
        public System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button NewChar_Button;
    }
}