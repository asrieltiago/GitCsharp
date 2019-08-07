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

namespace WPFCalculator.Views
{
    /// <summary>
    /// Interaction logic for ucCalculadora.xaml
    /// </summary>
    public partial class ucCalculadora : UserControl
    {
        public ucCalculadora()
        {
            InitializeComponent();
        }

        

        private void BtnAdicao_Click(object sender, RoutedEventArgs e)
        {          
            double valueOne = Convert.ToDouble(tbxValueOne.Text);
            double valueTwo = Convert.ToDouble(tbxValueTwo.Text);
            double resultado = valueOne + valueTwo;
            tbxResultado.Text = valueOne.ToString() + " + " + valueTwo.ToString() + " = " + resultado.ToString();
        }

        private void BtnSubtracao_Click(object sender, RoutedEventArgs e)
        {
            double valueOne = Convert.ToDouble(tbxValueOne.Text);
            double valueTwo = Convert.ToDouble(tbxValueTwo.Text);
            double resultado = valueOne - valueTwo;
            tbxResultado.Text = valueOne.ToString() + " - " + valueTwo.ToString() + " = " + resultado.ToString();
        }

        private void BtnMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            double valueOne = Convert.ToDouble(tbxValueOne.Text);
            double valueTwo = Convert.ToDouble(tbxValueTwo.Text);
            double resultado = valueOne * valueTwo;
            tbxResultado.Text = valueOne.ToString() + " x " + valueTwo.ToString() + " = " + resultado.ToString();
        }

        private void BtnDivisao_Click(object sender, RoutedEventArgs e)
        {
            double valueOne = Convert.ToDouble(tbxValueOne.Text);
            double valueTwo = Convert.ToDouble(tbxValueTwo.Text);
            double resultado = valueOne / valueTwo;
            tbxResultado.Text = valueOne.ToString() + " / " + valueTwo.ToString() + " = " + resultado.ToString();
        }

        private void TbxResultado_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, RoutedEventArgs e)
        {
            tbxResultado.Text = "";
        }
    }
}
