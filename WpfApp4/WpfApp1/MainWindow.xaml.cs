using System;
using System.IO;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private string fileContent;

       
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
           
            string filePath = "Lorem.txt";

            try
            {
                
                fileContent = File.ReadAllText(filePath);

               
                inputTextBox.Text = fileContent;
                inputTextBox_Kopiuj.Text = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas otwierania pliku: " + ex.Message);
            }
        }

        
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            
            string outputPath = "Output.txt";

            try
            {
                
                File.WriteAllText(outputPath, inputTextBox_Kopiuj1.Text);
                MessageBox.Show("Plik został zapisany.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisywania pliku: " + ex.Message);
            }
        }

        
        private void ReplaceButton_Click(object sender, RoutedEventArgs e)
        {
            
            string searchText = inputTextBox_Kopiuj2.Text;
            string replaceText = inputTextBox_Kopiuj1.Text;

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Proszę podać ciąg do wyszukania.");
                return;
            }

           
            fileContent = fileContent.Replace(searchText, replaceText);

            
            inputTextBox_Kopiuj.Text = fileContent;
            inputTextBox_Kopiuj1.Text = fileContent;
        }
    }
}
