using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Programming_Classwork_4
{
    public partial class Task8 : Form
    {
        private int _vowels = 0;
        private int _consonants = 0;
        private int _symbols = 0;

        private const string vowels = "aeiouAEIOU";
        private const string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
        private const string symbols = "!\\\"#$%&'()*+,-./:;<=>?@[\\\\]^_`{|}~";


        public Task8()
        {
            InitializeComponent();
        }

        private async void countBtn_Click(object sender, EventArgs e)
        {
            char[] chars = textTB.Text.ToCharArray();

            if (chars.Length == 0) return;

            ClearTBs();

            vowelsTB.Text = "";
            consonantsTB.Text = "";
            symbolsTB.Text = "";

            CalculateChars(chars);

            vowelsTB.Text = _vowels.ToString();
            consonantsTB.Text = _consonants.ToString();
            symbolsTB.Text = _symbols.ToString();
        }

        private async void CalculateChars(char[] chars)
        {
            await Task.Run(() =>
            {
                foreach (char c in chars)
                {
                    if (vowels.Contains(c.ToString())) _vowels++;
                    else if (consonants.Contains(c.ToString())) _consonants++;
                    else if (symbols.Contains(c.ToString())) _symbols++;
                }
            });
        }

        private async void ClearTBs()
        {
            await Task.Run(() =>
            {
                _vowels = 0;
                _consonants = 0;
                _symbols = 0;
            });
        }
    }
}
