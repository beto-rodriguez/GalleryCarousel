using CommunityToolkit.Mvvm.ComponentModel;

namespace BasicSample.Samples.BindableLayout;

public partial class ViewModel : ObservableObject
{
    [ObservableProperty]
    private Item[] _items = 
    {
        new("First", "img1.png"),
        new("Second", "img2.png"),
        new("Third", "img3.png"),
        new("Fourth", "img4.png"),
        new("Fifth", "img5.png"),
    };
}

public record Item(string Name, string Image);
