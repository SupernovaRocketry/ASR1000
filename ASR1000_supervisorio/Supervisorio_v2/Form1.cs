using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Supervisorio_v2
{
    public partial class Form1 : Form
    {
        string RxString, latitude_Str, longitude_Str, alturaBmp_Str, altitude_Str;
        long latitude_Long;
        double latitude, longitude;
        float alturaBmp, altitude;



        int cont; int contErro=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Write("1");
        }

        private void AtualizaListaCOMs()
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Write("1");
        }

        private void TimerCOM_Tick(object sender, EventArgs e)
        {
            AtualizaListaCOMs();
           
        }

        private void BtConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) // Se a porta de comunicação serial não está aberta
            {
                try
                {
                    serialPort1.PortName = comboBox1.SelectedItem.ToString();
                    serialPort1.Open(); //abre a porta de conexão com o item selecionado

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen) //Se  conexão serial é feita
                {
                    btConectar.Text = "Desconectar"; //Texto do botão muda para desconectar
                    comboBox1.Enabled = false;  // Como já há conexão, não pode mais selecionar na combo box
                   

                }
            }
            else //Se já há comunicação serial
            {

                try
                {
                    serialPort1.Close(); // Clique do botão desconecta do arduino
                    comboBox1.Enabled = true;
                    btConectar.Text = "Conectar";
                    
                }
                catch
                {
                    return;
                }

            }

        
    }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta
                serialPort1.Close();         //fecha a porta
        }
        private void TrataDadoRecebido(object sender, EventArgs e)
        {
            try
            {
                switch (RxString[0])
                {
                    case 'L':
                        latitude_Str = RxString.Substring(1);
                        Double.TryParse(latitude_Str, out latitude);
                        latitude = latitude / 1000000;
                        textBoxLatitude.AppendText(latitude + "\n");
                        cont++;

                        break;
                    case 'M':
                        longitude_Str = RxString.Substring(1);
                        Double.TryParse(longitude_Str, out longitude);
                        longitude = longitude / 1000000;
                        textBoxLongitude.AppendText(longitude + "\n");
                        cont++;

                        break;
                    case 'H':
                        alturaBmp_Str = RxString.Substring(1);
                        Single.TryParse(alturaBmp_Str, out alturaBmp);
                        alturaBmp = alturaBmp / 1000000;
                        textBoxAltura.AppendText(alturaBmp + "\n");
                        cont++;

                        break;
                    case 'A':
                        altitude_Str = RxString.Substring(1);
                        Single.TryParse(altitude_Str, out altitude);
                        altitude = altitude / 1000000;
                        textBoxAltitude.AppendText(altitude + "\n");
                        cont++;

                        break;
                    default:
                        contErro++;
                        textBoxErro.AppendText("Erro" + contErro + " \n");
                        break;

                }
                if (cont == 4)
                {
                    GravaDados();
                    cont = 0;
                }
            }
            catch (Exception)
            {
                textBoxErro.AppendText("Interferência \n");
            }
        }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = "";
            RxString = serialPort1.ReadExisting();//le o dado disponível na serial

            this.Invoke(new EventHandler(TrataDadoRecebido));   //chama outra thread para escrever o dado  
        }
        private void GravaDados()
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\souz_\Desktop\testeDeAlcance\testeDeAlcance.txt", true))
            {
                file.WriteLine(latitude+";"+ longitude+";"+altitude+";"+alturaBmp);
            }
        }
    }
   
}
