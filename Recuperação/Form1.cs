namespace Recuperação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            decimal valor = decimal.Parse(txtValor.Text);

            decimal valortotal = quantidade * valor;
            decimal desconto = 0; 
            if (valortotal >= 200)
            {
                desconto = valortotal * 0.10m;
            }
            decimal valorfinal = valortotal - desconto;
            {
                MessageBox.Show($"Produto: {produto}\n" + $"Quantidade: {quantidade}\n" + $"Valor total: R$ {valortotal:F2}\n" + $"Desconto: R$ {desconto:F2}\n" + $"Valor final a pagar: R$ {valorfinal:F2}", "Resumo da Compra");

            }
        }
    }
}
