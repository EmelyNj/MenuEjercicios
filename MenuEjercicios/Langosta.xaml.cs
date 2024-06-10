namespace MenuEjercicios;

public partial class Langosta : ContentPage
{
	public Langosta()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        double total;
        int NP;
      
        if (NumPlatos.Text != null)
        {
            try
            {
                NP = Convert.ToInt32(NumPlatos.Text);
                if (NP > 300)
                {
                    total = NP * 75;
                }
                else if (NP > 200)
                {
                    total = NP * 85;
                }
                else
                {
                    total = NP * 95;
                }
                Total.Text = total.ToString("C2");
            }
            catch
            {
                DisplayAlert("Error", " Verifique los datos correctamente", "Ok");
            }
        }
        else
        {
            DisplayAlert("Error", " Por favor introduzca los datos que se le solicitan", "Ok");
        }
        
    }
}