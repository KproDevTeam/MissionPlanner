using System;
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

		public override string Name { get { return _Name; } }
		public override string Version { get { return _Version; } }
		public override string Author { get { return _Author; } }

		// SET THIS TO THE PWM VALUE YOU WANT TO COMMAND TO RELEASE PAYLOAD
		private const int RELEASE_PWM_VALUE = 1900;
		private const int RELEASE_SERVO_NUM = 12;
		// CHANGE THIS TO TRUE TO USE THIS PLUGIN
		public override bool Init() { return false; }

		public override bool Loaded()
		{
			MyButton but_release = new MyButton();
			ToolTip toolTip1 = new ToolTip();

			// Rename these .Text fields to any valid mode and the code will automatically work
			but_release.Text = "Release Payload";
			but_release.Location = new System.Drawing.Point(4, 4);
			but_release.Size = new System.Drawing.Size(75, 30);
			toolTip1.SetToolTip(but_release, "Releases Payload, requires confirmation");
			but_release.Click += new EventHandler(but_release_Click);

			// Increase the minimum size of the persistent panel. Not necessary, but adds a little
			// more gap between the buttons and the tabs.
			MainV2.instance.FlightData.panel_persistent.MinimumSize = new System.Drawing.Size(0, 40);

			// Add the buttons
			MainV2.instance.FlightData.panel_persistent.Controls.Add(but_release);

			return true;
		}

		public override bool Exit() { return true; }

		private void but_release_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("페이로드를 해제하시겠습니까? Are you sure you want to release the payload??",
								 "Confirm Release!!",
								 MessageBoxButtons.YesNo);
			if (confirmResult != DialogResult.Yes)
			{
				// do nothing
				return;
			}
			try
			{
				if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, RELEASE_PWM_VALUE, 0, 0,
					0, 0, 0))
				{
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
}