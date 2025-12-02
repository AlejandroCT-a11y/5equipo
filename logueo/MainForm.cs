/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC34
 * Fecha: 01/12/2025
 * Hora: 05:59 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace logueo
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
			string user="admin";
			string pass="1234";
			
			if(txtUsuario.Text==user && txtContraseña.Text==pass)
			{
				MainForm m=new MainForm();
				m.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Usuario o contraseña incorrectos");
		}
	}
}
}
