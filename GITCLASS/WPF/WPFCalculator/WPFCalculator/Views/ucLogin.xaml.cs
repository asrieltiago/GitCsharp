﻿using System;
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
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        public event EventHandler loginSuccess;

        private void TbxEntrar_Click(object sender, RoutedEventArgs e)
        {
            Teste(tbxLogin.Text, tbxSenha.Text);
        }

        public void Teste(string login, string senha)
        {
            if (login == "admin" && senha == "admin")
            {
                this.Visibility = Visibility.Hidden;
                loginSuccess(null, new EventArgs());
            }
            else
                MessageBox.Show("Deu pau");
        }
    }
}
