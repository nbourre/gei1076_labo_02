using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170201
{
    public class PortSerie
    {
        private SerialPort serialPort = null;
        private bool ouvert = false;

        byte[] tampon = new byte[8];

        public PortSerie() {
            serialPort = new SerialPort();
        }

        public bool Ouvrir(string nomPort = "COM1", int baudRate = 9600)
        {
            if (!ouvert)
            {
                try
                {
                    serialPort.PortName = nomPort;
                    serialPort.BaudRate = baudRate;
                    serialPort.DataBits = 8;
                    serialPort.Parity = Parity.None;
                    serialPort.StopBits = StopBits.One;
                    serialPort.Handshake = Handshake.None;

                    serialPort.Open();

                    serialPort.DiscardInBuffer();

                    ouvert = true;
                    return true;
                }
                catch (Exception erreur)
                {
                    MessageBox.Show("Problème à l'ouverture du port " + nomPort + " à la vitesse de " + baudRate + "   " + erreur.Message, "ERREUR !!");
                }
            }

            return false;
        }

        public bool Fermer()
        {
            if (ouvert == false) return false;

            try
            {
                serialPort.Close();
                ouvert = false;
                return true;
            }
            catch (IOException erreur)
            {
                MessageBox.Show("Problème à la fermeture du port " + erreur.Message);
            }

            return false;
        }



        public bool EcrireOctet(byte octet)
        {
            if (ouvert == false) return false;

            tampon[0] = octet;
            serialPort.Write(tampon, 0, 1);

            return true;
        }

        public bool EcrireLigne(string tampon)
        {
            if (ouvert == false) return false;

            serialPort.WriteLine(tampon);

            return true;
        }

        public int DonneesALire()
        {
            if (ouvert == false) return 0;

            return this.serialPort.BytesToRead;
        }

        public bool LireOctet(ref byte octet)
        {
            if (ouvert == false) return false;

            
            octet = (byte)serialPort.ReadByte();

            return true;
        }

        public bool Ouvert
        {
            get
            {
                return ouvert;
            }
        }


        public int LireOctets(byte[] tableau, int decalage, int v)
        {

            // Voir : http://stackoverflow.com/questions/21337123/read-and-store-bytes-from-serial-port
            if (!ouvert) return -1;

            
            return serialPort.Read(tableau, decalage, v);            
            
        }





    }
}
