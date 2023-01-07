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
        //int leftButtonState[5] = { 0, 0, 0, 0, 0 };// error
        int[] arr00000 = new int[5] { 0, 0, 0, 0, 0 };
        int[] arr00001 = new int[5] { 0, 0, 0, 0, 1 };
        int[] arr00010 = new int[5] { 0, 0, 0, 1, 0 };
        int[] arr00011 = new int[5] { 0, 0, 0, 1, 1 };
        int[] arr00100 = new int[5] { 0, 0, 1, 0, 0 };
        int[] arr00101 = new int[5] { 0, 0, 1, 0, 1 };
        int[] arr00110 = new int[5] { 0, 0, 1, 1, 0 };
        int[] arr00111 = new int[5] { 0, 0, 1, 1, 1 };
        int[] arr01000 = new int[5] { 0, 1, 0, 0, 0 };
        int[] arr01001 = new int[5] { 1, 0, 0, 0, 1 };
        
        int[] arr01010 = new int[5] { 0, 1, 0, 1, 0 };
        int[] arr01011 = new int[5] { 0, 1, 0, 1, 1 };
        int[] arr01100 = new int[5] { 0, 1, 1, 0, 0 };
        int[] arr01101 = new int[5] { 0, 1, 1, 0, 1 };
        int[] arr01110 = new int[5] { 0, 1, 1, 1, 0 };
        int[] arr01111 = new int[5] { 0, 1, 1, 1, 1 };
        int[] arr10000 = new int[5] { 1, 0, 0, 0, 0 };
        int[] arr10001 = new int[5] { 1, 0, 0, 0, 1 };
        int[] arr10010 = new int[5] { 1, 0, 0, 1, 0 };
        int[] arr10011 = new int[5] { 1, 0, 0, 1, 1 };

        int[] arr10100 = new int[5] { 1, 0, 1, 0, 0 };
        int[] arr10101 = new int[5] { 1, 0, 1, 0, 1 };
        int[] arr10110 = new int[5] { 1, 0, 1, 1, 0 };
        int[] arr10111 = new int[5] { 1, 0, 1, 1, 1 };
        int[] arr11000 = new int[5] { 1, 1, 0, 0, 0 };
        int[] arr11001 = new int[5] { 1, 1, 0, 0, 1 };
        int[] arr11010 = new int[5] { 1, 1, 0, 1, 0 };
        int[] arr11011 = new int[5] { 1, 1, 0, 1, 1 };
        int[] arr11100 = new int[5] { 1, 1, 1, 0, 0 };
        int[] arr11101 = new int[5] { 1, 1, 1, 0, 1 };

        int[] arr11110 = new int[5] { 1, 1, 1, 1, 0 };
        int[] arr11111 = new int[5] { 1, 1, 1, 1, 1 };


        public static bool checkEquality<T>(T[] first, T[] second)
        {
            return Enumerable.SequenceEqual(first, second);
        }

        int PWM = 0;
        int[] leftButtonState = new int[5] { 0, 0, 0, 0, 0 };
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

        void checkBulletBalance()
        {
            if (0 == cntLeftBullets)
            {
                leftAll.Text = "All fired";
                isLeft_All_Fired = true;
            }
            else if ( 5 == cntLeftBullets)
            {
                leftAll.Text = "Select All";
                isLeft_All_Fired = false;
            }

            if (0 == cntRightBullets)
            {
                rightAll.Text = "All fired";
                isRight_All_Fired = true;
            }
            else if (5 == cntRightBullets)
            {
                rightAll.Text = "Select All";
                isRight_All_Fired = false;
            }
        }

        void buttonStateUpdate(string _time)
        {   
            // Left Button update
            if(_time == "After Launch")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (1 == leftButtonState[i]) // ready -> fired
                    {
                        //cntLeftBullets--;
                        //checkBulletBalance();
                        leftButtonState[i] = 2;
                        if (0 == i) { leftOne.Text = "fired"; }
                        if (1 == i) { leftTwo.Text = "fired"; }
                        if (2 == i) { leftThree.Text = "fired"; }
                        if (3 == i) { leftFour.Text = "fired"; }
                        if (4 == i) { leftFive.Text = "fired"; }
                    }
                }
                return;
            }

            else if (_time == "After Reset")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (2 == leftButtonState[i]) // fired -> 1,2,3,4,5
                    {
                        leftButtonState[i] = 0;
                        if (0 == i) { leftOne.Text = "1"; }
                        if (1 == i) { leftTwo.Text = "2"; }
                        if (2 == i) { leftThree.Text = "3"; }
                        if (3 == i) { leftFour.Text = "4"; }
                        if (4 == i) { leftFive.Text = "5"; }
                    }
                    
                }
                return;
            }
         
            //  Rigth Button Update
            
        }

        void sendPWMtoFC(int _pwm)
        {
            try
            {
                if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, _pwm, 0, 0,
                    0, 0, 0))
                {
                    /*
                    leftTwo.Text = "fired";
                    isLeft_2_Fired = true;
                    cntLeftBullets--;
                    checkBulletBalance();
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
            if (0==leftButtonState[0]) // button is not pushed yet
            {
                // button pushed and locked
                //ready to fire
                leftButtonState[0] = 1;
                leftOne.Text = "Ready";
                return;

            }
            else if (1 == leftButtonState[0]) // button is pushed already
            {
                // release
                leftButtonState[0] = 0;
                leftOne.Text = "1";
                return;
            }       
        }

        private void leftTwo_Click(object sender, EventArgs e)
        {
            if (0 == leftButtonState[1]) // button is not pushed yet
            {
                // button pushed and locked
                // ready to fire
                leftButtonState[1] = 1;
                leftTwo.Text = "Ready";
                return;

            }
            else if (1 == leftButtonState[1]) // button is pushed already
            {
                // release
                leftButtonState[1] = 0; 
                leftTwo.Text = "2";
                return;
            }
        }

        private void leftThree_Click(object sender, EventArgs e)
        {
            if (0 == leftButtonState[2]) // button is not pushed yet
            {
                // button pushed and locked
                //ready to fire
                leftButtonState[2] = 1;
                leftThree.Text = "Ready";
                return;

            }
            else if (1 == leftButtonState[2]) // button is pushed already
            {
                // release
                leftButtonState[2] = 0;
                leftThree.Text = "3";
                return;
            }
        }

        private void leftFour_Click(object sender, EventArgs e)
        {
            if (0 == leftButtonState[3]) // button is not pushed yet
            {
                // button pushed and locked
                //ready to fire
                leftButtonState[3] = 1;
                leftFour.Text = "Ready";
                return;

            }
            else if (1 == leftButtonState[3]) // button is pushed already
            {
                // release
                leftButtonState[3] = 0;
                leftFour.Text = "4";
                return;
            }
        }

        private void leftFive_Click(object sender, EventArgs e)
        {
            if (0 == leftButtonState[4]) // button is not pushed yet
            {
                // button pushed and locked
                //ready to fire
                leftButtonState[4] = 1;
                leftFive.Text = "Ready";
                return;

            }
            else if (1 == leftButtonState[4]) // button is pushed already
            {
                // release
                leftButtonState[4] = 0;
                leftFive.Text = "5";
                return;
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

        // Left Side Final launch Button
        // Luanch all ready to fire bullets
        private void leftOn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isLeftOn) 
            {
                isLeftOn = true;

                if      (checkEquality(arr00000, leftButtonState)) PWM = 1000;
                else if (checkEquality(arr00001, leftButtonState)) PWM = 1015;
                else if (checkEquality(arr00010, leftButtonState)) PWM = 1030;
                else if (checkEquality(arr00011, leftButtonState)) PWM = 1045;
                else if (checkEquality(arr00100, leftButtonState)) PWM = 1060;
                else if (checkEquality(arr00101, leftButtonState)) PWM = 1075;
                else if (checkEquality(arr00110, leftButtonState)) PWM = 1090;
                else if (checkEquality(arr00111, leftButtonState)) PWM = 1105;
                else if (checkEquality(arr01000, leftButtonState)) PWM = 1120;
                else if (checkEquality(arr01001, leftButtonState)) PWM = 1135;

                else if (checkEquality(arr01010, leftButtonState)) PWM = 1150;
                else if (checkEquality(arr01011, leftButtonState)) PWM = 1165;
                else if (checkEquality(arr01100, leftButtonState)) PWM = 1180;
                else if (checkEquality(arr01101, leftButtonState)) PWM = 1195;
                else if (checkEquality(arr01110, leftButtonState)) PWM = 1210;
                else if (checkEquality(arr01111, leftButtonState)) PWM = 1225;
                else if (checkEquality(arr10000, leftButtonState)) PWM = 1240;
                else if (checkEquality(arr10001, leftButtonState)) PWM = 1255;
                else if (checkEquality(arr10010, leftButtonState)) PWM = 1270;
                else if (checkEquality(arr10011, leftButtonState)) PWM = 1285;

                else if (checkEquality(arr10100, leftButtonState)) PWM = 1300;
                else if (checkEquality(arr10101, leftButtonState)) PWM = 1315;
                else if (checkEquality(arr10110, leftButtonState)) PWM = 1330;
                else if (checkEquality(arr10111, leftButtonState)) PWM = 1345;
                else if (checkEquality(arr11000, leftButtonState)) PWM = 1360;
                else if (checkEquality(arr11001, leftButtonState)) PWM = 1375;
                else if (checkEquality(arr11010, leftButtonState)) PWM = 1390;
                else if (checkEquality(arr11011, leftButtonState)) PWM = 1405;
                else if (checkEquality(arr11100, leftButtonState)) PWM = 1420;
                else if (checkEquality(arr11101, leftButtonState) ) PWM = 1435;

                else if (checkEquality(arr11110, leftButtonState)) PWM = 1450;
                else if (checkEquality(arr11111, leftButtonState)) PWM = 1465;

                sendPWMtoFC(PWM);

                buttonStateUpdate("After Launch");
            }
        }

        private void rightOn_CheckedChanged(object sender, EventArgs e)
        {
            isRightOn= true;
        }


        //  Reset ------------------------------------------------------------------
        private void leftOff_CheckedChanged(object sender, EventArgs e)
        {
            if (isLeftOn)
            {
                isLeftOn = false;
                cntLeftBullets = 5;
                checkBulletBalance();

                sendPWMtoFC(1000);
                buttonStateUpdate("After Reset");
                //ToDo: Disable all left side fire button(ex: buton color change to gray..)
            }
            
        }

        private void rightOff_CheckedChanged(object sender, EventArgs e)
        {
            if (isRightOn)
            {
                isRightOn = false;
                cntRightBullets = 5;
                checkBulletBalance();

                sendPWMtoFC(1500);
                buttonStateUpdate("After Reset");


                //ToDo: Disable all right side fire button(ex: buton color change to gray..)
            }
        }
    }
}
