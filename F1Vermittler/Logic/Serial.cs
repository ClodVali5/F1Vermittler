using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace F1Vermittler.Logic
{
    public class Serial
    {
        static bool _continue;
        //static SerialPort _serialPort;
        public static string ComPortName;
        public static bool comOpen;

        private static string SENDWORD = "A";

        /// <summary>
        /// Wartet auf das Signal der USB Puzzer
        /// </summary>
        public static bool WaitForSerialSignal(bool onlysimulation)
        {
            if (!onlysimulation)
            {
                try
                {
                    string message;
                    StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

                    //// Create a new SerialPort object with default settings.
                    //_serialPort = new SerialPort();

                    ////Definition der COM-Schnittstelle
                    //_serialPort.BaudRate = 9600;
                    ////_serialPort.ParityReplace = &H3B;                   //' replace ";" when parity error occurs
                    ////_serialPort.PortName = cboComPort.Text
                    //_serialPort.Parity = Parity.None;
                    //_serialPort.DataBits = 8;
                    //_serialPort.StopBits = StopBits.One;
                    //_serialPort.Handshake = Handshake.None;
                    //_serialPort.RtsEnable = false;
                    //_serialPort.ReceivedBytesThreshold = 1;            // 'threshold: one byte in buffer > event is fired
                    ////_serialPort.NewLine = vbCr         // ' CR must be the last char in frame. This terminates the SerialPort.readLine
                    //_serialPort.ReadTimeout = 10000;
                                
                    //_serialPort.PortName = ComPortName; 
                  
                    //// Oeffne den Port
                    //_serialPort.Open();
                    //comOpen = _serialPort.IsOpen;
                    _continue = true;

                    //Schreibe auf die Serielle Schnittstelle                 
                            //_serialPort.WriteLine(SENDWORD);  //Schreibe auf Schnittstelle

                    while (_continue)
                    {
                        message = Console.ReadLine();

                        Debug.Print("gesendet: " + SENDWORD + ",   empfangen:  " + message); 

                        if (message == SENDWORD)
                        {
                            return false;
                        }
                    }

                    //_serialPort.Close();
                }
                catch (System.IO.IOException ex)
                {
                    throw ex;
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        #region HILFSMETHODEN

        private static string SetPortName(string defaultPortName)
        {
            string portName;

            Console.WriteLine("Available Ports:");
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("COM port({0}): ", defaultPortName);
            portName = Console.ReadLine();

            if (portName == "")
            {
                portName = defaultPortName;
            }
            return portName;
        }

        private static int SetPortBaudRate(int defaultPortBaudRate)
        {
            string baudRate;

            Console.Write("Baud Rate({0}): ", defaultPortBaudRate);
            baudRate = Console.ReadLine();

            if (baudRate == "")
            {
                baudRate = defaultPortBaudRate.ToString();
            }

            return int.Parse(baudRate);
        }

        private static Parity SetPortParity(Parity defaultPortParity)
        {
            string parity;

            Console.WriteLine("Available Parity options:");
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Parity({0}):", defaultPortParity.ToString());
            parity = Console.ReadLine();

            if (parity == "")
            {
                parity = defaultPortParity.ToString();
            }

            return (Parity)Enum.Parse(typeof(Parity), parity);
        }

        private static int SetPortDataBits(int defaultPortDataBits)
        {
            string dataBits;

            Console.Write("Data Bits({0}): ", defaultPortDataBits);
            dataBits = Console.ReadLine();

            if (dataBits == "")
            {
                dataBits = defaultPortDataBits.ToString();
            }

            return int.Parse(dataBits);
        }

        private static StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            string stopBits;

            Console.WriteLine("Available Stop Bits options:");
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Stop Bits({0}):", defaultPortStopBits.ToString());
            stopBits = Console.ReadLine();

            if (stopBits == "")
            {
                stopBits = defaultPortStopBits.ToString();
            }

            return (StopBits)Enum.Parse(typeof(StopBits), stopBits);
        }

        private static Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake;

            Console.WriteLine("Available Handshake options:");
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Handshake({0}):", defaultPortHandshake.ToString());
            handshake = Console.ReadLine();

            if (handshake == "")
            {
                handshake = defaultPortHandshake.ToString();
            }

            return (Handshake)Enum.Parse(typeof(Handshake), handshake);
        }

        #endregion

   
    }

}
