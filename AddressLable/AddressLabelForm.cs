namespace AddressLable
{
    public partial class AddressLabelForm : Form
    {
        public AddressLabelForm()
        {
            InitializeComponent();
        }

        //Custom Methods below---------------------------------------------

        //Closes program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Empties fields
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

        //Display wont print if there is nothing in any of the fieldss
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Displaylabel.Text = FirstNameTextBox.Text + " " +
                                LastNameTextBox.Text +
                         "\n" + StreetTextBox.Text +
                         "\n" + CityTextBox.Text + ", " +
                                StateTextBox.Text + " " +
                                ZipTextBox.Text;
            }            
        }


        //Checks for content in the fields
        private bool ValidateFields()
        {
            if (FirstNameTextBox.Text != "" &  LastNameTextBox.Text != "" &  CityTextBox.Text != "" & StateTextBox.Text != "" &  ZipTextBox.Text != "" &  StreetTextBox.Text != "" )
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
    }
}
