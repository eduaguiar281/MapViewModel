using MapViewModel;
using MapViewModel.Services;
using MapViewModel.Validacao.AdapterOnboarding;
using MapViewModel.Validacao.Spe;
using Microsoft.Extensions.DependencyInjection;

namespace ValidadorAdapter
{
    public partial class Form1 : Form
    {
        private readonly ValidacaoApplication _app;
        private readonly ValidacaoEndPointTurma _validacao;

        public Form1()
        {
            InitializeComponent();
            Console.SetOut(new ConsoleWriter(consoleOutput));

            _app= new ValidacaoApplication();
            _validacao = new ValidacaoEndPointTurma(_app.ServiceProvider.GetRequiredService<IAdapterOnboardingService>(),
                _app.ServiceProvider.GetRequiredService<IEemEventosService>(), "escolas_users.csv");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await _validacao.Iniciar();
        }
    }
}