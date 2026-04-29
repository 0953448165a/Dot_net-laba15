using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            int k = listBox1.Items.Count;
            listBox1.Text = k.ToString();
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            Type t = listBox1.Items.GetType();
            listBox1.Text = t.ToString();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int index = listBox1.Items.IndexOf(listBox1.Text);
            listBox1.Text = index.ToString();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(1, "Новий елемент");
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Text);
        }

        private void buttonRemoveAt_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonContains_Click(object sender, EventArgs e)
        {
            bool exists = listBox1.Items.Contains(listBox1.Text);
            listBox1.Text = exists.ToString();
        }

        private void buttonAddRange_Click(object sender, EventArgs e)
        {
            string[] arr = { "Буря", "Тартар", "Артист", "Співак" };
            listBox1.Items.AddRange(arr);
        }
    }
}
