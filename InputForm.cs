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
    public partial class InputForm : Form
    {
        //список введённых элементов
        List<String> Elements = new List<string>();

        //счётчик введённых в качестве переменных букв алфавита
        int c = 0;

        //массив букв алфавита, используемых в качестве переменных
        char[] alph = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public InputForm()
        {
            InitializeComponent();
            SetEnableButtons(true, true, false, true, true, true);
        }

        //обработчики нажатия на кнопки - подписаны соответственно кнопке
        private void Open_Bkt_Button_Click(object sender, EventArgs e)
        {
            Elements.Add("(");
            Editable_Line.Text += "(";
            SetEnableButtons(true, true, false, true, true, false);
        }

        private void Close_Bkt_Button_Click(object sender, EventArgs e)
        {
            Elements.Add(")");
            Editable_Line.Text += ")";
            SetEnableButtons(true, true, true, false, false, true);
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                //удаляем последний введённый элемент выражения
                Elements.RemoveAt(Elements.Count - 1);
                //приравниваем строку к списку элементов
                Editable_Line.Text = String.Join("", Elements);
                //алгоритм настройки доступности кнопок, в зависимости от последнего элемента,
                //оставшегося после удаления
                if (Elements.Last().Length == 1) //если последний элемент содержит один символ - a, b и тд
                {
                    switch (Editable_Line.Text.Last())
                    {
                        case '(':
                            SetEnableButtons(true, true, false, true, true, false);
                            break;
                        case ')':
                            SetEnableButtons(true, true, true, false, false, true);
                            break;
                        default:
                            if (Char.IsLetter(Editable_Line.Text.Last())) //если последний символ - переменная
                                SetEnableButtons(false, true, true, false, false, true);
                            else //если последний символ - операция
                                SetEnableButtons(true, false, false, true, true, false);
                            break;
                    }
                }
                else //если последний элемент содержит больше одного символа - sin, cos и тд
                    SetEnableButtons(true, false, false, false, false, false);
            }
            catch
            {
                SetEnableButtons(true, true, false, true, true, true);
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Elements.Clear();
            Editable_Line.Text = "";
            SetEnableButtons(true, true, false, true, true, true);
        }

        private void Plus_Button_Click(object sender, EventArgs e)
        {
            Elements.Add("+");
            Editable_Line.Text += "+";
            SetEnableButtons(true, false, false, true, true, false);
        }

        private void Minus_Button_Click(object sender, EventArgs e)
        {
            Elements.Add("-");
            Editable_Line.Text += "-";
            SetEnableButtons(true, false, false, true, true, false);
        }

        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            Elements.Add("*");
            Editable_Line.Text += "*";
            SetEnableButtons(true, false, false, true, true, false);
        }

        private void Division_Button_Click(object sender, EventArgs e)
        {
            Elements.Add("/");
            Editable_Line.Text += "/";
            SetEnableButtons(true, false, false, true, true, false);
        }

        private void Sin_Button_Click(object sender, EventArgs e)
        {
            Elements.Add("sin");
            Editable_Line.Text += "sin";
            SetEnableButtons(true, false, false, false, false, false);
        }

        private void Cos_Button_Click(object sender, EventArgs e)
        {
            Elements.Add("cos");
            Editable_Line.Text += "cos";
            SetEnableButtons(true, false, false, false, false, false);
        }

        private void Tg_Button_Click(object sender, EventArgs e)
        {
            Elements.Add("tg");
            Editable_Line.Text += "tg";
            SetEnableButtons(true, false, false, false, false, false);
        }

        private void Ctg_Button_Click(object sender, EventArgs e)
        {
            Elements.Add("ctg");
            Editable_Line.Text += "ctg";
            SetEnableButtons(true, false, false, false, false, false);
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            int o = Editable_Line.Text.Length - Editable_Line.Text.Replace("(", "").Length;
            int c = Editable_Line.Text.Length - Editable_Line.Text.Replace(")", "").Length;
            if (o != c)
                MessageBox.Show("Количество открывающих и закрывающих скобок не сходится - проверьте скобочную стрктуру выражения!", 
                    "Внимание!");
            else
            {
                Close();
            }
        }

        private void NewChar_Button_Click(object sender, EventArgs e)
        {
            //добавление к строке новой буквы в качестве переменной
            Elements.Add(alph[c].ToString());
            Editable_Line.Text += alph[c];

            //увеличение счётчика введённых букв (в случае, если алфавит кончился - обнуление)
            switch (c)
            {
                case 25:
                    c = 0;
                    break;
                default:
                    c++;
                    break;
            }
            SetEnableButtons(false, true, true, false, false, true);
        }

        //получение строки из формы
        public String GetInput()
        {
            return Editable_Line.Text;
        }

        //данный метод задаёт значения доступности для различных кнопок ввода, с целью запретить 
        //пользователю вводить некорректные данные
        private void SetEnableButtons(bool OpenBkt, bool CloseBkt, bool Operation, bool Function, bool Char, bool Calculate)
        {
            Open_Bkt_Button.Enabled = OpenBkt;
            Close_Bkt_Button.Enabled = CloseBkt;
            Plus_Button.Enabled = Operation;
            Minus_Button.Enabled = Operation;
            Multiply_Button.Enabled = Operation;
            Division_Button.Enabled = Operation;
            Sin_Button.Enabled = Function;
            Cos_Button.Enabled = Function;
            Tg_Button.Enabled = Function;
            Ctg_Button.Enabled = Function;
            NewChar_Button.Enabled = Char;
            Exit.Enabled = Calculate;
        }

    }
}
