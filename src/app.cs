using System;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;


[assembly: AssemblyTitle("Standard environment for WPF")]
[assembly: AssemblyProduct("Windows標準環境で作成したWPFアプリ")]
[assembly: AssemblyVersion("0.1.0.0")]
[assembly: AssemblyCopyright("Copyright (c) 2023 mokuichi147")]


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