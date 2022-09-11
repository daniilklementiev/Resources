namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var bmp = new Bitmap(WinFormsApp6.Properties.Resources.frog);
            pictureBox1.Image = bmp;
        }
    }
}