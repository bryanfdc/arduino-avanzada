using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // Libreria de comunicación SERIAL 

namespace arduino_avanzada
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }

        public Form1()
        {
               InitializeComponent();

            //Configuración de COmunicación SERIAL
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM3"; //Verificar con la configuración de Su equipo
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            // Manejadores de Eventos
            this.FormClosing += CerrandoForm1;
            this.btnEncender.Click += btnEncender_Click;
            this.btnApagar.Click += btnApagar_Click;
        }

        private void CerrandoForm1(object sender, EventArgs e)
        {
            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.Close();
            }
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEncender = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(181, 197);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(163, 70);
            this.btnEncender.TabIndex = 0;
            this.btnEncender.Text = "encendido";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(427, 197);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(187, 80);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click_1);
            // 
            // Form1
            // 
            this.BackgroundImage = global::arduino_avanzada.Properties.Resources.noble_6;
            this.ClientSize = new System.Drawing.Size(1529, 544);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEncender);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click_1(object sender, EventArgs e)
        {

        }
    }
}