using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{

    //Elaborado por 
    //Liliana Coronado, Estibaliz Salazar, Grace Sanchez, Mónica Serrano
    public partial class Form1 : Form
    {
        private ErrorProvider errorProvider;
        public Form1()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIngresarPalabra_Validating(object sender, CancelEventArgs e)
        {
            int numErrado;
            if (string.IsNullOrWhiteSpace(txtIngresarPalabra.Text))
            {
                errorProvider.SetError(txtIngresarPalabra, "Por favor ingrese una palabra");
                e.Cancel = true;
            }
            else if (int.TryParse(txtIngresarPalabra.Text, out numErrado))
            {
                errorProvider.SetError(txtIngresarPalabra, "Solo se aceptan letras");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIngresarPalabra, string.Empty);
            }

        }

        private void btidentificar_Click(object sender, EventArgs e)
        {
            listbVocales.Items.Clear(); 
            char letra;
            string palabra = txtIngresarPalabra.Text;

            // expresión para detectar las vocales dentro de la palabra ingresada
            var vocalRegex = new Regex(@"[aeiouAEIOU]", RegexOptions.IgnoreCase);

            for (int i = 0; i < txtIngresarPalabra.Text.Length; i++)
            {
                letra = palabra[i];

                if (vocalRegex.IsMatch(letra.ToString()))
                {
                    listbVocales.Items.Add(letra);
                }

            }
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            //faltaria ponerle lo del form2
            Frm2 form2 = new Frm2();
            form2.Show();
            this.Hide();
}
}
}
