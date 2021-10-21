using System;
using System.IO;
using System.Windows.Forms;

namespace SecurityAssistant
{
    public partial class Form1 : Form
    {
        private string _dataFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\securityAssistant.txt";
        public BluetoothManager BluetoothManager { get; set; } = new BluetoothManager();

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(_dataFile))
            {
                this.bluetoothNameInput.Text = File.ReadAllText(_dataFile);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                if (BluetoothManager.Success == false && !string.IsNullOrEmpty(this.bluetoothNameInput.Text))
                {
                    File.WriteAllText(_dataFile, this.bluetoothNameInput.Text);
                    BluetoothManager.IsStart = true;
                    BluetoothManager.Start(this, this.bluetoothNameInput.Text);
                    this.RunningStatusLabel.Text = "Running";
                    this.RunningStatusLabel.BackColor = System.Drawing.Color.Green;
                }
                else if (BluetoothManager.Success)
                {
                    MessageBox.Show("The previous one is running");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message);
            }


        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            BluetoothManager.Success = false;
            BluetoothManager.IsStart = false;
            this.RunningStatusLabel.Text = "Stopped";
            this.RunningStatusLabel.BackColor = System.Drawing.Color.Yellow;
        }
    }
}
