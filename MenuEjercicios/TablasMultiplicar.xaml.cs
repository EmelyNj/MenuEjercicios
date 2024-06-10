namespace MenuEjercicios;

public partial class TablasMultiplicar : ContentPage
{
	public TablasMultiplicar()
	{
		InitializeComponent();
	}

    /// <summary>
    /// El boton tiene 11 variables, 10 para guardar las multiplicaciones y una para guardar 
    /// el texto obtenido del entry en el .xaml, luego se convierten en string y se ordenan para
    /// onbtener la tabla de multiplicar.
    /// </summary>
    private void Obtener_Clicked(object sender, EventArgs e)
    {
        int n, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10;


        n = Convert.ToInt32(num.Text);


        t1 = n * 1;
        t2 = n * 2;
        t3 = n * 3;
        t4 = n * 4;
        t5 = n * 5;
        t6 = n * 6;
        t7 = n * 7;
        t8 = n * 8;
        t9 = n * 9;
        t10 = n * 10;

        r1.Text = Convert.ToString(n + " X 1" + " = " + t1);
        r2.Text = Convert.ToString(n + " X 2" + " = " + t2);
        r3.Text = Convert.ToString(n + " X 3" + " = " + t3);
        r4.Text = Convert.ToString(n + " X 4" + " = " + t4);
        r5.Text = Convert.ToString(n + " X 5" + " = " + t5);
        r6.Text = Convert.ToString(n + " X 6" + " = " + t6);
        r7.Text = Convert.ToString(n + " X 7" + " = " + t7);
        r8.Text = Convert.ToString(n + " X 8" + " = " + t8);
        r9.Text = Convert.ToString(n + " X 9" + " = " + t9);
        r10.Text = Convert.ToString(n + " X 10" + " = " + t10);

    }
}