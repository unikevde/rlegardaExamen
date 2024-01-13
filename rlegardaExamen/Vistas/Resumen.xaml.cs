using static System.Runtime.InteropServices.JavaScript.JSType;

namespace rlegardaExamen.Vistas;

public partial class Resumen : ContentPage
{
    public Resumen(string nombre, string apellido, string edad, Double inicial, Double pago, Double calculo)
    {
		InitializeComponent();
        txtnombre.Text = nombre;
        txtapellido.Text = apellido;
        txtedad.Text = edad;
        txtinicial.Text = Convert.ToString(inicial);
        txtpago.Text = Convert.ToString(pago);
        txttotal.Text = Convert.ToString(calculo);
    }
}