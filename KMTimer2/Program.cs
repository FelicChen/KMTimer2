namespace KMTimer2
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var mutex = new Mutex(initiallyOwned: false, Application.ProductName, out var notOpen);
            if (notOpen)
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new KMTimer2());
            }
            mutex.Dispose();
        }
    }
}