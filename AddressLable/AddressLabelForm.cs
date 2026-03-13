namespace AddressLable
{
    public partial class AddressLabelForm : Form
    {
        public AddressLabelForm()
        {
            InitializeComponent();
        }

        //Custom Methods below--------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            StreetTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            ZipTextBox.Text = "";

            Displaylabel.Text = "";
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            Displaylabel.Text = FirstNameTextBox.Text + " " +
                                LastNameTextBox.Text +
                         "\n" + StreetTextBox.Text +
                         "\n" + CityTextBox.Text + ", " + 
                                StateTextBox.Text + " " +
                                ZipTextBox.Text;
        }

        private void ValidateFields()
        {

        }
        
    }
}
