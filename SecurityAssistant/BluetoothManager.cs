using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityAssistant
{
    public class BluetoothManager
    {
        private readonly BluetoothClient _bluetoothClient;
        private BluetoothRadio _bluetoothRadio;
        public bool Success { get; set; }
        public bool IsStart { get; set; }

        public BluetoothManager()
        {
            _bluetoothClient = new BluetoothClient();
        }

        public void Connect(BluetoothAddress address)
        {
            _bluetoothClient.Connect(address, BluetoothService.GenericAudio);
        }
        public async void Start(Form1 form1, string name)
        {
            _bluetoothRadio = BluetoothRadio.Default;
            if (BluetoothRadio.Default == null)
            {
                MessageBox.Show("Please open bluetooth");
                return;
            }
            _bluetoothRadio.Mode = RadioMode.Connectable;
            await Task.Run(() =>
            {
                var active = false;
                var nameCorrect = false;
                

                while (IsStart)
                {
                    var paired = _bluetoothClient.PairedDevices.ToArray();
                    try
                    {
                        if (paired.Length > 0)
                        {
                            foreach (var device in paired)
                            {
                                if (device.DeviceName == name)
                                {
                                    if (device.Connected)
                                    {
                                        form1.ConnectStatusLabel.Text = "Connected";
                                        form1.ConnectStatusLabel.BackColor = System.Drawing.Color.Green;
                                    }
                                    else
                                    {
                                        form1.ConnectStatusLabel.Text = "Connecting";
                                        form1.ConnectStatusLabel.BackColor = System.Drawing.Color.Yellow;
                                    }
                                    if (!device.Connected && active)
                                    {
                                        Screen.LockWorkStation();
                                        active = false;
                                    }
                                    if (device.Connected)
                                    {
                                        active = true;
                                    }
                                    else
                                    {
                                        Connect(device.DeviceAddress);
                                    }
                                    nameCorrect = true;
                                }
                            }
                            if (!nameCorrect)
                            {
                                MessageBox.Show("The bluetooth name is not correct");
                                Success = false;
                                return;
                            }
                            else
                            {
                                Success = true;
                            }
                        }

                        Thread.Sleep(1000);
                    }
                    catch (System.Exception)
                    {
                        ;
                    }
                }

            });

            System.Console.WriteLine();
        }
    }
}
