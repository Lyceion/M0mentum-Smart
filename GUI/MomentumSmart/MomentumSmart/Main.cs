#region Regions
#region Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
#endregion
#region Codes
namespace MomentumSmart
{
    #region Form
    public partial class Form1 : Form
    {
        #region ConstantParameters
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        #endregion
        #region FormLoadPart
        public Form1()
        {
            InitializeComponent();
            getAvailableComPorts();
            int duration = 1200;//in milliseconds
            int steps = 90;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = duration / steps;

            int currentStep = 0;
            timer.Tick += (arg1, arg2) =>
            {
                Opacity = ((double)currentStep) / steps;
                currentStep++;

                if (currentStep >= steps)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };
            timer.Start();
            foreach (string port in ports)
            {
                portCombo.AddItem(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    portCombo.selectedIndex = 0;
                }
            }
        }
        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }
        #endregion
        #region Buttons
        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = portCombo.selectedValue;
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            connect.Text = "OK";
            login();
        }
        private void login()
        {
            loginPage.Visible = false;
            connect.Enabled = false;
        }

        private void connect_Click(object sender, EventArgs e)
        {
            connectToArduino();
            loginPage.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            disconnectFromArduino();
            Application.Exit();
        }
        private void disconnectFromArduino()
        {
            try
            {
                isConnected = false;
                port.Write("#STOP\n");
                port.Close();
            }
            catch
            {

            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("M0mentum SmarT Projesi \nYapanlar: Can Destan / Ömer Faruk Yeşiltaş \nVersiyon Alpha 0.5-7", "Hakkında");
        }

        private void krkb_Click(object sender, EventArgs e)
        {
            port.Write("#LED1ON\n");
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            port.Write("#LED2ON\n");
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            port.Write("#LED2OF\n");
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            port.Write("#LED1OF\n");
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            port.Write("#STOP\n");
            Thread.Sleep(3000);
            port.Write("#STAR\n");
        }
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region FormEffects
        private async void FadeIn(Form o, int interval = 80)
        {
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
    }
    #endregion
}
#endregion
#endregion
