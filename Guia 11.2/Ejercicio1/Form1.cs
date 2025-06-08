using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio1
{

    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int[] valores = new int[1000];
        int contador = 0;
        int acumulador = 0;
        int maximo = -1;
        int minimo = 99999;
        private void btnRegistrarNum_Click(object sender, EventArgs e)
        {
            int numero; 
           if (int.TryParse(tbPedirNumero.Text, out numero))
           {
                valores[contador] = numero;
                acumulador += numero;
                contador++;
                tbPedirNumero.Clear();
                tbPedirNumero.Focus();
                if (contador == 1000)
                {
                    btnRegistrarNum.Enabled = false;
                }
                if (numero > maximo)
                {
                    maximo = numero;
                }
                if (numero < minimo)
                {
                    minimo = numero;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un numero");
            }
        }

        private void btnActualizarMaxYMin_Click(object sender, EventArgs e)
        {
            lbMostrarMaximo.Text = maximo.ToString();
            lbMostrarMinimo.Text = minimo.ToString();
        }

        public double CalcularPromedio()
        {
            return (double)acumulador / contador;
        }
        private void btnActualizarPromedio_Click(object sender, EventArgs e)
        {
            lbMostrarPromedio.Text = CalcularPromedio().ToString("0.00");
        }

        private void btnActualizarCant_Click(object sender, EventArgs e)
        {
            lbMostrarCantidad.Text = contador.ToString();
        }

        public int Busqueda(int valor)
        {
            int pos = -1;
            int i = 0;
            while (pos == -1 && i < contador)
            {
                if (valores[i] == valor )
                {
                    pos = i;
                    
                }
                i++;
            }
            return pos;
        }
        public void Ordenamiento()
        {
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    int aux = valores[i];
                    valores[i] = valores[j];
                    valores[j] = aux;
                }
            }
        }
        private void btnBuscarValor_Click(object sender, EventArgs e)
        {
            Ordenamiento();
            int valorBuscado;
            if (int.TryParse(tbBuscarNumero.Text, out valorBuscado))
            {
               int pos = Busqueda(valorBuscado);
                if (pos != -1)
                {
                    MessageBox.Show($"El valor {valorBuscado} se encuentra en la posicion {pos+1}");
                }
                else 
                {
                    MessageBox.Show($"El valor {valorBuscado} no existe en el arreglo");
                }
            }
        }

        private void btnListaOrdenada_Click(object sender, EventArgs e)
        {
            Ordenamiento();
            listaValores.Items.Clear();
            for (int i = 0; i < contador; i++)
            {
                listaValores.Items.Add($"{valores[i]} | posicion: {i+1}");
            }
        }

        private void btnMayorPromedio_Click(object sender, EventArgs e)
        {
            Ordenamiento();
            listaValores.Items.Clear();
            bool hayMayores = false;
            for (int i = 0; i < contador; i++)
            {
                if (valores[i] > CalcularPromedio())
                {
                    listaValores.Items.Add($"{valores[i]}");
                    hayMayores = true;
                }
            }
            if (!hayMayores)
            {
                listaValores.Items.Add("No hay valores que superen el promedio");
            }
        }
    }
}
