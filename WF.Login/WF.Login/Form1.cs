namespace WF.Login
{
    public partial class Form1 : Form
    {
        private object messageBoxButtons;

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "USUARIO")
                textBox3.Text = String.Empty;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
                textBox3.Text = "USUARIO";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "SENHA")
                textBox2.Text = string.Empty;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
                textBox2.Text = "SENHA";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {   
            var resposta=MessageBox.Show("Deseja encerrar o programa",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(resposta == DialogResult.Yes)
            Application.Exit();

        }
    }
}
