/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC35
 * Fecha: 29/11/2025
 * Hora: 01:48 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tarbajo
{
	 public partial class MainForm : Form
    {
        int[] numeros = new int[10];
        Random rnd = new Random();
        
        public MainForm()
        {
            InitializeComponent();
        }
        void BtnGenerarClick(object sender, EventArgs e)
		{
	    listBox1.Items.Clear();
        for (int i = 0; i < 10; i++)
        {
        numeros[i] = rnd.Next(1, 101); 
        listBox1.Items.Add(numeros[i]);
        }
	}
		
          void BtnOrdenarClick(object sender, EventArgs e)
    {
listBox1.Items.Clear();
Array.Sort(numeros);
foreach (int n in numeros)
            {
                listBox1.Items.Add(n);
            }
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Close();
		}
    }
}