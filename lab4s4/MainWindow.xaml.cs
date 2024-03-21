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

namespace lab4s4
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

        public void LowerEverySecond(object sender, RoutedEventArgs e) {
            changeCharsResult.Content = changeCharsInput.Text.EverySecondCharLowercase();
        }

        public void UpperEverySecond(object sender, RoutedEventArgs e)
        {
            changeCharsResult.Content = changeCharsInput.Text.EverySecondCharUppercase();


        }

        public void RemoveVowels(object sender, RoutedEventArgs args) {
            removeCharsResult.Content = deleteCharsInput.Text.DeleteVowels();

        }

        public void CountWords(object sender, RoutedEventArgs args) {
            string wordsLength = "[ ";
            int[] arrayOfLengths = countWordsInput.Text.WordsLength();
            foreach (int i in arrayOfLengths) {
                wordsLength += i + ", ";
            }
            wordsLength = wordsLength.Substring(0, wordsLength.Length - 2);

            wordsLength += " ]";

            countWordsResult.Content = wordsLength;

        }

        public void IsSentence(object sender, RoutedEventArgs args) {
            isSentenceResult.Content = sentenceInput.Text.IsSentence().ToString();
        }

        public void FindMostCommonElement(object sender, RoutedEventArgs args) {
            try
            {
                mostCommonResult.Content = mostCommonInput.Text.MostCommonElement<char>().ToString();

            }
            catch { }

        }
    }
}
