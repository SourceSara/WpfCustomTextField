using System.Diagnostics;
using System.Windows.Input;

namespace WpfSandbox
{
    public partial class MainWindow
    {
        public MainWindow()
            => InitializeComponent();

        private void OnAmRoLogoPreviewMouseDown(object sender, MouseButtonEventArgs e)
            => Process.Start(new ProcessStartInfo("https://github.com/AmRo045") { UseShellExecute = true });
    }
}
