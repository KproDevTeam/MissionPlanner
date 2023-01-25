using System;
using System.Threading;
using System.Windows.Forms;
using MissionPlanner;
using MissionPlanner.Plugin;
using MissionPlanner.Controls;

namespace PersistentSimpleActions
{
	public class PersistentSimpleActions : Plugin
	{
		private string _Name = "Payload Release Button";
		private string _Version = "0.1";
		private string _Author = "Bob Long";

        MyButton but_release1;


        public override string Name { get { return _Name; } }
		public override string Version { get { return _Version; } }
		public override string Author { get { return _Author; } }

        // SET THIS TO THE PWM VALUE YOU WANT TO COMMAND TO RELEASE PAYLOAD
        // 1100: Grab,  1900: Release
        int pwmValue = 1100;
        private const int RELEASE_SERVO_NUM = 12;
		bool isReleased = false;

		// CHANGE THIS TO TRUE TO USE THIS PLUGIN
		public override bool Init() { return true; }

		public override bool Loaded()
		{
			but_release1 = new MyButton();
			ToolTip toolTip1 = new ToolTip();

            but_release1.Text = "화물 투하 \n (Release Payload)";
			but_release1.Location = new System.Drawing.Point(4, 4);
			but_release1.Size = new System.Drawing.Size(150, 30);
			toolTip1.SetToolTip(but_release1, "Releases Payload, requires confirmation");
			but_release1.Click += new EventHandler(but1_release_Click);


            // Increase the minimum size of the persistent panel. Not necessary, but adds a little
            // more gap between the buttons and the tabs.
            MainV2.instance.FlightData.panel_persistent.MinimumSize = new System.Drawing.Size(0, 40);

			// Add the buttons
			MainV2.instance.FlightData.panel_persistent.Controls.Add(but_release1);

            return true;
		}

		public override bool Exit() { return true; }


		private void but1_release_Click(object sender, EventArgs e)
		{
            var confirmResult = MessageBox.Show("화물을 투하 하겠습니까? \n Are you sure you want to drop the cargo?",
                "Confirm Release!!", MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes)
			{
                // do nothing
                return;
            }
			try
			{
                // send release signal
                if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1900, 0, 0,
					0, 0, 0))
				{
                    Thread.Sleep(500);
                    // send grab signal
                    MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, 1100, 0, 0,
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

        private void but2_release_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("하물을 고정하겠습니까? Are you sure you want to grab the payload??",
                                 "Confirm Release!!",
                                 MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
            {
                // do nothing
                return;
            }
            try
            {
                if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, pwmValue, 0, 0,
                    0, 0, 0))
                {
                    //RELEASE_STATUS = false;
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
}