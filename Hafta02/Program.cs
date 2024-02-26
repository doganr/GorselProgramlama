namespace Hafta02
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
            Application.Run(new Form1());

            //Form pencere = new Form();
            //pencere.Text = "Ýlk Windows Form Uygulamam";
            //pencere.Width = 800;
            //pencere.Height = 300;
            ////nesne.Show();
            ////Thread.Sleep(5000);

            //Button buton1 = new Button();
            //buton1.Text = "Týkla";
            //buton1.Location = new Point(100, 20);

            //pencere.Controls.Add(buton1);

            //Application.Run(pencere);
        }
    }
}