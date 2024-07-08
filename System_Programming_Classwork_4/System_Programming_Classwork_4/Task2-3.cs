using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Programming_Classwork_4
{
    public partial class Task2 : Form
    {
        private bool isPause = false;
        private bool isStop = false;

        private ProgressBar[] pBars = new ProgressBar[3];


        public Task2()
        {
            InitializeComponent();
            createProgressBars();
        }

        private void createProgressBars()
        {
            for (int i = 0; i < pBars.Length; i++)
            {
                pBars[i] = new ProgressBar();
                pBars[i].Location = new System.Drawing.Point(20, 200 + (i * 40));
                pBars[i].Name = $"progressBar{i + 1}";
                pBars[i].Width = 200;
                pBars[i].Height = 30;
                Controls.Add(pBars[i]);
            }
        }


        // Start Button
        private void startCopyingBtn_Click(object sender, EventArgs e)
        {
            if (pBars[0].Value != 0) return;

            isPause = false;
            isStop = false;

            Thread[] threads = new Thread[3];

            for (var i = 0; i < threads.Length; i++)
            {
                var i1 = i;
                threads[i] = new Thread(() => StartPBar(pBars[i1]));
                threads[i].Start();
            }

            for (int i = 0; i < 3; i++)
            {
                threads[i].Join();
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

            pBar.Maximum = 100;
            pBar.Value = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (isStop)
                {
                    UpdatePBar(pBar, 0);
                    break;
                }

                while (isPause)
                {
                    await Task.Delay(1000);
                }

                await Task.Delay(rnd.Next(500)); // Simulate work being done
                UpdatePBar(pBar, i);
            }
        }




        // Pause Button
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            isPause = !isPause;
        }


        // Stop Button
        private void stopBtn_Click(object sender, EventArgs e)
        {
            isStop = !isStop;
        }





        // Update Progress Bar
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