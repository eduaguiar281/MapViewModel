using MapViewModel.Models.Common;
using Refit;
using System.Text;

namespace MapViewModel.Validacao.Spe
{


    public class ValidacaoEnturmacaoSpe
    {
        private readonly ISpeService _service;

        private const string _senha = "ON*5653!alfa";

        private readonly List<DadosPlanilha> _dadosPlanilha;

        private readonly string _filePath;
        private readonly string _fileName;

        public ValidacaoEnturmacaoSpe(ISpeService service, string file)
        {
            _service = service;
            _dadosPlanilha = new List<DadosPlanilha>();
            _fileName = file;
            _filePath = $"{Directory.GetCurrentDirectory()}\\Validacao\\Spe\\{file}";
        }


        private async Task<ResultService> ObterJWT(string login)
        {
            try
            {
                Dictionary<string, object> data = new()
                {
                    { "grant_type", "password" },
                    { "password", _senha },
                    { "username", login }
                };
                ResultService resultStatus = await _service.GetToken(data);
                if (!resultStatus.sucesso)
                    return resultStatus;

                if (resultStatus.dados.schools.Count > 1)
                {
                    Console.WriteLine($"ATENÇÃO: O usuário {login} possui mais de uma escola!");
                }

                data = new()
                {
                    { "grant_type", "change_school" },
                    { "access_token", resultStatus.dados.access_token },
                    { "school_id", resultStatus.dados.schools.FirstOrDefault()?.id }
                };
                resultStatus = await _service.GetToken(data);
                return resultStatus;

            }
            catch (ApiException ex)
            {
                return new ResultService
                {
                    dados = null,
                    mensagem = ex.Message,
                    sucesso = false
                };
            }
        }


        public async Task<List<DadosPlanilha>> Testar()
        {
            Console.WriteLine("Iniciando validação...");
            LerPlanilha();
            foreach (var dado in _dadosPlanilha)
            {
                Console.WriteLine($"Validando linha {_dadosPlanilha.IndexOf(dado) + 1} de {_dadosPlanilha.Count}");
                ResultService resultLogin = await ObterJWT(dado.Login);
                if (!resultLogin.sucesso)
                    continue;
                try
                {
                    dado.LoginOnOk = true;
                    IEnumerable<NivelEnsinoResponse> response = await _service
                        .GetNiveisEnsino(resultLogin.dados.access_token, dado.UsuarioUnicoId);
                    if (response != null && response.Any())
                        dado.HaveBrain = false;
                    else
                        dado.HaveBrain = true;
                }
                catch (ApiException)
                {
                    dado.HaveBrain = true;
                    continue;
                }
            }
            GravarDados();
            return _dadosPlanilha;
        }


        private void GravarDados()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"login, idUsuario, loginOk, deuCerebro");
            foreach (var dado in _dadosPlanilha)
            {
                sb.AppendLine($"{dado.Login}, {dado.UsuarioUnicoId}, {dado.LoginOnOk}, {dado.HaveBrain}");
            }
            string caminhoArquivo = $"{Directory.GetCurrentDirectory()}\\Validacao\\Spe\\resultados_{_fileName}";

            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                sw.Write(sb.ToString());
            }
        }


        private void LerPlanilha()
        {
            Console.WriteLine("Lendo a planilha...");

            using (var reader = new StreamReader(_filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    _dadosPlanilha.Add(
                        new DadosPlanilha
                        {
                            Login = values[0].Replace("\"", "").Replace(" ", ""),
                            UsuarioUnicoId = Guid.Parse(values[1])
                        });
                }
            }

            Console.WriteLine("Leitura Finalizada...");
        }
    }



}
