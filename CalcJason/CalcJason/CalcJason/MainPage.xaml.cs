using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcJason
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            pkOperaciones.Items.Add("Suma");
            pkOperaciones.Items.Add("Resta");
            pkOperaciones.Items.Add("Multiplicacion");
            pkOperaciones.Items.Add("Division");

        }

        private void OperacionesPicker(object sender, EventArgs e)
        {
            String op = pkOperaciones.SelectedItem.ToString();
            var n1 = double.Parse(num1.Text);
            var n2 = double.Parse(num2.Text);

            double res = 0;

            if (op == "Suma")
            {
                res = n1 + n2;
                resultado.Text ="Resultado de la suma: "+ res ;
            }
            else if (op == "Resta")
            {
                res = n1 - n2;
                resultado.Text = "Resultado de la resta: " + res;
            }
            else if (op == "Multiplicacion")
            {
                res = n1 * n2;
                resultado.Text = "Resultado de la Multiplicación: " + res;
            }
            else {
                res = n1 / n2;
                resultado.Text = "Resultado de la División: " + res;
            }

        }
    }
}
