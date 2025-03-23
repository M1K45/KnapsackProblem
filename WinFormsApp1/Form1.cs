using lab_1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int numItems;
        int seed;
        int capacity;

        public Form1()
        {
            InitializeComponent();
            itemsNumberValidation.Hide();
            capacityValidate.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            numItems = Int32.Parse(itemsNumberBox.Text);
            capacity = Int32.Parse(capacityBox.Text);
            seed = Int32.Parse(seedBox.Text);

            if (numItems < 0)
            {
                itemsNumberBox.ForeColor = Color.Red;
                itemsNumberValidation.Show();
            }

            if (capacity < 0)
            {
                capacityBox.ForeColor = Color.Red;
                capacityValidate.Show();

            }

            Problem problem = new Problem(numItems, seed);

            instanceBox.Text = problem.ToString();
            resultBox.Text = problem.Solve(capacity).ToString();

        }

        private void itemsNumberBox_TextChanged(object sender, EventArgs e)
        {
            //if (Int32.Parse(itemsNumberBox.Text) < 0) {
            //    itemsNumberValidation.Show();
            //}
            //else itemsNumberValidation.Hide();

        }

        private void seedBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void capacityBox_TextChanged(object sender, EventArgs e)
        {
        }


    }
}
