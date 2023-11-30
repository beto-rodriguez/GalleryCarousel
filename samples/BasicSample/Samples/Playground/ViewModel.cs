using CommunityToolkit.Mvvm.ComponentModel;

namespace BasicSample.Samples.Playground;

public partial class ViewModel : ObservableObject
{
    [ObservableProperty]
    private int _activeItem = 4;

    [ObservableProperty]
    private double _wingStart = 80;

    [ObservableProperty]
    private double _wingLength = 80;

    [ObservableProperty]
    private int _takeChildren = 3;

    [ObservableProperty]
    private double _scale = 0.8;

    [ObservableProperty]
    private double _wingScaleStep = 0.05;

    [ObservableProperty]
    private double _rotation = 25;
}
