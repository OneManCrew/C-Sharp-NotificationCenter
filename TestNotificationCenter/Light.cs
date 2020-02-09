using System.Windows.Forms;
using NotificationCenter;

namespace TestNotificationCenter
{
    public partial class Light : UserControl
    {
        public Light()
        {
            InitializeComponent();
            NotificationCenterManager.Instance.AddObserver(OnSwitchIsOn, @"SwitchIsON");
            NotificationCenterManager.Instance.AddObserver(OnSwitchIsOff, @"SwitchIsOFF");
        }

        private void OnSwitchIsOff(object p_object)
        {
            Off();
        }

        private void OnSwitchIsOn(object p_object)
        {
            On();
        }

        private void On()
        {
            ligthPictureBox.BackgroundImage = Properties.Resources.light_on;
        }

        private void Off()
        {
            ligthPictureBox.BackgroundImage = Properties.Resources.light_off;
        }

        public void OnAppClosed()
        {
            NotificationCenterManager.Instance.RemoveObserver(OnSwitchIsOn, @"SwitchIsON");
            NotificationCenterManager.Instance.RemoveObserver(OnSwitchIsOff, @"SwitchIsOFF");
        }

    }
}
