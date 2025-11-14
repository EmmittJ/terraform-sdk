using EmmittJ.Terraform.Sdk.AppHost.Parsers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Service collection extensions for Terraform code generation.
/// </summary>
internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTerraformCodeGeneration(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Configuration
        services.AddSingleton<TerraformCodeGenOptions>(sp =>
        {
            var appHostDirectory = configuration["AppHost:Directory"]
                ?? throw new InvalidOperationException("AppHost:Directory not found in configuration");

            var repositoryRoot = Path.Combine(
                Directory.GetParent(appHostDirectory)?.FullName
                    ?? throw new InvalidOperationException("Could not determine repository root"),
                "providers");

            return new TerraformCodeGenOptions
            {
                OutputDirectory = repositoryRoot,
                WorkingDirectory = Path.Combine(Directory.GetCurrentDirectory(), ".terraform-codegen"),
                TemplatesDirectory = Path.Combine(AppContext.BaseDirectory, "Templates", "Files")
            };
        });

        // Infrastructure
        services.AddSingleton<IFileSystem, FileSystemWrapper>();
        services.AddSingleton<ITerraformCli, TerraformCliExecutor>();

        // Schema
        services.AddSingleton<ISchemaParser, SchemaParser>();

        // CodeGen
        services.AddSingleton<ITypeMapper, TypeMapper>();
        services.AddSingleton<IModelBuilder, ModelBuilder>();

        // Templates
        services.AddSingleton<ITemplateRenderer, MustacheTemplateRenderer>();
        services.AddSingleton<ViewModelTransformer>();

        // Template classes
        services.AddSingleton<Templates.ResourceTemplate>();
        services.AddSingleton<Templates.DataSourceTemplate>();
        services.AddSingleton<Templates.ProviderTemplate>();
        services.AddSingleton<Templates.ProviderFunctionsTemplate>();
        services.AddSingleton<Templates.EphemeralResourceTemplate>();
        services.AddSingleton<Templates.TerraformConfigTemplate>();

        // Service aggregator
        services.AddSingleton<TerraformCodeGenServices>();

        return services;
    }
}
