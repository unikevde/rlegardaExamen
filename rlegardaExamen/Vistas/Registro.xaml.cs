namespace rlegardaExamen.Vistas;

public partial class Registro : ContentPage
{
    Double inicial = 0;
    Double pago = 0;
    Double calculo = 0;
    public Registro(string usuario)
	{
		InitializeComponent();
        lblUsaurio.Text = "Bienvido:" + usuario;
    }

    public void btncalcular_Clicked(object sender, EventArgs e)
    {
        Double inicial = Convert.ToDouble(txtmonto.Text);
        Double pago = Convert.ToDouble(txtpago.Text);
        double calculo = ((inicial - pago) / 4)+(inicial*0.04);
        txtpago.Text = calculo.ToString();
    }
     
    public void btnresumen_Clicked(object sender, EventArgs e)
    {
        string nombre= Convert.ToString(txtnombre.Text);
        string apellido= Convert.ToString(txtapellido.Text);
        String edad = Convert.ToString(txtedad.Text);
        Navigation.PushAsync(new Vistas.Resumen(nombre, apellido, edad, inicial, pago, calculo));
    }
}