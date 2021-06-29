
namespace Modeling_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StackList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.NewLine = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.One_Step_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.MainVlaue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Входная строка (инфиксная форма)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(390, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выходная строка (постфиксная форма)";
            // 
            // StackList
            // 
            this.StackList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StackList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StackList.FormattingEnabled = true;
            this.StackList.Location = new System.Drawing.Point(405, 115);
            this.StackList.Name = "StackList";
            this.StackList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.StackList.Size = new System.Drawing.Size(114, 173);
            this.StackList.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Стек";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ввести выражение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Calculate_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Calculate_Button.Location = new System.Drawing.Point(3, 20);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(154, 25);
            this.Calculate_Button.TabIndex = 10;
            this.Calculate_Button.Text = "Выполнить автоматически";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
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
            // Input
            // 
            this.Input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input.Location = new System.Drawing.Point(3, 18);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(380, 20);
            this.Input.TabIndex = 0;
            this.Input.TabStop = false;
            this.Input.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Input_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Input);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NewLine);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Output);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 81);
            this.panel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.Calculate_Button);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 55);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автоматический режим";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.One_Step_Button);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 55);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пошаговый режим";
            // 
            // One_Step_Button
            // 
            this.One_Step_Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.One_Step_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.One_Step_Button.Location = new System.Drawing.Point(3, 20);
            this.One_Step_Button.Name = "One_Step_Button";
            this.One_Step_Button.Size = new System.Drawing.Size(154, 25);
            this.One_Step_Button.TabIndex = 11;
            this.One_Step_Button.Text = "Выполнить один шаг";
            this.One_Step_Button.UseVisualStyleBackColor = true;
            this.One_Step_Button.Click += new System.EventHandler(this.One_Step_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Выбор режима";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Таблица принятия решений";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.MainVlaue);
            this.groupBox3.Controls.Add(this.CalculateButton);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox3.Location = new System.Drawing.Point(12, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 55);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вычисление";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalculateButton.Location = new System.Drawing.Point(3, 20);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(154, 25);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Вычислить";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // MainVlaue
            // 
            this.MainVlaue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainVlaue.BackColor = System.Drawing.SystemColors.Window;
            this.MainVlaue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainVlaue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainVlaue.Location = new System.Drawing.Point(253, 20);
            this.MainVlaue.Name = "MainVlaue";
            this.MainVlaue.ReadOnly = true;
            this.MainVlaue.Size = new System.Drawing.Size(124, 25);
            this.MainVlaue.TabIndex = 13;
            this.MainVlaue.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(182, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Результат: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StackList);
            this.Name = "Form1";
            this.Text = "Л.р. 2 Шалютин";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox StackList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Calculate_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TextBox NewLine;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button One_Step_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MainVlaue;
    }
}

