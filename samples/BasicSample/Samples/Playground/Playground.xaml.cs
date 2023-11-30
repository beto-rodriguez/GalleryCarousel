namespace BasicSample.Samples.Playground
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
