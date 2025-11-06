using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_database_migration_project.
/// </summary>
public class AzurermDatabaseMigrationProjectDataSource : TerraformDataSource
{
    public AzurermDatabaseMigrationProjectDataSource(string name) : base("azurerm_database_migration_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("location");
        this.DeclareOutput("source_platform");
        this.DeclareOutput("tags");
        this.DeclareOutput("target_platform");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public string? ServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_name")?.Value;
        set => this.WithProperty("service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The source_platform attribute.
    /// </summary>
    public TerraformExpression SourcePlatform => this["source_platform"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The target_platform attribute.
    /// </summary>
    public TerraformExpression TargetPlatform => this["target_platform"];

}
