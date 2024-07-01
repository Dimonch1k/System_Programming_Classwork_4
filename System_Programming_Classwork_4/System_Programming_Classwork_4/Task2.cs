using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Programming_Classwork_4
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void startCopyingBtn_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void Run()
        {
            ProgressBar[] pBars = new ProgressBar[3];

            for (int i = 0; i < pBars.Length; i++)
            {
                pBars[i] = new ProgressBar();
                pBars[i].Location = new System.Drawing.Point(20, 200 + (i * 40));
                pBars[i].Name = $"progressBar{i + 1}";
                pBars[i].Width = 200;
                pBars[i].Height = 30;
                Controls.Add(pBars[i]);
            }


            Thread[] threads = new Thread[3];
            
            for (var i = 0; i < threads.Length; i++)
            {
                var i1 = i;
                threads[i] = new Thread(() => StartPBar(pBars[i1]));
                threads[i].Start();
            }

            threads[0].Priority = ThreadPriority.Lowest;
            threads[1].Priority = ThreadPriority.Normal;
            threads[2].Priority = ThreadPriority.Highest;

            foreach (var t in threads)
            {
                t.Join();
            }
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            fileNameLb.Text = openFileDialog1.FileName;

        }


        private async void StartPBar(ProgressBar pBar)
        {
            Random rnd = new Random();

            int steps = 100;
            pBar.Maximum = steps;
            pBar.Value = 0;

            for (int i = 0; i <= steps; i++)
            {
                await Task.Delay(rnd.Next(500)); // Simulate work being done
                UpdatePBar(pBar, i);
            }
        }

        private void UpdatePBar(ProgressBar pBar, int value)
        {
            if (pBar.InvokeRequired)
            {
                pBar.Invoke(new Action<ProgressBar, int>(UpdatePBar), pBar, value);
            }
            else
            {
                pBar.Value = value;
            }
        }
    }
}