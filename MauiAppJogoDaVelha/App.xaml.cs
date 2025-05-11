namespace MauiAppJogoDaVelha
{
    public partial class App : Application
    {
 InitializeComponent();
 MainPage = new AppShell();
 }
 protected override Window CreateWindow(IActivationState activationState)
 {
 var window = base.CreateWindow(activationState);
 window.Width = 400;
 window.Height = 600;
 return window;
 }
} // Fecha classe
} // Fecha namespace
