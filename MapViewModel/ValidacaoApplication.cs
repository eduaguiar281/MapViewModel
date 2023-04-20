using MapViewModel.Services;
using MapViewModel.Validacao.AdapterOnboarding;
using MapViewModel.Validacao.Spe;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace MapViewModel
{
    public class ValidacaoApplication
    {
        private readonly IConfiguration _configuration;
        private readonly ServiceCollection _serviceCollection = new();
        private readonly IServiceProvider _serviceProvider;

        private List<Func<Task>> _actions = new List<Func<Task>>();


        public ValidacaoApplication()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            _serviceCollection
            .AddSingleton(typeof(IConfiguration), _configuration)
            .AddRefitClient<ISpeService>().ConfigureHttpClient(x =>
            {
                x.BaseAddress = new Uri(_configuration.GetValue<string>("SpeSettings:Uri"));
            });

            _serviceCollection.AddRefitClient<IEemEventosService>()
                .ConfigureHttpClient(x =>
                {
                    x.BaseAddress = new Uri(_configuration.GetValue<string>("EemEventosSettings:Uri"));
                    x.DefaultRequestHeaders.Add("x-api-key", _configuration.GetValue<string>("EemEventosSettings:Key"));
                });

            _serviceCollection.AddRefitClient<IAdapterOnboardingService>()
                .ConfigureHttpClient(x =>
                {
                    x.BaseAddress = new Uri(_configuration.GetValue<string>("AdapterApiSettings:Uri"));
                    x.DefaultRequestHeaders.Add("x-api-key", _configuration.GetValue<string>("AdapterApiSettings:Key"));
                });
            _serviceProvider = _serviceCollection.BuildServiceProvider();

            _actions.Add(ValidarEnturmacaoSpe);
            _actions.Add(ValidarAdapter);
            _actions.Add(Finalizar);
        }

        public IServiceProvider ServiceProvider { get { return _serviceProvider; } }


        public async Task Iniciar()
        {
            bool repeat = true;
            do
            {
                Console.Clear();
                EscreveMenu();
                int.TryParse(Console.ReadLine(), out int opcao);

                if (!OpcaoEhValida(opcao, new int[] { 1, 2, 3 }))
                {
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla e tente novamente.");
                    Console.ReadKey();
                    continue;
                }
                await _actions[opcao - 1].Invoke();
                repeat = opcao != 3;
            }
            while (repeat);

        }

        private bool OpcaoEhValida(int opcao, int[] opcoes)
        {
            return opcoes.Contains(opcao);
        }

        private void EscreveMenu()
        {
            Console.WriteLine("Digite uma opção válida.");
            Console.WriteLine("1 - Validar Enturmação SPE");
            Console.WriteLine("2 - Validar Adapter End Point Turmas");
            Console.WriteLine("3 - Sair");

        }

        private Task Finalizar()
        {
            Console.WriteLine("Aplicação finalizada com sucesso!");
            return Task.CompletedTask;
        }

        private async Task ValidarAdapter()
        {
            Console.Clear();
            Console.WriteLine("=======================================================================");
            Console.WriteLine("               VALIDAÇÃO ADAPTER END POINT TURMA                       ");
            Console.WriteLine("=======================================================================");
            var teste = new ValidacaoEndPointTurma(_serviceProvider.GetRequiredService<IAdapterOnboardingService>(),
                _serviceProvider.GetRequiredService<IEemEventosService>(),
                "escolas_users.csv");
            
            await teste.Iniciar();

            Console.WriteLine("");
            Console.WriteLine("Validação Concluída! Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
        }

        private async Task ValidarEnturmacaoSpe()
        {
            Console.Clear();
            Console.WriteLine("=======================================================================");
            Console.WriteLine("               VALIDAÇÃO ENTURMAÇÃO SPE (CÉREBRO)                      ");
            Console.WriteLine("=======================================================================");
            var teste = new ValidacaoEnturmacaoSpe(_serviceProvider.GetRequiredService<ISpeService>(),
                "alunos_drummond2.csv");
            await teste.Testar();

            Console.WriteLine("");
            Console.WriteLine("Validação Concluída! Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
        }

    }
}
