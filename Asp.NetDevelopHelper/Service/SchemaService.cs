using Asp.NetDevelopHelper.IO;
using Asp.NetDevelopHelper.Model;
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
          return  IO.IOService.ReplaceInFile($"{prjPath}\\{NameSpaces.Infrastructure}\\Migrations\\{fileName}.cs", dic,false);
        }

        public void ChangeSchema(string schema, string table, string newschema)
        {
            var replaces = new Dictionary<string, string>
           {
               { $"using {NameSpaces.Domain}.DTOs.{schema}", $"using {NameSpaces.Domain}.DTOs.{newschema}" },
               { $"using {NameSpaces.Domain}.Models.{schema}",$"using {NameSpaces.Domain}.Models.{newschema}"},
               { $"using {NameSpaces.Domain}.ViewModels.{schema}",$"using {NameSpaces.Domain}.ViewModels.{newschema}"},
               { $"using {NameSpaces.Application}.Interfaces.{schema}",$"using {NameSpaces.Application}.Interfaces.{newschema}"},
               { $"using {NameSpaces.Infrastructure}.Interfaces.{schema}",$"using {NameSpaces.Infrastructure}.Interfaces.{newschema}"},
               { $"namespace {NameSpaces.Api}.Controllers.{schema}",$"namespace {NameSpaces.Api}.Controllers.{newschema}"},
               { $"[Route(\"api/{schema}",$"[Route(\"api/{newschema}"},
               { $"namespace {NameSpaces.Application}.Interfaces.{schema}",$"namespace {NameSpaces.Application}.Interfaces.{newschema}"},
               { $"namespace {NameSpaces.Application}.Services.{schema}",$"namespace {NameSpaces.Application}.Services.{newschema}"},
               { $"namespace {NameSpaces.Domain}.DTOs.{schema}",$"namespace {NameSpaces.Domain}.DTOs.{newschema}"},
               { $"namespace {NameSpaces.Domain}.Models.{schema}",$"namespace {NameSpaces.Domain}.Models.{newschema}"},
               { $"builder.ToTable(\"{table}\", \"{schema}\");",$"builder.ToTable(\"{table}\", \"{newschema}\");"},
               { $"namespace {NameSpaces.Domain}.ViewModels.{schema}",$"namespace {NameSpaces.Domain}.ViewModels.{newschema}"},
               { $"namespace {NameSpaces.Infrastructure}.Interfaces.{schema}",$"namespace {NameSpaces.Infrastructure}.Interfaces.{newschema}"},
               { $"namespace {NameSpaces.Infrastructure}.Repositories.{schema}",$"namespace {NameSpaces.Infrastructure}.Repositories.{newschema}"},

           };
            var files = new List<Schema>
            {
                new Schema($"\\{NameSpaces.Api}\\Controllers\\{schema}\\{table}Controller.cs", $"\\{NameSpaces.Api}\\Controllers\\{newschema}\\{table}Controller.cs"),
                new Schema($"\\{NameSpaces.Application}\\Services\\{schema}\\{table}Service.cs", $"\\{NameSpaces.Application}\\Services\\{newschema}\\{table}Service.cs"),
                new Schema($"\\{NameSpaces.Application}\\Interfaces\\{schema}\\I{table}Service.cs",$"\\{NameSpaces.Application}\\Interfaces\\{newschema}\\I{table}Service.cs"),
                new Schema($"\\{NameSpaces.Infrastructure}\\Repositories\\{schema}\\{table}Repository.cs",$"\\{NameSpaces.Infrastructure}\\Repositories\\{newschema}\\{table}Repository.cs"),
                new Schema($"\\{NameSpaces.Infrastructure}\\Interfaces\\{schema}\\I{table}Repository.cs",$"\\{NameSpaces.Infrastructure}\\Interfaces\\{newschema}\\I{table}Repository.cs"),
                new Schema($"\\{NameSpaces.Domain}\\ViewModels\\{schema}\\{table}ViewModel.cs", $"\\{NameSpaces.Domain}\\ViewModels\\{newschema}\\{table}ViewModel.cs"),
                new Schema($"\\{NameSpaces.Domain}\\DTOs\\{schema}\\{table}Dto.cs",$"\\{NameSpaces.Domain}\\DTOs\\{newschema}\\{table}Dto.cs"),
                new Schema($"\\{NameSpaces.Domain}\\Models\\{schema}\\{table}.cs",$"\\{NameSpaces.Domain}\\Models\\{newschema}\\{table}.cs"),
                new Schema($"\\{NameSpaces.Domain}\\Models\\{schema}\\Configure\\{table}Configuration.cs",$"\\{NameSpaces.Domain}\\Models\\{schema}\\Configure\\{table}Configuration.cs")
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
