namespace Pogodynka
{
    public partial class MainWindow : Form
    {
        public event EventHandler? CapitalChanged;
        public event EventHandler? CityChanged;
        public string SelectedCity { get => capitalCbx.SelectedItem?.ToString() ?? ""; }
        public int SetCapitalIndex
        {
            set
            {
                if (value >= -1 && value < capitalCbx.Items.Count)
                {
                    capitalCbx.SelectedIndex = value;
                }
            }
        }
        public string Temperature { set => TempLbl.Text = value; }
        public string Humidity { set => HumidLbl.Text = value; }
        public string Pressure { set => PressureLbl.Text = value; }
        public string City { get => cityTbx.Text; set { cityTbx.Text = value; } }
        public string Description { set => DescriptionLbl.Text = value; }
        public string CityLabel { set => cityLbl.Text = value; }
        public string IconUrl
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    iconPbx.LoadAsync(value);
                }
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void capitalCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapitalChanged?.Invoke(this, EventArgs.Empty);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            CityChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
