using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HolaMundo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var n1 = double.Parse(Number1.Text);
            var n2 = double.Parse(Number2.Text);
            var resultado = n1 + n2;

            Resultado.Text = "Resultado de la suma es: "+resultado.ToString();


        }

        private void btn_resta_Clicked(object sender, EventArgs e)
        {
            var n1 = double.Parse(Number1.Text);
            var n2 = double.Parse(Number2.Text);
            var resultado = n1 - n2;

            Resultado.Text = "Resultado de la resta es: " + resultado.ToString();

        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var n1 = double.Parse(Number1.Text);
            var n2 = double.Parse(Number2.Text);
            var resultado = n1 * n2;

            Resultado.Text = "Resultado de la Multiplicación es: " + resultado.ToString();
        }

        private void btn_division_Clicked(object sender, EventArgs e)
        {
            var n1 = double.Parse(Number1.Text);
            var n2 = double.Parse(Number2.Text);
            var resultado = n1 / n2;

            Resultado.Text = "Resultado de la División es: " + resultado.ToString();
        }

        private void Limpiar(object sender, EventArgs e)
        {
            Number1.Text = "";
            Number2.Text = "";
        }
    }
}
