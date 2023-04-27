using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EstacionMonitoreo.V4._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void contra_Click(object sender, EventArgs e)
        {
            if (contraseña.Text == "abrir")
            {
                INICIO VENTANA = new INICIO();
                VENTANA.Show();
                this.Hide();
            }
            else
            {
                contraseña.Text = "";
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void contraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (contraseña.Text == "abrir")
                {
                    INICIO VENTANA = new INICIO();
                    VENTANA.Show();
                    this.Hide();
                }
                else
                {
                    contraseña.Text = "";
                }
            }
        }

        private void SpaceVoyager_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SpaceVoyager_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
