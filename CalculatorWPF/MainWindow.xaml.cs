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
using Calculator;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculatorUnderTest calc = new CalculatorUnderTest();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {          
            MessageBox.Show(OperationComboBox.Text);

            string selectedItem = OperationComboBox.Text;
            double value1 = Double.Parse(val1TextBox.Text);
            double value2 = Double.Parse(val2TextBox.Text);
            double result = 0;          

            switch (selectedItem)
            {
                case "Add":
                    result = calc.Add(value1, value2);
                    MessageBox.Show(result.ToString());                  
                    break;
                case "Subtract":
                    result = calc.Subtract(value1, value2);
                    MessageBox.Show(result.ToString());
                    break;
                case "Multiply":
                    result = calc.Multiply(value1, value2);
                    MessageBox.Show(result.ToString());
                    break;
                case "Divide":
                    result = calc.Divide(value1, value2);
                    MessageBox.Show(result.ToString());
                    break;
                default:
                    MessageBox.Show("Invalid");
                    break;
            }
        }
    }
}
