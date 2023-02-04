namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            PARIMPAR(Convert.ToString(RestextBox1));
            POSNEG(Convert.ToString(RestextBox2));

        }
        private int PARIMPAR(int num, int parimpar) {
            num = int.Parse(NumtextBox.Text);
            parimpar = num % 2;
            if (parimpar == 0)
                RestextBox1.Text = "Numero Par";

            else
                RestextBox1.Text = "Numero Impar";

          
        }

        private int POSNEG(int N)
        {
            if (N < 0)
                RestextBox2.Text = "Numero Negativo";
            else
                RestextBox2.Text = "Numero Positivo";

        
        }

        private void RestextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
     

    }