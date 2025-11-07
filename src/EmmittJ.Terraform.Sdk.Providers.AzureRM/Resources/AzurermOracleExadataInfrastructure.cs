using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_oracle_exadata_infrastructure resource.
/// </summary>
public class AzurermOracleExadataInfrastructure : TerraformResource
{
    public AzurermOracleExadataInfrastructure(string name) : base("azurerm_oracle_exadata_infrastructure", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    public TerraformProperty<double>? ComputeCount
    {
        get => GetProperty<TerraformProperty<double>>("compute_count");
        set => this.WithProperty("compute_count", value);
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public TerraformProperty<List<string>>? CustomerContacts
    {
        get => GetProperty<TerraformProperty<List<string>>>("customer_contacts");
        set => this.WithProperty("customer_contacts", value);
    }

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseServerType
    {
        get => GetProperty<TerraformProperty<string>>("database_server_type");
        set => this.WithProperty("database_server_type", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The shape attribute.
    /// </summary>
    public TerraformProperty<string>? Shape
    {
        get => GetProperty<TerraformProperty<string>>("shape");
        set => this.WithProperty("shape", value);
    }

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    public TerraformProperty<double>? StorageCount
    {
        get => GetProperty<TerraformProperty<double>>("storage_count");
        set => this.WithProperty("storage_count", value);
    }

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageServerType
    {
        get => GetProperty<TerraformProperty<string>>("storage_server_type");
        set => this.WithProperty("storage_server_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

}
