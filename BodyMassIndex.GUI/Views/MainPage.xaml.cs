using BodyMassIndex.GUI.ViewsModels;

namespace BodyMassIndex.GUI
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        
    }
}