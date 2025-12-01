/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC34
 * Fecha: 01/12/2025
 * Hora: 05:30 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_german
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double[] cal = new double[7];

            cal[0] = double.Parse(textBox1.Text);
            cal[1] = double.Parse(textBox2.Text);
            cal[2] = double.Parse(textBox3.Text);
            cal[3] = double.Parse(textBox4.Text);
            cal[4] = double.Parse(textBox5.Text);
            cal[5] = double.Parse(textBox6.Text);
            cal[6] = double.Parse(textBox7.Text);

            double suma = 0;
            foreach(double x in cal)
                suma += x;

            double promedio = suma / 7;

            lblResultado.Text = "Promedio: " + promedio.ToString("0.00");
		}
	}
}
