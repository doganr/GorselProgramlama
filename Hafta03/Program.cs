namespace Hafta03
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Form1 nesne = new Form1();
            //nesne.Text = "Deneme";
            //Application.Run(nesne);
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            Form2 nesne = new Form2();
            nesne.Text = "Ana Pencere";
            Application.Run(nesne);
        }
    }
}