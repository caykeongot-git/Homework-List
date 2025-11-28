namespace Day_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtLastName.Text);
            item.SubItems.Add(txtFirstName.Text);
            item.SubItems.Add(txtPhone.Text);

            lvInformation.Items.Add(item);
        }

        private void lvInformation_Click(object sender, EventArgs e)
        {
            txtLastName.Text = lvInformation.SelectedItems[0].SubItems[0].Text;
            txtFirstName.Text = lvInformation.SelectedItems[0].SubItems[1].Text;
            txtPhone.Text = lvInformation.SelectedItems[0].SubItems[2].Text;

        }

        private void fileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files (*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string[] line = File.ReadAllLines(open.FileName);
                foreach (string x in line)
                {
                    string[] data = x.Split('|');

                    string lastName = data.Length > 0 ? data[0].Trim() : "";
                    string firstName = data.Length > 1 ? data[1].Trim() : "";
                    string phone = data.Length > 2 ? data[2].Trim() : "";

                    ListViewItem item = new ListViewItem(lastName);
                    item.SubItems.Add(firstName);
                    item.SubItems.Add(phone);

                    lvInformation.Items.Add(item);

                }
            }
        }




        private void viewDetails_Click(object sender, EventArgs e)
        {
            lvInformation.View = View.Details;
        }

        private void formatGridLines_Click(object sender, EventArgs e)
        {
            lvInformation.GridLines = true;
        }



        private void sortLastName_Click(object sender, EventArgs e)
        {

            lvInformation.ListViewItemSorter = new ListViewItemComparer(0);
            lvInformation.Sort();
        }

        private void firstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvInformation.ListViewItemSorter = new ListViewItemComparer(1);
            lvInformation.Sort();
        }
    }
}
