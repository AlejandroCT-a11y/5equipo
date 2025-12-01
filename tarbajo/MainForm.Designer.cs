/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC35
 * Fecha: 29/11/2025
 * Hora: 01:48 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace tarbajo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btnGenerar = new System.Windows.Forms.Button();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(139, 95);
			this.listBox1.TabIndex = 0;
			// 
			// btnGenerar
			// 
			this.btnGenerar.BackColor = System.Drawing.Color.Yellow;
			this.btnGenerar.Location = new System.Drawing.Point(40, 124);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(75, 23);
			this.btnGenerar.TabIndex = 1;
			this.btnGenerar.Text = "Generar";
			this.btnGenerar.UseVisualStyleBackColor = false;
			this.btnGenerar.Click += new System.EventHandler(this.BtnGenerarClick);
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.BackColor = System.Drawing.Color.Lime;
			this.btnOrdenar.Location = new System.Drawing.Point(40, 153);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
			this.btnOrdenar.TabIndex = 2;
			this.btnOrdenar.Text = "Ordenar";
			this.btnOrdenar.UseVisualStyleBackColor = false;
			this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Red;
			this.btnSalir.Location = new System.Drawing.Point(40, 183);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 3;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(165, 212);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.btnGenerar);
			this.Controls.Add(this.listBox1);
			this.Name = "MainForm";
			this.Text = "tarbajo";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.Button btnGenerar;
		private System.Windows.Forms.ListBox listBox1;
	}
}
