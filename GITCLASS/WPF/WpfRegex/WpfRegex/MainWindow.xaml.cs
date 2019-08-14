using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using WpfRegex.Controller;

namespace WpfRegex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {                        
            string email = tbxEmail.Text;
            string telefone = tbxTelefone.Text;

            if (ValidatesCustom.ValidPhone(telefone))
            {
                MessageBox.Show($"{tbxNome.Text.ToUpper()}! O telefone {telefone} é VÁLIDO.", "Informação", MessageBoxButton.OK, MessageBoxImage.Information);
                resTelefone.Text = "True";
            }

            else
            {
                MessageBox.Show($"ATENÇÃO {tbxNome.Text.ToUpper()}, o telefone {tbxTelefone.Text} é INVÁLIDO.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                resTelefone.Text = "False";
            }

            if (ValidatesCustom.ValidEmail(email))
            {
                MessageBox.Show($"{tbxNome.Text.ToUpper()}! O email {email} é VÁLIDO.", "Informação", MessageBoxButton.OK, MessageBoxImage.Information);
                resEmail.Text = "True";
            }

            else
            {
                MessageBox.Show($"ATENÇÃO {tbxNome.Text.ToUpper()}, o email {tbxEmail.Text} é INVÁLIDO.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                resEmail.Text = "False";
            }
        }

    }
}
