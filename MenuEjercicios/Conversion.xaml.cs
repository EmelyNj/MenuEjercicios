namespace MenuEjercicios;

public partial class Conversion : ContentPage
{
	public Conversion()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (ePeso != null)
        {
            try
            {
                double peso;
                if (ePeso.Text.StartsWith('$'))
                {
                    peso = Convert.ToDouble(ePeso.Text.Remove(0, 1));
                }
                else
                {
                    peso = Convert.ToDouble(ePeso.Text);
                }
                double dollar;
                dollar = peso * 0.057;
                eDolar.Text = dollar.ToString("C2");
                ePeso.Text = peso.ToString("C2");
            }
            catch
            {
                DisplayAlert("Error", "Los datos ingresados deben ser numéricos", "Ok");
            }
        }
        else
        {
            DisplayAlert("Error", "Por favor introduza datos", "Ok");
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}