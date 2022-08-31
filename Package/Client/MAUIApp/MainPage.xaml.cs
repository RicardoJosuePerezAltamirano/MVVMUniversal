

using Core.ViewModels;
using MAUIApp.ViewModels;

namespace MAUIApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        LoginViewModel ViewModel;
        MainViewModel MainViewModel;
        public MainPage( MainViewModel MainViewModel_, LoginViewModel ViewModel_)
        {
            InitializeComponent();
            ViewModel = ViewModel_;
            MainViewModel = MainViewModel_;
            ViewModel.Messagge = " LoginViewModel";
            MainViewModel.Message += ViewModel.Messagge;
            BindingContext = MainViewModel;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

           // ViewModel.User = "perro";
           // ViewModel.Password = "perro";
           // await ViewModel.LoginCommand.ExecuteAsync();

        }
    }
}