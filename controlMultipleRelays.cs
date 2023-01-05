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
        bool isLeft_1_Fired = false;
        bool isLeft_2_Fired = false;
        bool isLeft_3_Fired = false;
        bool isLeft_4_Fired = false;
        bool isLeft_5_Fired = false;
        bool isLeft_All_Fired = false;
        int cntLeftBullets = 5;

        bool isRightOn = false;// failsafe lever switch
        bool isRight_1_Fired = false;
        bool isRight_2_Fired = false;
        bool isRight_3_Fired = false;
        bool isRight_4_Fired = false;
        bool isRight_5_Fired = false;
        bool isRight_All_Fired = false;
        int cntRightBullets = 5;

        private const int RELEASE_SERVO_NUM = 12;
        public controlMultipleRelays()
        {
            InitializeComponent();

            this.ControlBox = false; // disable close button
            /*
            https://social.msdn.microsoft.com/Forums/en-US/b1f0d913-c603-43e9-8fe3-681fb7286d4c/c-disable-close-button-on-windows-form-application?forum=csharpgeneral
            */
        }

        void ReloadBullet()
        {
            //Thread.Sleep(1000);
            MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1000, 0, 0,
            0, 0, 0);
        }

        void checkBulletBalance()
        {
            if (0 == cntLeftBullets)
            {
                leftAll.Text = "All fired";
                isLeft_All_Fired = true;
            }
            else if ( 5 == cntLeftBullets)
            {
                leftAll.Text = "Fire All at once";
                isLeft_All_Fired = false;
            }

            if (0 == cntRightBullets)
            {
                rightAll.Text = "All fired";
                isRight_All_Fired = true;
            }
            else if (5 == cntRightBullets)
            {
                rightAll.Text = "Fire All at once";
                isRight_All_Fired = false;
            }
        }

        // TODO: change the button color 
        //--------------------- Left Side (push rock switch) ------------------------
        private void leftAll_Click(object sender, EventArgs e)
        {
            if ( isLeftOn ) // fail safe lever switch
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1100, 0, 0,
                        0, 0, 0))
                    {
                        // TODO: change the button color
                        leftOne.Text = "fired";
                        isLeft_1_Fired = true;

                        leftTwo.Text = "fired";
                        isLeft_2_Fired = true;

                        leftThree.Text = "fired";
                        isLeft_3_Fired = true;

                        leftFour.Text = "fired";
                        isLeft_4_Fired = true;

                        leftFive.Text = "fired";
                        isLeft_5_Fired = true;

                        cntLeftBullets = 0;
                        checkBulletBalance();
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
            if (isLeft_1_Fired) // reload manually
            {
                // color chnage to green
               //leftOne.BackColor = Color.DarkGreen;
                leftOne.Text = "1";
                isLeft_1_Fired = false;
                cntLeftBullets++;
                checkBulletBalance();
                return;
            }

            if ( !isLeft_1_Fired && isLeftOn ) // fire
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1175, 0, 0,
                        0, 0, 0))
                    {
                        // TODO: change the button color to Gray or red
                        leftOne.Text = "fired";
                        leftOne.UseVisualStyleBackColor = false;
                        leftOne.BackColor = Color.Red;
                        
                        isLeft_1_Fired = true;
                        cntLeftBullets--;
                        checkBulletBalance();
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
            if (isLeft_2_Fired) // reload manually
            {
                leftTwo.Text = "2";
                isLeft_2_Fired = false;
                cntLeftBullets++;
                checkBulletBalance();
                // color chnage to green
                return;
            }

            if ( !isLeft_2_Fired && isLeftOn)// Fire
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1250, 0, 0,
                        0, 0, 0))
                    {
                        // TODO: change the button color 
                        leftTwo.Text = "fired";
                        isLeft_2_Fired = true;
                        cntLeftBullets--;
                        checkBulletBalance();
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
            if (isLeft_3_Fired) // reload manually
            {
                leftThree.Text = "3";
                isLeft_3_Fired = false;
                cntLeftBullets++;
                checkBulletBalance();
                // color chnage to green
                return;
            }

            if ( !isLeft_3_Fired && isLeftOn)// Fire
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1325, 0, 0,
                        0, 0, 0))
                    {
                        leftThree.Text = "fired";
                        isLeft_3_Fired = true;
                        cntLeftBullets--;
                        checkBulletBalance();
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
            if (isLeft_4_Fired) // reload manually
            {
                leftFour.Text = "4";
                isLeft_4_Fired = false;
                cntLeftBullets++;
                checkBulletBalance();
                // color chnage to green
                return;
            }

            if ( !isLeft_4_Fired && isLeftOn) // Fire
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1400, 0, 0,
                        0, 0, 0))
                    {
                        leftFour.Text = "fired";
                        isLeft_4_Fired = true;
                        cntLeftBullets--;
                        checkBulletBalance();
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
            if (isLeft_5_Fired) // reload manually
            {
                leftFive.Text = "5";
                isLeft_5_Fired = false;
                cntLeftBullets++;
                checkBulletBalance();
                // color chnage to green
                return;
            }

            if ( !isLeft_5_Fired && isLeftOn == true) // Fire
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1475, 0, 0,
                        0, 0, 0))
                    {
                        leftFive.Text = "fired";
                        isLeft_5_Fired = true;
                        cntLeftBullets--;
                        checkBulletBalance();
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

                        // TODO: change the button color
                        rightOne.Text = "fired";
                        isRight_1_Fired = true;

                        rightTwo.Text = "fired";
                        isRight_2_Fired = true;

                        rightThree.Text = "fired";
                        isRight_3_Fired = true;

                        rightFour.Text = "fired";
                        isRight_4_Fired = true;

                        rightFive.Text = "fired";
                        isRight_5_Fired = true;

                        cntRightBullets = 0;
                        checkBulletBalance();
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
            if (isRight_1_Fired) // reload manually
            {
                rightOne.Text = "1";
                isRight_1_Fired = false;
                cntRightBullets++;
                checkBulletBalance();
                // color chnage to green
                return;
            }

            if ( !isRight_1_Fired && isRightOn) // Fire
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1625, 0, 0,
                        0, 0, 0))
                    {
                        rightOne.Text = "fired";
                        isRight_1_Fired = true;
                        cntRightBullets--;
                        checkBulletBalance();
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
            if (isRight_2_Fired) // reload manually
            {
                rightTwo.Text = "2";
                isRight_2_Fired = false;
                cntRightBullets++;
                checkBulletBalance();
                // color chnage to green
                return;
            }

            if ( !isRight_2_Fired && isRightOn) // fail safe lever switch
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1700, 0, 0,
                        0, 0, 0))
                    {
                        rightTwo.Text = "fired";
                        isRight_2_Fired = true;
                        cntRightBullets--;
                        checkBulletBalance();
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
            if (isRight_3_Fired) // reload manually
            {
                rightThree.Text = "3";
                isRight_3_Fired = false;
                cntRightBullets++;
                checkBulletBalance();
                // color chnage to green
                return;
            }

            if ( !isRight_3_Fired && isRightOn) // Fire
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1775, 0, 0,
                        0, 0, 0))
                    {
                        rightThree.Text = "fired";
                        isRight_3_Fired = true;
                        cntRightBullets--;
                        checkBulletBalance();
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
            if (isRight_4_Fired) // reload manually
            {
                rightFour.Text = "4";
                isRight_4_Fired = false;
                cntRightBullets++;
                checkBulletBalance();
                // color chnage to green
                return;
            }
            if (!isRight_4_Fired && isRightOn) // fail safe lever switch
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1850, 0, 0,
                        0, 0, 0))
                    {
                        rightFour.Text = "fired";
                        isRight_4_Fired = true;
                        cntRightBullets--;
                        checkBulletBalance();
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
            if (isRight_5_Fired) // reload manually
            {
                rightFive.Text = "5";
                isRight_5_Fired = false;
                cntRightBullets++;
                checkBulletBalance();
                // color chnage to green
                return;
            }

            if (!isRight_5_Fired && isRightOn)// fail safe lever switch
            {
                try
                {
                    if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1925, 0, 0,
                        0, 0, 0))
                    {
                        rightFive.Text = "fired";
                        isRight_5_Fired = true;
                        cntRightBullets--;
                        checkBulletBalance();
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
            if (isLeftOn)
            {
                isLeftOn = false;
                ReloadBullet();
            }
            
        }

        private void rightOff_CheckedChanged(object sender, EventArgs e)
        {
            if (isRightOn)
            {
                isRightOn = false;
                ReloadBullet();
            }
            
        }
    }
}
