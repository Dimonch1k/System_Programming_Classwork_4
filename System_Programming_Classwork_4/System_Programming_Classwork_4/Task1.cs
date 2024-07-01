using System;
using System.Threading;
using System.Windows.Forms;

namespace System_Programming_Classwork_4
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Додати пріоритети у ComboBox
            foreach (var priority in Enum.GetValues(typeof(ThreadPriority)))
            {
                comboBoxNumberPriority.Items.Add(priority);
                comboBoxLetterPriority.Items.Add(priority);
                comboBoxSymbolPriority.Items.Add(priority);
            }

            comboBoxNumberPriority.SelectedIndex = 2; // Normal
            comboBoxLetterPriority.SelectedIndex = 2; // Normal
            comboBoxSymbolPriority.SelectedIndex = 2; // Normal
        }

        private void buttonStartNumbers_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(GenerateNumbers);
            thread.Priority = (ThreadPriority)comboBoxNumberPriority.SelectedItem;
            thread.Start();
        }

        private void buttonStartLetters_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(GenerateLetters);
            thread.Priority = (ThreadPriority)comboBoxLetterPriority.SelectedItem;
            thread.Start();
        }

        private void buttonStartSymbols_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(GenerateSymbols);
            thread.Priority = (ThreadPriority)comboBoxSymbolPriority.SelectedItem;
            thread.Start();
        }

        private void GenerateNumbers()
        {
            Random random = new Random();
            UpdateListBox(listBoxNumbers, DateTime.Now.ToString());
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(500);
                int number = random.Next(0, 100);
                UpdateListBox(listBoxNumbers, number.ToString());
            }
            UpdateListBox(listBoxNumbers, DateTime.Now.ToString());
        }

        private void GenerateLetters()
        {
            Random random = new Random();
            UpdateListBox(listBoxLetters, DateTime.Now.ToString());
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(500);
                char letter = (char)random.Next('A', 'Z' + 1);
                UpdateListBox(listBoxLetters, letter.ToString());
            }
            UpdateListBox(listBoxLetters, DateTime.Now.ToString());
        }

        private void GenerateSymbols()
        {
            string symbols = "!@#$%^&*()_-+={}[]:;\"'<>?,./\\|`~";
            Random random = new Random();
            UpdateListBox(listBoxSymbols, DateTime.Now.ToString());
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(500);
                char symbol = symbols[random.Next(symbols.Length)];
                UpdateListBox(listBoxSymbols, symbol.ToString());
            }
            UpdateListBox(listBoxSymbols, DateTime.Now.ToString());
        }

        private void UpdateListBox(ListBox listBox, string item)
        {
            if (listBox.InvokeRequired)
            {
                listBox.Invoke(new Action<ListBox, string>(UpdateListBox), listBox, item);
            }
            else
            {
                listBox.Items.Add(item);
            }
        }
    }
}
