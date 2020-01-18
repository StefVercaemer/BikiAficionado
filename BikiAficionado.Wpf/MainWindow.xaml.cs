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
using Fietsen.Lib.Entities;

namespace BikiAficionado.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FietsWinkel> winkels;
        FietsWinkel huidigeFietsWinkel;

        public MainWindow()
        {
            InitializeComponent();
            winkels = new List<FietsWinkel>
            {
                new FietsWinkel("Het velootje")
            };
            huidigeFietsWinkel = winkels[0];
        }

    }
}
