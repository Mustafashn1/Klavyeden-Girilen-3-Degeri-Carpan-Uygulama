namespace Klavyeden__Girilen__3_Değeri_Çarpan_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int carpim (int s1, int s2,int s3)
        {
            int s4 = s1 * s2 * s3;
            return s4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1,s2,s3,s4;
            
            s1 = Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            s3 = Convert.ToInt16(textBox3.Text);

            s4 = carpim(s1, s2, s3);


            label5.Text = s4.ToString();
        }
    }
}