using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.ThreeD;
using Aspose.ThreeD.Animation;
using Aspose.ThreeD.Entities;
using Aspose.ThreeD.Formats;
using Aspose.ThreeD.Render;
using Aspose.ThreeD.Utilities;
using EstacionMonitoreo.V4._0.Controls;
using Microsoft.Win32;



namespace EstacionMonitoreo.V4._0
{

    public partial class INICIO : Form
    { //---------DATOS-------------------
        string datos_puerto;
        System.IO.Ports.SerialPort puerto;
        double tiempo = 0.0;
        bool IsOpen = false;
        /// graficas
        static public double velocidad = 0.0;
        static public double aceleracion = 0.0;
        static public double altura = 0.0;
        static public string presion = "0.0";
        static public string Temperatura = "0.0";
        static public string Orientacion_x = "0.0";
        static public string Orientacion_y = "0.0";
        //-------------DATOS*----------------
        private Scene scene = new Scene();
        public Cylinder box = new Cylinder();
        public Transform tr;
        public INICIO()
        {
            InitializeComponent();
            renderView1.Scene = scene;
            renderView1.SceneUpdated("");
            renderView1.SetUpVector(Axis.YAxis);
            box = new Cylinder(2, 5);
            tr = scene.RootNode.CreateChildNode("C",box).Transform;


        }
        /// <summary>
        ///
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void salir_Click(object sender, EventArgs e)
        {
            clok.Stop();
            if (IsOpen == true)
            {
                puerto.Close();
            }

            this.Close();
            // anular todo

            Form1 abrir = new Form1();
            abrir.Show();
        }

        private void SpaceVoyager_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void maximisar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximisar.Visible = false;
            max.Visible = true;
        }

        private void max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            max.Visible = false;
            maximisar.Visible = true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void INICIO_Load(object sender, EventArgs e)
        {
            TiempoReloj.Interval = 1000;
            TiempoReloj.Start();
            try
            {
                // Puerto
                string[] ports = SerialPort.GetPortNames();
                PUERTOS.DataSource = ports;


                // Baudrate
                string[] rates = { "9600", "38400", "57600", "115200" };
                BAUDIOS.DataSource = rates;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        ///------------------conexion serial*************************
        public void serial()
        {

            try
            {
                this.puerto = new System.IO.Ports.SerialPort("" + PUERTOS.Text, Convert.ToInt32(BAUDIOS.Text), System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);

                this.puerto.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(recepcion);

            }
            catch (Exception error)
            {
                MessageBox.Show("falla en conexion");
                this.puerto = new System.IO.Ports.SerialPort("" + "0", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);


            }
        }
        public void recepcion(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                // Thread.Sleep(1);
                datos_puerto = this.puerto.ReadLine();
                Console.WriteLine(datos_puerto);
                if (datos_puerto.StartsWith("$"))
                {
                    // formato de string recibido
                    NumberFormatInfo formatProvider = new NumberFormatInfo();
                    formatProvider.NumberDecimalSeparator = ".";
                    formatProvider.NumberGroupSeparator = ",";
                    // deteccion de dato
                    datos_puerto = datos_puerto.Remove(0, 1);
                    // separacion de datos
                    string[] arreglo = datos_puerto.Split(';');
                    // datos recibidos y transformados a tipo bouble
                    altura = Convert.ToDouble(arreglo[0], formatProvider);
                    aceleracion = Convert.ToDouble(arreglo[1], formatProvider);
                    velocidad = Convert.ToDouble(arreglo[2], formatProvider);
                    Orientacion_x = arreglo[5];
                    Orientacion_y = arreglo[6];
                    presion = arreglo[3];
                    Temperatura = arreglo[4];

                    Console.WriteLine(arreglo[0]);
                    Console.WriteLine(arreglo[1]);
                    Console.WriteLine(arreglo[2]);
                    Console.WriteLine(arreglo[3]);
                    Console.WriteLine(arreglo[4]);
                    Console.WriteLine(arreglo[5]);
                    Console.WriteLine(arreglo[6]);
                    Console.WriteLine("-----");
                    Console.WriteLine(altura);
                    Console.WriteLine(aceleracion);
                    Console.WriteLine(velocidad);

                }
                else
                {
                    altura = 0.0;
                    velocidad = 0.0;
                    aceleracion = 0.0;
                    presion = "0.0";
                    Temperatura = "0.0";
                    Orientacion_x = "0.0";
                    Orientacion_y = "0.0";
                }

            }
            catch (Exception error)
            {
                altura = 0.0;
                velocidad = 0.0;
                aceleracion = 0.0;
                presion = "0.0";
                Temperatura = "0.0";
                Orientacion_x = "0.0";
                Orientacion_y = "0.0";
                MessageBox.Show("falla en actualizar");

            }

        }

        private void clok_Tick(object sender, EventArgs e)
        {

            tr.Translation = new Vector3(0, 5, 0);
            //tr = scene.RootNode.CreateChildNode(box).Transform;
            //// Scale transform
            tr.Scale = new Vector3(1, 1, 1);
            // Set Euler Angles
            tr.EulerAngles = new Vector3(Convert.ToDouble(Orientacion_x) * 100, Convert.ToDouble(Orientacion_y) * 100, 50);
            tiempo++;
            htiemp.Series[0].Points.AddXY(tiempo, altura);
            Atiem.Series[0].Points.AddXY(tiempo, aceleracion);
            Vtiem.Series[0].Points.AddXY(tiempo, velocidad);
            label11.Text = velocidad.ToString();
            label9.Text = aceleracion.ToString();
            label7.Text = altura.ToString();
            label14.Text = Orientacion_x;
            label20.Text = Orientacion_y;

            //uso de circle bar temperatura
            string[] textSplit = Temperatura.Split('.');
            bunifuCircleProgress1.ValueByTransition = Convert.ToInt32(textSplit[0]);
            bunifuCircleProgress1.SubScriptText = textSplit[1];

            //uso de circle bar presion
            string[] textSplit1 = presion.Split('.');
            bunifuCircleProgress2.ValueByTransition = Convert.ToInt32(textSplit1[0]);
            bunifuCircleProgress2.SubScriptText = textSplit1[1];

        }

        private void ConecDesc_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (ConecDesc.Checked)
                {
                    serial();
                    puerto.Open();
                    bunifuPictureBox1.Image = Properties.Resources.icons8_disconnected_32px;
                    IsOpen = true;
                    label3.Text = "Desconectar";
                    clok.Start();
                    clok.Interval = Convert.ToInt32(TiempoIntervalo.Text);
                    Console.WriteLine("abilitar puerto");


                }

                else
                {

                    clok.Stop();
                    //tmrRedraw.Stop();
                    IsOpen = false;

                    Console.WriteLine("CLOSED PORT");

                    bunifuPictureBox1.Image = Properties.Resources.conectar1;
                    label3.Text = "CONECTAR";

                    htiemp.Series[0].Points.Clear();
                    Atiem.Series[0].Points.Clear();
                    Vtiem.Series[0].Points.Clear();
                    datos_puerto = "$0.0;0.0;0.0;0.0;0.0;0,0;0.0";
                    tiempo = 0.0;
                    velocidad = 0.0;
                    aceleracion = 0.0;
                    altura = 0.0;
                    presion = "0.0";
                    Temperatura = "0.0";
                    Orientacion_x = "0.0";
                    Orientacion_y = "0.0";
                    puerto.Close();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("falla en coneccion");
                ConecDesc.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] ports = SerialPort.GetPortNames();
            PUERTOS.DataSource = ports;
        }

        private void renderView1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnStandardMovement_Click(object sender, EventArgs e)
        {
            renderView1.ChangeMovement<StandardMovement>();
        }

        private void btnOrbital_Click(object sender, EventArgs e)
        {
            renderView1.ChangeMovement<OrbitalMovement>();
        }

        private void Vtiem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clok.Stop();
            if (IsOpen == true)
            {
                puerto.Close();
            }

            this.Close();
            // anular todo

            Form1 abrir = new Form1();
            abrir.Show();
        }

        private void PauseReanu_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (PauseReanu.Checked)
                {
                    bunifuPictureBox2.Image = Properties.Resources.reanudar;

                    label5.Text = "Reanudar";
                    clok.Stop();
                }

                else
                {

                    bunifuPictureBox2.Image = Properties.Resources.pausa;
                    label5.Text = "Pausar";
                    if (IsOpen == true)
                    {
                        clok.Start();

                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("falla al pausar");
            }
        }

        private void TiempoReloj_Tick(object sender, EventArgs e)
        {
            reloj.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
