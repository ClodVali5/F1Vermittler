using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;

namespace F1Vermittler
{
    public partial class Start : Form
    {
        static SerialPort _serialPort;
        public static string ComPortName;
        static bool comOpen;
        private string readBuffer = null;
        private static string SENDWORD = "A";
        private bool isGedrueckt;
        bool onlysimulation;     
 
        public Start()
        {
            InitializeComponent();
        }   

        private void Start_Load(object sender, EventArgs e) 
        {
            DataSet data = new DataSet();     //Auslesen aus Config aus File App.xml
            data.ReadXml(Application.StartupPath + @"\Configuration\App.xml");

            tfApplicationName.Text = data.Tables[0].Rows[0][1].ToString();
            tfClassname.Text = data.Tables[0].Rows[0][0].ToString();
            Logic.Serial.ComPortName = data.Tables[0].Rows[0][2].ToString();
            Start.ComPortName = data.Tables[0].Rows[0][2].ToString();
            Logic.Trigger.PressKey = data.Tables[0].Rows[0][3].ToString();
        }


        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (comOpen)
            {
                _serialPort.Close();
                Debug.Print("COM geschlossen");
            }
        }
                
        private void btTool_Click(object sender, EventArgs e)
        {
            string toolpath = Application.StartupPath + @"\Tool\spyxx.exe";

            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo(toolpath);
            proc.Start();
        }

        private void btStartMonitor_Click(object sender, EventArgs e)
        {
            rtfLog.Text = "Warte auf Befehl von USB Schnittstelle...\r\n";

            onlysimulation = cbSimulation.Checked;

            if (!onlysimulation)
            {
                    try
                    {
                        if (comOpen)         //Port schliessen wenn geöfnnet
                        { _serialPort.Close(); } 
                        
                        _serialPort_init();  //Port Definiton und öffnen des Port 

                        if (comOpen)         //Dynamische Aktualisierung UI
                        {
                            picComOpen.BackColor = Color.Green;
                        }

                        _serialPort_write(); // Zyklisch auf die Schnittstelle schreiben               
                    }
                    catch (System.IO.IOException ex)
                    {
                        throw ex;
                    }
                }
            else
            {
                SendeTasteProgram();  // gewünschtes Programm die Taste senden 
            }
        }

       private void _serialPort_init()
        {
            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            //Definition der COM-Schnittstelle
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.None;
            _serialPort.RtsEnable = false;
            _serialPort.ReceivedBytesThreshold = 1;            // 'threshold: one byte in buffer > event is fired
            _serialPort.ReadTimeout = 10000;

            _serialPort.PortName = ComPortName;
           
            // Event auslösen wenn Daten ankommen/gelesen werden
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);

            // Oeffne den Port
            _serialPort.Open();
            comOpen = _serialPort.IsOpen;    
        }

        private void _serialPort_write()  //Zyklisches Schreiben auf die Schnittstelle
        {
           if (comOpen)
           {
               _serialPort.WriteLine(SENDWORD);

               Timer2.Enabled = true;
           }
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int dataLength = _serialPort.BytesToRead;

            //readBuffer = _serialPort.ReadTo(SENDWORD);  // generiert TimeOut's
            readBuffer = _serialPort.ReadLine();    
                      
            //data to UI thread
            this.Invoke(new EventHandler(DoUpdate));
        }

        private void DoUpdate(object sender, EventArgs e)  //Zurück in den UI, gewünschtes Programm ausführen 
        {
            picDataReceived.BackColor = Color.Green;
            //rtfLog.Text = readBuffer;   //nur für Testzwecke
            Timer1.Enabled = true;
            isGedrueckt = true;

            if (isGedrueckt)
            {
                SendeTasteProgram();
            }
        }

        private void SendeTasteProgram()
        // gewünschtes Programm die gewünschte Taste drücken
        {
            Logic.Trigger trigger = new Logic.Trigger();
            trigger.TransmitF1(tfClassname.Text, tfApplicationName.Text);
        }

        private void btSendWord_Click(object sender, EventArgs e)   
        //nur für Testzwecke genutzt. Button versteckt
        {
            if (comOpen) 
            {
                _serialPort.WriteLine(SENDWORD);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
             picDataReceived.BackColor = Color.Gray;
             Timer1.Enabled = false;
        }

        private void Timer2_Tick(object sender, EventArgs e)  //Zyklisches Schreiben auf COM-Schnittstelle
        {
               _serialPort.WriteLine(SENDWORD);
        }

    }
}
