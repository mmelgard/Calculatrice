namespace Calculatrice
{
    public partial class Calculatrice : Form
    {
        public Calculatrice()
        {
            InitializeComponent();
        }
        string operateur;

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox_resultat.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox_resultat.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox_resultat.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "0";
        }

        private void button_virgule_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += ",";
        }

        private void button_addition_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "+";
            operateur = "+";
        }

        private void button_soustraction_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "-";
            operateur = "-";
        }

        private void button_multiplication_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "*";
            operateur = "*";
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            textBox_resultat.Text += "/";
            operateur = "/";
        }

        private void button_effacer_Click(object sender, EventArgs e)
        {
            textBox_resultat.Clear();
        }

        private void button_egale_Click(object sender, EventArgs e)
        {
            if (operateur == "+")
            {
                string[] chaine = textBox_resultat.Text.Split('+');

       
                textBox_resultat.Text += Environment.NewLine + " = " + Environment.NewLine + (double.Parse(chaine[0]) + double.Parse(chaine[1])).ToString();
            }

            if (operateur == "-")
            {
                string[] chaine = textBox_resultat.Text.Split('-');


                textBox_resultat.Text += Environment.NewLine + " = " + Environment.NewLine + (double.Parse(chaine[0]) - double.Parse(chaine[1])).ToString();
            }

            if (operateur == "*")
            {
                string[] chaine = textBox_resultat.Text.Split('*');


                textBox_resultat.Text += Environment.NewLine + " = " + Environment.NewLine + (double.Parse(chaine[0]) * double.Parse(chaine[1])).ToString();
            }

            if (operateur == "/")
            {
                string[] chaine = textBox_resultat.Text.Split('/');


                textBox_resultat.Text += Environment.NewLine + " = " + Environment.NewLine + (double.Parse(chaine[0]) / double.Parse(chaine[1])).ToString();
            }

            else
            {
                textBox_resultat.Text += Environment.NewLine + " = " + Environment.NewLine + "La division sur 0 est impossible";
            }
        }
    }
}
