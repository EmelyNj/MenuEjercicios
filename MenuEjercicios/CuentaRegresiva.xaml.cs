namespace MenuEjercicios;

public partial class CuentaRegresiva : ContentPage
{
	public CuentaRegresiva()
	{
		InitializeComponent();
        for (int i = 10; i > 0; i--)
        {
            txtCuenta.Text = txtCuenta.Text + " " + i.ToString() + " ";
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}