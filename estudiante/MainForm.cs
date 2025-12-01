/*
 * Creado por SharpDevelop.
 * Usuario: janux
 * Fecha: 01/12/2025
 * Hora: 05:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace estudiante
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
		
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
		string datos = "";

            datos += "Nombre: " + textBox1.Text + Environment.NewLine;

            datos += "Apellido: " + textBox2.Text + Environment.NewLine;

            datos += "Edad: " + textBox3.Text + Environment.NewLine;

            datos += "Grupo: " + textBox4.Text + Environment.NewLine;

            datos += "Carrera: " + textBox5.Text + Environment.NewLine;

            datos += "Matrícula: " + textBox6.Text + Environment.NewLine;

            datos += "Correo: " + textBox7.Text + Environment.NewLine;

            datos += "Teléfono: " + textBox8.Text + Environment.NewLine;

            datos += "Dirección: " + textBox9.Text + Environment.NewLine;

            datos += "Ciudad: " + textBox10.Text + Environment.NewLine;



            txtResultado.Text = datos;    	
		}
	}
}
