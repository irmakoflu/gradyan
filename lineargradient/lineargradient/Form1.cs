namespace lineargradient
{
    using System.Drawing;
    using System.Drawing.Drawing2D;

    public partial class Form1 : Form
    {
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            LinearGradientBrush lineargradientbrush = new LinearGradientBrush(new Point(0, 0), new Point(bitmap.Width, 0), Color.FromArgb(50,42,198,76),Color.FromArgb(50,189,54,89));

            gr.FillRectangle(lineargradientbrush,new Rectangle(0,0,bitmap.Width,bitmap.Height));
            pictureBox1.Image = bitmap;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush solidBrush= new SolidBrush(Color.Blue);
            Font font = new Font("Arial", 36);

            graphics.DrawString("SPÝDERMAN",font,solidBrush,10,10);
            pictureBox1.Image = bitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Kaydet";
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                string path = saveFileDialog.FileName;
                bitmap.Save(path);
                MessageBox.Show("Resim kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Image);

        }
    }
}
