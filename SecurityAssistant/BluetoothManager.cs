using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace SecurityAssistant
{
    public class BluetoothManager
    {
        private BluetoothClient _bluetoothClient;
        private BluetoothRadio _bluetoothRadio;

        public BluetoothManager()
        {
            _bluetoothClient = new BluetoothClient();
            _bluetoothRadio = BluetoothRadio.Default;
            // _bluetoothRadio.Mode = RadioMode.Discoverable;
            _bluetoothRadio.Mode = RadioMode.Connectable;
        }

        public void Open() => Process.Start(@"ms-settings:bluetooth");

        public void Connect(BluetoothAddress address)
        {
            _bluetoothClient.Connect(address, BluetoothService.GenericAudio);
        }
        public async void Start(string name)
        {
            // var device = bluetoothClient.DiscoverDevices().ToArray().Where(name => name.DeviceName == "vivo S1").First();
            // bluetoothClient.Connect()
            // BluetoothListener bluetoothListener = new BluetoothListener(device.);
            // bluetoothRadio.Mode = BluetoothService.
            await Task.Run(() =>
            {

                var active = false;
                // _bluetoothClient.Client.BeginConnect();
                BluetoothDeviceInfo[] paired;
                while (true)
                {
                    // var discoverd = _bluetoothClient.DiscoverDevices().ToArray();
                    paired = _bluetoothClient.PairedDevices.ToArray();
                    try
                    {
                        if (paired.Length > 0)
                        {
                            foreach (var device in paired)
                            {
                                if (device.DeviceName == name)
                                {

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

                                }
                            }


                        }

                        Thread.Sleep(1000);
                    }
                    catch (System.Exception e)
                    {

                        ;
                    }
                }

            });

            System.Console.WriteLine();
        }
    }
}
