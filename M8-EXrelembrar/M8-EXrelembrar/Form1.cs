namespace M8_EXrelembrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbox.Text = string.Empty;
            numup.Text = string.Empty;
            cbox.Text = string.Empty;
            label4.Text = "Diciplina  ";
            label5.Text = "Módulo  ";
            label7.Text = "Classificação  ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if(txtbox.Text== ""||cbox.SelectedIndex == -1)
            {
                //MessageBox.Show("Prenencha todos os dados")
                string msg = "Prenencha todos os dados";
                MessageBox.Show(msg, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                
                string modulo, classificacao;
                modulo = cbox.Text;
                classificacao = numup.Text;
                string diciplina = txtbox.Text;
                label4.Text +=  diciplina;
                label5.Text +=  modulo;
                label7.Text += classificacao;


            }
        }
    }
}
