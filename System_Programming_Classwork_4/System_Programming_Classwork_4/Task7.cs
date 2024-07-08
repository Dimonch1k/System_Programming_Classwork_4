using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Programming_Classwork_4
{
    public partial class Task7 : Form
    {
        public Task7()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private async void countBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(numberTB.Text);
                int power = int.Parse(powerTB.Text);

                resultTB.Text = "Calculating...";
                resultTB.Refresh();

                double result = await CalculatePowerAsync(number, power);

                resultTB.Text = $"{result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private async Task<double> CalculatePowerAsync(double number, int power)
        {
            return await Task.Run(() =>
            {
                double result = Math.Pow(number, power);
                return result;
            });
        }
    }
}