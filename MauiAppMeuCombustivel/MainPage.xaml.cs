using System.ComponentModel.Design;

namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";
                if (etanol <= gasolina * 0.7)
                {
                    msg = "O etanol está compensando mais!";

                }
                else
                {
                    msg = "A gasolina está compensando mais!";
                }

                await DisplayAlert("Calculado", msg, "OK");

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "Fechar");


            } // Fecha metodo
        }//Fecha Button_Clicked     
    }//Fecha Class
}//Fecha Namespace

