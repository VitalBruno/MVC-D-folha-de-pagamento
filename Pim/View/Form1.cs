namespace Pim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            V_Login login = new V_Login();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            V_Funcionario v_Funcionario = new V_Funcionario();
            v_Funcionario.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            V_FolhaDePagamento v_FolhaDePagamento=new V_FolhaDePagamento();
            v_FolhaDePagamento.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            V_Relatorios v_Relatorios = new V_Relatorios();
            v_Relatorios.ShowDialog();
        }
    }
}