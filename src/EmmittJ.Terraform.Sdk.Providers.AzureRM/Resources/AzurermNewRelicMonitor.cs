using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_new_relic_monitor resource.
/// </summary>
public class AzurermNewRelicMonitor : TerraformResource
{
    public AzurermNewRelicMonitor(string name) : base("azurerm_new_relic_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_creation_source attribute.
    /// </summary>
    public TerraformProperty<string>? AccountCreationSource
    {
        get => GetProperty<TerraformProperty<string>>("account_creation_source");
        set => this.WithProperty("account_creation_source", value);
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
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
    /// The ingestion_key attribute.
    /// </summary>
    public TerraformProperty<string>? IngestionKey
    {
        get => GetProperty<TerraformProperty<string>>("ingestion_key");
        set => this.WithProperty("ingestion_key", value);
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
    /// The org_creation_source attribute.
    /// </summary>
    public TerraformProperty<string>? OrgCreationSource
    {
        get => GetProperty<TerraformProperty<string>>("org_creation_source");
        set => this.WithProperty("org_creation_source", value);
    }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationId
    {
        get => GetProperty<TerraformProperty<string>>("organization_id");
        set => this.WithProperty("organization_id", value);
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
    /// The user_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserId
    {
        get => GetProperty<TerraformProperty<string>>("user_id");
        set => this.WithProperty("user_id", value);
    }

}
