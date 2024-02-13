using System;
using System.Threading;
using Avalonia.Controls;
using Avalonia.Media;
using System.Timers;
using Avalonia.Media.Immutable;
using Avalonia.Skia;
using Avalonia.Threading;
using Color = System.Drawing.Color;
using Timer = System.Timers.Timer;

namespace PreparationTracking;

public partial class MainWindow : Window
{
    private IImmutableSolidColorBrush _color;
    private DispatcherTimer _timer = new DispatcherTimer();
    public MainWindow()
    {
        InitializeComponent();
        _timer.Interval = TimeSpan.FromSeconds(3);
        _timer.Tick += Counter;
        _timer.Start();
    }

    private void Counter(object? sender, EventArgs e)
    {
        RandomMetod();
        Ellipse1.Fill = _color;
        RandomMetod();
        Ellipse2.Fill = _color;
        RandomMetod();
        Ellipse3.Fill = _color;
        RandomMetod();
        Ellipse4.Fill = _color;
        RandomMetod();
        Ellipse5.Fill = _color;
        RandomMetod();
        Ellipse6.Fill = _color;
    }
    private void RandomMetod()
    {
        Random random = new Random();
        int nextStation = random.Next(1, 100);
        if (nextStation < 51)
        {
            _color = Brushes.Blue;
        }
        else
        {
            _color = Brushes.Green;
        }
    }
}