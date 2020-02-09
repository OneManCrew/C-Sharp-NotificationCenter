using System.Windows.Forms;
using NotificationCenter;

namespace TestNotificationCenter
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            NotificationCenterManager.Instance.AddObserver(OnSwitchIsOn, @"SwitchIsON");
            NotificationCenterManager.Instance.AddObserver(OnSwitchIsOff, @"SwitchIsOFF");
        }

        private void OnSwitchIsOff(Notification p_notification)
        {
            statuslabel.Text = @"Ligths OFF";
        }

        private void OnSwitchIsOn(Notification p_notification)
        {
            statuslabel.Text = @"Ligths ON";
        }

        private void MainScreenFormClosed(object p_sender, FormClosedEventArgs p_e)
        {
            NotificationCenterManager.Instance.RemoveObserver(OnSwitchIsOn, @"SwitchIsON");
            NotificationCenterManager.Instance.RemoveObserver(OnSwitchIsOff, @"SwitchIsOFF");
            light1.OnAppClosed();
            light2.OnAppClosed();
            light3.OnAppClosed();
        }
    }
}
