﻿using Asp.NetDevelopHelper.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetDevelopHelper.Service
{
    public class ServiceCreator
    {
        private readonly BaseModel _model;
        String.ModelStringBuilder _builder;
        public ServiceCreator(BaseModel baseModel)
        {
            _model = baseModel;
            _builder = new String.ModelStringBuilder(baseModel);

        }

        public static List<Property> GetProperties(string path, string schema, string table)
        {
            path = path + $"\\ArvinERPFinal.Domain\\Models\\{schema}\\{table}.cs";
            var properties = new List<Property>();
            var file = IO.IOService.ReadFile(path);
            var index = file.IndexOf("public class") + 5;
            var lastIndex = file.LastIndexOf("set; }");
            while (index >= 0)
            {
                index = file.IndexOf("public", index) + 7;
                var endindex = file.IndexOf("{ get;", index) - 1;
                if (index == -1 || endindex == -2)
                    break;
                var result = file.Substring(index, endindex - index).Replace("  ", " ");
                properties.Add(new Property() { Name = result.Split(" ").Last(), Type = result.Split(" ").First() });
            }
            return properties;
        }
        public static List<string> GetSchemas(string path)
        {
            return IO.IOService.GetDirectories(path + $"\\ArvinERPFinal.Domain\\Models");
        }
        public static List<string> GetTables(string path, string schema)
        {
            return IO.IOService.GetFiles(path + $"\\ArvinERPFinal.Domain\\Models\\{schema}");
        }
        public async void CreateArvinService()
        {
            if (_model.CreateModel)
                IO.IOService.CreateFile(_model.ProjectPath + $"\\ArvinERPFinal.Domain\\Models\\{_model.Schema}\\{_model.Table}.cs", _builder.GetModelClass());
            if (_model.CreateDto)
                IO.IOService.CreateFile(_model.ProjectPath + $"\\ArvinERPFinal.Domain\\DTOs\\{_model.Schema}\\{_model.Table}Dto.cs", _builder.GetDtoClass());
            if (_model.CreateViewModel)
                IO.IOService.CreateFile(_model.ProjectPath + $"\\ArvinERPFinal.Domain\\ViewModels\\{_model.Schema}\\{_model.Table}ViewModel.cs", _builder.GetViewModelClass());

            if (_model.CreateMapping)
                IO.IOService.CreateFile(_model.ProjectPath + $"\\ArvinERPFinal.Domain\\Mapping\\{_model.Schema}\\{_model.Table}MappingProfile.cs", _builder.GetMappingClass());

            if (_model.CreateRepository)
            {
                IO.IOService.CreateFile(_model.ProjectPath + $"\\ArvinERPFinal.Infrastructure\\Interfaces\\{_model.Schema}\\I{_model.Table}Repository.cs", _builder.GetIRepository());
                IO.IOService.CreateFile(_model.ProjectPath + $"\\ArvinERPFinal.Infrastructure\\Repositories\\{_model.Schema}\\{_model.Table}Repository.cs", _builder.GetRepository());
            }

            if (_model.CreateService)
            {
                IO.IOService.CreateFile(_model.ProjectPath + $"\\ArvinERPFinal.Application\\Interfaces\\{_model.Schema}\\I{_model.Table}Service.cs", _builder.GetIService());
                IO.IOService.CreateFile(_model.ProjectPath + $"\\ArvinERPFinal.Application\\Services\\{_model.Schema}\\{_model.Table}Service.cs", _builder.GetService());
            }
            if (_model.CreateController)
                IO.IOService.CreateFile(_model.ProjectPath + $"\\ArvinERPFinal.API\\Controllers\\{_model.Schema}\\{_model.Table}Controller.cs", _builder.GetController());
            if (_model.CreateContextDbset)
            {
                var contextPath = _model.ProjectPath + $"\\ArvinERPFinal.Infrastructure\\ArvinContext.cs";
                var dbsetIndex = IO.IOService.FindIndex(contextPath, $"#region {_model.Schema}", 0);

                if (dbsetIndex == -1)
                {
                    IO.IOService.InsertIntoFile(contextPath, IO.IOService.FindIndex(contextPath, $"#endregion", 0) + 10, $"\n\t\t#region {_model.Schema}\n\t\t#endregion");
                    IO.IOService.InsertIntoFile(contextPath, 0, $"using ArvinERPFinal.Domain.Models.{_model.Schema};\n");
                    dbsetIndex = IO.IOService.FindIndex(contextPath, $"#region {_model.Schema}", 0);
                }
                var dbsetInsertIndex = IO.IOService.FindIndex(contextPath, $"#endregion", dbsetIndex);
                IO.IOService.InsertIntoFile(contextPath, dbsetInsertIndex, $"public DbSet<{_model.Table}> {_model.Table} {{ get; set; }}\n\t\t");
            }
            if (_model.CreateRelations)
            {
                foreach (var item in _model.Relations)
                {

                    var pricipalPath = _model.ProjectPath + $"\\ArvinERPFinal.Domain\\Models\\{item.Schema}\\{item.Table}.cs";
                    var pricipalInsertIndex = IO.IOService.FindLastIndex(pricipalPath, "{ get; set; }") + 13;
                    IO.IOService.InsertIntoFile(pricipalPath, pricipalInsertIndex, $"\n\t\tpublic virtual {(item.RelationType != RelationType.One2One ? $"ICollection<{_model.Table}>" : _model.Table)} {_model.Table} {{ get; set; }}");
                    if (item.Schema != _model.Schema)
                        IO.IOService.InsertIntoFile(pricipalPath, 0, $"using ArvinERPFinal.Domain.Models.{_model.Schema};\n");
                    var principalrepository = _model.ProjectPath + $"\\ArvinERPFinal.Infrastructure\\Repositories\\{item.Schema}\\{item.Table}Repository.cs";
                    var pricipalrepoInsertIndex = IO.IOService.FindLastIndex(principalrepository, "}\r\n}");
                    IO.IOService.InsertIntoFile(principalrepository, pricipalrepoInsertIndex, _builder.GetDeleteOverride(item.Table));
                }
            }

            if (_model.CreateResources)
            {

                var resourcePath = _model.ProjectPath + $"\\ArvinERPFinal.Domain\\Resources\\{_model.Schema}.resx";
                var designerPath = _model.ProjectPath + $"\\ArvinERPFinal.Domain\\Resources\\{_model.Schema}.Designer.cs";

                if (!IO.IOService.FileExists(resourcePath))
                    IO.IOService.CreateFile(resourcePath, _builder.GetResxTemplate());
                if (!IO.IOService.FileExists(designerPath))
                    IO.IOService.CreateFile(designerPath, _builder.GetDesignerTemplate());

                var index = IO.IOService.FindIndex(resourcePath, "</root>", 0);
                var index1 = IO.IOService.FindLastIndex(designerPath, "}\r\n}");
                _builder.GetResxResources().ForEach(i =>
                {
                    IO.IOService.InsertIntoFile(resourcePath, index, i);
                });
                _builder.GetDesignerResources().ForEach(i =>
                {
                    IO.IOService.InsertIntoFile(designerPath, index1, i);
                });
            }

            //var mapPath = _model.ProjectPath + $"\\ArvinERPFinal.API\\Extensions\\ConfigureMapping.cs";
            //var mapIndex = IO.IOService.FindIndex(mapPath, $"#region {_model.Schema}", 0);
            //if (mapIndex == -1)
            //{
            //    IO.IOService.InsertIntoFile(mapPath, IO.IOService.FindIndex(mapPath, $"#endregion", 0)+10, $"\n\t\t\t\t#region {_model.Schema}\n\t\t\t\t#endregion");
            //    mapIndex = IO.IOService.FindIndex(mapPath, $"#region {_model.Schema}", 0);
            //}
            //var mapInsertIndex = IO.IOService.FindIndex(mapPath, $"#endregion", mapIndex);
            //IO.IOService.InsertIntoFile(_model.ProjectPath + $"\\ArvinERPFinal.API\\Extensions\\ConfigureMapping.cs", mapInsertIndex, $"map.AddProfile<{_model.Table}MappingProfile>();\n\t\t\t\t");
            //IO.IOService.InsertIfNotExists(mapPath, 0, $"using ArvinERPFinal.Domain.Mapping.{_model.Schema};\r\n");

            //var configureIndex = IO.IOService.FindIndex(contextPath, $"#region {_model.Schema}", dbsetInsertIndex);
            //if (configureIndex == -1)
            //{
            //    IO.IOService.InsertIntoFile(contextPath, IO.IOService.FindIndex(contextPath, $"#endregion", IO.IOService.FindIndex(contextPath, "OnModelCreating", 0))  + 10, $"\n\t\t\t#region {_model.Schema}\n\t\t\t#endregion");
            //    configureIndex = IO.IOService.FindIndex(contextPath, $"#region {_model.Schema}", dbsetInsertIndex);
            //}
            //var configureInsertIndex = IO.IOService.FindIndex(contextPath, $"#endregion", configureIndex);
            //IO.IOService.InsertIntoFile(contextPath, configureInsertIndex, $"modelBuilder.ApplyConfiguration(new {_model.Table}Configuration());\n\t\t\t");
            //IO.IOService.InsertIfNotExists(contextPath, 0, $"using ArvinERPFinal.Domain.Models.{_model.Schema};\r\n");


            //var servicePath = _model.ProjectPath + $"\\ArvinERPFinal.API\\Extensions\\DependencyInjectionServices.cs";
            //var regServiceIndex = IO.IOService.FindIndex(servicePath, $"#region {_model.Schema}", 0);
            //if (regServiceIndex == -1)
            //{
            //    IO.IOService.InsertIntoFile(servicePath, IO.IOService.FindIndex(servicePath, $"#endregion", 0) + 10, $"\n\t\t\t#region {_model.Schema}\n\t\t\t#endregion");
            //    regServiceIndex = IO.IOService.FindIndex(servicePath, $"#region {_model.Schema}", 0);
            //}
            //var regServiceInsertIndex = IO.IOService.FindIndex(servicePath, $"#endregion", regServiceIndex);
            //IO.IOService.InsertIntoFile(servicePath, regServiceInsertIndex, $"services.AddTransient<I{_model.Table}Service, {_model.Table}Service>();\n\t\t\t");
            //IO.IOService.InsertIfNotExists(servicePath, 0, $"using ArvinERPFinal.Application.Services.{_model.Schema};\r\n");


            //var repoPath = _model.ProjectPath + $"\\ArvinERPFinal.API\\Extensions\\DependencyInjectionRepository.cs";
            //var regReposIndex = IO.IOService.FindIndex(repoPath, $"#region {_model.Schema}", 0);
            //if (regReposIndex == -1)
            //{
            //    IO.IOService.InsertIntoFile(repoPath, IO.IOService.FindIndex(repoPath, $"#endregion", 0) + 10, $"\n\t\t\t#region {_model.Schema}\n\t\t\t#endregion");
            //    regReposIndex = IO.IOService.FindIndex(repoPath, $"#region {_model.Schema}", 0);
            //}
            //var regRepoInsertIndex = IO.IOService.FindIndex(repoPath, $"#endregion", regReposIndex);
            //IO.IOService.InsertIntoFile(repoPath, regRepoInsertIndex, $"services.AddTransient<I{_model.Table}Repository, {_model.Table}Repository>();\n\t\t\t");
            //IO.IOService.InsertIfNotExists(repoPath, 0, $"using ArvinERPFinal.Infrastructure.Interfaces.{_model.Schema};\r\n");

        }

        public void Revert()
        {
            if (_model.CreateModel)
                IO.IOService.DeleteFile(_model.ProjectPath + $"\\ArvinERPFinal.Domain\\Models\\{_model.Schema}\\{_model.Table}.cs");
            if (_model.CreateDto)
                IO.IOService.DeleteFile(_model.ProjectPath + $"\\ArvinERPFinal.Domain\\DTOs\\{_model.Schema}\\{_model.Table}Dto.cs");
            if (_model.CreateViewModel)
                IO.IOService.DeleteFile(_model.ProjectPath + $"\\ArvinERPFinal.Domain\\ViewModels\\{_model.Schema}\\{_model.Table}ViewModel.cs");

            if (_model.CreateMapping)
                IO.IOService.DeleteFile(_model.ProjectPath + $"\\ArvinERPFinal.Domain\\Mapping\\{_model.Schema}\\{_model.Table}MappingProfile.cs");

            if (_model.CreateRepository)
            {
                IO.IOService.DeleteFile(_model.ProjectPath + $"\\ArvinERPFinal.Infrastructure\\Interfaces\\{_model.Schema}\\I{_model.Table}Repository.cs");
                IO.IOService.DeleteFile(_model.ProjectPath + $"\\ArvinERPFinal.Infrastructure\\Repositories\\{_model.Schema}\\{_model.Table}Repository.cs");
            }

            if (_model.CreateService)
            {
                IO.IOService.DeleteFile(_model.ProjectPath + $"\\ArvinERPFinal.Application\\Interfaces\\{_model.Schema}\\I{_model.Table}Service.cs");
                IO.IOService.DeleteFile(_model.ProjectPath + $"\\ArvinERPFinal.Application\\Services\\{_model.Schema}\\{_model.Table}Service.cs");

            }
            if (_model.CreateController)
                IO.IOService.DeleteFile(_model.ProjectPath + $"\\ArvinERPFinal.API\\Controllers\\{_model.Schema}\\{_model.Table}Controller.cs");
            if (_model.CreateContextDbset)
            {
                IO.IOService.CutFromFile(_model.ProjectPath + $"\\ArvinERPFinal.Infrastructure\\ArvinContext.cs", $"public DbSet<{_model.Table}> {_model.Table} {{ get; set; }}\n\t\t");
            }


            // IO.IOService.CutFromFile(_model.ProjectPath + $"\\ArvinERPFinal.API\\Extensions\\ConfigureMapping.cs", $"map.AddProfile<{_model.Table}MappingProfile>();\n\t\t\t\t");


            //IO.IOService.CutFromFile(_model.ProjectPath + $"\\ArvinERPFinal.Infrastructure\\ArvinContext.cs", $"modelBuilder.ApplyConfiguration(new {_model.Table}Configuration());\n\t\t\t");

            // IO.IOService.CutFromFile(_model.ProjectPath + $"\\ArvinERPFinal.API\\Extensions\\DependencyInjectionServices.cs", $"services.AddTransient<I{_model.Table}Service, {_model.Table}Service>();\n\t\t\t");

            // IO.IOService.CutFromFile(_model.ProjectPath + $"\\ArvinERPFinal.API\\Extensions\\DependencyInjectionRepository.cs", $"services.AddTransient<I{_model.Table}Repository, {_model.Table}Repository>();\n\t\t\t");
            if (_model.CreateRelations)
            {
                foreach (var item in _model.Relations)
                {
                    var pricipalPath = _model.ProjectPath + $"\\ArvinERPFinal.Domain\\Models\\{item.Schema}\\{item.Table}.cs";
                    IO.IOService.CutFromFile(pricipalPath, $"\n\t\tpublic virtual {(item.RelationType != RelationType.One2One ? $"ICollection<{_model.Table}>" : _model.Table)} {_model.Table} {{ get; set; }}");
                    var principalrepository = _model.ProjectPath + $"\\ArvinERPFinal.Infrastructure\\Repositories\\{item.Schema}\\{item.Table}Repository.cs";
                    var pricipalrepoInsertIndex = IO.IOService.FindLastIndex(principalrepository, "}\r\n}");
                    IO.IOService.CutFromFile(principalrepository, _builder.GetDeleteOverride(item.Table));
                }
            }
            if (_model.CreateResources)
            {
                var resourcePath = _model.ProjectPath + $"\\ArvinERPFinal.Domain\\Resources\\{_model.Schema}.resx";
                var designerPath = _model.ProjectPath + $"\\ArvinERPFinal.Domain\\Resources\\{_model.Schema}.Designer.cs";
                _builder.GetResxResources().ForEach(x => IO.IOService.CutFromFile(resourcePath, x));
                _builder.GetDesignerResources().ForEach(x => IO.IOService.CutFromFile(designerPath, x));
            }
        }
    }
}
