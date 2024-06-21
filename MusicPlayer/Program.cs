using Dark.Net;
namespace MusicPlayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Form mainForm = new Form1();
            DarkNet.Instance.SetWindowThemeForms(mainForm, Theme.Dark, new ThemeOptions
            {
                TitleBarTextColor = Color.Empty,
                TitleBarBackgroundColor = Color.Black,
                WindowBorderColor = Color.DarkOrange
            });
            Application.Run(mainForm);
        }
    }
}