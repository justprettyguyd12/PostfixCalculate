using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeling_1
{
    public partial class Form1 : Form
    {
        //массивы значений таблицы принятий решений для вариантов 1 и 2
        int[] m1 = { 1, 2, 3, 4, 5, 7, 13, 14, 15, 17, 23, 24, 25, 27, 35, 37, 45, 47,
        51, 52, 53, 54, 55, 57, 65};
        int[] m2 = { 10, 11, 12, 16, 20, 21, 22, 26, 30, 31, 32, 33, 34, 36,
        40, 41, 42, 43, 44, 46, 60, 61, 62, 63, 64};

        //номер обрабатываемого символа преобразованной входной строки
        int c = 0;

        //показывает, преобразована ли входная строка
        bool IsTransformed = false;
        //показывает, закончено ли преобразование
        bool IsReady = false;

        //конструктор
        public Form1()
        {
            InitializeComponent();
        }

        #region обработчики

        //обработчик нажатия кнопки ввода выражения
        private void button1_Click(object sender, EventArgs e)
        {
            OpenInputForm();
        }

        //обработчик закрытия формы ввода выражения - получает введённое выражение
        void f2_FormClosing(object sender, EventArgs e)
        {
            Input.Text = (sender as InputForm).GetInput();
            Output.Text = "";
            IsReady = false;
            IsTransformed = false;
        }

        void f3_FormClosing(object sender, EventArgs e)
        {
            ///
            ///
            /// U R HERE
            /// 
            ///
        }

        //обработчик нажатия кнопки автоматического преобразования
        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            TransformInput();
            CalculateOutput();
            TransformOutput();
            MessageBox.Show("Преобразование окончено успешно");
        }

        //обработчик нажатия кнопки пошагового преобразования
        private void One_Step_Button_Click(object sender, EventArgs e)
        {
            if (IsReady) //очищает строку вывода и начинает преобразование заново
            {
                Output.Text = "";
                IsReady = false;
            }

            if (!IsTransformed)
            {
                TransformInput();
                IsTransformed = true;
            }
            else if (c < NewLine.Text.Length | StackList.Items.Count != 0)
            {
                c = MakeStep(c);
            }
            else
            {
                IsTransformed = false;
                IsReady = true;
                c = 0;
                TransformOutput();
                MessageBox.Show("Преобразование окончено успешно");
            }
        }

        //обработчик щелчка по входной строке - открывает форму ввода
        private void Input_MouseClick(object sender, MouseEventArgs e)
        {
            OpenInputForm();
        }

        //обработчик щелчка по кнопке "вычислить"
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (Output.Text.Length == 0)
                MessageBox.Show("Введите выражение для вычисления");
            else
            {
                CalculateForm f3 = new CalculateForm(Output.Text);
                f3.FormClosing += new FormClosingEventHandler(f3_FormClosing);
                f3.ShowDialog();
            }
        }

        #endregion



        #region методы

        //предобработка входной строки согласно рекомендациям
        protected void TransformInput()
        {
            NewLine.Text = Input.Text;
            NewLine.Text = NewLine.Text.Replace("sin", "S");
            NewLine.Text = NewLine.Text.Replace("cos", "C");
            NewLine.Text = NewLine.Text.Replace("ctg", "K");
            NewLine.Text = NewLine.Text.Replace("tg", "T");
        }

        //постобработка выходной строки
        private void TransformOutput()
        {
            Output.Text = Output.Text.Replace("S", "sin");
            Output.Text = Output.Text.Replace("C", "cos");
            Output.Text = Output.Text.Replace("T", "tg");
            Output.Text = Output.Text.Replace("K", "ctg");
        }

        //метод автоматического преобразования
        private void CalculateOutput()
        {
            StackList.Items.Clear();
            Output.Text = "";
            c = 0;
            if (NewLine.Text.Length == 0) //обработка изначально пустой входной строки
                MessageBox.Show("Входная строка пуста! Введите выражение", "Внимание!");
            else
            {
                // с = -1 возвращается в случае ошибки или успешного завершения
                while (c != -1)
                {
                    c = MakeStep(c);
                }
                if (NewLine.Text.Length == 0 & StackList.Items.Count == 0) //проверка успешности завершения алгоритма
                {
                    IsReady = true;
                    c = 0;
                }
                else if (c == -1)
                {
                    NewLine.Text = "";
                    StackList.Items.Clear();
                    c = 0;
                }
            }
        }

        //открытие формы ввода и создания обработчика события её закрытия
        private void OpenInputForm()
        {
            InputForm f2 = new InputForm();
            //создание события "закрытие формы" и привязка к нему метода "f2_FormClosing"
            f2.FormClosing += new FormClosingEventHandler(f2_FormClosing);
            f2.ShowDialog();
        }

        //основной метод - выполнение одного шага алгоритма
        //метод принимает число - индекс обрабатываемого символа входной строки
        private int MakeStep(int c)
        {
            //число а соотв. стобцам таблицы принятия решений, 
            //b - строкам, iSum - итоговое число, определяющее выполнение одного из шести действий алгоритма
            int a, b, iSum;

            //получение a и b с помощь соотв. методов и получение из них iSum
            if (NewLine.Text.Length == 0)
                a = 0;
            else
                a = SymbNumInputStr(NewLine.Text[c]);
            if (StackList.Items.Count == 0)
                b = 0;
            else
                b = SymbNumStack((char)StackList.Items[0]);
            iSum = a + 10 * b;

            //выбор действия в зависимости от полученного итогового числа
            switch (iSum)
            {
                case 0: // value = 4
                    return -1;
                case 6:
                case 50: // value = 5
                    MessageBox.Show("Ошибка скобочной структуры");
                    return -1;
                case 56: // value = 3
                    //удаление из строки и стека
                    NewLine.Text = NewLine.Text.Remove(c, 1);
                    StackList.Items.RemoveAt(0);
                    return c;
                case 66:
                case 67: // value = 7
                    MessageBox.Show("Ошибка! После функции отсутствует (");
                    return -1;
                default:
                    if (m1.Contains(iSum)) // value = 1
                    {
                        //перемещение из строки в стек
                        StackList.Items.Insert(0, NewLine.Text[c]);
                        NewLine.Text = NewLine.Text.Remove(c, 1);
                        return c;
                    }
                    else if (m2.Contains(iSum)) // value = 2
                    {
                        //перемещение из стека в выходную строку
                        Output.Text += StackList.Items[0];
                        StackList.Items.RemoveAt(0);
                        return c++;
                    }
                    else // value = 6
                    {
                        //перемещение из входной в выходную строку
                        Output.Text += NewLine.Text[c];
                        NewLine.Text = NewLine.Text.Remove(c, 1);
                        return c;
                    }
            }
        }

        //получение числа столбца для входной строки
        private byte SymbNumInputStr(char c)
        {
            switch (c)
            {
                case '+':
                    return 1;
                case '-':
                    return 2;
                case '*':
                    return 3;
                case '/':
                    return 4;
                case '(':
                    return 5;
                case ')':
                    return 6;
                default:
                    if (c == 'S' | c == 'C' | c == 'T' | c == 'K')
                        return 7;
                    else if (Char.IsLetter(c))
                        return 8;
                    else
                    {
                        MessageBox.Show("Недопустимый символ - допущена ошибка во входной строке. Проверьте данные");
                        return 0;
                    }
            }
        }

        //получение числа строки для стека
        private byte SymbNumStack(char c)
        {
            switch (c)
            {
                case '0':
                    return 0;
                case '+':
                    return 1;
                case '-':
                    return 2;
                case '*':
                    return 3;
                case '/':
                    return 4;
                case '(':
                    return 5;
                case 'F':
                    return 6;
                default:
                    if (Char.IsUpper(c))
                        return 6;
                    else
                    {
                        MessageBox.Show("Недопустимый символ - допущена ошибка во входной строке. Проверьте данные");
                        return 0;
                    }
            }
        }


        #endregion

    }
}
