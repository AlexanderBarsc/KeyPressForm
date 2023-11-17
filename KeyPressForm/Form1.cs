namespace KeyPressForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event bude spusten jakmile dojde ke stisknuti klavesy kdyz je Form "vybran" na obrazovce.
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            // u000f je 15 = se stisknuti Ctrl + O
            if (e.KeyChar == '\u000f')
            {

                Label.Text = "Byla stisknuta klavesa Ctrl + O";

            }
            else
            {

                Label.Text = "Nebyla stisknuta klavesa Ctrl + O";

            }
       
        }
    }
}