using System;
using System.Windows.Forms;
using NotificationCenter;

namespace TestNotificationCenter
{
    public partial class Switch : UserControl
    {
        private bool m_switchOn;
        public Switch()
        {
            InitializeComponent();
        }
        private void SwitchOn()
        {
            m_switchOn = true;
            switchPictureBox.BackgroundImage = Properties.Resources.SwitchOn;
            NotificationCenterManager.Instance.PostNotification(@"SwitchIsON");
        }
        private void SwitchOff()
        {
            m_switchOn = false;
            switchPictureBox.BackgroundImage = Properties.Resources.SwitchOff;
            NotificationCenterManager.Instance.PostNotification(@"SwitchIsOFF");
        }

        private void SwitchPictureBoxClick(object p_sender, EventArgs p_e)
        {
            if (m_switchOn)
                SwitchOff();
            else
                SwitchOn();
        }
    }
}
