namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Container for all Terraform code generation services.
/// </summary>
public sealed class TerraformCodeGenServices(
    IFileSystem fileSystem,
    ITerraformCli terraformCli,
    ISchemaParser schemaParser,
    IModelBuilder modelBuilder,
    TerraformCodeGenOptions options,
    Templates.ResourceTemplate resourceTemplate,
    Templates.DataSourceTemplate dataSourceTemplate,
    Templates.ProviderTemplate providerTemplate,
    Templates.TerraformConfigTemplate terraformConfigTemplate)
{
    public IFileSystem FileSystem { get; } = fileSystem;
    public ITerraformCli TerraformCli { get; } = terraformCli;
    public ISchemaParser SchemaParser { get; } = schemaParser;
    public IModelBuilder ModelBuilder { get; } = modelBuilder;
    public TerraformCodeGenOptions Options { get; } = options;
    public Templates.ResourceTemplate ResourceTemplate { get; } = resourceTemplate;
    public Templates.DataSourceTemplate DataSourceTemplate { get; } = dataSourceTemplate;
    public Templates.ProviderTemplate ProviderTemplate { get; } = providerTemplate;
    public Templates.TerraformConfigTemplate TerraformConfigTemplate { get; } = terraformConfigTemplate;
}
