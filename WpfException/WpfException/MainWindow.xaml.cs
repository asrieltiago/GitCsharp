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
using WpfException.Data;

namespace WpfException
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

        public BibliotecaDBContext context;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context = new BibliotecaDBContext();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*foreach (var item in context.Livros)
            {
                MessageBox.Show(item.Titulo);
            }*/
            MessageBox.Show(context.Livros.OrderBy(x => x.Titulo).FirstOrDefault(x => x.Id > 0).Titulo);

            var runList = context.Livros.
                OrderBy(x => x.Titulo).ToList<Livro>();

            gridView1.ItemsSource = runList;
               
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
