using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrianguloLoco
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcularArea(object sender, EventArgs e)
        {
            var basexd = Double.Parse(Base.Text);
            var lado1 = Double.Parse(Lado1.Text);
            var lado2 = Double.Parse(Lado2.Text);
            var altura = Double.Parse(Altura.Text);
            var area = (basexd * altura) / 2;
            Area.Text = area.ToString();

            string resultado = "";

            if (basexd <= 0 || lado1 <= 0 || lado2 <= 0)
            {
                resultado = "No es un triangulo";
               
            }
        }
    }
}
