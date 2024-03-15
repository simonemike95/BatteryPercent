namespace BatteryPercent
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            loadProperties();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            // Save values to properties
            applyChangesToProperties();

            // Recreate the form with new parameters
            Program.instance.reloadFromProperties();
            this.Close();
        }

        private void loadProperties()
        {
            Properties.Settings props = Properties.Settings.Default;

            // Background
            this.checkBoxAutoBackgroundColor.Checked = props.AutoBackgroundColor;
            this.textBoxBackgroundColor.Text = props.BackgroundColor;

            // Text and Font
            this.checkBoxAutoTextColor.Checked = props.AutomaticTextColor;
            this.textBoxTextColor.Text = props.TextColor;

            // Clock Settings
            this.checkBoxShowClock.Checked = props.ShowClock;
            this.checkBoxClockFormat.Checked = props.ShowClockFormat;

            // Battery Settings
            this.checkBoxBatteryPercentage.Checked = props.ShowBatteryPercent;
            this.checkBoxBatteryTime.Checked = props.ShowBatteryTime;

            // TODO: Implement sliders
        }

        private void applyChangesToProperties()
        {
            Properties.Settings props = Properties.Settings.Default;

            // Background
            props.AutoBackgroundColor = this.checkBoxAutoBackgroundColor.Checked;
            props.BackgroundColor = this.textBoxBackgroundColor.Text;

            // Text and Font
            props.AutomaticTextColor = this.checkBoxAutoTextColor.Checked;
            props.TextColor = this.textBoxTextColor.Text;

            // Clock Settings
            props.ShowClock = this.checkBoxShowClock.Checked;
            props.ShowClockFormat = this.checkBoxClockFormat.Checked;

            // Battery Settings
            props.ShowBatteryPercent = this.checkBoxBatteryPercentage.Checked;
            props.ShowBatteryTime = this.checkBoxBatteryTime.Checked;

            // TODO: Implement sliders
        }
    }
}
