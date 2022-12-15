using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class controlMultipleRelays : Form
    {   
        bool isLeftOn = false;
        bool isRightOn = false;
        private const int RELEASE_SERVO_NUM = 12;
        public controlMultipleRelays()
        {
            InitializeComponent();
        }

        private void leftAll_Click(object sender, EventArgs e)
        {
            if (isLeftOn == true)
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1100, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }

        private void leftOne_Click(object sender, EventArgs e)
        {
            if (isLeftOn == true)
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1175, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }

        private void leftTwo_Click(object sender, EventArgs e)
        {
            if (isLeftOn == true)
            {
                try
                {

                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1250, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }

        private void leftThree_Click(object sender, EventArgs e)
        {
            if (isLeftOn == true)
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1325, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }

        private void leftFour_Click(object sender, EventArgs e)
        {
            if (isLeftOn == true)
            {
                try
                {

                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1400, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }

        private void leftFive_Click(object sender, EventArgs e)
        {
            if (isLeftOn == true)
            {
                try
                {

                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1475, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }

        private void rightAll_Click(object sender, EventArgs e)
        {
            if (isRightOn == true)
            {
                try
                {

                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1550, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }

        private void rightOne_Click(object sender, EventArgs e)
        {
            if (isRightOn == true)
            {
                try
                {

                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1625, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }

        private void rightTwo_Click(object sender, EventArgs e)
        {
            if (isRightOn == true)
            {
                try
                {

                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1700, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }

        private void rightThree_Click(object sender, EventArgs e)
        {
            if (isRightOn == true)
            {
                try
                {

                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1775, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }

        private void rightFour_Click(object sender, EventArgs e)
        {
            if (isRightOn == true)
            {
                try
                {

                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1850, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }

        private void rightFive_Click(object sender, EventArgs e)
        {
            if (isRightOn == true)
            {
                try
                {

                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1925, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI
                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }

        private void leftOn_CheckedChanged(object sender, EventArgs e)
        {
            isLeftOn= true;
        }

        private void rightOn_CheckedChanged(object sender, EventArgs e)
        {
            isRightOn= true;
        }

        private void leftOff_CheckedChanged(object sender, EventArgs e)
        {
            isLeftOn= false;
        }

        private void rightOff_CheckedChanged(object sender, EventArgs e)
        {
            isRightOn= false;
        }
    }
}
