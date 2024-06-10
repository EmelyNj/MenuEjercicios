namespace MenuEjercicios
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }


        /// <summary>
        /// El evento clicked de los botones, realizan la acción de navegar a otras páginas 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Eje1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NumImpar());
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
            Navigation.PushAsync(new Langosta());
        }

        private void Eje6_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Conversion());
        }
    }

}
