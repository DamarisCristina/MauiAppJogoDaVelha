namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {

        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            } else

            {
                btn.Text = "O";
                vez = "X";
            }

            /* Verificando se o X ganhou na 1ª linha */
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Fim de Jogo", "O X ganhou!", "OK");
                zerar();
            }

        }// Fecha o método Button_Clicked

        void zerar ()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";


            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
        }

    }// Fecha a classe MainPage
}// Fecha o namespace MauiAppJogoDaVelha
