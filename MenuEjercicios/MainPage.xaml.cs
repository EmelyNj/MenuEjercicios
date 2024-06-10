namespace MenuEjercicios
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }



        private void Eje1_Clicked(object sender, EventArgs e)
        {

        }

        private void Eje2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CuentaRegresiva());
        }

        private void Eje3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TablasMultiplicar());
        }

        private void Eje4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SueldoSemanal());
        }

        private void Eje5_Clicked(object sender, EventArgs e)
        {

        }

        private void Eje6_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Conversion());
        }
    }

}
