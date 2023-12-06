using System;
using System.ComponentModel;

namespace PropertyChangeExperiment.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private DateTime _startDateTime;
    private DateTime _endDateTime;

    public DateTime StartDateTime
    {
        get => _startDateTime;
        set => SetProperty(ref _startDateTime, value);
    }

    public DateTime EndDateTime
    {
        get => _endDateTime;
        set => SetProperty(ref _endDateTime, value);
    }

    public MainViewModel()
    {
        PropertyChanged += OnPropCh;
    }

    private void OnPropCh(object? sender, PropertyChangedEventArgs e) 
    {
        MyMethod();
    }

    public virtual void MyMethod()
    {

    }
}
