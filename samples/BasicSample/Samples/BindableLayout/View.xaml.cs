namespace BasicSample.Samples.BindableLayout
{
    public partial class View : ContentPage
    {
        public View()
        {
            InitializeComponent();
            BindingContext = new ViewModel();
        }
    }
}
