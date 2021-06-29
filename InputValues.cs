using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeling_1
{
    public partial class InputValues : Form
    {
        //список числовых значений переменных
        //хранится строками, тк неизвестно, целочисленное число введено или нет
        List<string> Values = new List<string>();
        //список переменных, полученный из предыдущей формы
        List<char> Variables = new List<char>();
        //счетчик присовенных переменных
        int c = 0;

        //конструктор формы - принимает список переменных и переписывает их себе
        public InputValues(List<char> Variables)
        {
            InitializeComponent();
            this.Variables = Variables;
            //первую переменную списка отправляет на форму
            Variable.Text = Char.ToString(Variables[c]);
        }

        //обработчик нажатия кнопки "ОК"
        private void button1_Click(object sender, EventArgs e)
        {
            if (Value.Text.Length == 0) //обработка пустого поля
                MessageBox.Show("Введите значение!");
            else
            {
                Values.Add(Value.Text);
                Value.Text = "";
                c++;
                if (c < Variables.Count) //введены не все переменные
                {
                    //textbox не работает с char, поэтому конвертим в строку
                    Variable.Text = Char.ToString(Variables[c]); 
                }
                else //введены все переменные
                {
                    Close();
                }
            }
        }

        //обработчик нажатия кнопки
        private void Value_KeyDown(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            //обработчик нажатия кнопки "Enter"
            if (n == 13)
            {
                button1_Click(sender, e);
                e.Handled = true;
            }
            //запрет ввода символов, не считая цифр, точки и backspace
            else if (!Char.IsDigit(n) && n != 8 && n != '.')
            {
                e.Handled = true;
            }
            //запрет ввода нескольких точек или точки в начале переменной
            else if ((n == '.' && Value.Text.Length == 0) || (n == '.' && Value.Text[Value.Text.Length - 1] == '.'))
            {
                e.Handled = true;
            }
        }

        //метод для получения значений предыдущей формой
        public List<string> GetValues()
        {
            return Values;
        }

    }
}
