using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_database_migration_project resource.
/// </summary>
public class AzurermDatabaseMigrationProject : TerraformResource
{
    public AzurermDatabaseMigrationProject(string name) : base("azurerm_database_migration_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceName
    {
        get => GetProperty<TerraformProperty<string>>("service_name");
        set => this.WithProperty("service_name", value);
    }

    /// <summary>
    /// The source_platform attribute.
    /// </summary>
    public TerraformProperty<string>? SourcePlatform
    {
        get => GetProperty<TerraformProperty<string>>("source_platform");
        set => this.WithProperty("source_platform", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The target_platform attribute.
    /// </summary>
    public TerraformProperty<string>? TargetPlatform
    {
        get => GetProperty<TerraformProperty<string>>("target_platform");
        set => this.WithProperty("target_platform", value);
    }

}
