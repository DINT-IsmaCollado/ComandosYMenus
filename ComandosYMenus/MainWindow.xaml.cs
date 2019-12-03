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

namespace ComandosYMenus
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> listaTextos;

        public MainWindow()
        {
            listaTextos = new List<string>();

            InitializeComponent();

            ListaItemsListBox.DataContext = listaTextos;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string etiqueta = "Item añadido a las " + HoraTextBlock.Text;
            listaTextos.Add(etiqueta);
            ListaItemsListBox.Items.Add(listaTextos.Last());
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
                if (listaTextos.Count < 10)
                    e.CanExecute = true;
                else
                    e.CanExecute = false;
           
        }

        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void DeleteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ListaItemsListBox.Items.Clear();
            listaTextos.Clear();
        }

        private void DeleteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (listaTextos.Count > 0)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }
    }
}
