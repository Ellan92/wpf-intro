using System.Windows;

namespace WPFIntro
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // läs inputrutorna
            string inputName = txtName.Text;
            string inputEmail = txtEmail.Text;

            // Skapa en interpolerad sträng med all information
            string personString = $"{inputName} - Email: {inputEmail}";

            // Lägg till den interpolerade strängen i listan
            lstPeople.Items.Add(personString);

            // Rensa inputrutorna
            txtName.Text = "";
            txtEmail.Clear();
        }
    }
}
