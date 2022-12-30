using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // for Sleep

namespace MissionPlanner
{
    public partial class controlMultipleRelays : Form
    {   
        bool isLeftOn = false; // failsafe lever switch
        bool isLeft_1_Ready = true;
        bool isLeft_2_Ready = true;
        bool isLeft_3_Ready = true;
        bool isLeft_4_Ready = true;
        bool isLeft_5_Ready = true;
        bool isLeft_All_Ready = true;

        bool isRightOn = false;// failsafe lever switch

        private const int RELEASE_SERVO_NUM = 12;
        public controlMultipleRelays()
        {
            InitializeComponent();
        }

        //--------------------- Left Side ------------------------
        private void leftAll_Click(object sender, EventArgs e)
        {
            if ( isLeftOn ) // fail safe lever switch
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1100, 0, 0,
                        0, 0, 0))
                    {
                        // TODO: change the button color or give some indication of success on the UI
                        leftOne.Text = "fired";
                        isLeft_1_Ready = false;

                        leftTwo.Text = "fired";
                        isLeft_2_Ready = false;

                        leftThree.Text = "fired";
                        isLeft_3_Ready = false;

                        leftFour.Text = "fired";
                        isLeft_4_Ready = false;

                        leftFive.Text = "fired";
                        isLeft_5_Ready = false;

                        leftAll.Text = "All fired";
                        isLeft_All_Ready = false;

                    /*
                        // send a relay reset signal to FC->Arduino
                        // or
                        // do not send any signal . Arduino itself do the process: relay off
                        Thread.Sleep(5000);
                        MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1000, 0, 0,
                        0, 0, 0);
                        leftOne.Text = "1";
                        isLeft_1_Ready = true;

                        leftTwo.Text = "2";
                        isLeft_2_Ready = true;

                        leftThree.Text = "3";
                        isLeft_3_Ready = true;

                        leftFour.Text = "4";
                        isLeft_4_Ready = true;

                        leftFive.Text = "5";
                        isLeft_5_Ready = true;

                        leftAll.Text = "All at once";
                        isLeft_All_Ready = true;
                    */

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
            if ( isLeftOn ) // fail safe lever switch
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1175, 0, 0,
                        0, 0, 0))
                    {
                        // TODO: change the button color or give some indication of success on the UI
                        leftOne.Text = "fired";
                        isLeft_1_Ready = false;
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
            if ( isLeftOn )// fail safe lever switch
            {
                try
                {

                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1250, 0, 0,
                        0, 0, 0))
                    {
                        // TODO: change the button color or give some indication of success on the UI
                        leftTwo.Text = "fired";
                        isLeft_2_Ready = false;
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
            if ( isLeftOn )// fail safe lever switch
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1325, 0, 0,
                        0, 0, 0))
                    {
                        leftThree.Text = "fired";
                        isLeft_3_Ready = false;
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
            if ( isLeftOn ) // fail safe lever switch
            {
                try
                {

                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1400, 0, 0,
                        0, 0, 0))
                    {
                        leftFour.Text = "fired";
                        isLeft_4_Ready = false;
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
                        leftFive.Text = "fired";
                        isLeft_5_Ready = false;
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

        //----------------------- Right Side ----------------------
        private void rightAll_Click(object sender, EventArgs e)
        {
            if ( isRightOn ) // fail safe lever switch
            {
                try
                {

                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1550, 0, 0,
                        0, 0, 0))
                    {
                        //RELEASE_STATUS = true;
                        // Do nothing.
                        // TODO: change the button color or give some indication of success on the UI


                        Thread.Sleep(1000);
                        MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1000, 0, 0,
                        0, 0, 0);
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
            if ( isRightOn ) // fail safe lever switch
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
            if ( isRightOn) // fail safe lever switch
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
            if ( isRightOn) // fail safe lever switch
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
            if (isRightOn) // fail safe lever switch
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
            if (isRightOn)// fail safe lever switch
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

        // Fail Safe Lever Switch
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
