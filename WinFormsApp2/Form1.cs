using System.Net.NetworkInformation;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void moveButton(Button btn)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            moveButton(btn);
            Random rnd = new Random();
            int formWidth = this.Width;
            int formHeight = this.Height;
            int maxLeft = formWidth - btn.Width;
            int maxTop = formHeight - btn.Height;

            Point p = new Point(rnd.Next(maxLeft), rnd.Next(maxTop));

            btn.Text = "Skibidi Sigma";
            btn.Location = p;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
