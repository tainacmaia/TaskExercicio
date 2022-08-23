using System.Diagnostics;

namespace TaskExercicio
{
    public partial class frmCalculoValores : Form
    {
        public frmCalculoValores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ltbValor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            ltbValor.Items.Clear();
            lblAguardar.Text = "Realizando os cálculos...\nPor favor aguarde.";
            btnCalcular.Enabled = false;

            var task1 = FolhaPagamento();
            var task2 = Impostos();
            var task3 = Despesas();
            var task4 = Receitas();

            await task1;
            await task2;
            await task3;
            await task4;

            lblAguardar.Text = $"Fim dos cálculos.\nTempo gasto: {Math.Round((double)stopwatch.ElapsedMilliseconds/1000,2)} segundos";
            btnCalcular.Enabled = true;
        }

        private async Task FolhaPagamento()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            ltbValor.Items.Add("R$ 5.000,00");
        }

        private async Task Impostos()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            ltbValor.Items.Add("R$ 300,00");
        }

        private async Task Receitas()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            ltbValor.Items.Add("R$ 8.000,00");
        }

        private async Task Despesas()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            ltbValor.Items.Add("R$ 7.000,00");
        }
    }
}