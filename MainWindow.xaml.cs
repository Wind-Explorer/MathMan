using System.Windows;


namespace MathMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double displayedAnswer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EvaluateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (SymbolComboBox.SelectedIndex)
                {
                    case 0: displayedAnswer = double.Parse(Number1.Text) + double.Parse(Number2.Text); break;
                    case 1: displayedAnswer = double.Parse(Number1.Text) - double.Parse(Number2.Text); break;
                    case 2: displayedAnswer = double.Parse(Number1.Text) * double.Parse(Number2.Text); break;
                    case 3: displayedAnswer = double.Parse(Number1.Text) / double.Parse(Number2.Text); break;
                }
                Answer.Text = displayedAnswer.ToString();
            } catch {
                Answer.Text = "Invalid values!";
            }
            
        }
    }
}
