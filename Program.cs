using Pogodynka.Presenter;

namespace Pogodynka
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            MainWindow mainWindow = new MainWindow();
            MainWindowPresenter Presenter = new MainWindowPresenter(mainWindow);
            Application.Run(mainWindow);
        }
    }
}