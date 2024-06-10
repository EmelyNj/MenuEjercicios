namespace MenuEjercicios;

public partial class NumImpar : ContentPage
{
	public NumImpar()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        for (int i = 0; i <= 100; i = i + 2)
        {
            resultado.Text = resultado.Text + "  " + i;
        }
    }
}