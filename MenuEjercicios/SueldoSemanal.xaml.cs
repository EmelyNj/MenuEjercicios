namespace MenuEjercicios;

public partial class SueldoSemanal : ContentPage
{
	public SueldoSemanal()
	{
		InitializeComponent();
	}

    /// <summary>
    /// El boton tienen 3 variables, una para las horas trabajadas (ht), otra para
    /// el pago por hora (ph) y una para el sueldo semanal(ss), se multiplica el ht por el ph y se guarda
    /// el resultado en la ss, luego lo pasamos a string y lo mostramos en el entry correspondiente
    /// </summary>
    private void Calcular_Clicked(object sender, EventArgs e)
    {
        double ht, ph, ss;

        if ( Horas.Text != null && Pago.Text!=null)
        {
            try
            {
                ht = Convert.ToDouble(Horas.Text);
                ph = Convert.ToDouble(Pago.Text);
                ss = ht * ph;

                Sueldo.Text = Convert.ToString(ss);
            }
            catch
            {
                DisplayAlert("Error", "Verifique sus datos", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Por favor introduzca correctamente los datos", "OK");

        }

       

    }
}