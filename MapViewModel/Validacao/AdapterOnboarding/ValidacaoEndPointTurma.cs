using MapViewModel.Attributes;
using MapViewModel.Models.ApiEventos;
using MapViewModel.Models.Common;
using MapViewModel.Services;
using Refit;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MapViewModel.Validacao.AdapterOnboarding
{
    public class ValidacaoEndPointTurma
    {
        private readonly IAdapterOnboardingService _adapterService;
        private readonly IEemEventosService _eemEventosService;
        private readonly string _filePath;
        private readonly string _fileName;
        private List<string[]> _dadosPlanilha = new();
        private StringBuilder _sb = new();


        public ValidacaoEndPointTurma(IAdapterOnboardingService adapterService, 
            IEemEventosService eemEventosService,
            string fileName)
        {
            _adapterService = adapterService;
            _eemEventosService = eemEventosService;
            _fileName = fileName;
            _filePath = $"{Directory.GetCurrentDirectory()}\\Validacao\\AdapterOnboarding\\{fileName}";
        }

        public async Task Iniciar()
        {
            LerPlanilha();
            foreach (var linha in _dadosPlanilha)
            {
                Console.WriteLine($"Validando linha {_dadosPlanilha.IndexOf(linha) + 1} de {_dadosPlanilha.Count}");

                _ = Guid.TryParse(linha[0], out Guid idEscola);
                _ = Guid.TryParse(linha[1], out Guid idUsuarioUnico);
                _sb.AppendLine("schoolId, userId, mapped, elementsEquals, hasError, errorMessage");
                try
                {
                    IEnumerable<Turma> turmasAdapter = await _adapterService.GetNiveisEnsinoUsuario(idEscola, idUsuarioUnico);
                    IEnumerable<Turma> turmasEEM = await _eemEventosService.GetNiveisEnsinoUsuario(idEscola, idUsuarioUnico);
                    bool mapped = turmasAdapter.GetType().GetGenericArguments()[0].IsRoot() && turmasEEM.GetType().GetGenericArguments()[0].IsRoot();
                    bool elementsEquals = turmasAdapter.Count() == turmasAdapter.Count();
                    _sb.AppendLine($"\"{idEscola}\", \"{idUsuarioUnico}\", {mapped}, {elementsEquals}, False, \"\"");

                    if (!mapped)
                        continue;

                    ValidaDadosTurma(turmasAdapter, turmasEEM, idEscola, idUsuarioUnico);
                }
                catch (ApiException ex)
                {
                    _sb.AppendLine($"\"{idEscola}\", \"{idUsuarioUnico}\", False, False, True, \"{ex.Message}\"");
                    Console.WriteLine($"Erro ao ler linha : {_dadosPlanilha.IndexOf(linha) + 1}");
                }
            }
            string caminhoArquivo = $"{Directory.GetCurrentDirectory()}\\Validacao\\AdapterOnboarding\\resultados_{_fileName}";
            using StreamWriter sw = new(caminhoArquivo);
            sw.Write(_sb.ToString());
        }

        private void ValidaDadosTurma(IEnumerable<Turma> turmasAdapter, IEnumerable<Turma> turmasEEM, Guid idEscola, Guid idUsuarioUnico)
        {
            Console.WriteLine("Validando Turmas ...");
            string group = $"\"SchoolId:{idEscola} - UserId:{idUsuarioUnico}\"";
            _sb.AppendLine($"group, type, index, exists, property, isEquals");
            List<Turma> lista = turmasAdapter.ToList();
            foreach (var turmaAdapter in lista)
            {
                int index = lista.IndexOf(turmaAdapter);
                Turma turmaEem = turmasEEM.FirstOrDefault(x => x.nome == turmaAdapter.nome);
                if (turmaEem is null)
                {
                    _sb.AppendLine($"{group}, \"{turmaAdapter.GetType().Name}\", {index}, False, \"\", False");
                    continue;
                }

                _sb.AppendLine($"{group}, \"{turmaAdapter.GetType().Name}\", {index}, True, \"\", True");
                IEnumerable<PropertyInfo> properties = turmaAdapter.GetType().GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(PropertyCheckAttribute)));
                Dictionary<string, bool> propResults = CheckProperties(turmaAdapter, turmaEem, properties);
                foreach (var result in propResults) 
                {
                    _sb.AppendLine($"{group}, \"{turmaAdapter.nome}\", {index}, True, \"{result.Key}\", {result.Value}");
                }


                properties = turmaAdapter.GetType().GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(AggregateCheckAttribute)));
                foreach(var prop in properties)
                {
                    _sb.AppendLine($"{group}, \"{prop.GetType().Name}\", {index}, True, \"\", True");

                    Dictionary<string, bool> agregateResults = CheckProperties(turmaAdapter, turmaEem, properties);
                    foreach (var result in agregateResults)
                    {
                        _sb.AppendLine($"{group}, \"{turmaAdapter.nome}\", {index}, True, \"{result.Key}\", {result.Value}");
                    }

                }

            }
        }

        private Dictionary<string, bool> CheckProperties<T>(T source, T dest, IEnumerable<PropertyInfo> properties)
        {
            Dictionary<string, bool> results = new();
            foreach (PropertyInfo property in properties)
            {
                var valueSource = property.GetValue(source, null);
                var valueDest = property.GetValue(source, null);
                results.Add(property.Name, valueSource.Equals(valueDest));
            }
            return results;
        }


        private void LerPlanilha()
        {
            Console.WriteLine("Lendo a planilha...");
            using (var reader = new StreamReader(_filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    _dadosPlanilha.Add(line.Split(','));
                }
            }
            Console.WriteLine("Leitura Finalizada...");
        }

    }
}
