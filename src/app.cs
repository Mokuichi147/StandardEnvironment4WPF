using System;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;


namespace MyApp
{
    public class App
    {
        [STAThread]
        public static void Main()
        {
            Window window = null;
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("app.xaml");
            window = (Window)XamlReader.Load(stream);

            /*using (var fs = new FileStream("ruiesources/app.xaml", FileMode.Open, FileAccess.Read))
            {
                window = (Window)XamlReader.Load(stream);
            }*/

            window.Title = "Standard environment for WPF";
            window.ShowDialog();
        }
    }
}