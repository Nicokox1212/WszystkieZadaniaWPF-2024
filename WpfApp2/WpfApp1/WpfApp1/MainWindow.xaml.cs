using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        private string generatedPassword = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void GeneratePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            int passwordLength;
            if (!int.TryParse(PasswordLengthBox.Text, out passwordLength) || passwordLength < 1)
            {
                MessageBox.Show("Proszę wprowadzić prawidłową liczbę znaków.");
                return;
            }

            generatedPassword = GeneratePassword(passwordLength, IncludeUpperLower.IsChecked == true, IncludeDigits.IsChecked == true, IncludeSpecialChars.IsChecked == true);
            MessageBox.Show($"Wygenerowane hasło: {generatedPassword}");
        }

        private string GeneratePassword(int length, bool includeUpperLower, bool includeDigits, bool includeSpecialChars)
        {
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const string specialChars = "!@#$%^&*()_+-=";

            StringBuilder charSet = new StringBuilder(lowerChars);
            if (includeUpperLower) charSet.Append(upperChars);
            if (includeDigits) charSet.Append(digits);
            if (includeSpecialChars) charSet.Append(specialChars);

            Random random = new Random();
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(charSet.Length);
                password.Append(charSet[index]);
            }

            return password.ToString();
        }

    
        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameBox.Text;
            string lastName = LastNameBox.Text;
            string position = (PositionBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Proszę wprowadzić wszystkie dane pracownika.");
                return;
            }

            MessageBox.Show($"Dane pracownika:\nImię: {firstName}\nNazwisko: {lastName}\nStanowisko: {position}\nHasło: {generatedPassword}");
        }
    }
}