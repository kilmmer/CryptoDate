using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CryptoDate
{
	public partial class Inicio : Form
	{
		public Inicio()
		{
			InitializeComponent();
            		n_car.Text = "0";
		}

		public double mostrarHora()
		{
			double h = DateTime.Now.Millisecond;   //Variável h recebe a hora
			return h;
		}

		private void cSHA1_Click(object sender, EventArgs e)
		{
            		resultBox.Text = "";
            		string cmp = cmpTexto.ToString();   //Variável cmp recebe o valor do text box
			double hr = mostrarHora();             //Variável hr recebe a hora do método 'mostrarHora'
			string cr = crypto.CalculateSHA1(cmp, hr);  //Variável cr recebe o resultado 
			resultBox.Text = cr;
		}

		private void cSHA256_Click(object sender, EventArgs e)
		{
			resultBox.Text = "";
		    	string cmp = cmpTexto.ToString();   //Variável cmp recebe o valor do text box
		    	Click += limpar_Click;
		    	double hr = mostrarHora();             //Variável hr recebe a hora do método 'mostrarHora'
		    	string cr = crypto.CalculateSHA256(cmp, hr);  //Variável cr recebe o resultado 
		    	resultBox.Text = cr;
		}

		private void cSHA512_Click(object sender, EventArgs e)
		{
		    	resultBox.Text = "";
		    	string cmp = cmpTexto.ToString();   //Variável cmp recebe o valor do text box
		    	double hr = mostrarHora();             //Variável hr recebe a hora do método 'mostrarHora'
		    	string cr = crypto.CalculateSHA512(cmp, hr);  //Variável cr recebe o resultado 
		    	resultBox.Text = cr;
		}

		private void limpar_Click(object sender, EventArgs e)
		{
			this.cmpTexto.Text = null;
			this.resultBox.Text = null;
		}

		private void SC_Click(object sender, EventArgs e)
		{
			string txt = cmpTexto.ToString();
			double hr = mostrarHora(); 
			string cr1 = crypto.CalculateSHA1(txt, hr);
			string cr2 = crypto.CalculateSHA256(cr1, hr);
			string cr3 = crypto.CalculateSHA512(cr2, hr);
			string cr4 = crypto.CalculateSC(cr3, hr);
			resultBox.Text = cr4; //+hr;
		}

		private void carac(object sender, EventArgs e)
		{
			int tam = resultBox.TextLength;
			n_car.Text = tam.ToString();
		}
	}
}
