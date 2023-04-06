namespace JogoBobo
{
    public partial class Form1 : Form
    {
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void orga()
        {
            bt1.Text = "1";
            bt2.Text = "2";
            bt3.Text = "3";
            bt4.Text = "4";
            bt5.Text = "5";
            bt6.Text = "6";
            bt7.Text = "7";
            bt8.Text = "8";
            bt0.Text = "";
        }
        public void checar()
        {
            if (
                bt1.Text == "1" &&
                bt2.Text == "2" &&
                bt3.Text == "3" &&
                bt4.Text == "4" &&
                bt5.Text == "5" &&
                bt6.Text == "6" &&
                bt7.Text == "7" &&
                bt8.Text == "8" &&
                bt0.Text == ""
                )
            {
                MessageBox.Show("Você Venceu!");
            }

        }


        public void baralhar()
        {
            int[] numeros = new int[9];
            bool igual = false;
            int a, b, numero;
            a = 1;
            do {
                Random random = new Random();
                numero = Convert.ToInt32(random.Next(0, 8) +1);
                for(b =1; b<= a; b++)
                { 
                    if(numeros[b] == numero)
                    {
                        igual = true;
                        break;
                    }
                }
                if(igual == true)
                {
                    igual=false;
                }
                else
                {
                    numeros[a] = numero;
                    a++;
                }

            } while (a <= 8);

            bt1.Text = Convert.ToString(numeros[1]);
            bt2.Text = Convert.ToString(numeros[2]);
            bt3.Text = Convert.ToString(numeros[3]);
            bt4.Text = Convert.ToString(numeros[4]);
            bt5.Text = Convert.ToString(numeros[5]);
            bt6.Text = Convert.ToString(numeros[6]);
            bt7.Text = Convert.ToString(numeros[7]);
            bt8.Text = Convert.ToString(numeros[8]);
            bt0.Text = "";
        }
        

        
        public void trocar(Button a, Button b)
        {
            if(b.Text == "")
            {
                b.Text = a.Text;
                a.Text = "";
                n++;
                mov.Text = n.ToString();
            }
            
        }
        private void button11_Click(object sender, EventArgs e)
        {
            n = 0;
            mov.Text = n.ToString();
            orga();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbMovimentos.Visible = false;
            btordenar.Visible = false;
            bt1.Enabled = false;
            bt2.Enabled = false;
            bt3.Enabled = false;
            bt4.Enabled = false;
            bt5.Enabled = false;
            bt6.Enabled = false;
            bt7.Enabled = false;
            bt8.Enabled = false;
            bt0.Enabled = false;
            orga();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            baralhar();
            mov.Text = n.ToString();
            lbMovimentos.Visible = true;
            btordenar.Visible = true;
            bt1.Enabled = true;
            bt2.Enabled = true;
            bt3.Enabled = true;
            bt4.Enabled = true;
            bt5.Enabled = true;
            bt6.Enabled = true;
            bt7.Enabled = true;
            bt8.Enabled = true;
            bt0.Enabled = true;
            button10.Enabled = true;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            trocar(bt1, bt2);
            trocar(bt1, bt4);
            checar();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            trocar(bt2, bt1);
            trocar(bt2, bt3);
            trocar(bt2, bt5);
            checar();

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            trocar(bt3, bt2);
            trocar(bt3, bt6);
            checar();
        }
        

        private void bt4_Click(object sender, EventArgs e)
        {
            trocar(bt4, bt1);
            trocar(bt4, bt5);
            trocar(bt4, bt7);
            checar();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            trocar(bt5, bt2);
            trocar(bt5, bt4);
            trocar(bt5, bt6);
            trocar(bt5, bt8);
            checar();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            trocar(bt6, bt3);
            trocar(bt6, bt5);
            trocar(bt6, bt0);
            checar();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            trocar(bt7, bt4);
            trocar(bt7, bt8);
            checar();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            trocar(bt8, bt5);
            trocar(bt8, bt7);
            trocar(bt8, bt0);
            checar();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            trocar(bt0, bt6);
            trocar(bt0, bt8);
            checar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}