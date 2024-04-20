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
using System.Windows.Shapes;

namespace sesion_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Grid grid = new Grid();
            ////Asignamos la grilla a la ventana actual.
            //this.Content = grid;
            //Button btn = new Button();
            //btn.FontSize = 26;
            //btn.Width = 150;
            //btn.Height = 50;

            //WrapPanel wrapPanel = new WrapPanel();
            //TextBlock textBlock = new TextBlock();
            //textBlock.Text = "Boton";
            //textBlock.Foreground = Brushes.Blue;

            //wrapPanel.Children.Add(textBlock);

            //btn.Content = wrapPanel;
            //grid.Children.Add(btn);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show("Has presionado el boton " + button.Name);
        }

        private void Button_ClickInterno(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has dado clic en el interno");
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Has dado clic sobre el boton externo");
        }

        private void Button_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Has dado clic sobre el boton interno");
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Has dado clic sobre la ventana");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Externo");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Interno");
        }


    }
}