
namespace Modeling_1
{
    partial class CalculateForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.OpenInputValues = new System.Windows.Forms.Button();
            this.NewLine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValuesList = new System.Windows.Forms.ListBox();
            this.Stack = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.One_Step_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Input);
            this.panel1.Controls.Add(this.OpenInputValues);
            this.panel1.Controls.Add(this.NewLine);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Output);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 81);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Входная строка (постфиксная форма)";
            // 
            // Input
            // 
            this.Input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input.Location = new System.Drawing.Point(3, 18);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(380, 20);
            this.Input.TabIndex = 0;
            this.Input.TabStop = false;
            // 
            // OpenInputValues
            // 
            this.OpenInputValues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenInputValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenInputValues.Location = new System.Drawing.Point(3, 42);
            this.OpenInputValues.Name = "OpenInputValues";
            this.OpenInputValues.Size = new System.Drawing.Size(380, 35);
            this.OpenInputValues.TabIndex = 9;
            this.OpenInputValues.Text = "Ввести значения";
            this.OpenInputValues.UseVisualStyleBackColor = true;
            this.OpenInputValues.Click += new System.EventHandler(this.OpenInputValues_Click);
            // 
            // NewLine
            // 
            this.NewLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewLine.BackColor = System.Drawing.SystemColors.Window;
            this.NewLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewLine.Location = new System.Drawing.Point(393, 18);
            this.NewLine.Name = "NewLine";
            this.NewLine.ReadOnly = true;
            this.NewLine.Size = new System.Drawing.Size(380, 20);
            this.NewLine.TabIndex = 11;
            this.NewLine.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(390, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Преобразованная строка";
            // 
            // Output
            // 
            this.Output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Output.BackColor = System.Drawing.SystemColors.Window;
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output.Location = new System.Drawing.Point(393, 57);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(380, 20);
            this.Output.TabIndex = 1;
            this.Output.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(390, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выходная строка (результат вычисления)";
            // 
            // ValuesList
            // 
            this.ValuesList.FormattingEnabled = true;
            this.ValuesList.Location = new System.Drawing.Point(15, 99);
            this.ValuesList.Name = "ValuesList";
            this.ValuesList.Size = new System.Drawing.Size(187, 173);
            this.ValuesList.TabIndex = 15;
            // 
            // Stack
            // 
            this.Stack.FormattingEnabled = true;
            this.Stack.Location = new System.Drawing.Point(208, 99);
            this.Stack.Name = "Stack";
            this.Stack.Size = new System.Drawing.Size(187, 173);
            this.Stack.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.One_Step_Button);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(405, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 85);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пошаговый режим";
            // 
            // One_Step_Button
            // 
            this.One_Step_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.One_Step_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.One_Step_Button.Location = new System.Drawing.Point(3, 35);
            this.One_Step_Button.Name = "One_Step_Button";
            this.One_Step_Button.Size = new System.Drawing.Size(154, 25);
            this.One_Step_Button.TabIndex = 11;
            this.One_Step_Button.Text = "Выполнить один шаг";
            this.One_Step_Button.UseVisualStyleBackColor = true;
            this.One_Step_Button.Click += new System.EventHandler(this.One_Step_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.Calculate_Button);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(405, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 85);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автоматический режим";
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Calculate_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Calculate_Button.Location = new System.Drawing.Point(3, 35);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(154, 25);
            this.Calculate_Button.TabIndex = 10;
            this.Calculate_Button.Text = "Выполнить автоматически";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Stack);
            this.Controls.Add(this.ValuesList);
            this.Controls.Add(this.panel1);
            this.Name = "CalculateForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button OpenInputValues;
        private System.Windows.Forms.TextBox NewLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ValuesList;
        private System.Windows.Forms.ListBox Stack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button One_Step_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Calculate_Button;
    }
}