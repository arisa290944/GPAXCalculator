namespace GPAXCalculator
{
    public partial class Form1 : Form
    {
        GPACalculater gpaCalculater = new GPACalculater();
        GPACalculater NCalculator = new GPACalculater();


        public Form1()
        {
            InitializeComponent();
        }

        //Add button
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //read textbox
            string input = this.textBoxInput.Text;
            // Convert string input to double
            double dInput = Convert.ToDouble(input);
            // Create obj
            gpaCalculater.setGPA(dInput);
            // get gpax from obj
            double gpax = gpaCalculater.getGPAx();
            //convert double to string
            this.textBoxOutput.Text = gpax.ToString();
            this.TxtGPASUM.Text = gpax.ToString();
            
        }

        //Show button
        private void buttonShow_Click(object sender, EventArgs e)
        {

        }
        // show N
        private void TxtN_TextChanged(object sender, EventArgs e)
        {

        }
        //show SUM
        private void TxtGPASUM_TextChanged(object sender, EventArgs e)
        {

        }

        //show Min
        private void TxtMin_TextChanged(object sender, EventArgs e)
        {

        }

        //show Max
        private void TxtMax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}