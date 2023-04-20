using MapViewModel.Models.Converters;
using MapViewModel.Models.Onboarding;

namespace MapViewModel.Models.Extensions
{
    public static class UserInfoExtensions
    {
        public static TokenSchoolViewModel ToViewModel(this Institution self)
        {
            bool _ = Guid.TryParse(self.InheritedSchoolCode, out Guid id);

            return new TokenSchoolViewModel
            {
                Id = id,
                IntegracaoId = null,
                Nome = self.CompanyName,
            };
        }

        public static IEnumerable<NivelEnsinoViewModel> ToNiveisEnsino(this UserInfoResponse me, string inheritedSchoolCode, string profile)
        {
            IEnumerable<Classroom> classRooom = me.Accounts
                .Where(a => a.Classrooms != null
                       && a.Classrooms.Any(x => x.ClassRoom.Active.HasValue && x.ClassRoom.Active.Value)
                       && a.Institution.ParentInstitution.InheritedSchoolCode.Equals(inheritedSchoolCode, StringComparison.OrdinalIgnoreCase)
                       && a.Profile.Name.Equals(profile, StringComparison.OrdinalIgnoreCase)
                 )
                .SelectMany(f => f.Classrooms.Select(c => c.ClassRoom));


            return classRooom?.GroupBy(g => g.Grade.Stage, g => g,
                (key, item) => new NivelEnsinoViewModel
                {
                    Value = key.Name.ConvertToNomeNivelEnsinoSPE(),
                    Label = key.Description,
                    Turmas = item.Select(i => new TurmasUsuarioViewModel
                    {
                        NomeSerie = i.Grade.Id.ConvertToSPESerie(),
                        NomeTurma = i.Name,
                        TurmaValida = true
                    }).ToList()
                });
        }
    }

    //    public static DadosUsuario ToDadosUsuario(this UserInfoResponse me, KeyCloackResponseToken response, string aliasParceiro)
    //    {
    //        List<TokenSchoolViewModel> grouped = me.Accounts
    //            .GroupBy(f => f.Institution.ParentInstitution, (key, g) => key.ToViewModel())
    //            .ToList();

    //        var usersId = me.Accounts.GroupBy(f => f.Institution.ParentInstitution.InheritedSchoolCode,
    //                                            f => f.User,
    //                                                (key, g) => new { Id = Guid.Parse(key), UserId = g.FirstOrDefault() });

    //        var roles = me.Accounts.GroupBy(f => f.Institution.ParentInstitution.InheritedSchoolCode,
    //                                                f => f.Profile.Name,
    //                                                (key, g) => new { Id = Guid.Parse(key), Roles = g.ToArray() });

    //        grouped.ForEach(g =>
    //        {
    //            g.UserId = usersId.FirstOrDefault(x => x.Id == g.Id).UserId.ToString();
    //            g.Roles = roles.FirstOrDefault(x => x.Id == g.Id).Roles.Distinct().Select(x => RenomearRoleParaFormatoSPE(x)).ToArray();
    //        });

    //        return new DadosUsuario
    //        {
    //            NomeUsuario = me.Username,
    //            Nome = me.FirstName,
    //            Email = me.Email,
    //            IdIntegracao = me.InheritedId,
    //            TokenDoParceiro = response.AccessToken,
    //            ExpireInParceiro = response.ExpiresIn,
    //            TokenTypeParceiro = response.TokenType,
    //            ScopeParceiro = response.Scope,
    //            RefreshTokenPerceiro = response.RefreshToken,
    //            AliasParceiro = aliasParceiro,
    //            Escolas = grouped
    //        };

    //        static string RenomearRoleParaFormatoSPE(string roleSSOArco)
    //        {
    //            return roleSSOArco switch
    //            {
    //                "Aluno" => "ALUNO",
    //                "Professor" => "PROFESSOR",
    //                "Conveniada" => "ADMINISTRADOR",
    //                "Pedagógico" => "COORDENADOR",
    //                "Responsável" => "PAIS_E_RESPONSAVEIS",
    //                _ => "ALUNO",
    //            };
    //        }
    //    }
    //}

}
