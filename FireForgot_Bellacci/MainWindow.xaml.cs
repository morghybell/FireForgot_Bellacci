using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using LibraryTasks;
//ricordati di aggiungere quest'ultima using

namespace FireForgot_Bellacci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CancellationTokenSource cts;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            cts = new CancellationTokenSource();
            Worker wrk = new Worker(10, 1000, cts);
            wrk.Start();
            MessageBox.Show("Mi dimentico del thread secondario e visualizzo subito questo messaggio senza attendere che l'altro abbia finito", "Informazioni", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Btn_Stop_Click(object sender, RoutedEventArgs e)
        {
            if (cts != null) 
            {
                cts.Cancel();
            }
        }
    }
}
