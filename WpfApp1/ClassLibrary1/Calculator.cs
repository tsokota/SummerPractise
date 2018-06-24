using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xaml;
using System.Messaging;


namespace ClassLibrary1
{
    // Состояния калькулятора
    enum dsCalcState : byte
    {
        InputArgument = 1, // ввод аргумента 
        InputCmdBinary,    // нажатие бинарной операции
        InputCmdUnary      // нажатие унарной операции
    }

    // доступные команды в калькуляторе
    enum dsCalcCmd : byte
    {
        None,               // команда не задана
        Add,                // команда сложения
        Sub,                // команда вычитания
        Mul,                // команда умножения
        Div,                // команда деление
        Factorial,          // вычисление факториала
        Sqrt,               // вычисление корня квадратного
        Sin                 // вычисление синуса
    }

    public interface ICalculator
    {
        void SendKey(string value);
        string Formula { get; }
        
    }
    public class Calculator : ICalculator
    {
        public string screenString;             // строковое значение нижней метки
        public double screenValue;             // числовое значение нижней метки
        private string formulaString;           // строковое значение верхней метки
        private double formulaValue;            // числовое значение верхней метки
        private string formulaLastString;        // последнее введенное значение
        private bool screenClear;                // флаг необходимости очистки экрана
        private dsCalcCmd lastCmd;               // переменная отвечающая за команду калькулятора
        private dsCalcState calcState;           // режим работы калькулятора
        public double rangeMin;                  // максимально доступное число для ввода
        public double rangeMax;                  // минимальное допустимое число для ввода

        // Конструктор : инициализирует параметры начальными значениями
        public Calculator()
        {
            screenString = "0";
            screenValue = 0;
            formulaString = "";
            formulaValue = 0;
            formulaLastString = "";
            lastCmd = 0;
            screenClear = false;
            calcState = dsCalcState.InputArgument;
            rangeMin = Double.MinValue;
            rangeMax = Double.MaxValue;
        }

        public string Formula
        {
            get
            {
                string tmpStr;
                tmpStr = formulaString;
                if (lastCmd == dsCalcCmd.None) tmpStr += " ";
                else if (lastCmd == dsCalcCmd.Add) tmpStr += " + ";
                else if (lastCmd == dsCalcCmd.Sub) tmpStr += " - ";
                else if (lastCmd == dsCalcCmd.Mul) tmpStr += " * ";
                else if (lastCmd == dsCalcCmd.Div) tmpStr += " / ";
                tmpStr += formulaLastString;

                return tmpStr;
            }
        }
        // метод проверяющий корректность введенных чисел в калькуляторе
        public bool RangeCheck(double value)
        {
            // проверка правильности введенных чисел
            bool result = (value >= rangeMin && value <= rangeMax);
            if (!result)
            {
                formulaString = "Выход за допустимый диапазон!!";
            }
            return result;
        }

        // Метод , отвечающий за ввод первого числа и его форматирование
        public void InputArgument(string value)
        {
            calcState = dsCalcState.InputArgument;
            if (screenClear)
            {
                screenString = "";
                screenValue = 0;
                screenClear = false;
            }

            string tmpStr = screenString + value;
            if (RangeCheck(Convert.ToDouble(tmpStr)))
            {
                screenValue = Convert.ToDouble(tmpStr);
                screenString = screenValue.ToString("#,0.###"); ;
            }
        }

        // метод , отвечающий за смену знака введенного числа
        public void InputSigned()
        {
            screenClear = false;

            double tmpDouble = screenValue * (-1);
            if (RangeCheck(tmpDouble))
            {
                screenString = tmpDouble.ToString("#,0.###");
                screenValue = tmpDouble;
            }
        }

        // метод , отвечающий за ввод запятой (не работает в данном варианте)
        private void InputComma()
        {
            if (screenClear)
            {
                screenString = "";
                screenValue = 0;
                screenClear = false;
            }

            if (screenString.IndexOf(",") >= 0)
            {
                return;
            }
            screenString += ",";
        }

        // метод , отвечающий за работоспособность кнопки BackSpace
        private void InputBackspace()
        {
            if (screenString.Length == 1)
            {
                screenString = "0";
                screenValue = 0;
            }
            else if (screenString.Length > 1)
            {
                string tmpStr = screenString.Substring(0, screenString.Length - 1);
                if(tmpStr == "+" || tmpStr == "-")
                {
                    tmpStr = "0";
                }
                screenValue = Convert.ToDouble(tmpStr);
                screenString = screenValue.ToString("#,0.###");
            }
        }

        // метод , отвечающий за работоспособность кнопки CE
        private void InputBtnCE()
        {
            calcState = dsCalcState.InputArgument;
            screenString = "0";
            screenValue = 0;
            formulaLastString = "";
        }

        // метод , отвечающий за работоспособность кнопки C
        private void InputBtnC()
        {
            calcState = dsCalcState.InputArgument;
            screenString = "0";
            screenValue = 0;
            formulaString = "";
            formulaValue = 0;
            formulaLastString = "";
            lastCmd = dsCalcCmd.None;
        }

        // метод - нахождение факториала числа
        public ulong Factorial(ulong value)
        {
            ulong fact = 1;
            if (value > 20)
            {
                formulaString = "Выход за допустимый диапазон!!";
                return 0;
            }
            else
            {
                for (ulong i = 1; i <= value; i++) fact *= i;
                return fact;
            }
           
        }

        // метод обрабающий нажатие бинарной операции
        private void InputCmdBinary(dsCalcCmd value)
        {
            if (calcState == dsCalcState.InputArgument)
            {
                calcState = dsCalcState.InputCmdBinary;
                screenClear = true;

                if (lastCmd == dsCalcCmd.None)
                {
                    formulaValue = screenValue;
                    formulaString = formulaValue.ToString();
                }
                else if (lastCmd == dsCalcCmd.Add)
                {
                    formulaValue += screenValue;
                    formulaString += " + ";
                    formulaString += screenValue.ToString();
                }
                if (lastCmd == dsCalcCmd.Sub)
                {
                    formulaValue -= screenValue;
                    formulaString += " - ";
                    formulaString += screenValue.ToString();
                }
                if (lastCmd == dsCalcCmd.Mul)
                {
                    formulaValue *= screenValue;
                    formulaString += " * ";
                    formulaString += screenValue.ToString();
                }
                if (lastCmd == dsCalcCmd.Div)
                {
                    formulaValue /= screenValue;
                    formulaString += " / ";
                    formulaString += screenValue.ToString();
                }

                screenValue = formulaValue;
                screenString = screenValue.ToString("#,0.###");
            }

            lastCmd = value;
        }

        // метод , обрабатующий нажатие унарной операции
        private void InputCmdUnary(dsCalcCmd value)
        {
            calcState = dsCalcState.InputCmdUnary;

            if (value == dsCalcCmd.Sqrt)
            {
                if (formulaLastString.Length == 0) formulaLastString = "sqrt(" + screenString + ")";
                else formulaLastString = "sqrt(" + formulaLastString + ")";
                screenValue = Math.Sqrt(screenValue);
            }
            else if (value == dsCalcCmd.Sin)
            {
                if (formulaLastString.Length == 0) formulaLastString = "sin(" + screenString + ")";
                else formulaLastString = "sin(" + formulaLastString + ")";
                screenValue = Math.Sin(screenValue);
            }
            else if (value == dsCalcCmd.Factorial)
            {
                if (screenValue < 0)
                {
                    formulaString ="Введено не корректное число!!";
                    screenString = "0";
                    return;
                }

                if (screenValue - Math.Truncate(screenValue) != 0)
                {
                    formulaString = "Введено не корректное число!!";
                    screenString = "0";
                    return;
                }

                if (formulaLastString.Length == 0) formulaLastString = "fact(" + screenString + ")";
                else formulaLastString = "fact(" + formulaLastString + ")";
                screenValue = Factorial((ulong)screenValue);

            }

            if (screenValue > 9999999999)
                screenString = screenValue.ToString("E");
            else
                screenString = screenValue.ToString("#,0.###");
        }

        // метод , отвечающий за работоспособность кнопки равно
        private void InputEnter()
        {
            if (lastCmd == dsCalcCmd.None)
            {
                formulaValue = screenValue;
                formulaString = formulaValue.ToString();
            }
            else if (lastCmd == dsCalcCmd.Add)
            {
                formulaValue += screenValue;
                formulaString += " + ";
                formulaString += screenValue.ToString();
            }
            if (lastCmd == dsCalcCmd.Sub)
            {
                formulaValue -= screenValue;
                formulaString += " - ";
                formulaString += screenValue.ToString();
            }
            if (lastCmd == dsCalcCmd.Mul)
            {
                formulaValue *= screenValue;
                formulaString += " * ";
                formulaString += screenValue.ToString();
            }
            if (lastCmd == dsCalcCmd.Div)
            {
                formulaValue /= screenValue;
                formulaString += " / ";
                formulaString += screenValue.ToString();
            }

            screenValue = formulaValue;
            screenString = screenValue.ToString("#,0.###");

            calcState = dsCalcState.InputArgument;

            formulaString = "";
            formulaValue = 0;

            formulaLastString = "";

            lastCmd = dsCalcCmd.None;
            screenClear = true;
        }

        // обработка нажатия клавиш
        public void SendKey(string value)
        {
            if (value == "0" ||
                value == "1" ||
                value == "2" ||
                value == "3" ||
                value == "4" ||
                value == "5" ||
                value == "6" ||
                value == "7" ||
                value == "8" ||
                value == "9" ) InputArgument(value);

            else if (value == "-/+") InputSigned();
            else if (value == ",") InputComma();
            else if (value == "←") InputBackspace();
            else if (value == "CE") InputBtnCE();
            else if (value == "C") InputBtnC();

            else if (value == "√") InputCmdUnary(dsCalcCmd.Sqrt);
            else if (value == "Sin") InputCmdUnary(dsCalcCmd.Sin);
            else if (value == "!") InputCmdUnary(dsCalcCmd.Factorial);

            else if (value == "+") InputCmdBinary(dsCalcCmd.Add);
            else if (value == "-") InputCmdBinary(dsCalcCmd.Sub);
            else if (value == "*") InputCmdBinary(dsCalcCmd.Mul);
            else if (value == "/") InputCmdBinary(dsCalcCmd.Div);

            else if (value == "=") InputEnter();
        }
    }
}
