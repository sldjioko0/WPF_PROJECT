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

namespace WiredBrainCoffee.CustomersApp
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

        private void BtnMoveClick(object sender, RoutedEventArgs e)
        {
            //var column = (int)btnGridMove.GetValue(Grid.ColumnProperty);
            //column = column == 0 ? 2 : 0;

            //btnGridMove.SetValue(Grid.ColumnProperty, column);

            var column = Grid.GetColumn(btnGridMove);
            column = column == 0 ? 2 : 0;

            Grid.SetColumn(btnGridMove, column);
        }
    }
}
