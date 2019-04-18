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

namespace Game1
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
        int counter = 0;
        int score = 0;
        int checker = 0;
        private void enter(object sender, MouseEventArgs e)
        {
            private void again()
            {

            

            
            if(counter==0)
            {
                colours.Background = Brushes.Red;
            }
            else if(counter==1)
            {
                colours.Background = Brushes.Yellow;
            }
            else if(counter==2)
            {
                colours.Background = Brushes.Pink;
            }
            else if (counter == 3)
            {
                colours.Background = Brushes.Green;
            }
            else if (counter == 4)
            {
                colours.Background = Brushes.Brown;
            }
            else if (counter == 5)
            {
                colours.Background = Brushes.Blue;
            }

        
    }
    }  
        private void leave(object sender, MouseEventArgs e)
        {
            counter++;
            
        }

        private void Red(object sender, RoutedEventArgs e)
        {
            if (colours.Background == Brushes.Red)
            {
                score++;
                scoreBox.Text = score.ToString();
                checker ++;
            }
            else if (colours.Background != Brushes.Red)
            {
                score--;
                scoreBox.Text = score.ToString();
            }
            
               
            



                
        }

        private void Blue(object sender, RoutedEventArgs e)
        {
             if (colours.Background==Brushes.Blue)
            {
                score++;
                scoreBox.Text = score.ToString();
            }
             else if (colours.Background != Brushes.Blue)
             {
                 score--;
                 scoreBox.Text = score.ToString();
             }
        }

        private void Green(object sender, RoutedEventArgs e)
        {
             if (colours.Background==Brushes.Green)
            {
                score++;
                scoreBox.Text = score.ToString();
            }
             else if (colours.Background != Brushes.Green)
             {
                 score--;
                 scoreBox.Text = score.ToString();
             }
        }

        private void Yellow(object sender, RoutedEventArgs e)
        {
            if (colours.Background == Brushes.Yellow)
            {
                score++;
                scoreBox.Text = score.ToString();
            }
            else if (colours.Background != Brushes.Yellow)
            {
                score--;
                scoreBox.Text = score.ToString();
            }
            
        }

        private void Brown(object sender, RoutedEventArgs e)
        {
             if (colours.Background==Brushes.Brown)
            {
                score++;
                scoreBox.Text = score.ToString();
            }
             else if (colours.Background != Brushes.Brown)
             {
                 score--;
                 scoreBox.Text = score.ToString();
             }

        }

        private void Pink(object sender, RoutedEventArgs e)
        {
            if (colours.Background==Brushes.Pink)
            {
                score++;
                scoreBox.Text = score.ToString();
            }
            else if(colours.Background!=Brushes.Pink)

            {
                score--;
                scoreBox.Text = score.ToString();
            }
        }

        private void clear(object sender, RoutedEventArgs e)
        {
            scoreBox.Clear();
            score = 0;
        }

        private void repeat(object sender, RoutedEventArgs e)
        {
            if (counter==6)
                {
    again();
}

            
        }
    }
}
