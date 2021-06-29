using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeling_1
{
    public partial class CalculateForm : Form
    {
        //списки переменных и их значений
        List<char> Variables = new List<char>();
        List<string> Values = new List<string>();
        //преобразованная строка
        String TransformText;
        //выполнен ли алгоритм преобразования
        bool isCalculated = false;

        public CalculateForm(String s)
        {
            InitializeComponent();
            Input.Text = s;
            NewLine.Text = Input.Text.Replace("sin", "S");
            NewLine.Text = NewLine.Text.Replace("cos", "C");
            NewLine.Text = NewLine.Text.Replace("ctg", "K");
            NewLine.Text = NewLine.Text.Replace("tg", "T");
            TransformText = NewLine.Text;
            //добавляем в список переменных все буквы, не являющиеся кодами функций
            foreach (char c in NewLine.Text)
            {
                if (Char.IsLetter(c) & c != 'S' & c != 'C' & c != 'T' & c != 'K')
                    Variables.Add(c);
            }
        }

        //обработчик закрытия формы ввода переменных
        private void OpenInputValues_Click(object sender, EventArgs e)
        {
            InputValues f4 = new InputValues(Variables);
            //создание события "закрытие формы" и привязка к нему метода "f4_FormClosing"
            f4.FormClosing += new FormClosingEventHandler(f4_FormClosing);
            f4.ShowDialog();
        }

        //обработчик закрытия формы "InputValues"
        private void f4_FormClosing(object sender, EventArgs e)
        {
            Values = (sender as InputValues).GetValues();
            ValuesList.Items.Clear();
            for (int i = 0; i < Values.Count; i++)
            {
                ValuesList.Items.Add(Variables[i] + " = " + Values[i]);
            }
            Stack.Items.Clear();
            NewLine.Text = TransformText;
            Output.Text = "";
        }

        //обработчик нажатия кнопки "выполнение одного шага"
        private void One_Step_Button_Click(object sender, EventArgs e)
        {
            if (!isCalculated) //выполнение шага, если алгоритм ещё не выполнен
            {
                if (Variables.Count != Values.Count)
                    MessageBox.Show("Задайте значения всех переменных!");
                else
                    MakeOneStep();
            }
            else //запуск алгоритма по-новой и выполнение шага
            {
                isCalculated = false;
                NewLine.Text = TransformText;
                MakeOneStep();
            }
        }

        //обработчик нажатия кнопки "автоматическое выполнение"
        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            if (Variables.Count != Values.Count)
                MessageBox.Show("Задайте значения всех переменных!");
            else
            {
                while (!isCalculated)
                {
                    MakeOneStep();
                }
            }
        }

        //основной метод - выполнение одного шага алгоритма вычисления
        private void MakeOneStep()
        {
            //локализация на английский язык для корректных вычислений
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            //проверка того, что входная строка не пуста
            if (NewLine.Text.Length != 0)
            {
                int index = 0; //индекс, подсчитывающий номер текущей переменной
                char c = NewLine.Text[0];
                //обработчик для переменных
                if (Char.IsLetter(c) & c != 'S' & c != 'C' & c != 'T' & c != 'K')
                {
                    for (int i = 0; i < Variables.Count; i++)
                    {
                        if (c == Variables[i])
                            index = i;
                    }
                    Stack.Items.Insert(0, Values[index]);
                    NewLine.Text = NewLine.Text.Remove(0, 1);
                }
                //обработчики для операций
                else if (c == '+' | c == '-' | c == '*' | c == '/')
                {
                    float a = float.Parse(Stack.Items[0].ToString());
                    Stack.Items.RemoveAt(0);
                    float b = float.Parse(Stack.Items[0].ToString());
                    Stack.Items.RemoveAt(0);
                    if (c == '+')
                        Stack.Items.Insert(0, b + a);
                    else if (c == '-')
                        Stack.Items.Insert(0, b - a);
                    else if (c == '*')
                        Stack.Items.Insert(0, b * a);
                    else //выполнение операции деления с проверкой деления на ноль
                    {
                        if (a != 0) //проверка деления на ноль
                        {
                            Stack.Items.Insert(0, b / a);
                        }
                        else
                        {
                            MessageBox.Show("Обнаружено деление на ноль. Повторите школьный курс арифметики " +
                                "и введите нормальные  значения переменных");
                            Values.Clear();
                            Stack.Items.Clear();
                            NewLine.Text = TransformText;
                            Output.Text = "";
                        }
                    }
                    NewLine.Text = NewLine.Text.Remove(0, 1);
                }
                //обработчики для функций
                else
                {
                    float a = float.Parse(Stack.Items[0].ToString());
                    Stack.Items.RemoveAt(0);
                    if (c == 'S')
                        Stack.Items.Insert(0, Math.Sin(a).ToString());
                    else if (c == 'C')
                        Stack.Items.Insert(0, Math.Cos(a).ToString());
                    else if (c == 'T')
                    {
                        double i = Math.Tan(a);
                        if (i == double.PositiveInfinity | i == double.NegativeInfinity) //обработка критических точек тангенса
                        {
                            MessageBox.Show("В данной точке тангенса не существует. Введите другие значения переменных");
                            Values.Clear();
                            Stack.Items.Clear();
                            NewLine.Text = TransformText;
                            Output.Text = "";
                            return;
                        }
                        else
                            Stack.Items.Insert(0, i.ToString());
                    }
                    else if (c == 'K')
                    {
                        double i = 1 / Math.Tan(a);
                        if (i == double.PositiveInfinity | i == double.NegativeInfinity) //обработка критических точек котангенса
                        {
                            MessageBox.Show("В данной точке котангенса не существует. Введите другие значения переменных");
                            Values.Clear();
                            Stack.Items.Clear();
                            NewLine.Text = TransformText;
                            Output.Text = "";
                            return;
                        }
                        else
                            Stack.Items.Insert(0, i.ToString());
                    }

                    NewLine.Text = NewLine.Text.Remove(0, 1);
                }
            }
            //если входная строка пуста - возвращаем значение из стека в ответ
            else
            {
                Output.Text = Stack.Items[0].ToString();
                Stack.Items.RemoveAt(0);
                if (Stack.Items.Count != 0) //проверка наполненности стека
                {
                    MessageBox.Show("В стеке что-то осталось! А это значит в выражении допущена ошибка." +
                        "Введите другое выражение", "Упс!");
                    Close();
                }
                else
                {
                    isCalculated = true;
                    MessageBox.Show("Вычисление закончено успешно");
                }

            }
        }

    }
}
