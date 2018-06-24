using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary1;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator Calc;

        public MainWindow()
        {
            InitializeComponent();
            Calc = new Calculator();
            IFormula.Content = "";
            IScreen.Content = "0";
            Calc.rangeMin = -200000;
            Calc.rangeMax = 400000;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Calc.SendKey(Convert.ToString((sender as Button).Content));
                IScreen.Content = Calc.screenString;
                IFormula.Content = Calc.Formula;
            }
        }

        private void Window_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            bool GoodKey = false;

            GoodKey = GoodKey || char.IsDigit(e.Text, 0);
            GoodKey = GoodKey || e.Text[0] == 8;  // BackSpace
            GoodKey = GoodKey || e.Text[0] == 13; // Enter
            GoodKey = GoodKey || e.Text[0] == 27; // Escape
            GoodKey = GoodKey || e.Text[0] == ',';
            GoodKey = GoodKey || e.Text[0] == '+';
            GoodKey = GoodKey || e.Text[0] == '-';
            GoodKey = GoodKey || e.Text[0] == '*';
            GoodKey = GoodKey || e.Text[0] == '/';

            if (!GoodKey) e.Handled = true;

            ////////////////////////////////////////////////////////
            if (e.Text[0] == '1') btn_Click(btnOne, null);
            if (e.Text[0] == '2') btn_Click(btnTwo, null);
            if (e.Text[0] == '3') btn_Click(btnThree, null);
            if (e.Text[0] == '4') btn_Click(btnFour, null);
            if (e.Text[0] == '5') btn_Click(btnFive, null);
            if (e.Text[0] == '6') btn_Click(btnSix, null);
            if (e.Text[0] == '7') btn_Click(btnSeven, null);
            if (e.Text[0] == '8') btn_Click(btnEight, null);
            if (e.Text[0] == '9') btn_Click(btnNine, null);
            if (e.Text[0] == '0') btn_Click(btnZero, null); 
            if (e.Text[0] == ',') btn_Click(btnComma, null);
            if (e.Text[0] == 'c') btn_Click(btnC, null);
            if (e.Text[0] == 'f') btn_Click(btnFactorial, null);
            if (e.Text[0] == 's') btn_Click(btnSinus, null);
            if (e.Text[0] == 'q') btn_Click(btnSqrt, null);
            if (e.Text[0] == 'i') btn_Click(btnSigned, null);
            if (e.Text[0] == '+') btn_Click(btnAdd, null);
            if (e.Text[0] == '-') btn_Click(btnSub, null);
            if (e.Text[0] == '*') btn_Click(btnMul, null);
            if (e.Text[0] == '/') btn_Click(btnDiv, null);
            if (e.Text[0] == 27) btn_Click(btnCE, null);
            if (e.Text[0] == 8) btn_Click(btnBack, null);
            if (e.Text[0] == 13) btn_Click(btnEqual, null);
        }

        private void Window_TextInput(object sender, TextCompositionEventArgs e)
        {
            IScreen.Content += e.Text;
        }
    }
}
