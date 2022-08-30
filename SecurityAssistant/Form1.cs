using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityAssistant
{
    public partial class Form1 : Form
    {
        private string _dataFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\securityAssistant.txt";
        private string _filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\securityAssistant2.txt";
        private string _scanCycle = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\securityAssistant3.txt";
        public BluetoothManager BluetoothManager { get; set; } = new BluetoothManager();
        public InfoDisplay InfoDisplay = new InfoDisplay();


        public Form1()
        {
            InitializeComponent();
            if (File.Exists(_dataFile))
            {
                this.bluetoothNameInput.Text = File.ReadAllText(_dataFile);
            }
            if (File.Exists(_filePath))
            {
                FilePathText.Text = File.ReadAllText(_filePath);
            }
            if (File.Exists(_scanCycle))
            {
                ScanCycleText.Text = File.ReadAllText(_scanCycle);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ToBlueSky/SecurityAssistant");

        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            if (openfile.ShowDialog() == DialogResult.OK && (openfile.FileName != ""))
            {
                FilePathText.Text = openfile.FileName;
                File.WriteAllText(_filePath, openfile.FileName);
                SmartCard.IsStart = false;
                SmartStart.Enabled = true;
            }

            openfile.Dispose();
        }

        private void SmartStart_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(ScanCycleText.Text) || string.IsNullOrWhiteSpace(ScanCycleText.Text)
                || string.IsNullOrEmpty(FilePathText.Text) || string.IsNullOrWhiteSpace(FilePathText.Text)))
            {
                SmartCard.IsStart = true;
                SmartCard.SmartCardMonitorAsync(int.Parse(ScanCycleText.Text), FilePathText.Text);
                File.WriteAllText(_filePath, FilePathText.Text);
                File.WriteAllText(_scanCycle, ScanCycleText.Text);
                SmartStart.Enabled = !SmartCard.IsStart;
            }
            else
            {
                MessageBox.Show("Please input content in text box");
            }
            
        }
    }
}
