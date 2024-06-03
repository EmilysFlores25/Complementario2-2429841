namespace Complementario22429841
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entry1.Text) && !string.IsNullOrEmpty(entry2.Text))
            {
                double Total, A, B;
                A = Convert.ToDouble(entry1.Text);
                B = Convert.ToDouble(entry2.Text);
                Total = ((A + B) * (A + B)) / 2;
                entryr.Text = Total.ToString();
            }
            else
            {
                DisplayAlert("Error", "Introduce todos los números", "Ok");
            }
        }
    }

}
