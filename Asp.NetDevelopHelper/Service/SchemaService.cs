using Asp.NetDevelopHelper.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetDevelopHelper.Service
{
    public class SchemaService
    {
        private readonly string prjPath;

        public SchemaService(string prjPath)
        {
            this.prjPath = prjPath;
        }
        public string ChangeMigration(string schema, string[] tables, string newschema, string fileName)
        {
            var dic = new Dictionary<string, string>();

            tables.ToList().ForEach(x => dic.Add($"[{schema}].[{x}]", $"[{newschema}].[{x}]"));
            tables.ToList().ForEach(x => dic.Add($"{schema}.{x}", $"{newschema}.{x}"));
          return  IO.IOService.ReplaceInFile($"{prjPath}\\ArvinERP.Infrastructure\\Migrations\\{fileName}.cs", dic,false);
        }

        public void ChangeSchema(string schema, string table, string newschema)
        {
            var replaces = new Dictionary<string, string>
           {
               { $"using ArvinERP.Domain.DTOs.{schema}", $"using ArvinERP.Domain.DTOs.{newschema}" },
               { $"using ArvinERP.Domain.Models.{schema}",$"using ArvinERP.Domain.Models.{newschema}"},
               { $"using ArvinERP.Domain.ViewModels.{schema}",$"using ArvinERP.Domain.ViewModels.{newschema}"},
               { $"using ArvinERP.Application.Interfaces.{schema}",$"using ArvinERP.Application.Interfaces.{newschema}"},
               { $"using ArvinERP.Infrastructure.Interfaces.{schema}",$"using ArvinERP.Infrastructure.Interfaces.{newschema}"},
               { $"namespace ArvinERP.API.Controllers.{schema}",$"namespace ArvinERP.API.Controllers.{newschema}"},
               { $"[Route(\"api/{schema}",$"[Route(\"api/{newschema}"},
               { $"namespace ArvinERP.Application.Interfaces.{schema}",$"namespace ArvinERP.Application.Interfaces.{newschema}"},
               { $"namespace ArvinERP.Application.Services.{schema}",$"namespace ArvinERP.Application.Services.{newschema}"},
               { $"namespace ArvinERP.Domain.DTOs.{schema}",$"namespace ArvinERP.Domain.DTOs.{newschema}"},
               { $"namespace ArvinERP.Domain.Models.{schema}",$"namespace ArvinERP.Domain.Models.{newschema}"},
               { $"builder.ToTable(\"{table}\", \"{schema}\");",$"builder.ToTable(\"{table}\", \"{newschema}\");"},
               { $"namespace ArvinERP.Domain.ViewModels.{schema}",$"namespace ArvinERP.Domain.ViewModels.{newschema}"},
               { $"namespace ArvinERP.Infrastructure.Interfaces.{schema}",$"namespace ArvinERP.Infrastructure.Interfaces.{newschema}"},
               { $"namespace ArvinERP.Infrastructure.Repositories.{schema}",$"namespace ArvinERP.Infrastructure.Repositories.{newschema}"},

           };
            var files = new List<Schema>
            {
                new Schema($"\\ArvinERP.API\\Controllers\\{schema}\\{table}Controller.cs", $"\\ArvinERP.API\\Controllers\\{newschema}\\{table}Controller.cs"),
                new Schema($"\\ArvinERP.Application\\Services\\{schema}\\{table}Service.cs", $"\\ArvinERP.Application\\Services\\{newschema}\\{table}Service.cs"),
                new Schema($"\\ArvinERP.Application\\Interfaces\\{schema}\\I{table}Service.cs",$"\\ArvinERP.Application\\Interfaces\\{newschema}\\I{table}Service.cs"),
                new Schema($"\\ArvinERP.Infrastructure\\Repositories\\{schema}\\{table}Repository.cs",$"\\ArvinERP.Infrastructure\\Repositories\\{newschema}\\{table}Repository.cs"),
                new Schema($"\\ArvinERP.Infrastructure\\Interfaces\\{schema}\\I{table}Repository.cs",$"\\ArvinERP.Infrastructure\\Interfaces\\{newschema}\\I{table}Repository.cs"),
                new Schema($"\\ArvinERP.Domain\\ViewModels\\{schema}\\{table}ViewModel.cs", $"\\ArvinERP.Domain\\ViewModels\\{newschema}\\{table}ViewModel.cs"),
                new Schema($"\\ArvinERP.Domain\\DTOs\\{schema}\\{table}Dto.cs",$"\\ArvinERP.Domain\\DTOs\\{newschema}\\{table}Dto.cs"),
                new Schema($"\\ArvinERP.Domain\\Models\\{schema}\\{table}.cs",$"\\ArvinERP.Domain\\Models\\{newschema}\\{table}.cs"),
                new Schema($"\\ArvinERP.Domain\\Models\\{schema}\\Configure\\{table}Configuration.cs",$"\\ArvinERP.Domain\\Models\\{schema}\\Configure\\{table}Configuration.cs")
            };

            foreach (var item in files)
            {
                if (item.OldSch.EndsWith("Configuration.cs") && !IO.IOService.FileExists(item.OldSch))
                    continue;
                IOService.ReplaceInFile(prjPath + item.OldSch, replaces);
                IOService.MoveFile(prjPath + item.OldSch, prjPath + item.NewSch);
            }
        }
    }

    public struct Schema
    {
        public string OldSch { get; }
        public string NewSch { get; }
        public Schema(string oldSch, string newSch)
        {
            OldSch = oldSch;
            NewSch = newSch;
        }

    }
}
